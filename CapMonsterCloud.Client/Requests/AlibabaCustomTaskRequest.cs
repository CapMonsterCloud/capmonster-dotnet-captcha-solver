namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Alibaba CustomTask recognition request.
    /// </summary>
    /// <example>
    /// https://docs.capmonster.cloud/docs/captchas/alibaba-task/
    /// </example>
    public sealed class AlibabaCustomTaskRequest : CustomTaskRequestBase
    {
        /// <inheritdoc/>
        public override string Class => "alibaba";

        /// <summary>
        ///
        /// These values will be set to Metadata property.
        ///
        /// - sceneId: "sceneId": "1ww7426c4"
        /// Field is required.
        /// CAPTCHA scenario identifier. See documentation for how to find this value
        /// 
        /// - prefix: "prefix": "dlw3kug"
        /// Field is required.
        /// CAPTCHA initialization parameter, passed in the URL of the request used to load the task text on the page.
        /// For example, if the URL looks like: https://dlw3kug.captcha-open.example.aliyuncs.com/, then the value of the prefix parameter corresponds to the subdomain — dlw3kug
        /// 
        /// 
        /// Other fields are optional and must only be specified if they are present on the target website:
        /// 
        /// - userId: "userId": "..."
        /// A unique identifier of the user or session on the website side.
        /// 
        /// - userUserId: "userUserId": "..."
        /// An additional (secondary) user identifier.
        ///  
        /// - verifyType: "verifyType": "..."
        /// The version or type of the captcha verification mechanism.
        /// 
        /// - region: "region": "..."
        /// The server or data center region through which the captcha is processed.
        /// 
        /// - UserCertifyId: "UserCertifyId": "..."
        /// A unique verification ID associated with the current captcha session.
        /// 
        /// - apiGetLib: "apiGetLib": "..."
        /// A link to the captcha JS library used by the website. The value is generated on the client side and may change dynamically on each page render.
        ///
        /// </summary>
        public AlibabaCustomTaskRequest(string sceneId,
            string prefix,
            string userId = null,
            string userUserId = null,
            string verifyType = null,
            string region = null,
            string UserCertifyId = null,
            string apiGetLib = null)
            =>
            Metadata = new
            {
                sceneId,
                prefix,
                userId,
                userUserId,
                verifyType,
                region,
                UserCertifyId,
                apiGetLib
            };
    }
}
