//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.3.0+a1d6f65
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Blog Post Page</summary>
	[PublishedModel("blogPostPage")]
	public partial class BlogPostPage : PublishedContentModel, IPageContentProperties, IPageHeaderProperties, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const string ModelTypeAlias = "blogPostPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<BlogPostPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public BlogPostPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Main Content: Enter the main content rows for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainContent")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainContent => global::Umbraco.Cms.Web.Common.PublishedModels.PageContentProperties.GetMainContent(this, _publishedValueFallback);

		///<summary>
		/// Header Image: Choose the header image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderImage => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeaderProperties.GetHeaderImage(this, _publishedValueFallback);

		///<summary>
		/// Subtitle: Add a page subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("subtitle")]
		public virtual string Subtitle => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeaderProperties.GetSubtitle(this, _publishedValueFallback);

		///<summary>
		/// Title: Add a page title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeaderProperties.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// SEO Description: This is the description you see in google, or other places where it is sheared
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sEODescription")]
		public virtual string SEodescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetSEodescription(this, _publishedValueFallback);

		///<summary>
		/// SEO Keywords: Enter the keywords for the searching
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sEOKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> SEokeywords => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetSEokeywords(this, _publishedValueFallback);

		///<summary>
		/// SEO Title: Enter the title for the meta name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sEOTitle")]
		public virtual string SEotitle => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetSEotitle(this, _publishedValueFallback);
	}
}
