
using MVVU_RESULT_UI.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using MVVU_RESULT_MODEL;
using MVVU_RESULT_MODEL.DTO;
using MVVU_RESULT_REPO;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;


namespace MVVU_RESULT_UI.Areas.Admin.ViewComponents
{
    public class PageAdminViewComponent : ViewComponent
    {
        IUnitOfWork uow;
        protected readonly IHttpContextAccessor httpContextAccessor;
        protected ISession Session => httpContextAccessor.HttpContext.Session;
        public PageAdminViewComponent(IUnitOfWork _uow, IHttpContextAccessor _httpContextAccessor)
        {
            httpContextAccessor = _httpContextAccessor;
            uow = _uow;
        }

        public async Task<IViewComponentResult> InvokeAsync(string RollNumber, bool IsAdmin = false)
        {
            try
            {
                if (!string.IsNullOrEmpty(RollNumber))
                {

                    //List<StudentMasterDTO> adminData = await uow.IAdminMaster.CheckResult("", RollNumber.Trim(), IsAdmin);

                    //if (adminData.Count() > 0)
                    //{
                      //  return View("~/areas/admin/views/components/_pageadmin.cshtml", adminData);
                    //}
                }

            }
            catch (Exception ex)
            {

            }

            return View("/views/components/.cshtml");

        }
        [NonAction]
        private static Byte[] BitmapToBytesCode(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}