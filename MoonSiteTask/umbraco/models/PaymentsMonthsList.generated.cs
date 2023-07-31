//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.0.1+20a4e47
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
	// Mixin Content Type with alias "paymentsMonthsList"
	/// <summary>PaymentsMonthsList</summary>
	public partial interface IPaymentsMonthsList : IPublishedElement
	{
		/// <summary>Month</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		global::System.DateTime Month { get; }

		/// <summary>Paymentslst</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Paymentslst { get; }
	}

	/// <summary>PaymentsMonthsList</summary>
	[PublishedModel("paymentsMonthsList")]
	public partial class PaymentsMonthsList : PublishedElementModel, IPaymentsMonthsList
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		public new const string ModelTypeAlias = "paymentsMonthsList";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<PaymentsMonthsList, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public PaymentsMonthsList(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Month
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[ImplementPropertyType("Month")]
		public virtual global::System.DateTime Month => GetMonth(this, _publishedValueFallback);

		/// <summary>Static getter for Month</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		public static global::System.DateTime GetMonth(IPaymentsMonthsList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.DateTime>(publishedValueFallback, "Month");

		///<summary>
		/// Paymentslst: list of payments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("paymentslst")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Paymentslst => GetPaymentslst(this, _publishedValueFallback);

		/// <summary>Static getter for Paymentslst</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Blocks.BlockListModel GetPaymentslst(IPaymentsMonthsList that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(publishedValueFallback, "paymentslst");
	}
}