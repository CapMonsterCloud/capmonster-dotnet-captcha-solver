using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Zennolab.CapMonsterCloud.Responses;
using System.Collections.Generic;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// ComplexImageTask recognition request for Recognition images
    /// </summary>
    public sealed class RecognitionComplexImageTaskRequest : ComplexImageTaskRequestBase<DynamicComplexImageTaskResponse>
    {
        /// <inheritdoc/>
        public override string Class => "recognition";

        /// <summary>
        /// Metadata for recognition
        /// </summary>
        public sealed class RecognitionMetadata
        {
            /// <summary>
            /// Task definition. Required.
            /// </summary>
            /// <example>
            /// oocl_rotate_new
            /// </example>
            [Required]
            [JsonProperty("Task")]
            public string Task { get; set; }

            /// <summary>
            /// Additional task argument definition. Optional.
            /// </summary>
            /// <example>
            /// 546
            /// </example>
            [JsonProperty("TaskArgument")]
            public string TaskArgument { get; set; }

            /// <summary>
            /// recognition: payload kind (e.g. "Audio").
            /// </summary>
            /// <remarks>Required for: bills_audio (see docs)</remarks>
            [JsonProperty("PayloadType", NullValueHandling = NullValueHandling.Ignore)]
            public string PayloadType { get; set; }
        }

        /// <summary>
        /// Metadata for recognition
        /// </summary>
        [JsonProperty("metadata")]
        [Required]
        public RecognitionMetadata Metadata { get; set; }

        /// <summary>
        /// Optional links to example images.
        /// </summary>
        [JsonProperty("exampleImageUrls", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> ExampleImageUrls { get; set; }

        /// <summary>
        /// Optional base64 example images.
        /// </summary>
        [JsonProperty("exampleImagesBase64", NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string> ExampleImagesBase64 { get; set; }
    }
}
