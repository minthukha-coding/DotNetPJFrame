using DotNetPJFrame.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Authenication;

public class UserSessionModel
{
    public string MobileNo { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string Role { get; set; }
    public string UserId { get; set; }
    public string SessionId { get; set; }
    public int? PositionId { get; set; }
    public string? PositionCode { get; set; }
    public string CustomerId { get; set; }
    public EnumUserType UserType { get; set; }
    public string TransactionPassword { get; set; }
    public string ForcePasswordFlag { get; set; }
    public bool IsResetPassword { get; set; }
    public string PasswordExpDate { get; set; }
    public string? MenuListKey { get; set; }
    public static string GenerateKey()
    {
        return Guid.NewGuid().ToString("N");
    }
}
