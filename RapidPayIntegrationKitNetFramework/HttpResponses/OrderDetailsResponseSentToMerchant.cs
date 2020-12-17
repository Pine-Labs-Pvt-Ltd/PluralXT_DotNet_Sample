using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RapidPayIntegration.Enums;

namespace RapidPayIntegration.HttpResponses
{
    public class OrderDetailsResponseSentToMerchant : Response
    {
        [JsonProperty("merchant_data", NullValueHandling = NullValueHandling.Ignore)]
        public MerchantDetailsResponse MerchantDetailsResponse { get; set; }

        [JsonProperty("order_data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderDetailsResponse OrderDetailsResponse { get; set; }

        [JsonProperty("payment_info_data", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentDetailsResponseSentToMerchant PaymentTxnResponse { get; set; }

        [JsonIgnore]
        public string CustomHeader { get; set; }
    }


    public class MerchantDetailsResponse
    {
        [JsonProperty("merchant_id", NullValueHandling = NullValueHandling.Ignore)]
        public int MerchantId { get; set; }

        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantOrderID { get; set; }
    }

    public class OrderDetailsResponse
    {
        [JsonProperty("agg_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public long AggOrderID { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long Amount { get; set; }

        [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumCurrency CurrencyCode { get; set; }

        [JsonProperty("order_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderDesc { get; set; }

        //[JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public EnumTxnType? TxnType { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumOrderStatus? OrderStatus { get; set; }    

        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefundAmount { get; set; }

        [JsonProperty("parent_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentAggOrderId { get; set; }

        [JsonProperty("parent_status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumOrderStatus? ParentOrderStatus { get; set; }

        [JsonProperty("parent_response_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentOrderResponseCode { get; set; }

    }

   



}