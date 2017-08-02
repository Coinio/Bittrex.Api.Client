﻿using Newtonsoft.Json;
using System;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// The result of the /market/buylimit and /market/selllimit end points.   
    /// </summary>
    public class OrderResult
    {
        /// <summary>
        /// The unique identifier of the order created by the end point
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public Guid Uuid { get; set; }
    }
}
