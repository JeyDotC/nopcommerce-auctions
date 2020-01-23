using System.Linq;
using System.Web.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.Auctions.Services;
using Nop.Services.Configuration;
using Nop.Services.Directory;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Services.Tax;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Kendoui;
using Nop.Web.Framework.Mvc;
using Nop.Web.Framework.Security;

namespace Nop.Plugin.Widgets.Auctions.Controllers
{
    public class AuctionsController : BasePluginController
    {
        private string Locate(string viewName)
            => $"~/Plugins/{Names.SystemName}/Views/{viewName}.cshtml";


        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            return View(Locate(nameof(Configure)));
        }

        [ChildActionOnly]
        public ActionResult PlaceOfferButton(string widgetZone, object additionalData)
        {
            return View(Locate(nameof(PlaceOfferButton)));
        }

        [ChildActionOnly]
        public ActionResult PlaceOfferModal(string widgetZone, object additionalData)
        {
            return View(Locate(nameof(PlaceOfferModal)));
        }
    }
}