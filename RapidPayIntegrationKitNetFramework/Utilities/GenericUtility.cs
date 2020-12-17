using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using RapidPayIntegration.Enums;

namespace RapidPayIntegration.Utilities
{
   public class GenericUtility
    {

        public static string GetBase64FromObject<T>(T obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            string base64String = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
            return base64String;
        }


        public static string GetSHAGenerated(string request, string secureSecret)
        {
            string hexHash = String.Empty;

            byte[] convertedHash = new byte[secureSecret.Length / 2];
            for (int i = 0; i < secureSecret.Length / 2; i++)
            {
                convertedHash[i] = (byte)int.Parse(secureSecret.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }

            using (HMACSHA256 hasher = new HMACSHA256(convertedHash))
            {
                byte[] hashValue = hasher.ComputeHash(Encoding.UTF8.GetBytes(request));
                foreach (byte b in hashValue)
                {
                    hexHash += b.ToString("X2");
                }
            }


            return hexHash;
        }


        public static string GetOrderCreationURL(EnumEnvironment environment)
        {
            string url = String.Empty;
            switch(environment)
            {
                case EnumEnvironment.DEV:
                    url = Constants.DEV_DOMAIN_NAME + Constants.ORDER_CREATION_END_POINT;
                    break;

                case EnumEnvironment.TEST:
                    url = Constants.TEST_DOMAIN_NAME + Constants.ORDER_CREATION_END_POINT;
                    break;

            }

            return url;
        }


        public static string GetRefundURL(EnumEnvironment environment, long paymentId)
        {
            string url = String.Empty;
            switch (environment)
            {
                case EnumEnvironment.DEV:
                    url = Constants.DEV_DOMAIN_NAME + Constants.DO_REFUND_URL + paymentId + Constants.REFUND_ENDPOINT;
                    break;

                case EnumEnvironment.TEST:
                    url = Constants.TEST_DOMAIN_NAME + Constants.DO_REFUND_URL + paymentId + Constants.REFUND_ENDPOINT;
                    break;

            }

            return url;
        }

       

        public static string GetOrderInquiryURL(EnumEnvironment environment, long aggOrderId)
        {
            string url = String.Empty;
            switch (environment)
            {
                case EnumEnvironment.DEV:
                    url = Constants.DEV_DOMAIN_NAME + Constants.DO_ORDER_INQUIRY_ENDPOINT + aggOrderId; 
                    break;

                case EnumEnvironment.TEST:
                    url = Constants.TEST_DOMAIN_NAME + Constants.DO_ORDER_INQUIRY_ENDPOINT + aggOrderId;
                    break;

            }

            return url;
        }


        public static string GetPaymentsInquiryURL(EnumEnvironment environment, long aggPaymentId)
        {
            string url = String.Empty;
            switch (environment)
            {
                case EnumEnvironment.DEV:
                    url = Constants.DEV_DOMAIN_NAME + Constants.DO_ORDER_INQUIRY_ENDPOINT + aggPaymentId;
                    break;

                case EnumEnvironment.TEST:
                    url = Constants.TEST_DOMAIN_NAME + Constants.DO_ORDER_INQUIRY_ENDPOINT + aggPaymentId;
                    break;

            }

            return url;
        }


        public static string GetRedirectURL(EnumEnvironment environment, String token, string PaymentModes)
        {
            string url = String.Empty;
            switch (environment)
            {
                case EnumEnvironment.DEV:
                    url = Constants.DEV_DOMAIN_NAME + Constants.REDIRECT_URL_END_POINT + token + Constants.REDIRECT_URL_PAYMENT_MODES + PaymentModes;
                    break;

                case EnumEnvironment.TEST:
                    url = Constants.TEST_DOMAIN_NAME + Constants.REDIRECT_URL_END_POINT + token + Constants.REDIRECT_URL_PAYMENT_MODES + PaymentModes;
                    break;

            }

            return url;
        }


        public bool ValidateSHAIncomingRequest(string base64Request, string incomingSHA, string secureSecret)
        {
            bool validated = false;
            try
            {
                if (!string.IsNullOrEmpty(secureSecret))
                {
                    byte[] convertedHash = new byte[secureSecret.Length / 2];
                    for (int i = 0; i < secureSecret.Length / 2; i++)
                    {
                        convertedHash[i] = (byte)int.Parse(secureSecret.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
                    }

                    string hexHash = string.Empty;
                    using (HMACSHA256 hasher = new HMACSHA256(convertedHash))
                    {
                        byte[] hashValue = hasher.ComputeHash(Encoding.UTF8.GetBytes(base64Request));
                        foreach (byte b in hashValue)
                        {
                            hexHash += b.ToString("X2");
                        }
                    }
                    validated = incomingSHA.Equals(hexHash);
                }
            }
            catch (Exception ex)
            {
                // log here
            }
            return validated;
        }

     
    }
}
