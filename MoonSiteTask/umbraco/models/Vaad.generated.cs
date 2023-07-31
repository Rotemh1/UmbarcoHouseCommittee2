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
	/// <summary>Vaad</summary>
	[PublishedModel("vaad")]
	public partial class Vaad : PublishedContentModel, IPaymentElemnet, IPaymentsList, IPaymentsMonthsList
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		public new const string ModelTypeAlias = "vaad";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Vaad, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Vaad(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Amount: Amount of payment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[ImplementPropertyType("amount")]
		public virtual int Amount => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentElemnet.GetAmount(this, _publishedValueFallback);

		///<summary>
		/// AptNumber: Aprtment number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[ImplementPropertyType("aptNumber")]
		public virtual int AptNumber => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentElemnet.GetAptNumber(this, _publishedValueFallback);

		///<summary>
		/// FullName: name of resident
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("FullName")]
		public virtual string FullName => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentElemnet.GetFullName(this, _publishedValueFallback);

		///<summary>
		/// PaymentId: id of payment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[ImplementPropertyType("paymentId")]
		public virtual int PaymentId => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentElemnet.GetPaymentId(this, _publishedValueFallback);

		///<summary>
		/// Payments: Payments list view
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("payments")]
		public virtual object Payments => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentsList.GetPayments(this, _publishedValueFallback);

		///<summary>
		/// Month
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[ImplementPropertyType("Month")]
		public virtual global::System.DateTime Month => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentsMonthsList.GetMonth(this, _publishedValueFallback);

		///<summary>
		/// Paymentslst: list of payments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.0.1+20a4e47")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("paymentslst")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Paymentslst => global::Umbraco.Cms.Web.Common.PublishedModels.PaymentsMonthsList.GetPaymentslst(this, _publishedValueFallback);
	}
}