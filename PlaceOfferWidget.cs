using Nop.Core.Plugins;
using Nop.Plugin.Widgets.Auctions.Services;
using Nop.Services.Cms;
using Nop.Services.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Nop.Plugin.Widgets.Auctions
{
    public class PlaceOfferWidget : BasePlugin, IWidgetPlugin
    {
        public override void Install()
        {
            // Locales
            this.AddOrUpdatePluginLocaleResource(Locales.PlaceOffer, "Place Offer");

            base.Install();
        }

        public override void Uninstall()
        {
            this.DeletePluginLocaleResource(Locales.PlaceOffer);

            base.Uninstall();
        }

        public void GetConfigurationRoute(out string actionName, out string controllerName, out System.Web.Routing.RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = Names.AuctionsController;
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", Names.ControllersNamespace },
                {"area", null},
            };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out System.Web.Routing.RouteValueDictionary routeValues)
        {
            actionName = widgetZone == "footer" ? "PlaceOfferModal" : "PlaceOfferButton";
            controllerName = Names.AuctionsController;
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", Names.ControllersNamespace },
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }

        public IList<string> GetWidgetZones()
            => new List<string>
            {
                "productbox_addinfo_middle",
                "productdetails_add_info",
                "footer"
            };
    }
}
