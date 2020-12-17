using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RapidPayIntegration.DTO
{
    public class MerchantRequest
    {
        [JsonProperty("merchant_id")]
        public int MerchantId { get; set; }

        [JsonProperty("merchant_access_code")]
        public string MerchantAccessCode { get; set; }

        [JsonProperty("merchant_return_url")]
        public string MerchantReturnUrl { get; set; }

        [JsonProperty("order_id")]
        public string MerchantOrderID { get; set; }


        [JsonProperty("unique_merchant_txn_id")]
        public string UniqueMerchantIxnId { get; set; }


    }
}
