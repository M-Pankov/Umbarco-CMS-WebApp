using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.V11.umbraco.models;

public class SiteHeaderNavigationModel
{
    public SiteHeaderNavigationModel()
    {
        NavigationItems = new List<NavigationItem>();
    }

    public IList<NavigationItem> NavigationItems { get; set; }
    public IPublishedContent SiteLogo { get; set; }
}
