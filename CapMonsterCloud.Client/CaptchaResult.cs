using Zennolab.CapMonsterCloud.Responses;

namespace Zennolab.CapMonsterCloud
{
    /// <summary>
    /// General captcha recognition result
    /// </summary>
    /// <typeparam name="TSolution">Concrete captcha result type</typeparam>
    public class CaptchaResult<TSolution> where TSolution : CaptchaResponseBase
    {
        /// <summary>
        /// Error code
        /// </summary>
        public ErrorType? Error { get; internal set; }

        /// <summary>
        /// Task result. Different for each type of task.
        /// </summary>
        public TSolution Solution { get; internal set; }

        /// <summary>
        /// Solution cost in US dollars (USD). Set only when the task was solved successfully, otherwise null.
        /// </summary>
        public double? Cost { get; internal set; }
    }
}
