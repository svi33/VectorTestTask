using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecondFormTest
{
    public partial class Form2Request
    {
        [JsonProperty("formProperties")]
        public FormProperties FormProperties { get; set; }

        [JsonProperty("emailConfig")]
        public EmailConfig EmailConfig { get; set; }

        [JsonProperty("viewMode")]
        public string ViewMode { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("labelIds")]
        public string[] LabelIds { get; set; }

        public Form2Request()
        {
            this.FormProperties = new FormProperties();
            this.EmailConfig = new EmailConfig();
        }

        public static Form2Request InitialForTest()
        {
            Form2Request initial = new Form2Request();
            initial.FormProperties.FormName = "Contacts Form 2";
            initial.FormProperties.FormId = "comp-jxd8gc7s";
            initial.EmailConfig = new EmailConfig();
            initial.EmailConfig.SendToOwnerAndEmails = new SendToOwnerAndEmails();
            initial.EmailConfig.SendToOwnerAndEmails.EmailIds = new List<object>();
            initial.ViewMode = "Site";
            initial.Fields = new Field[2];
            initial.Fields[0] = new Field();
            initial.Fields[1] = new Field();
            initial.Fields[0].FirstName = new FirstName();
            initial.Fields[1].Email = new Email();
            initial.Fields[0].FieldId = "comp-jxd8gc8n";
            initial.Fields[0].Label = "First Name";
            initial.Fields[1].FieldId = "comp-jxd8gc99";
            initial.Fields[1].Label = "Email";
            initial.Fields[1].Email.Tag = "main";
            initial.LabelIds = new string[3];
            initial.LabelIds[0] = "contacts-contacted_me";
            initial.LabelIds[1] = "0e84ae80-8bf1-43a6-ba05-8eefb8cbc86b";
            initial.LabelIds[2] = "2f48386d-f13f-455f-a00f-9d697ef76de6";
            return initial;
        }
    }

    public partial class EmailConfig
    {
        [JsonProperty("sendToOwnerAndEmails", NullValueHandling = NullValueHandling.Ignore)]
        public SendToOwnerAndEmails SendToOwnerAndEmails { get; set; }
    }

    public partial class SendToOwnerAndEmails
    {
        [JsonProperty("emailIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> EmailIds { get; set; }
    }

    public partial class Field
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public FirstName FirstName { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public Email Email { get; set; }

    }

    public partial class Email
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public partial class FirstName
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class FormProperties
    {
        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("formId")]
        public string FormId { get; set; }
    }
}
