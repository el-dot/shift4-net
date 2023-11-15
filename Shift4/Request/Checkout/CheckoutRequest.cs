﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Shift4.Request.Checkout
{
    public class CheckoutRequest
    {
        [JsonProperty("charge")]
        public CheckoutRequestCharge Charge {get;set;}

        [JsonProperty("subscription")]
        public CheckoutRequestSubscription Subscription {get;set;}

        [JsonProperty("customCharge")]
        public CheckoutRequestCustomCharge CustomCharge { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId {get;set;}

        [JsonProperty("rememberMe")]
        public bool RememberMe {get;set;}

        [JsonProperty("termsAndConditionsUrl")]
        public string TermsAndConditionsUrl { get; set; }

        [JsonProperty("threeDSecure")]
        public CheckoutRequestThreeDSecure ThreeDSecure { get; set; }
    }
}
