using DotNetPJFrame.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Common;

public class ApiResponseModel
{
    public ResponseModel? Response { get; set; }
    public string ReqService { get; set; }
    public DateTime ReqDate { get; set; }
    public DateTime RespDate { get; set; }
    public EnumUserType UserType { get; set; }
    public string ProcessTime { get; set; }
    public string? IV { get; set; }
    public object RespData { get; set; }
    public string Token { get; set; }
}