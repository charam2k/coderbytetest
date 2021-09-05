using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqRes.Lib.Model
{

    /// <summary>
    /// Req res user model.
    /// </summary>
    public class ReqResUserModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
