namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// DataDome CustomTask recognition request
    /// </summary>
    public sealed class DataDomeCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "DataDome";

        /// <summary>
        ///
        /// These values will be set to Metadata property.
        /// 
        /// - datadomeCookie: "datadomeCookie": "datadome=6BvxqELMoorFNoo7GT1...JyfP_mhz"
        /// Field is required. Your cookies from datadome. You can get it on the page using "document.cookie" or in the Set-Cookie request header: "datadome=..."
        /// 
        /// - captchaUrl: "captchaUrl": "..."
        /// Field is required. You can take the link from the page with the captcha.
        /// Often it looks like https://geo.captcha-delivery.com/captcha/?initialCid=...
        /// 
        /// - datadomeVersion: "datadomeVersion": "new"
        /// DataDome solving method version. If set to "new", the updated solving method is used with support for both i.js and c.js scripts (see details below).
        /// If the parameter is not specified, the legacy solving method is applied, which supports only i.js.
        /// 
        /// </summary>
        public DataDomeCustomTaskRequest(string datadomeCookie, string captchaUrl, string datadomeVersion = null)
            => Metadata = new { datadomeCookie, captchaUrl, datadomeVersion };
    }
}
