using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// A general result wrapper for the bittrex api end points
    /// Every end point provides results in the same format containing a success flag, a message field to return any errors that may have occurred and the actual json result.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> 
    {
        public ApiResult(bool success, String message, T result)
        {
            Success = success;
            Message = message;
            Result = result;
        }     

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
        [JsonProperty(PropertyName = "message")]
        public String Message { get; set; }
        [JsonProperty(PropertyName = "result")]
        public T Result { get; set; }
    }
}
