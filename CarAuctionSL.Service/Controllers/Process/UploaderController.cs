using CarAuctionSL.Model._Process;
using CarAuctionSL.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CarAuctionSL.Service.Controllers.Process
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("Uploader")]
    public class UploaderController : ApiController
    {
        Repository.RepoBase<UploadList> db;
        public UploaderController()
        {
            db = new Repository.RepoBase<UploadList>("UploadLists");
        }



       
        [HttpPost]
        [Route("UploadSingleImage")]
        public HttpResponseMessage UploadSingleImage()
        {
            var exMessage = string.Empty;
            try
            {
                string uploadPath = "~/content/upload";
                HttpPostedFile file = null;
                if (HttpContext.Current.Request.Files.Count > 0)
                {
                    file = HttpContext.Current.Request.Files.Get("file");
                }
                // Check if we have a file
                if (null == file)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new
                    {
                        error = true,
                        message = "Image file not found"
                    });

                // Make sure the file has content
                if (!(file.ContentLength > 0))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new
                    {
                        error = true,
                        message = "Image file not found"
                    });

                if (!Directory.Exists(HttpContext.Current.Server.MapPath(uploadPath)))
                {
                    // If it doesn't exist, create the directory
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath(uploadPath));
                }

                //Upload File
                file.SaveAs(HttpContext.Current.Server.MapPath($"{uploadPath}/{file.FileName}"));
                return Request.CreateResponse(HttpStatusCode.OK, "Successfull" );

            }
            catch (Exception ex)
            {
                exMessage = ex.Message;
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { error = true, message = exMessage == string.Empty ? "An unknown error occured" : exMessage });
            }
           
        }


    }
}
