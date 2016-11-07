using PEPmodnaKompanija_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_UI.Util
{
   public  class WebAPIHelper
    {
       public HttpClient client { get; set; }
       private string route { get; set; }

       public WebAPIHelper (string uri, string route)
       {
           client = new HttpClient();
           client.BaseAddress = new Uri(uri);
           this.route = route;

       }

       public HttpResponseMessage GetResponse()
       {
           return client.GetAsync(route).Result;
       }

       public HttpResponseMessage GetActionResponse(string action, string parameter = "")
       {
           return client.GetAsync(route + "/" + action + "/" + parameter).Result;
       }
       public HttpResponseMessage GetActionResponse(string action, int? parameter)
       {
           return client.GetAsync(route + "/" + action + "/" + parameter).Result;
       }
       public HttpResponseMessage GetActionResponse4(string action, string parameter4, int? parameter, int? parameter2, string parameter3 = "" )
       {
           return client.GetAsync(route + "/" + action + "/" + parameter4 + "/" + parameter + "/" + parameter2 + "/" + parameter3).Result;
       }
       public HttpResponseMessage GetActionResponse3(string action, int? parameter, int? parameter2, string parameter3 = "")
       {
           return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter2 + "/" + parameter3).Result;
       }

 

       public HttpResponseMessage GetActionResponse2(string action, int? parameter, int? parameter2)
       {
           return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter2).Result;
       }

       public HttpResponseMessage GetActionResponse22(string action, string parameter, string parameter2)
       {
           return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter2).Result;
       }
       public HttpResponseMessage GetResponse(string parameter)    {
          
           return client.GetAsync(route + "/" + parameter).Result;
       }
       public HttpResponseMessage PostResponse(Object newObject)
       {
           return client.PostAsJsonAsync(route, newObject).Result;
       }

       public HttpResponseMessage PostActionResponse(string action,Object newObject)
       {
           return client.PostAsJsonAsync(route + "/"+ action, newObject).Result;
       }


       public HttpResponseMessage PutResponse(int Id, Object exitingObject)   
       {
           return client.PutAsJsonAsync(route + "/" + Id, exitingObject).Result;
       }

    }
}
