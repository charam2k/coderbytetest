using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ReqRes.Lib.Model
{
    /// <summary>
    /// Generic response model for req rest.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }

        public string ErrorMessage { get; set; }
    }
}
