using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace RapidPayIntegration.HttpRequest
{
    /// </summary>
    [DataContract]
    public class AcceptPaymentRequest
    {
      

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        [DataMember]
        [JsonProperty("request")]
        public string Request { get; set; }

        /// <summary>
        /// Gets or sets the source ip address.
        /// </summary>
        /// <value>
        /// The source ip address.
        /// </value>
        [IgnoreDataMember]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>
        /// The user agent.
        /// </value>
        [IgnoreDataMember]
        public string UserAgent { get; set; }
    }
}
