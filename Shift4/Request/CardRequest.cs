using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Shift4.Request
{
    public class CardRequest : BaseRequest
    {
        /// <summary>
        /// Id of exisiting card, card token or charge id when used in ChargeCustomer.
        /// Should be empty when requesting for new card
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonIgnore]
        public String CustomerId { get; set; }

        [JsonProperty("number")]
        public String Number { get; set; }

        [JsonProperty("expMonth")]
        public String ExpMonth { get; set; }

        [JsonProperty("expYear")]
        public String ExpYear { get; set; }

        [JsonProperty("cvc")]
        public String Cvc { get; set; }

        [JsonProperty("cardholderName")]
        public String CardholderName { get; set; }

        [JsonProperty("addressLine1")]
        public String AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public String AddressLine2 { get; set; }

        [JsonProperty("addressCity")]
        public String AddressCity { get; set; }

        [JsonProperty("addressZip")]
        public String AddressZip { get; set; }

        [JsonProperty("addressState")]
        public String AddressState { get; set; }

        [JsonProperty("addressCountry")]
        public String AddressCountry { get; set; }

        [JsonProperty("fraudCheckData")]
        public FraudCheckDataRequest FraudCheckData { get; set; }
    }
}
