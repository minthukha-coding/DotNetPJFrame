using DotNetPJFrame.Modules.Features.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Modules.Features;

public class Api
{
    private readonly BL_Test _blTest;

    public Api(BL_Test blTest)
    {
        _blTest = blTest;
    }

    public async Task<bool> Test()
    {
        return await _blTest.Test();
    }
}
