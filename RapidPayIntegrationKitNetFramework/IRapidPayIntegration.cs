using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using RapidPayIntegration.DTO;
using RapidPayIntegration.Enums;
using RapidPayIntegration.HttpResponses;

namespace RapidPayIntegration
{
    interface IRapidPayIntegration
    {
        string createBase64String(Object orderDetailsRequest);

        string createSHA256(string base64encodedString, string secureSecret);

        bool validateSecureHash(NameValueCollection nvCollection, string strSecureSecret, string strHashType, ref String responseMessage);

        PinePGTxnAcceptPaymentResponse createPurchaseOrder(EnumEnvironment environment, string base64Encoded, string xVerify, string PaymentModes);


        OrderDetailsResponseSentToMerchant DoRefund(EnumEnvironment environment, PaymentRefundDataDto paymentRefundData);

        OrderDetailsResponseSentToMerchant DoOrderInquiry(EnumEnvironment environment, int MerchantId, string MerchantAccessCode, long aggOrderId);

        OrderPaymentDetailResponseSentToMerchant DoPaymentsInquiry(EnumEnvironment environment, int MerchantId, string MerchantAccessCode, long aggPaymentId);

        bool ValidateSecureIncomingRequest(string request, string xVerify, string secureSeret);









    }
}
