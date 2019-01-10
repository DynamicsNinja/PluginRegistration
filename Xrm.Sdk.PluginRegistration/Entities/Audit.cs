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
	
	/// <summary>
	/// Track changes to records for analysis, record keeping, and compliance.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("audit")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class Audit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Action = "action";
			public const string AttributeMask = "attributemask";
			public const string AuditId = "auditid";
			public const string Id = "auditid";
			public const string CallingUserId = "callinguserid";
			public const string CreatedOn = "createdon";
			public const string ObjectId = "objectid";
			public const string Operation = "operation";
			public const string RegardingObjectId = "regardingobjectid";
			public const string TransactionId = "transactionid";
			public const string UserAdditionalInfo = "useradditionalinfo";
			public const string UserId = "userid";
			public const string lk_audit_callinguserid = "lk_audit_callinguserid";
			public const string lk_audit_userid = "lk_audit_userid";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Audit() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "audit";
		
		public const string PrimaryIdAttribute = "auditid";
		
		public const int EntityTypeCode = 4567;
		
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
		/// Actions the user can perform that cause a change
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("action")]
		public Microsoft.Xrm.Sdk.OptionSetValue Action
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("action");
			}
		}
		
		/// <summary>
		/// Contains a CSV of the ColumnNumber metadata property of attributes
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributemask")]
		public string AttributeMask
		{
			get
			{
				return this.GetAttributeValue<string>("attributemask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the auditing instance
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
		public System.Nullable<System.Guid> AuditId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("auditid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				base.Id = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the calling user in case of an impersonated call
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
		public Microsoft.Xrm.Sdk.EntityReference CallingUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("callinguserid");
			}
		}
		
		/// <summary>
		/// Date and time when the audit record was created.
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
		/// Unique identifier of the record that is being audited
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
		}
		
		/// <summary>
		/// The action that causes the audit--it will be create, delete, or update
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
		public Microsoft.Xrm.Sdk.OptionSetValue Operation
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operation");
			}
		}
		
		/// <summary>
		/// Unique identifier of the object with which the record is associated.
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
		/// Unique identifier for multiple changes that are part of a single operation; this field contains the same GUID for all the audit rows generated in a single transaction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactionid")]
		public System.Nullable<System.Guid> TransactionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("transactionid");
			}
		}
		
		/// <summary>
		/// Additional information associated to the user who caused the change.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useradditionalinfo")]
		public string UserAdditionalInfo
		{
			get
			{
				return this.GetAttributeValue<string>("useradditionalinfo");
			}
			set
			{
				this.OnPropertyChanging("UserAdditionalInfo");
				this.SetAttributeValue("useradditionalinfo", value);
				this.OnPropertyChanged("UserAdditionalInfo");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who caused a change
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_audit
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_audit")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_audit
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_audit", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_audit");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_audit", null, value);
				this.OnPropertyChanged("userentityinstancedata_audit");
			}
		}
		
		/// <summary>
		/// N:1 lk_audit_callinguserid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_callinguserid")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_audit_callinguserid
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_audit_callinguserid", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_audit_userid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_userid")]
		public Xrm.Sdk.PluginRegistration.Entities.SystemUser lk_audit_userid
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.SystemUser>("lk_audit_userid", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public Audit(object anonymousType) : 
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
                        Attributes["auditid"] = base.Id;
                        break;
                    case "auditid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("action")]
		public virtual audit_action? ActionEnum
		{
			get
			{
				return ((audit_action?)(EntityOptionSetEnum.GetEnum(this, "action")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
		public virtual audit_operation? OperationEnum
		{
			get
			{
				return ((audit_operation?)(EntityOptionSetEnum.GetEnum(this, "operation")));
			}
		}
	}
}