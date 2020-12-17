using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RapidPayIntegration.HttpResponses
{
    public class OrderPaymentDetailResponseSentToMerchant
    {
        [JsonProperty("merchant_data", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantDetailsResponse MerchantDetailsResponse { get; set; }

        [JsonProperty("order_data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderDetailsResponse OrderDetailsResponse { get; set; }

        [JsonProperty("payment_info_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<PaymentDetailsResponseSentToMerchant> lsPaymentTxnResponse { get; set; }

        [JsonIgnore]
        public string CustomHeader { get; set; }
    }
}
