using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace RapidPayIntegration.DTO
{
    public class ProductDetailsRequest
    {
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("product_amount")]
        public long ProductAmount { get; set; }

        public ProductDetailsRequest()
        {


        }

        public ProductDetailsRequest(string ProductCode, long ProductAmount)
        {
            this.ProductCode = ProductCode;
            this.ProductAmount = ProductAmount;
        }
    }
}