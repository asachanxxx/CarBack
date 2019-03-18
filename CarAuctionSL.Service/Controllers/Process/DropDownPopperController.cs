using CarAuctionSL.Model;
using CarAuctionSL.Service.App_Start;
using CarAuctionSL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CarAuctionSL.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("DropDownPopper")]
    public class DropDownPopperController : ApiController
    {
        LoadReferanceUOW UOW;

        public DropDownPopperController()
        {
            UOW = new LoadReferanceUOW();
        }

        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetMakes")]
        public async Task<HttpResponseMessage> GetMakes()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;
                
                return  Request.CreateResponse<IEnumerable<KeyValuePear>>(HttpStatusCode.OK, await UOW.LoadAllMakesForDropDowns());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetMakesWithBool")]
        public async Task<HttpResponseMessage> GetMakesWithBool()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<KeyValuePearWithbool>>(HttpStatusCode.OK, await UOW.LoadAllMakesForDropDownsWithBool());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetMilagesWithBool")]
        public async Task<HttpResponseMessage> GetMilagesWithBool()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<KeyValuePearWithbool>>(HttpStatusCode.OK, await UOW.LoadAllMilagesForDropDownsWithBool());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetYearsWithBool")]
        public async Task<HttpResponseMessage> GetYearsWithBool()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<KeyValuePearWithbool>>(HttpStatusCode.OK, await UOW.LoadAllYearssForDropDownsWithBool());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetBodyTypeWithBool")]
        public async Task<HttpResponseMessage> GetBodyTypeWithBool()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<KeyValuePearWithbool>>(HttpStatusCode.OK, await UOW.LoadAllBodyTypeForDropDownsWithBool());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Authorize]
        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        [Route("GetModels")]
        public async Task<HttpResponseMessage> GetModels(int MakeId)
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<KeyValuePear>>(HttpStatusCode.OK, await UOW.LoadAllModelMasterRepoDropDowns(MakeId));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetYears")]
        public async Task<HttpResponseMessage> GetYears()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;
                return Request.CreateResponse<IEnumerable<KeyValuePear>>(HttpStatusCode.OK, await UOW.LoadAllYearsForDropDowns());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllBodyTypes")]
        public async Task<HttpResponseMessage> GetAllBodyTypes()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;
                return Request.CreateResponse<IEnumerable<KeyValuePear>>(HttpStatusCode.OK, await UOW.LoadAllBodyTypeForDropDowns());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllMilages")]
        public async Task<HttpResponseMessage> GetAllMilages()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;
                return Request.CreateResponse<IEnumerable<KeyValuePear>>(HttpStatusCode.OK, await UOW.LoadAllmilagesForDropDowns());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
