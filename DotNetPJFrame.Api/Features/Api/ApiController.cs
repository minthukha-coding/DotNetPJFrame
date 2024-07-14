using DotNetPJFrame.Api.Features.Gate;
using DotNetPJFrame.Models.Enum.Common;
using DotNetPJFrame.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPJFrame.Api.Features.Api;

[Route("api")]
[ApiController]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> logger;
    private readonly MainApiGate _mainApiGate;

    public ApiController(ILogger<ApiController> logger,
        MainApiGate mainApiGate)
    {
        this.logger = logger;
        _mainApiGate = mainApiGate;
    }

    [HttpPost]
    [Route("Service")]
    public async Task<IActionResult> Service([FromBody] ApiRequestModel reqModel)
    {
        var model = await _mainApiGate.ExecuteAsync(reqModel);
        return Content(model.ToJson() ?? throw new InvalidOperationException(), "application/json");
    }
}