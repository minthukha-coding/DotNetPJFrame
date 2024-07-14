using DotNetPJFrame.Api.Features.Api;
using DotNetPJFrame.Models.Common;
using DotNetPJFrame.Models.Enum.Common;
using DotNetPJFrame.Modules.Features;
using DotNetPJFrame.Shared;
using Newtonsoft.Json.Linq;

namespace DotNetPJFrame.Api.Features.Gate;

public class MainApiGate
{
    private ILogger<MainApiGate> logger;
    private ApiGate _api;

    public MainApiGate(ILogger<MainApiGate> logger,
        ApiGate api)
    {
        this.logger = logger;
        _api = api;
    }

    public async Task<ApiResponseModel> ExecuteAsync(ApiRequestModel reqModel)
    {
        var model = new ApiResponseModel();
        try
        {
            var jObj = reqModel.ToJObject();
            var userId = jObj["UserId"]!.ToString();

            var objRequestData = reqModel.ReqData!.ToString().ToJson();

            object? result = await _api.Service(reqModel.ReqService, reqModel.ReqData.ToString()!);

            JObject jobj = result.ToJObject();
            if(jobj.ContainsKey("Response"))
            {
                var response = jobj["Response"]!.ToObject<ResponseModel>();
                model.Response = response;
            }
            return model;
        }
        catch (Exception ex)
        {
            //model.Response = ex.getres();
        }
        return model;
    }
}
