using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RapidPayIntegration.DTO
{
    public class OrderDetailsRequest
    {
        [JsonProperty("merchant_data")]
        public MerchantRequest MerchantRequest { get; set; }

        [JsonProperty("payment_info_data")]
        public OrderTxnInfoRequest OrderTxnInfoRequest { get; set; }

        [JsonProperty("customer_data")]
        public CustomerRequest CustomerRequest { get; set; }

        [JsonProperty("billing_address_data")]
        public BillingAddressRequest BillingAddressRequest { get; set; }

        [JsonProperty("shipping_address_data")]
        public ShippingAddressRequest ShippingAddressRequest { get; set; }

        [JsonProperty("product_info_data")]
        public ProductInfoRequest ProductInfoRequest { get; set; }

        [JsonProperty("additional_info_data")]
        public AdditonalDataRequest AdditonalDataRequest { get; set; }

    }
}
