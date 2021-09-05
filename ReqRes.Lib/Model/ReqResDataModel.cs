using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqRes.Lib.Model
{
    /// <summary>
    /// Reqres user data model.
    /// </summary>
    public class ReqResDataModel
    {
        [JsonProperty("data")]
        public ReqResUserModel User { get; set; }
    }
}
