﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shift4.Response
{
    public class WithCrossSale : BaseResponse
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("partnerId")]
        public string PartnerId { get; set; }

        [JsonProperty("chargeId")]
        public string ChargeId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
