using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;
using Umbraco.V11.umbraco.models;

namespace Umbraco.V11.Components;

public class MetaDataViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(IPublishedContent content, SiteSettings? settings)
    {
        var metaData = new MetaDataModel();

        metaData.Title =  content.Value<string>("sEOTitle");
        metaData.Description = content.Value<string>("sEODescription");
        metaData.Keywords = string.Join(", ", content.Value<string[]>("sEOKeywords"));

        if (string.IsNullOrEmpty(metaData.Title))
        {
            metaData.Title = settings.SEotitle;
        }
        if (string.IsNullOrEmpty(metaData.Description))
        {
            metaData.Description = settings.SEodescription;
        }
        if (string.IsNullOrEmpty(metaData.Keywords))
        {
            metaData.Keywords = string.Join(", ", settings.SEokeywords);
        }

        return View(metaData);
    }
}
