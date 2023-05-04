using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.V11.umbraco.models;

public class SiteHeaderViewModel
{
    public SiteHeaderViewModel()
    {
        NavigationItems = new List<NavigationItem>();
    }

    public IPublishedContent CurrentPage { get; set; }
    public IList<NavigationItem> NavigationItems { get; set; }
    public MediaWithCrops SiteLogo { get; set; }

}
