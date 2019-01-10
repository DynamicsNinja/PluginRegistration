//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xrm.Sdk.PluginRegistration.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum PriceLevelState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Entity that defines pricing levels.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pricelevel")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class PriceLevel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string BeginDate = "begindate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EndDate = "enddate";
			public const string ExchangeRate = "exchangerate";
			public const string FreightTermsCode = "freighttermscode";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string PaymentMethodCode = "paymentmethodcode";
			public const string PriceLevelId = "pricelevelid";
			public const string Id = "pricelevelid";
			public const string ShippingMethodCode = "shippingmethodcode";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_pricelevel_createdonbehalfby = "lk_pricelevel_createdonbehalfby";
			public const string lk_pricelevel_modifiedonbehalfby = "lk_pricelevel_modifiedonbehalfby";
			public const string lk_pricelevelbase_createdby = "lk_pricelevelbase_createdby";
			public const string lk_pricelevelbase_modifiedby = "lk_pricelevelbase_modifiedby";
			public const string organization_price_levels = "organization_price_levels";
			public const string transactioncurrency_pricelevel = "transactioncurrency_pricelevel";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PriceLevel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "pricelevel";
		
		public const string PrimaryIdAttribute = "pricelevelid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1022;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Date on which the price list becomes effective.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("begindate")]
		public System.Nullable<System.DateTime> BeginDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("begindate");
			}
			set
			{
				this.OnPropertyChanging("BeginDate");
				this.SetAttributeValue("begindate", value);
				this.OnPropertyChanged("BeginDate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the pricelevel.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Description of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Date that is the last day the price list is valid.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enddate")]
		public System.Nullable<System.DateTime> EndDate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("enddate");
			}
			set
			{
				this.OnPropertyChanging("EndDate");
				this.SetAttributeValue("enddate", value);
				this.OnPropertyChanged("EndDate");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Freight terms for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
			}
			set
			{
				this.OnPropertyChanging("FreightTermsCode");
				this.SetAttributeValue("freighttermscode", value);
				this.OnPropertyChanged("FreightTermsCode");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the pricelevel.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Payment terms to use with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymentmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PaymentMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymentmethodcode");
			}
			set
			{
				this.OnPropertyChanging("PaymentMethodCode");
				this.SetAttributeValue("paymentmethodcode", value);
				this.OnPropertyChanged("PaymentMethodCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public System.Nullable<System.Guid> PriceLevelId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pricelevelid");
			}
			set
			{
				this.OnPropertyChanging("PriceLevelId");
				this.SetAttributeValue("pricelevelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PriceLevelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.PriceLevelId = value;
			}
		}
		
		/// <summary>
		/// Method of shipment for products in the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
			}
			set
			{
				this.OnPropertyChanging("ShippingMethodCode");
				this.SetAttributeValue("shippingmethodcode", value);
				this.OnPropertyChanged("ShippingMethodCode");
			}
		}
		
		/// <summary>
		/// Status of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.PriceLevelState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.PriceLevelState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.PriceLevelState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the price level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N price_level_accounts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_accounts")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Account> price_level_accounts
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Account>("price_level_accounts", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_accounts");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Account>("price_level_accounts", null, value);
				this.OnPropertyChanged("price_level_accounts");
			}
		}
		
		/// <summary>
		/// 1:N price_level_contacts
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_contacts")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Contact> price_level_contacts
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Contact>("price_level_contacts", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_contacts");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Contact>("price_level_contacts", null, value);
				this.OnPropertyChanged("price_level_contacts");
			}
		}
		
		/// <summary>
		/// 1:N price_level_invoices
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_invoices")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Invoice> price_level_invoices
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Invoice>("price_level_invoices", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_invoices");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Invoice>("price_level_invoices", null, value);
				this.OnPropertyChanged("price_level_invoices");
			}
		}
		
		/// <summary>
		/// 1:N price_level_opportunties
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_opportunties")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Opportunity> price_level_opportunties
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("price_level_opportunties", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_opportunties");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Opportunity>("price_level_opportunties", null, value);
				this.OnPropertyChanged("price_level_opportunties");
			}
		}
		
		/// <summary>
		/// 1:N price_level_orders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_orders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SalesOrder> price_level_orders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SalesOrder>("price_level_orders", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_orders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SalesOrder>("price_level_orders", null, value);
				this.OnPropertyChanged("price_level_orders");
			}
		}
		
		/// <summary>
		/// 1:N price_level_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_product_price_levels")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProductPriceLevel> price_level_product_price_levels
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProductPriceLevel>("price_level_product_price_levels", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_product_price_levels");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProductPriceLevel>("price_level_product_price_levels", null, value);
				this.OnPropertyChanged("price_level_product_price_levels");
			}
		}
		
		/// <summary>
		/// 1:N price_level_products
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_products")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Product> price_level_products
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Product>("price_level_products", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_products");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Product>("price_level_products", null, value);
				this.OnPropertyChanged("price_level_products");
			}
		}
		
		/// <summary>
		/// 1:N price_level_quotes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_quotes")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Quote> price_level_quotes
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Quote>("price_level_quotes", null);
			}
			set
			{
				this.OnPropertyChanging("price_level_quotes");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Quote>("price_level_quotes", null, value);
				this.OnPropertyChanged("price_level_quotes");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> PriceLevel_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("PriceLevel_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("PriceLevel_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("PriceLevel_AsyncOperations", null, value);
				this.OnPropertyChanged("PriceLevel_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> PriceLevel_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("PriceLevel_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("PriceLevel_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_connections1
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections1")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Connection> pricelevel_connections1
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("pricelevel_connections1", null);
			}
			set
			{
				this.OnPropertyChanging("pricelevel_connections1");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("pricelevel_connections1", null, value);
				this.OnPropertyChanged("pricelevel_connections1");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_connections2
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections2")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Connection> pricelevel_connections2
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("pricelevel_connections2", null);
			}
			set
			{
				this.OnPropertyChanging("pricelevel_connections2");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Connection>("pricelevel_connections2", null, value);
				this.OnPropertyChanged("pricelevel_connections2");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> pricelevel_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("pricelevel_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("pricelevel_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("pricelevel_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("pricelevel_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N pricelevel_principalobjectattributeaccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_principalobjectattributeaccess")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> pricelevel_principalobjectattributeaccess
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("pricelevel_principalobjectattributeaccess", null);
			}
			set
			{
				this.OnPropertyChanging("pricelevel_principalobjectattributeaccess");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("pricelevel_principalobjectattributeaccess", null, value);
				this.OnPropertyChanged("pricelevel_principalobjectattributeaccess");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> PriceLevel_ProcessSessions
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("PriceLevel_ProcessSessions", null);
			}
			set
			{
				this.OnPropertyChanging("PriceLevel_ProcessSessions");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("PriceLevel_ProcessSessions", null, value);
				this.OnPropertyChanged("PriceLevel_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N PriceLevel_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> PriceLevel_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("PriceLevel_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("PriceLevel_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("PriceLevel_SyncErrors", null, value);
				this.OnPropertyChanged("PriceLevel_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N PriceList_Campaigns
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceList_Campaigns")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Campaign> PriceList_Campaigns
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Campaign>("PriceList_Campaigns", null);
			}
			set
			{
				this.OnPropertyChanging("PriceList_Campaigns");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Campaign>("PriceList_Campaigns", null, value);
				this.OnPropertyChanged("PriceList_Campaigns");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_pricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_pricelevel")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_pricelevel
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_pricelevel", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_pricelevel");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_pricelevel", null, value);
				this.OnPropertyChanged("userentityinstancedata_pricelevel");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_pricelevel_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevel_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_pricelevel_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_pricelevel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_pricelevel_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevel_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_pricelevel_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_pricelevel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevelbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_pricelevelbase_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevelbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_pricelevelbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_pricelevelbase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_pricelevelbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_price_levels")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_price_levels
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_price_levels", null);
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_pricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_pricelevel")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency transactioncurrency_pricelevel
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_pricelevel", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_pricelevel");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_pricelevel", null, value);
				this.OnPropertyChanged("transactioncurrency_pricelevel");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public PriceLevel(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["pricelevelid"] = base.Id;
                        break;
                    case "pricelevelid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
		public virtual pricelevel_freighttermscode? FreightTermsCodeEnum
		{
			get
			{
				return ((pricelevel_freighttermscode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
			}
			set
			{
				FreightTermsCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymentmethodcode")]
		public virtual pricelevel_paymentmethodcode? PaymentMethodCodeEnum
		{
			get
			{
				return ((pricelevel_paymentmethodcode?)(EntityOptionSetEnum.GetEnum(this, "paymentmethodcode")));
			}
			set
			{
				PaymentMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
		public virtual pricelevel_shippingmethodcode? ShippingMethodCodeEnum
		{
			get
			{
				return ((pricelevel_shippingmethodcode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
			}
			set
			{
				ShippingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual pricelevel_statuscode? StatusCodeEnum
		{
			get
			{
				return ((pricelevel_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}