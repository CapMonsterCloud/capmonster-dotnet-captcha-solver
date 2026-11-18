namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Proton Captcha CustomTask recognition request. A proxy is required.
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/proton-task/
    /// </example>
    public sealed class ProtonCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "proton";

        /// <inheritdoc/>
        internal override bool IsProxyRequired => true;

        /// <summary>
        /// Initializes Proton Captcha task with required metadata.
        /// </summary>
        ///
        /// <param name="humanVerificationToken">
        /// Token from the response (HumanVerificationToken).
        /// </param>
        /// <param name="pageAction">
        /// Action on the site: login or signup.
        /// </param>
        public ProtonCustomTaskRequest(string humanVerificationToken, string pageAction) =>
            Metadata = new { HumanVerificationToken = humanVerificationToken, pageAction };
    }
}
