namespace Zennolab.CapMonsterCloud.Requests
{
    /// <summary>
    /// Imperva CustomTask recognition request
    /// </summary>
    public class ImpervaCustomTaskRequest : CustomTaskRequestBase
    {        
        /// <inheritdoc/>
        public override string Class => "Imperva";

        /// <summary>
        ///
        /// These values will be set to Metadata property.
        ///
        /// - incapsulaScriptUrl: "incapsulaScriptUrl": "_Incapsula_Resource?SWJIYLWA=719d34d31c8e3a6e6fffd425f7e032f3"
        /// Name of the Incapsula JS file
        /// 
        /// - incapsulaCookies: "incapsulaCookies": "incap_ses_1166_2930313=br7iX33ZNCtf3HlpEXcuEDzz72cAAAAA0suDnBGrq/iA0J4oERYzjQ==; visid_incap_2930313=P3hgPVm9S8Oond1L0sXhZqfK72cAAAAAQUIPAAAAAABoMSY9xZ34RvRseJRiY6s+;"
        /// Your cookies from Incapsula. You can obtain them on the page using "document.cookie" or in the request header Set-Cookie
        /// 
        /// - reese84UrlEndpoint: "reese84UrlEndpoint": "Built-with-the-For-hopence-Hurleysurfecting-the-"
        /// The name of the endpoint where the reese84 fingerprint is sent can be found among the requests and ends with ?d=site.com
        /// 
        /// </summary>
        public ImpervaCustomTaskRequest(string incapsulaScriptUrl, string incapsulaCookies, string reese84UrlEndpoint) => Metadata = new { incapsulaScriptUrl, incapsulaCookies, reese84UrlEndpoint };
    }
}
