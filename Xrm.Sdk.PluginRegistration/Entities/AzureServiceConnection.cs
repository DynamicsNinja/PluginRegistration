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
	public enum AzureServiceConnectionState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Stores connection information for an Azure service
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("azureserviceconnection")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class AzureServiceConnection : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AccountKey = "accountkey";
			public const string AzureServiceConnectionId = "azureserviceconnectionid";
			public const string Id = "azureserviceconnectionid";
			public const string ConnectionType = "connectiontype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string LastConnectionStatusCode = "lastconnectionstatuscode";
			public const string LastConnectionTime = "lastconnectiontime";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string ServiceUri = "serviceuri";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string lk_azureserviceconnection_createdby = "lk_azureserviceconnection_createdby";
			public const string lk_azureserviceconnection_createdonbehalfby = "lk_azureserviceconnection_createdonbehalfby";
			public const string lk_azureserviceconnection_modifiedby = "lk_azureserviceconnection_modifiedby";
			public const string lk_azureserviceconnection_modifiedonbehalfby = "lk_azureserviceconnection_modifiedonbehalfby";
			public const string organization_azureserviceconnection = "organization_azureserviceconnection";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public AzureServiceConnection() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "azureserviceconnection";
		
		public const string PrimaryIdAttribute = "azureserviceconnectionid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 9936;
		
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
		/// Type the Azure account key.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountkey")]
		public string AccountKey
		{
			get
			{
				return this.GetAttributeValue<string>("accountkey");
			}
			set
			{
				this.OnPropertyChanging("AccountKey");
				this.SetAttributeValue("accountkey", value);
				this.OnPropertyChanged("AccountKey");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Azure service connection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public System.Nullable<System.Guid> AzureServiceConnectionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("azureserviceconnectionid");
			}
			set
			{
				this.OnPropertyChanging("AzureServiceConnectionId");
				this.SetAttributeValue("azureserviceconnectionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("AzureServiceConnectionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureserviceconnectionid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.AzureServiceConnectionId = value;
			}
		}
		
		/// <summary>
		/// Azure service connection type
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectiontype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ConnectionType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("connectiontype");
			}
			set
			{
				this.OnPropertyChanging("ConnectionType");
				this.SetAttributeValue("connectiontype", value);
				this.OnPropertyChanged("ConnectionType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the Azure service connection.
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
		/// Date and time when the Azure service connection was created.
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
		/// Unique identifier of the delegate user who created the Azure service connection.
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
		/// Enter a description of the Azure service connection.
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
		/// Shows the status of the last connection to the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectionstatuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue LastConnectionStatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("lastconnectionstatuscode");
			}
			set
			{
				this.OnPropertyChanging("LastConnectionStatusCode");
				this.SetAttributeValue("lastconnectionstatuscode", value);
				this.OnPropertyChanged("LastConnectionStatusCode");
			}
		}
		
		/// <summary>
		/// shows the time of the last connection to the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectiontime")]
		public System.Nullable<System.DateTime> LastConnectionTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastconnectiontime");
			}
			set
			{
				this.OnPropertyChanging("LastConnectionTime");
				this.SetAttributeValue("lastconnectiontime", value);
				this.OnPropertyChanged("LastConnectionTime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the Azure service connection.
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
		/// Date and time when the Azure service connection was last modified.
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
		/// Unique identifier of the delegate user who last modified the Azure service connection.
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
		/// Type a logical name for the connection.
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
		/// Unique identifier of the organization associated with the Azure service connection.
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
		/// Type the service URL for the Azure service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceuri")]
		public string ServiceUri
		{
			get
			{
				return this.GetAttributeValue<string>("serviceuri");
			}
			set
			{
				this.OnPropertyChanging("ServiceUri");
				this.SetAttributeValue("serviceuri", value);
				this.OnPropertyChanged("ServiceUri");
			}
		}
		
		/// <summary>
		/// Shows whether the Azure service connection is active or inactive.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnectionState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnectionState)(System.Enum.ToObject(typeof(Xrm.Sdk.PluginRegistration.Entities.AzureServiceConnectionState), optionSet.Value)));
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
		/// Select the Azure service connection's status.
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
		/// 1:N azureserviceconnection_advancedsimilarityrule
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_advancedsimilarityrule")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AdvancedSimilarityRule> azureserviceconnection_advancedsimilarityrule
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AdvancedSimilarityRule>("azureserviceconnection_advancedsimilarityrule", null);
			}
			set
			{
				this.OnPropertyChanging("azureserviceconnection_advancedsimilarityrule");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AdvancedSimilarityRule>("azureserviceconnection_advancedsimilarityrule", null, value);
				this.OnPropertyChanged("azureserviceconnection_advancedsimilarityrule");
			}
		}
		
		/// <summary>
		/// 1:N azureserviceconnection_knowledgesearchmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_knowledgesearchmodel")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.KnowledgeSearchModel> azureserviceconnection_knowledgesearchmodel
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.KnowledgeSearchModel>("azureserviceconnection_knowledgesearchmodel", null);
			}
			set
			{
				this.OnPropertyChanging("azureserviceconnection_knowledgesearchmodel");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.KnowledgeSearchModel>("azureserviceconnection_knowledgesearchmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_knowledgesearchmodel");
			}
		}
		
		/// <summary>
		/// 1:N azureserviceconnection_topicmodel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("azureserviceconnection_topicmodel")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.TopicModel> azureserviceconnection_topicmodel
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModel>("azureserviceconnection_topicmodel", null);
			}
			set
			{
				this.OnPropertyChanging("azureserviceconnection_topicmodel");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.TopicModel>("azureserviceconnection_topicmodel", null, value);
				this.OnPropertyChanged("azureserviceconnection_topicmodel");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_createdby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_azureserviceconnection_createdby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_createdonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_azureserviceconnection_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_createdonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_createdonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_modifiedby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_azureserviceconnection_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_azureserviceconnection_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_azureserviceconnection_modifiedonbehalfby")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_azureserviceconnection_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_modifiedonbehalfby", null);
			}
			set
			{
				this.OnPropertyChanging("lk_azureserviceconnection_modifiedonbehalfby");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_azureserviceconnection_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_azureserviceconnection_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_azureserviceconnection
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_azureserviceconnection")]
		public Xrm.Sdk.PluginRegistration.Entities.Organization organization_azureserviceconnection
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Organization>("organization_azureserviceconnection", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public AzureServiceConnection(object anonymousType) : 
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
                        Attributes["azureserviceconnectionid"] = base.Id;
                        break;
                    case "azureserviceconnectionid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectiontype")]
		public virtual azureserviceconnection_connectiontype? ConnectionTypeEnum
		{
			get
			{
				return ((azureserviceconnection_connectiontype?)(EntityOptionSetEnum.GetEnum(this, "connectiontype")));
			}
			set
			{
				ConnectionType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastconnectionstatuscode")]
		public virtual azureserviceconnection_lastconnectionstatuscode? LastConnectionStatusCodeEnum
		{
			get
			{
				return ((azureserviceconnection_lastconnectionstatuscode?)(EntityOptionSetEnum.GetEnum(this, "lastconnectionstatuscode")));
			}
			set
			{
				LastConnectionStatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual azureserviceconnection_statuscode? StatusCodeEnum
		{
			get
			{
				return ((azureserviceconnection_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}