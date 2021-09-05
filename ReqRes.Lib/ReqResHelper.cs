using Newtonsoft.Json;
using ReqRes.Lib.Model;
using RestSharp;

namespace ReqRes.Lib
{
    /// <summary>
    /// Helper class to peform http request using req rest api.
    /// </summary>
    public class ReqResHelper
    {
        /// <summary>
        /// Get user
        /// </summary>
        /// <param name="baseUrl">Provide the base url.</param>
        /// <param name="userid">Provide the user id.</param>
        /// <returns>Response model containing the user information <see cref="ReqResUserModel"/></returns>
        public static ResponseModel<ReqResDataModel> GetUser(string baseUrl, long userid)
        {
            // URL is accepted as parameter here... this can be stored as a configuration parameter and changed per environment for eg., TEST, UAT etc.,
            string endPointUrl = $"{baseUrl}/{userid}"; 
            RestClient restclient = new RestClient(endPointUrl);
            RestRequest restRequest = new RestRequest(Method.GET);
            var restResponse = restclient.Execute(restRequest);
            ReqResDataModel responseModel = null;
            if (restResponse.IsSuccessful)
            {
                responseModel = JsonConvert.DeserializeObject<ReqResDataModel>(restResponse.Content);
            }

            return new ResponseModel<ReqResDataModel>()
            {
                StatusCode = restResponse.StatusCode,
                Data = responseModel,
                ErrorMessage = restResponse.ErrorMessage,
            };
        }
    }
}
