using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using RapidPayIntegration.ApiClients.Abstract;
using RapidPayIntegration.ApiClients.Concrete;
using RapidPayIntegration.DTO;
using RapidPayIntegration.Enums;
using RapidPayIntegration.HttpResponses;
using RapidPayIntegration.Utilities;

namespace RapidPayIntegration
{
    public class RapidPayIntegration : IRapidPayIntegration
    {

        private readonly IApiIntegrationClient apiClient;

        public RapidPayIntegration(IApiIntegrationClient apiClient)
        {
            this.apiClient = apiClient;
        }


        public string createBase64String(Object orderDetailsRequest)
        {
            var base64Converted = GenericUtility.GetBase64FromObject(orderDetailsRequest);
            return base64Converted;
        }

        public string createSHA256(string base64encodedString, string secureSecret)
        {
            var shaGenerated = GenericUtility.GetSHAGenerated(base64encodedString, secureSecret);
            return shaGenerated;
        }


        public PinePGTxnAcceptPaymentResponse createPurchaseOrder(EnumEnvironment environment, string base64Encoded, string xVerify, string PaymentModes)
        {
            string url = GenericUtility.GetOrderCreationURL(environment);
            var acceptPaymentResponse =  this.apiClient.CreateOrderAtRapidPay(base64Encoded, xVerify, url);
            if (acceptPaymentResponse != null && acceptPaymentResponse.RESPONSE_CODE.Equals(Constants.SUCCESS))
            {
                acceptPaymentResponse.strRedirectUrl = GenericUtility.GetRedirectURL(environment, acceptPaymentResponse.strtoken, PaymentModes);
            }

            return acceptPaymentResponse;
        }



        public  OrderDetailsResponseSentToMerchant DoRefund(EnumEnvironment environment, PaymentRefundDataDto paymentRefundData)
        {
            string url = GenericUtility.GetRefundURL(environment, paymentRefundData.AggPaymentId);
            var orderDetailsResponse =  this.apiClient.DoRefundAtRapidPay(paymentRefundData, url);
            return orderDetailsResponse;

        }



        public OrderDetailsResponseSentToMerchant DoOrderInquiry(EnumEnvironment environment, int MerchantId, string MerchantAccessCode, long aggOrderId)
        {
            string url = GenericUtility.GetOrderInquiryURL(environment, aggOrderId);
            var orderDetailsResponse =  this.apiClient.DoOrderInquiryAtRapidPay(url, MerchantId, MerchantAccessCode);
            return orderDetailsResponse;

        }


        public OrderPaymentDetailResponseSentToMerchant DoPaymentsInquiry(EnumEnvironment environment, int MerchantId, string MerchantAccessCode, long aggPaymentId)
        {
            string url = GenericUtility.GetPaymentsInquiryURL(environment, aggPaymentId);
            var orderPaymentDetailsResponse =  this.apiClient.DoPaymentsInquiryAtRapidPay(url, MerchantId, MerchantAccessCode);
           
            
            return orderPaymentDetailsResponse;
        }


        public bool ValidateSecureIncomingRequest(string request, string xVerify, string secureSeret)
        {
            return xVerify.Equals(createSHA256(request, secureSeret));
        }

        public bool validateSecureHash(NameValueCollection nvCollection, string strSecureSecret, string strHashType, ref String responseMessage)
        {
            bool isSecureHashMatch = false;
            try
            {
                SortedList<string, string> srtdListCaptureReqObject = new SortedList<string, string>(new VPCStringComparer());
                foreach (string key in nvCollection.AllKeys)
                {
                    srtdListCaptureReqObject[key] = nvCollection[key];
                }

                isSecureHashMatch = validateSecureHash(srtdListCaptureReqObject, strSecureSecret, strHashType, ref responseMessage);
            }
            catch (Exception ex)
            {
                responseMessage = ex.ToString();

            }
            return isSecureHashMatch;
        }


        private bool validateSecureHash(SortedList<String, String> sortedFields, string strSecureSecret, string strHashType, ref String responseMessage)
        {
            bool isSecureHashMatch = false;
            try
            {

                string secureHashFromIncomingRequest = sortedFields[Constants.DIA_SECRET];
                string secureHashTypeFromIncomingRequest = sortedFields[Constants.DIA_SECRET_TYPE];
                sortedFields.Remove(Constants.DIA_SECRET);
                sortedFields.Remove(Constants.DIA_SECRET_TYPE);
                if (secureHashFromIncomingRequest.Equals(createHashSignature(sortedFields, strSecureSecret, strHashType, ref responseMessage)))
                {
                    isSecureHashMatch = true;

                }

            }
            catch (Exception ex)
            {
                responseMessage = ex.ToString();

            }
            return isSecureHashMatch;
        }
        private string createHashSignature(NameValueCollection nvCollection, string strSecureSecret, string strHashType, ref String responseMessage)
        {
            string strsecureHash = "";
            try
            {
                SortedList<string, string> srtdListCaptureReqObject = new SortedList<string, string>(new VPCStringComparer());
                foreach (string key in nvCollection.AllKeys)
                {
                    srtdListCaptureReqObject[key] = nvCollection[key];
                }
                strsecureHash = createHashSignature(srtdListCaptureReqObject, strSecureSecret, strHashType, ref responseMessage);

            }
            catch (Exception ex)
            {
                responseMessage = ex.ToString();
                strsecureHash = Constants.EMPTY;
            }
            return strsecureHash;
        }


        public string createHashSignature(SortedList<String, String> sortedFields, string strSecureSecret, string strHashType, ref String responseMessage)
        {
            string strsecureHash = "";
            try
            {
                // Hex Decode the Secure Secret for use in using the HMACSHA256 hasher
                // hex decoding eliminates this source of error as it is independent of the character encoding
                // hex decoding is precise in converting to a byte array and is the preferred form for representing binary values as hex strings. 

                byte[] convertedHash = new byte[strSecureSecret.Length / 2];
                for (int i = 0; i < strSecureSecret.Length / 2; i++)
                {
                    convertedHash[i] = (byte)Int32.Parse(strSecureSecret.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
                }

                // Build string from collection in preperation to be hashed
                StringBuilder sb = new StringBuilder();
                SortedList<String, String> list = sortedFields;
                foreach (KeyValuePair<string, string> kvp in list)
                {

                    sb.Append(kvp.Key + "=" + kvp.Value + "&");


                }
                sb.Remove(sb.Length - 1, 1);

                // Create secureHash on string

                if (strHashType.ToUpper().Equals(Constants.HASH_ALGO_SHA256))
                {
                    using (HMACSHA256 hasher = new HMACSHA256(convertedHash))
                    {
                        byte[] hashValue = hasher.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()));
                        foreach (byte b in hashValue)
                        {
                            strsecureHash += b.ToString("X2");
                        }
                    }

                }
                else if (strHashType.ToUpper().Equals(Constants.HASH_ALGO_MD5))
                {

                    using (HMACMD5 hasher = new HMACMD5(convertedHash))
                    {
                        byte[] hashValue = hasher.ComputeHash(
                        Encoding.UTF8.GetBytes(sb.ToString()));
                        foreach (byte b in hashValue)
                        {
                            strsecureHash += b.ToString("X2");
                        }
                    }

                }




            }
            catch (Exception ex)
            {
                responseMessage = ex.ToString();
                strsecureHash = Constants.EMPTY;
            }
            return strsecureHash;
        }







    }

}
