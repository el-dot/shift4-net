﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shift4.Request
{
    public class ListRequest : BaseRequest
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("startingAfterId")]
        public String StartingAfterId { get; set; }

        [JsonProperty("endingBeforeId")]
        public String EndingBeforeId { get; set; }

        [JsonProperty("includeTotalCount")]
        public bool? IncludeTotalCount { get; set; }

        [JsonProperty("created")]
        public CreatedFilter Created { get; set; }

    }
}
