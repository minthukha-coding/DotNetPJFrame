using DotNetPJFrame.Models.Authenication;
using DotNetPJFrame.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Common
{
    public class ApiBaseRequestModel
    {
        public EnumUserType UserType { get; set; }
        public string? UserId { get; set; } = "";
        public string? SessionId { get; set; } = "";
    }

    public class ApiRequestModel : ApiBaseRequestModel
    {
        public string ReqService { get; set; }
        public object? ReqData { get; set; }
        public string? IV { get; set; } = "";
        public string? DeviceId { get; set; } = "";
        public string? DeviceOS { get; set; } = "";
        public string? DeviceModel { get; set; } = "";
        public string Version { get; set; } = "";
        public string FirebaseToken { get; set; } = "";
        public string UserTypeDesp => UserType.ToString();
        public void SetSession(UserSessionModel userSessionModel)
        {
            UserId = userSessionModel.UserId;
            SessionId = userSessionModel.SessionId;
        }
    }
}
