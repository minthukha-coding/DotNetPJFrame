using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Modules.Features.Test;

public class BL_Test
{
    private readonly ILogger<BL_Test> logger;
    private readonly DA_Test _daTest;

    public BL_Test(ILogger<BL_Test> logger, 
        DA_Test daTest)
    {
        this.logger = logger;
        _daTest = daTest;
    }

    public async Task<bool> Test()
    {
        return false;
    }
}
