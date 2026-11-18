using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// FengkongCloud CustomTask recognition request
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/fengkongcloud-task/
    /// </example>
    public sealed class FengkongCloudCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "fengkongcloud";

        /// <summary>
        /// The value of the siteKey parameter found on the page.
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// Initializes FengkongCloud task with optional metadata.
        /// </summary>
        ///
        /// <param name="apiJsUrl">
        /// Link to smcp.min.js. For example https://example.com/path/to/smcp.min.js
        /// </param>
        public FengkongCloudCustomTaskRequest(string apiJsUrl = null) => Metadata = new { apiJsUrl };
    }
}
