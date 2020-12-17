using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RapidPayIntegration.HttpResponses
{
    public class Response
    {

        [JsonProperty("response_code")]
        public int RESPONSE_CODE { get; set; }

        [JsonProperty("response_message")]
        public string RESPONSE_MESSAGE { get; set; }


        public Response()
        {

        }


    }
    public class PinePGTxnAcceptPaymentResponse : Response
    {

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string strtoken { get; set; }

        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        public string strRedirectUrl { get; set; }

        [JsonProperty("rapidpay_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string strRapidPayOrderId { get; set; }

        [JsonProperty("api_url", NullValueHandling = NullValueHandling.Ignore)]
        public string strApiUrl { get; set; }
    }

}
