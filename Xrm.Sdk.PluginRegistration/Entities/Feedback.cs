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
	public enum FeedbackState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Open = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Closed = 1,
	}
	
	/// <summary>
	/// Container for feedback and ratings for knowledge articles.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("feedback")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class Feedback : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClosedBy = "closedby";
			public const string ClosedOn = "closedon";
			public const string Comments = "comments";
			public const string CreatedBy = "createdby";
			public const string CreatedByContact = "createdbycontact";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByContact = "createdonbehalfbycontact";
			public const string ExchangeRate = "exchangerate";
			public const string FeedbackId = "feedbackid";
			public const string Id = "feedbackid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string MaxRating = "maxrating";
			public const string MinRating = "minrating";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string NormalizedRating = "normalizedrating";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Rating = "rating";
			public const string RegardingObjectId = "regardingobjectid";
			public const string Source = "source";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string Title = "title";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_feedback = "business_unit_feedback";
			public const string Contact_Feedback = "Contact_Feedback";
			public const string Referencingfeedback_feedback = "feedback_feedback";
			public const string KnowledgeArticle_Feedback = "KnowledgeArticle_Feedback";
			public const string lk_contact_feedback_createdby = "lk_contact_feedback_createdby";
			public const string lk_contact_feedback_createdonbehalfby = "lk_contact_feedback_createdonbehalfby";
			public const string lk_feedback_closedby = "lk_feedback_closedby";
			public const string lk_feedback_createdby = "lk_feedback_createdby";
			public const string lk_feedback_createdonbehalfby = "lk_feedback_createdonbehalfby";
			public const string lk_feedback_modifiedby = "lk_feedback_modifiedby";
			public const string lk_feedback_modifiedonbehalfby = "lk_feedback_modifiedonbehalfby";
			public const string transactioncurrency_feedback = "transactioncurrency_feedback";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Feedback() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "feedback";
		
		public const string PrimaryIdAttribute = "feedbackid";
		
		public const string PrimaryNameAttribute = "title";
		
		public const int EntityTypeCode = 9958;
		
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
		/// Shows who closed the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closedby")]
		public Microsoft.Xrm.Sdk.EntityReference ClosedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("closedby");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was closed. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closedon")]
		public System.Nullable<System.DateTime> ClosedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("closedon");
			}
		}
		
		/// <summary>
		/// Type the feedback comments.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("comments")]
		public string Comments
		{
			get
			{
				return this.GetAttributeValue<string>("comments");
			}
			set
			{
				this.OnPropertyChanging("Comments");
				this.SetAttributeValue("comments", value);
				this.OnPropertyChanged("Comments");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the contact who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbycontact")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByContact
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbycontact");
			}
			set
			{
				this.OnPropertyChanging("CreatedByContact");
				this.SetAttributeValue("createdbycontact", value);
				this.OnPropertyChanged("CreatedByContact");
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Shows the contact who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbycontact")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfByContact
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfbycontact");
			}
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfByContact");
				this.SetAttributeValue("createdonbehalfbycontact", value);
				this.OnPropertyChanged("CreatedOnBehalfByContact");
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
		/// FeedbackId
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("feedbackid")]
		public System.Nullable<System.Guid> FeedbackId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("feedbackid");
			}
			set
			{
				this.OnPropertyChanging("FeedbackId");
				this.SetAttributeValue("feedbackid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("FeedbackId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("feedbackid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.FeedbackId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Enter the maximum rating value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxrating")]
		public System.Nullable<int> MaxRating
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxrating");
			}
			set
			{
				this.OnPropertyChanging("MaxRating");
				this.SetAttributeValue("maxrating", value);
				this.OnPropertyChanged("MaxRating");
			}
		}
		
		/// <summary>
		/// Enter the minimum rating value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minrating")]
		public System.Nullable<int> MinRating
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("minrating");
			}
			set
			{
				this.OnPropertyChanging("MinRating");
				this.SetAttributeValue("minrating", value);
				this.OnPropertyChanged("MinRating");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows the rating scaled to a value between 0 and 1 based on minimum and maximum ratings.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("normalizedrating")]
		public System.Nullable<decimal> NormalizedRating
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("normalizedrating");
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
		/// Unique identifier of the user or team who owns the knowledge article views.
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
		/// Unique identifier of the business unit that owns the knowledge article views.
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
		/// Unique identifier of the team that owns the feedback.
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
		/// Unique identifier of the user who owns this feedback.
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
		/// Specifies how helpful the related record was.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rating")]
		public System.Nullable<int> Rating
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("rating");
			}
			set
			{
				this.OnPropertyChanging("Rating");
				this.SetAttributeValue("rating", value);
				this.OnPropertyChanged("Rating");
			}
		}
		
		/// <summary>
		/// Shows the record that the feedback is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Shows where the feedback was submitted from.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
		public Microsoft.Xrm.Sdk.OptionSetValue Source
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("source");
			}
			set
			{
				this.OnPropertyChanging("Source");
				this.SetAttributeValue("source", value);
				this.OnPropertyChanged("Source");
			}
		}
		
		/// <summary>
		/// Shows whether the feedback is open, rejected or closed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.FeedbackState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.FeedbackState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.FeedbackState), optionSet.Value)));
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
		/// Select the feedback's status.
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
		/// Type a title for the feedback.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
		/// Version number of the feedback.
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
		/// 1:N feedback_feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.Feedback> Referencedfeedback_feedback
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Feedback>("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			set
			{
				this.OnPropertyChanging("Referencedfeedback_feedback");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.Feedback>("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedfeedback_feedback");
			}
		}
		
		/// <summary>
		/// 1:N feedback_principalobjectattributeaccess
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("feedback_principalobjectattributeaccess")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess> feedback_principalobjectattributeaccess
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("feedback_principalobjectattributeaccess", null);
			}
			set
			{
				this.OnPropertyChanging("feedback_principalobjectattributeaccess");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.PrincipalObjectAttributeAccess>("feedback_principalobjectattributeaccess", null, value);
				this.OnPropertyChanged("feedback_principalobjectattributeaccess");
			}
		}
		
		/// <summary>
		/// 1:N Feedback_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Feedback_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> Feedback_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("Feedback_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("Feedback_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("Feedback_SyncErrors", null, value);
				this.OnPropertyChanged("Feedback_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_feedback")]
		public Xrm.Sdk.PluginRegistration.Entities.BusinessUnit business_unit_feedback
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.BusinessUnit>("business_unit_feedback", null);
			}
		}
		
		/// <summary>
		/// N:1 Contact_Feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Feedback")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact Contact_Feedback
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("Contact_Feedback", null);
			}
			set
			{
				this.OnPropertyChanging("Contact_Feedback");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("Contact_Feedback", null, value);
				this.OnPropertyChanged("Contact_Feedback");
			}
		}
		
		/// <summary>
		/// N:1 feedback_feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Xrm.Sdk.PluginRegistration.Entities.Feedback Referencingfeedback_feedback
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Feedback>("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			set
			{
				this.OnPropertyChanging("Referencingfeedback_feedback");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Feedback>("feedback_feedback", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingfeedback_feedback");
			}
		}
		
		/// <summary>
		/// N:1 KnowledgeArticle_Feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KnowledgeArticle_Feedback")]
		public Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle KnowledgeArticle_Feedback
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle>("KnowledgeArticle_Feedback", null);
			}
			set
			{
				this.OnPropertyChanging("KnowledgeArticle_Feedback");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.KnowledgeArticle>("KnowledgeArticle_Feedback", null, value);
				this.OnPropertyChanged("KnowledgeArticle_Feedback");
			}
		}
		
		/// <summary>
		/// N:1 lk_contact_feedback_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbycontact")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_feedback_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact lk_contact_feedback_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("lk_contact_feedback_createdby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_feedback_createdby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("lk_contact_feedback_createdby", null, value);
				this.OnPropertyChanged("lk_contact_feedback_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_contact_feedback_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbycontact")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_feedback_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.Contact lk_contact_feedback_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("lk_contact_feedback_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_contact_feedback_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Contact>("lk_contact_feedback_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_contact_feedback_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_feedback_closedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_feedback_closedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_feedback_closedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_closedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_feedback_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_feedback_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_feedback_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_feedback_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_feedback_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_feedback_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_feedback_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_feedback_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_feedback_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_feedback_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_feedback_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_feedback_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_feedback_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_feedback_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_feedback_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_feedback_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_feedback_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_feedback
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_feedback")]
		public Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency transactioncurrency_feedback
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_feedback", null);
			}
			set
			{
				this.OnPropertyChanging("transactioncurrency_feedback");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.TransactionCurrency>("transactioncurrency_feedback", null, value);
				this.OnPropertyChanged("transactioncurrency_feedback");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public Feedback(object anonymousType) : 
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
                        Attributes["feedbackid"] = base.Id;
                        break;
                    case "feedbackid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
		public virtual feedback_source? SourceEnum
		{
			get
			{
				return ((feedback_source?)(EntityOptionSetEnum.GetEnum(this, "source")));
			}
			set
			{
				Source = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual feedback_statuscode? StatusCodeEnum
		{
			get
			{
				return ((feedback_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}