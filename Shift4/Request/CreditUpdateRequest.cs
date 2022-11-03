﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shift4.Request
{
    public class CreditUpdateRequest : BaseRequest
    {
        [JsonIgnore]
        public string CreditId { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<String, String> Metadata { get; set; }
    }
}
