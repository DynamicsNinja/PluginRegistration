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
	public enum RatingValueState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// A unique value associated with a rating model that allows providing a user friendly rating value.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ratingvalue")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class RatingValue : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string RatingModel = "ratingmodel";
			public const string RatingValueId = "ratingvalueid";
			public const string Id = "ratingvalueid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string Value = "value";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_ratingvalue = "business_unit_ratingvalue";
			public const string lk_ratingvalue_createdby = "lk_ratingvalue_createdby";
			public const string lk_ratingvalue_createdonbehalfby = "lk_ratingvalue_createdonbehalfby";
			public const string lk_ratingvalue_modifiedby = "lk_ratingvalue_modifiedby";
			public const string lk_ratingvalue_modifiedonbehalfby = "lk_ratingvalue_modifiedonbehalfby";
			public const string ratingmodel_ratingvalue_RatingModel = "ratingmodel_ratingvalue_RatingModel";
			public const string team_ratingvalue = "team_ratingvalue";
			public const string TransactionCurrency_ratingvalue = "TransactionCurrency_ratingvalue";
			public const string user_ratingvalue = "user_ratingvalue";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public RatingValue() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ratingvalue";
		
		public const string PrimaryIdAttribute = "ratingvalueid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 1142;
		
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
		/// Unique identifier of the user who created the record.
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
		/// Unique identifier of the delegate user who created the record.
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
		/// Exchange rate for the currency associated with the ratingvalue with respect to the base currency.
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
		/// Unique identifier of the user who modified the record.
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
		/// Unique identifier of the delegate user who modified the record.
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
		/// Type a name that represents a rating value such as familiar, good, proficient etc.
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
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Select the model that this rating value is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ratingmodel")]
		public Microsoft.Xrm.Sdk.EntityReference RatingModel
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ratingmodel");
			}
			set
			{
				this.OnPropertyChanging("RatingModel");
				this.SetAttributeValue("ratingmodel", value);
				this.OnPropertyChanged("RatingModel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the rating value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ratingvalueid")]
		public System.Nullable<System.Guid> RatingValueId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ratingvalueid");
			}
			set
			{
				this.OnPropertyChanging("RatingValueId");
				this.SetAttributeValue("ratingvalueid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("RatingValueId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ratingvalueid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.RatingValueId = value;
			}
		}
		
		/// <summary>
		/// Status of the Rating Value
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.RatingValueState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.RatingValueState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.RatingValueState), optionSet.Value)));
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
		/// Reason for the status of the Rating Value
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
		/// Exchange rate for the currency associated with the RatingValue with respect to the base currency.
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
		/// Type a rating value which is unique to the rating model it is associated with and lies within the range specified on the model.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("value")]
		public System.Nullable<int> Value
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("value");
			}
			set
			{
				this.OnPropertyChanging("Value");
				this.SetAttributeValue("value", value);
				this.OnPropertyChanged("Value");
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
		/// 1:N ratingvalue_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> ratingvalue_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ratingvalue_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ratingvalue_AsyncOperations", null, value);
				this.OnPropertyChanged("ratingvalue_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_bookableresourcecharacteristic_RatingValue
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_bookableresourcecharacteristic_RatingValue")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic> ratingvalue_bookableresourcecharacteristic_RatingValue
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic>("ratingvalue_bookableresourcecharacteristic_RatingValue", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_bookableresourcecharacteristic_RatingValue");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BookableResourceCharacteristic>("ratingvalue_bookableresourcecharacteristic_RatingValue", null, value);
				this.OnPropertyChanged("ratingvalue_bookableresourcecharacteristic_RatingValue");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> ratingvalue_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ratingvalue_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ratingvalue_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ratingvalue_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> ratingvalue_DuplicateBaseRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("ratingvalue_DuplicateBaseRecord", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_DuplicateBaseRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("ratingvalue_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("ratingvalue_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord> ratingvalue_DuplicateMatchingRecord
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("ratingvalue_DuplicateMatchingRecord", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_DuplicateMatchingRecord");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.DuplicateRecord>("ratingvalue_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("ratingvalue_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder> ratingvalue_MailboxTrackingFolders
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("ratingvalue_MailboxTrackingFolders", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_MailboxTrackingFolders");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.MailboxTrackingFolder>("ratingvalue_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("ratingvalue_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_PrincipalObjectAttributeAccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_PrincipalObjectAttributeAccess")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> ratingvalue_PrincipalObjectAttributeAccess
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("ratingvalue_PrincipalObjectAttributeAccess", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_PrincipalObjectAttributeAccess");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("ratingvalue_PrincipalObjectAttributeAccess", null, value);
				this.OnPropertyChanged("ratingvalue_PrincipalObjectAttributeAccess");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.ProcessSession> ratingvalue_ProcessSession
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ratingvalue_ProcessSession", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_ProcessSession");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.ProcessSession>("ratingvalue_ProcessSession", null, value);
				this.OnPropertyChanged("ratingvalue_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N RatingValue_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RatingValue_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> RatingValue_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("RatingValue_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("RatingValue_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("RatingValue_SyncErrors", null, value);
				this.OnPropertyChanged("RatingValue_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N ratingvalue_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingvalue_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> ratingvalue_UserEntityInstanceDatas
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("ratingvalue_UserEntityInstanceDatas", null);
			}
			set
			{
				this.OnPropertyChanging("ratingvalue_UserEntityInstanceDatas");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("ratingvalue_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("ratingvalue_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_ratingvalue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_ratingvalue")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_ratingvalue
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_ratingvalue", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ratingvalue_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ratingvalue_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ratingvalue_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ratingvalue_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ratingvalue_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ratingvalue_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ratingvalue_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ratingvalue_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_ratingvalue_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ratingvalue_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ratingvalue_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ratingvalue_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ratingvalue_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_ratingvalue_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_ratingvalue_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_ratingvalue_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ratingvalue_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 ratingmodel_ratingvalue_RatingModel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ratingmodel")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ratingmodel_ratingvalue_RatingModel")]
		public Xrm.Sdk.PluginRegistration.Entities.RatingModel ratingmodel_ratingvalue_RatingModel
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RatingModel>("ratingmodel_ratingvalue_RatingModel", null);
			}
			set
			{
				this.OnPropertyChanging("ratingmodel_ratingvalue_RatingModel");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.RatingModel>("ratingmodel_ratingvalue_RatingModel", null, value);
				this.OnPropertyChanged("ratingmodel_ratingvalue_RatingModel");
			}
		}
		
		/// <summary>
		/// N:1 team_ratingvalue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ratingvalue")]
		public Xrm.Sdk.PluginRegistration.Entities.Team team_ratingvalue
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Team>("team_ratingvalue", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_ratingvalue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ratingvalue")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency TransactionCurrency_ratingvalue
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_ratingvalue", null);
			}
			set
			{
				this.OnPropertyChanging("TransactionCurrency_ratingvalue");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("TransactionCurrency_ratingvalue", null, value);
				this.OnPropertyChanged("TransactionCurrency_ratingvalue");
			}
		}
		
		/// <summary>
		/// N:1 user_ratingvalue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_ratingvalue")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser user_ratingvalue
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("user_ratingvalue", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public RatingValue(object anonymousType) : 
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
                        Attributes["ratingvalueid"] = base.Id;
                        break;
                    case "ratingvalueid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual ratingvalue_statuscode? StatusCodeEnum
		{
			get
			{
				return ((ratingvalue_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}