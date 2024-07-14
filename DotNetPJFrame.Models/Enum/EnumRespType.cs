using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Enum;

public enum EnumRespType
{
    [Description("Success")] MS,
    [Description("Information")] MI,
    [Description("Warning")] MW,
    [Description("Error")] ME,
    [Description("System Error")] SE,
    [Description("No Data")] ND
}