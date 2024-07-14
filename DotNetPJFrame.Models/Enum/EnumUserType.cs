using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Models.Enum;

public enum EnumUserType
{
    Default,
    [Description("Wallet")]
    Wallet,
    [Description("Retail")]
    Retail,
    [Description("Corporate")]
    Corporate,
    [Description("Agent")]
    Agent,
    [Description("Teller")]
    Teller,
    Admin,
    System,
    Mobile,
    Merchant
}
