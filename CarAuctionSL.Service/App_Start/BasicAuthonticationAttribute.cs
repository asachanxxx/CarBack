using CarAuctionSL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CarAuctionSL.Service.App_Start
{
    public class BasicAuthonticationAttribute : AuthorizationFilterAttribute
    {

        //public override void OnAuthorization(HttpActionContext actionContext)
        //{
        //    base.OnAuthorization(actionContext);
        //}

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authtocken = actionContext.Request.Headers.Authorization.Parameter;
                string DecauthTocken = Encoding.UTF8.GetString(Convert.FromBase64String(authtocken));
                string[] arr = DecauthTocken.Split(':');
                string username = arr[0];
                string password = arr[1];

                bool isauthorized = SecurityManager.Login(username, password);
                if (isauthorized)
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
           //return base.OnAuthorization(actionContext);
        }
    }
}