using Newtonsoft.Json;
using Zennolab.CapMonsterCloud.Responses;

namespace Zennolab.CapMonsterCloud
{
    public partial class CapMonsterCloudClient
    {
        private class ResponseBase
        {
#pragma warning disable IDE1006 // Naming Styles
            public int errorId { get; set; }

            public string errorCode { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }

        private class GetBalanceResponse : ResponseBase
        {
#pragma warning disable IDE1006 // Naming Styles
            public decimal balance { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }

        private class CreateTaskResponse : ResponseBase
        {
#pragma warning disable IDE1006 // Naming Styles
            public int taskId { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }

        private class GetTaskResultResponse : ResponseBase
        {
#pragma warning disable IDE1006 // Naming Styles
            public string status { get; set; }

            public object solution { get; set; }

            public double? cost { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }

        private abstract class TaskResult
        {
            public class TaskInProgress : TaskResult
            {
            }

            public class TaskFailed : TaskResult
            {
                public TaskFailed(ErrorType error)
                {
                    this.Error = error;

                }

                public ErrorType Error { get; }
            }

            public class TaskCompleted : TaskResult
            {
                public TaskCompleted(object solution, double? cost = null)
                {
                    this.Solution = solution;
                    this.Cost = cost;
                }

                public object Solution { get; }

                public double? Cost { get; }
            }

            public static TaskInProgress InProgress { get; } = new TaskInProgress();

            public static TaskFailed Failed(ErrorType error) => new TaskFailed(error);

            public static TaskCompleted Completed(object solution, double? cost = null) => new TaskCompleted(solution, cost);
        }

        private class CreateTaskRequest<TSolution> where TSolution : CaptchaResponseBase
        {
#pragma warning disable IDE1006 // Naming Styles
            public string clientKey { get; set; }

            public Requests.CaptchaRequestBase<TSolution> task { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? softId { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        }
    }
}
