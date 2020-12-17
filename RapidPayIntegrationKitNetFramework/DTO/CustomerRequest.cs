using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RapidPayIntegration.DTO
{
    public class CustomerRequest
    {
        [JsonProperty("customer_id")]
        public long CustomerId { get; set; }

        [JsonProperty("customer_ref_no")]
        public string CustomerReferenceNumber { get; set; }

        public long MerchantId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("mobile_no")]
        public string MobileNumber { get; set; }

        [JsonProperty("email_id")]
        public string EmailId { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}