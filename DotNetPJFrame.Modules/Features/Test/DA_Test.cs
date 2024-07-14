using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Modules.Features.Test;

public class DA_Test
{
    private readonly ILogger<DA_Test> logger;

    public DA_Test(ILogger<DA_Test> logger)
    {
        this.logger = logger;
    }

    public async Task<bool> Test()
    {
        return false;
    }
}
