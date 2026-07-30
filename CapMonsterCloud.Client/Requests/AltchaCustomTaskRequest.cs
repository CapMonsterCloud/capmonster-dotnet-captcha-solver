using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Altcha CustomTask recognition request.
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/altcha-task
    /// </example>
    public sealed class AltchaCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "Altcha";

        /// <summary>
        /// For this task, sending an empty string is allowed.
        /// </summary>
        [JsonProperty("websiteKey", Required = Required.Always)]
        [StringLength(int.MaxValue, MinimumLength = 0)]
        public string WebsiteKey { get; set; }

        /// <summary>
        /// Initializes Altcha task with required metadata.
        /// </summary>
        /// 
        /// <param name="challenge">
        /// <example>"3dd28253be6cc0c54d95f7f98c517e68744597cc6e66109619d1ac975c39181c"</example>
        /// Unique task identifier obtained from the website.
        /// </param>
        /// 
        /// <param name="iterations">
        /// <example>"5000"</example>
        /// Number of iterations or the maximum number for calculations.
        /// Important: the iterations parameter corresponds to the maxnumber value!
        /// </param>
        /// 
        /// <param name="salt">
        /// <example>"46d5b1c8871e5152d902ee3f?edk=1493462145de1ce33a52fb569b27a364&amp;codeChallenge=464Cjs7PbiJJhJZ_ReJ-y9UGGDndcpsnP6vS8x1nEJyTkhjQkJyL2jcnYEuMKcrG&amp;expires=1761048664"</example>
        /// Salt obtained from the site, used for hash generation.
        /// Important: Always send the full value of the salt field! If the site returns something like this:
        /// "salt": "46d5b1c8871e5152d902ee3f?edk=1493462145de1ce33a52fb569b27a364&amp;codeChallenge=464Cjs7PbiJJhJZ_ReJ-y9UGGDndcpsnP6vS8x1nEJyTkhjQkJyL2jcnYEuMKcrG&amp;expires=1761048664"
        /// Then copy and include it in your request exactly as it is, with all characters and parameters (edk, codeChallenge, etc.).
        /// </param>
        /// 
        /// <param name="signature">
        /// <example>"4b1cf0e0be0f4e5247e50b0f9a449830f1fbca44c32ff94bc080146815f31a18"</example>
        /// Digital signature of the request.
        /// </param>
        public AltchaCustomTaskRequest(string challenge, string iterations, string salt, string signature) => Metadata = new { challenge, iterations, salt, signature };
    }
}
