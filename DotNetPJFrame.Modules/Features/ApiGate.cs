using DotNetPJFrame.Models.Enum;
using DotNetPJFrame.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Modules.Features;

public class ApiGate
{
    private readonly Api _api;

    public ApiGate(Api api)
    {
        _api = api;
    }

    public async Task<object>Service(string serviceName,string raw)
    {
        object result = null;
        var name = serviceName.ToEnum<EnumApi>();
        result = name switch
        {
            EnumApi.TEST => _api.Test()
        };
        return result;
    }
}
