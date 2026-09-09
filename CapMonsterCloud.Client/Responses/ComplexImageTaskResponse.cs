using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zennolab.CapMonsterCloud.Responses
{
    /// <summary>
    /// Response for grid-like tasks
    /// </summary>
    public class GridComplexImageTaskResponse : CaptchaResponseBase
    {
        /// <summary>
        /// Collection with answers. Click on images with 'true'
        /// </summary>
        /// <example>
        /// [false,true,false,true,false,false,true,false,false]
        /// </example>
        [JsonProperty("answer")]
        public ICollection<bool> Answer { get; set; }

        /// <summary>
        /// Metadata with the answer type, when returned
        /// </summary>
        [JsonProperty("metadata")]
        public DynamicComplexImageTaskResponse.RecognitionMetadata Metadata { get; set; }
    }
}
