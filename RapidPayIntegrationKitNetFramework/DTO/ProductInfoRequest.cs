using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RapidPayIntegration.DTO
{
    public class ProductInfoRequest
    {
        [JsonProperty("product_details")]
        public ProductDetailsRequest[] productDetails { get; set; }
       
    }
}