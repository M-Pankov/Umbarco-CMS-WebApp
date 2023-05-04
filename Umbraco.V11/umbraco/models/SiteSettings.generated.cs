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
	/// <summary>Site Settings</summary>
	[PublishedModel("siteSettings")]
	public partial class SiteSettings : PublishedContentModel, ISEO, ISiteFooterProperties, ISiteHeaderProperties, ISiteNavigationProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const string ModelTypeAlias = "siteSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SiteSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SiteSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

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

		///<summary>
		/// Footer Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLinks")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel FooterLinks => global::Umbraco.Cms.Web.Common.PublishedModels.SiteFooterProperties.GetFooterLinks(this, _publishedValueFallback);

		///<summary>
		/// Footer Social Links: Enter the social links to display in the footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerSocialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.SocialLink> FooterSocialLinks => global::Umbraco.Cms.Web.Common.PublishedModels.SiteFooterProperties.GetFooterSocialLinks(this, _publishedValueFallback);

		///<summary>
		/// Footer Text: Enter the text for footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerText")]
		public virtual string FooterText => global::Umbraco.Cms.Web.Common.PublishedModels.SiteFooterProperties.GetFooterText(this, _publishedValueFallback);

		///<summary>
		/// Footer Title: Add the title for footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerTitle")]
		public virtual string FooterTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SiteFooterProperties.GetFooterTitle(this, _publishedValueFallback);

		///<summary>
		/// Site Logo Image: Add Site Logo Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteLogoImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SiteLogoImage => global::Umbraco.Cms.Web.Common.PublishedModels.SiteHeaderProperties.GetSiteLogoImage(this, _publishedValueFallback);

		///<summary>
		/// Site Title: Add the site title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteTitle")]
		public virtual string SiteTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SiteHeaderProperties.GetSiteTitle(this, _publishedValueFallback);

		///<summary>
		/// Main Navigation: Add the links for the main navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.3.0+a1d6f65")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainNavigation")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainNavigation => global::Umbraco.Cms.Web.Common.PublishedModels.SiteNavigationProperties.GetMainNavigation(this, _publishedValueFallback);
	}
}
