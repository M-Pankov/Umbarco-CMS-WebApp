using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;
using Umbraco.V11.umbraco.models;

namespace Umbraco.V11.Components;

public class SiteNavigationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(BlockListModel? navigation, SiteSettings? settings, IPublishedContent? logo)
    {

        if (navigation != null)
        {
            var mainNavigation = new SiteHeaderNavigationModel();

            mainNavigation.SiteLogo = logo;

            foreach (var item in navigation)
            {
                var navItem = (NavigationItem)item.Content;
                var navItemSettings = (NavigationItemSettings)item.Settings;

                if(navItemSettings.Hide)
                {
                    continue;
                }

                mainNavigation.NavigationItems.Add(navItem);
            }

            return View("HeaderNavigation", mainNavigation);
        }

        return View("FooterNavigation",settings);
    }
}
