﻿using Newtonsoft.Json;

namespace BindERP.Connector.Modules.Webhooks.Models;

public record SubscriptionCreationModel
{
    [JsonProperty("event")]
    public string? EventName
    {
        get;
        set;
    }

    [JsonProperty("target_url")]
    public string? TargetUrl
    {
        get;
        set;
    }
}
