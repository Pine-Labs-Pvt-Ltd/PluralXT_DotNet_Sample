using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RapidPayIntegration.DTO
{
    public class PaymentRefundDataDto
    {
        [JsonProperty("unique_merchant_txn_id")]
        public string UniqueMerchantTxnId { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        public int MerchantId { get; set; }

        public string MerchantAccessCode { get; set; }

        public long AggPaymentId { get; set; }
    }
}