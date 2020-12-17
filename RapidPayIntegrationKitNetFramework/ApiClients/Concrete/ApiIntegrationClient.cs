using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RapidPayIntegration.ApiClients.Abstract;
using RapidPayIntegration.DTO;
using RapidPayIntegration.HttpRequest;
using RapidPayIntegration.HttpResponses;


namespace RapidPayIntegration.ApiClients.Concrete
{
    public class ApiIntegrationClient : IApiIntegrationClient
    {


        public ApiIntegrationClient()
        {
           
        }
        public PinePGTxnAcceptPaymentResponse CreateOrderAtRapidPay(string base64EncodedRequest, string XVerify, string url)
        {
            PinePGTxnAcceptPaymentResponse rapidPayOrderResponseDto = null;
            AcceptPaymentRequest rapidPayCreateOrderRequest = new AcceptPaymentRequest();
            rapidPayCreateOrderRequest.Request = base64EncodedRequest;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    client.DefaultRequestHeaders.Add("X-VERIFY", XVerify);

                    rapidPayOrderResponseDto = CoreApiClient.DoPostRequestJsonAsync
                        <HttpClient, AcceptPaymentRequest, PinePGTxnAcceptPaymentResponse>(client, url, rapidPayCreateOrderRequest).Result;


                }
            }
            catch (HttpRequestException httpRequestEx)
            {
            }
            catch (Exception ex)
            {
            }

            return rapidPayOrderResponseDto;
        }


        public OrderDetailsResponseSentToMerchant DoRefundAtRapidPay(PaymentRefundDataDto paymentRefundData, string url)
        {
            OrderDetailsResponseSentToMerchant rapidPayRefundResponseDto = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(string.Format("{0}:{1}",
                        paymentRefundData.MerchantId, paymentRefundData.MerchantAccessCode))));


                    rapidPayRefundResponseDto =  CoreApiClient.DoPostRequestJsonAsync
                        <HttpClient, PaymentRefundDataDto, OrderDetailsResponseSentToMerchant>(client, url, paymentRefundData).Result;



                }
            }
            catch (HttpRequestException httpRequestEx)
            {
            }
            catch (Exception ex)
            {
            }

            return rapidPayRefundResponseDto;
        }


        public OrderDetailsResponseSentToMerchant DoOrderInquiryAtRapidPay(string url, int MerchantId, string MerchantAccessCode)
        {
            OrderDetailsResponseSentToMerchant orderInquiryResponse = null;
            string xVerifyResponse = String.Empty;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    orderInquiryResponse = CoreApiClient.DoGetAsync<HttpClient, OrderDetailsResponseSentToMerchant>(client, url, MerchantId.ToString(), MerchantAccessCode,  xVerifyResponse).Result;

                    orderInquiryResponse.CustomHeader = xVerifyResponse;

                }
            }
            catch (HttpRequestException httpRequestEx)
            {
            }
            catch (Exception ex)
            {
            }

            return orderInquiryResponse;
        }



        public OrderPaymentDetailResponseSentToMerchant DoPaymentsInquiryAtRapidPay(string url, int MerchantId, string MerchantAccessCode)
        {
            OrderPaymentDetailResponseSentToMerchant orderInquiryResponse = null;
            string xVerifyResponse = String.Empty;


            try
            {
                using (HttpClient client = new HttpClient())
                {
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    orderInquiryResponse = CoreApiClient.DoGetAsync<HttpClient, OrderPaymentDetailResponseSentToMerchant>(client, url, MerchantId.ToString(), MerchantAccessCode, xVerifyResponse).Result;

                }
            }
            catch (HttpRequestException httpRequestEx)
            {
            }
            catch (Exception ex)
            {
            }

            return orderInquiryResponse;
        }


    }

}
