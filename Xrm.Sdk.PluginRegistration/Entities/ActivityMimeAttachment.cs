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
	/// MIME attachment for an activity.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activitymimeattachment")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class ActivityMimeAttachment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActivityId = "activityid";
			public const string ActivityMimeAttachmentId = "activitymimeattachmentid";
			public const string Id = "activitymimeattachmentid";
			public const string ActivityMimeAttachmentIdUnique = "activitymimeattachmentidunique";
			public const string ActivitySubject = "activitysubject";
			public const string AnonymousLink = "anonymouslink";
			public const string AttachmentContentId = "attachmentcontentid";
			public const string AttachmentId = "attachmentid";
			public const string AttachmentNumber = "attachmentnumber";
			public const string Body = "body";
			public const string ComponentState = "componentstate";
			public const string FileName = "filename";
			public const string FileSize = "filesize";
			public const string IsFollowed = "isfollowed";
			public const string IsManaged = "ismanaged";
			public const string MimeType = "mimetype";
			public const string ObjectId = "objectid";
			public const string ObjectTypeCode = "objecttypecode";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string SolutionId = "solutionid";
			public const string Subject = "subject";
			public const string VersionNumber = "versionnumber";
			public const string activity_pointer_activity_mime_attachment = "activity_pointer_activity_mime_attachment";
			public const string appointment_activity_mime_attachment = "appointment_activity_mime_attachment";
			public const string email_activity_mime_attachment = "email_activity_mime_attachment";
			public const string template_activity_mime_attachments = "template_activity_mime_attachments";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ActivityMimeAttachment() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "activitymimeattachment";
		
		public const string PrimaryIdAttribute = "activitymimeattachmentid";
		
		public const string PrimaryNameAttribute = "filename";
		
		public const int EntityTypeCode = 1001;
		
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
		/// Unique identifier of the activity with which the attachment is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.EntityReference ActivityId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
			}
			set
			{
				this.OnPropertyChanging("ActivityId");
				this.SetAttributeValue("activityid", value);
				this.OnPropertyChanged("ActivityId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentid")]
		public System.Nullable<System.Guid> ActivityMimeAttachmentId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitymimeattachmentid");
			}
			set
			{
				this.OnPropertyChanging("ActivityMimeAttachmentId");
				this.SetAttributeValue("activitymimeattachmentid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ActivityMimeAttachmentId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ActivityMimeAttachmentId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentidunique")]
		public System.Nullable<System.Guid> ActivityMimeAttachmentIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("activitymimeattachmentidunique");
			}
			set
			{
				this.OnPropertyChanging("ActivityMimeAttachmentIdUnique");
				this.SetAttributeValue("activitymimeattachmentidunique", value);
				this.OnPropertyChanged("ActivityMimeAttachmentIdUnique");
			}
		}
		
		/// <summary>
		/// Descriptive subject for the activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitysubject")]
		public string ActivitySubject
		{
			get
			{
				return this.GetAttributeValue<string>("activitysubject");
			}
		}
		
		/// <summary>
		/// anonymous link
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anonymouslink")]
		public string AnonymousLink
		{
			get
			{
				return this.GetAttributeValue<string>("anonymouslink");
			}
		}
		
		/// <summary>
		/// For internal use only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcontentid")]
		public string AttachmentContentId
		{
			get
			{
				return this.GetAttributeValue<string>("attachmentcontentid");
			}
			set
			{
				this.OnPropertyChanging("AttachmentContentId");
				this.SetAttributeValue("attachmentcontentid", value);
				this.OnPropertyChanged("AttachmentContentId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the attachment with which this activitymimeattachment is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentid")]
		public Microsoft.Xrm.Sdk.EntityReference AttachmentId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("attachmentid");
			}
			set
			{
				this.OnPropertyChanging("AttachmentId");
				this.SetAttributeValue("attachmentid", value);
				this.OnPropertyChanged("AttachmentId");
			}
		}
		
		/// <summary>
		/// Number of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentnumber")]
		public System.Nullable<int> AttachmentNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("attachmentnumber");
			}
			set
			{
				this.OnPropertyChanging("AttachmentNumber");
				this.SetAttributeValue("attachmentnumber", value);
				this.OnPropertyChanged("AttachmentNumber");
			}
		}
		
		/// <summary>
		/// Contents of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("body")]
		public string Body
		{
			get
			{
				return this.GetAttributeValue<string>("body");
			}
			set
			{
				this.OnPropertyChanging("Body");
				this.SetAttributeValue("body", value);
				this.OnPropertyChanged("Body");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// File name of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
		public string FileName
		{
			get
			{
				return this.GetAttributeValue<string>("filename");
			}
			set
			{
				this.OnPropertyChanging("FileName");
				this.SetAttributeValue("filename", value);
				this.OnPropertyChanged("FileName");
			}
		}
		
		/// <summary>
		/// File size of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
		public System.Nullable<int> FileSize
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filesize");
			}
		}
		
		/// <summary>
		/// Indicates if this attachment is followed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfollowed")]
		public System.Nullable<bool> IsFollowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isfollowed");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// MIME type of the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
		public string MimeType
		{
			get
			{
				return this.GetAttributeValue<string>("mimetype");
			}
			set
			{
				this.OnPropertyChanging("MimeType");
				this.SetAttributeValue("mimetype", value);
				this.OnPropertyChanged("MimeType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the record with which the attachment is associated
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// Object Type Code of the entity that is associated with the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public string ObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("objecttypecode");
			}
			set
			{
				this.OnPropertyChanging("ObjectTypeCode");
				this.SetAttributeValue("objecttypecode", value);
				this.OnPropertyChanged("ObjectTypeCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the activity_mime_attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the activity mime attachment.
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
		/// Unique identifier of the user who owns the activity mime attachment.
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
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Descriptive subject for the attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
		public string Subject
		{
			get
			{
				return this.GetAttributeValue<string>("subject");
			}
			set
			{
				this.OnPropertyChanging("Subject");
				this.SetAttributeValue("subject", value);
				this.OnPropertyChanged("Subject");
			}
		}
		
		/// <summary>
		/// Version number of the activity mime attachment.
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
		/// 1:N ActivityMimeAttachment_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation> ActivityMimeAttachment_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ActivityMimeAttachment_AsyncOperations", null);
			}
			set
			{
				this.OnPropertyChanging("ActivityMimeAttachment_AsyncOperations");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.AsyncOperation>("ActivityMimeAttachment_AsyncOperations", null, value);
				this.OnPropertyChanged("ActivityMimeAttachment_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ActivityMimeAttachment_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure> ActivityMimeAttachment_BulkDeleteFailures
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null);
			}
			set
			{
				this.OnPropertyChanging("ActivityMimeAttachment_BulkDeleteFailures");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ActivityMimeAttachment_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N ActivityMimeAttachment_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_SyncErrors")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.SyncError> ActivityMimeAttachment_SyncErrors
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ActivityMimeAttachment_SyncErrors", null);
			}
			set
			{
				this.OnPropertyChanging("ActivityMimeAttachment_SyncErrors");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.SyncError>("ActivityMimeAttachment_SyncErrors", null, value);
				this.OnPropertyChanged("ActivityMimeAttachment_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_activitymimeattachment
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activitymimeattachment")]
		public System.Collections.Generic.IEnumerable<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData> userentityinstancedata_activitymimeattachment
		{
			get
			{
				return this.GetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_activitymimeattachment", null);
			}
			set
			{
				this.OnPropertyChanging("userentityinstancedata_activitymimeattachment");
				this.SetRelatedEntities<Xrm.Sdk.PluginRegistration.Entities.UserEntityInstanceData>("userentityinstancedata_activitymimeattachment", null, value);
				this.OnPropertyChanged("userentityinstancedata_activitymimeattachment");
			}
		}
		
		/// <summary>
		/// N:1 activity_pointer_activity_mime_attachment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_activity_mime_attachment")]
		public Xrm.Sdk.PluginRegistration.Entities.ActivityPointer activity_pointer_activity_mime_attachment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActivityPointer>("activity_pointer_activity_mime_attachment", null);
			}
			set
			{
				this.OnPropertyChanging("activity_pointer_activity_mime_attachment");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.ActivityPointer>("activity_pointer_activity_mime_attachment", null, value);
				this.OnPropertyChanged("activity_pointer_activity_mime_attachment");
			}
		}
		
		/// <summary>
		/// N:1 appointment_activity_mime_attachment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_mime_attachment")]
		public Xrm.Sdk.PluginRegistration.Entities.Appointment appointment_activity_mime_attachment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Appointment>("appointment_activity_mime_attachment", null);
			}
			set
			{
				this.OnPropertyChanging("appointment_activity_mime_attachment");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Appointment>("appointment_activity_mime_attachment", null, value);
				this.OnPropertyChanged("appointment_activity_mime_attachment");
			}
		}
		
		/// <summary>
		/// N:1 email_activity_mime_attachment
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_mime_attachment")]
		public Xrm.Sdk.PluginRegistration.Entities.Email email_activity_mime_attachment
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Email>("email_activity_mime_attachment", null);
			}
			set
			{
				this.OnPropertyChanging("email_activity_mime_attachment");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Email>("email_activity_mime_attachment", null, value);
				this.OnPropertyChanged("email_activity_mime_attachment");
			}
		}
		
		/// <summary>
		/// N:1 template_activity_mime_attachments
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("template_activity_mime_attachments")]
		public Xrm.Sdk.PluginRegistration.Entities.Template template_activity_mime_attachments
		{
			get
			{
				return this.GetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Template>("template_activity_mime_attachments", null);
			}
			set
			{
				this.OnPropertyChanging("template_activity_mime_attachments");
				this.SetRelatedEntity<Xrm.Sdk.PluginRegistration.Entities.Template>("template_activity_mime_attachments", null, value);
				this.OnPropertyChanged("template_activity_mime_attachments");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		public ActivityMimeAttachment(object anonymousType) : 
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
                        Attributes["activitymimeattachmentid"] = base.Id;
                        break;
                    case "activitymimeattachmentid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual componentstate? ComponentStateEnum
		{
			get
			{
				return ((componentstate?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
	}
}