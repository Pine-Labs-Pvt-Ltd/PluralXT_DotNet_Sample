using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RapidPayIntegration.DTO;
using RapidPayIntegration.HttpResponses;

namespace RapidPayIntegration.ApiClients.Abstract
{
    public interface IApiIntegrationClient
    {
        PinePGTxnAcceptPaymentResponse CreateOrderAtRapidPay(string base64EncodedRequest, string XVerify, string url);


        OrderDetailsResponseSentToMerchant DoRefundAtRapidPay(PaymentRefundDataDto paymentRefundData, string url);


        OrderDetailsResponseSentToMerchant DoOrderInquiryAtRapidPay(string url, int MerchantId, string MerchantAccessCode);

        OrderPaymentDetailResponseSentToMerchant DoPaymentsInquiryAtRapidPay(string url, int MerchantId, string MerchantAccessCode);
    }
}
