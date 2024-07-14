using DotNetPJFrame.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Common;

public class BaseSubResponseModel
{
    public ResponseModel Response { get; set; } = new ResponseModel();
    public string RefID { get; set; }
    public int TotalRowCount { get; set; }
    //public EnumUserType UserType { get; set; }
}

public class ResponseModel
{
    public string RespCaseId { get; set; }
    public string RespCode { get; set; }
    public string RespDesp { get; set; }
    public int? UpdateCount { get; set; }
    public EnumRespType RespType { get; set; }
    public bool IsSuccess => RespType == EnumRespType.MS;
    public bool IsError => !IsSuccess;
    public object[]? RespDespParameter { get; set; } = new string[] { };
}
