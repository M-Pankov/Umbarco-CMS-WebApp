using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Common.UmbracoContext;
using Umbraco.Extensions;

namespace UmbracoCmsWebApp.Components;

public class NavigationViewComponent : ViewComponent
{
    private readonly IUmbracoContextFactory _umbracoContext;

	public NavigationViewComponent(IUmbracoContextFactory umbracoContext)
	{
        _umbracoContext = umbracoContext;
	}

	public async Task<IViewComponentResult> InvokeAsync(IPublishedContent content, int? i)
    {
		
		using (var cref = _umbracoContext.EnsureUmbracoContext())
		{
			var cache = cref.UmbracoContext.Content;
			var navigation = cache.GetAtRoot().DescendantsOrSelf<Settings>().First();
			var navigationItems = navigation?.MainNavigation.Select(x => (NavigationItem)x.Content) ?? Enumerable.Empty<NavigationItem>();
			return View(navigationItems);
		}
    }
}
