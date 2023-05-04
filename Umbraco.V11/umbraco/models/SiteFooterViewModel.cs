using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Umbraco.V11.umbraco.models;

public class SiteFooterViewModel
{
    public SiteFooterViewModel()
    {
        FooterNavigationItems = new List<FooterNavigationItem>();
        SocialLinks = new List<SocialLink>();
    }

    public string FooterTitle { get; set; }
    public string FooterContent { get; set; }
    public IList<FooterNavigationItem> FooterNavigationItems { get; set; }
    public IEnumerable<SocialLink> SocialLinks { get; set; }
}
