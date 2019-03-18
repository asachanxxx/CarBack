using CarAuctionSL.Model;
using CarAuctionSL.Model.ViewModels;
using CarAuctionSL.Service.App_Start;
using CarAuctionSL.UnitOfWorks;
using CarAuctionSL.UnitOfWorks.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;


namespace CarAuctionSL.Service.Controllers.Process
{
  
    [RoutePrefix("SearchItems")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ItemsController : ApiController
    {
        ItemSearchUOM UOW;
        public ItemsController()
        {
            UOW = new ItemSearchUOM();
        }

        [Authorize]
        [HttpGet]
        [Route("GetItemList")]
        public async Task<HttpResponseMessage> GetItemList()
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<ItemListingVM>>(HttpStatusCode.OK, await UOW.GetItemList());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


        [Authorize]
        [HttpPost]
        [Route("GetSaveItemPartial")]
        public async Task<HttpResponseMessage> GetSaveItemPartial(ItemMaster model)
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<SaveReturnVM>>(HttpStatusCode.OK, await UOW.GetSaveItemPartial(model));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("GetSaveItemFull")]
        public async Task<HttpResponseMessage> GetSaveItemFull(ItemDetailFullVM model)
        {
            try
            {
                string username = Thread.CurrentPrincipal.Identity.Name;

                return Request.CreateResponse<IEnumerable<SaveReturnVM>>(HttpStatusCode.OK, await UOW.GetSaveItemFull(model));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }


    }



}
