//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.4.0+daff988
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
	// Mixin Content Type with alias "contentProperties"
	/// <summary>Content Properties</summary>
	public partial interface IContentProperties : IPublishedElement
	{
		/// <summary>Body Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Strings.IHtmlEncodedString BodyText { get; }
	}

	/// <summary>Content Properties</summary>
	[PublishedModel("contentProperties")]
	public partial class ContentProperties : PublishedElementModel, IContentProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const string ModelTypeAlias = "contentProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ContentProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ContentProperties(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Body Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bodyText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString BodyText => GetBodyText(this, _publishedValueFallback);

		/// <summary>Static getter for Body Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.4.0+daff988")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Strings.IHtmlEncodedString GetBodyText(IContentProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(publishedValueFallback, "bodyText");
	}
}
