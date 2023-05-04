using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;
using Umbraco.V11.umbraco;
using Umbraco.V11.umbraco.models;

namespace Umbraco.V11.Components;

public class SiteNavigationViewComponent : ViewComponent
{
    private readonly ILocalizationService _localizationService;
    public SiteNavigationViewComponent(ILocalizationService localizationService)
    {
        _localizationService = localizationService;
    }

    public async Task<IViewComponentResult> InvokeAsync(SiteSettings siteSettings, bool isheader, IPublishedContent content)
    {
        if (isheader)
        {
            var header = new SiteHeaderViewModel();
            header.CurrentPage = content;
            header.SiteLogo = siteSettings.SiteLogoImage;

            foreach (var item in siteSettings.MainNavigation)
            {
                var navItemSettings = (NavigationItemSettings)item.Settings;

                if (navItemSettings.Hide)
                {
                    continue;
                }

                var navItem = (NavigationItem)item.Content;
                header.NavigationItems.Add(navItem);
            }

            return View("HeaderNavigation", header);
        }


        var footer = new SiteFooterViewModel();

        footer.FooterTitle = siteSettings.FooterTitle;
        footer.FooterContent = siteSettings.FooterText;
        footer.SocialLinks = siteSettings.FooterSocialLinks;

        foreach (var item in siteSettings.FooterLinks)
        {
            var navItemSettings = (FooterNavigationItemSettings)item.Settings;

            if (navItemSettings.Hide)
            {
                continue;
            }

            var navItem = (FooterNavigationItem)item.Content;
            footer.FooterNavigationItems.Add(navItem);
        }



        return View("FooterNavigation", footer);

    }
}
