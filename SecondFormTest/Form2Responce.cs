using System;
using Newtonsoft.Json;

namespace SecondFormTest
{
    class Form2Responce
    {
        [JsonProperty("submissionId")]
        public Guid SubmissionId { get; set; }
    }
}
