﻿using Bit.Core.Enums;
using Bit.Core.Settings;
using Duende.IdentityServer.Models;

namespace Bit.Identity.IdentityServer;

public class StaticClientStore
{
    public StaticClientStore(GlobalSettings globalSettings)
    {
        ApiClients = new List<Client>
        {
            new ApiClient(globalSettings, BitwardenClient.Mobile, 60, 1),
            new ApiClient(globalSettings, BitwardenClient.Web, 7, 1),
            new ApiClient(globalSettings, BitwardenClient.Browser, 30, 1),
            new ApiClient(globalSettings, BitwardenClient.Desktop, 30, 1),
            new ApiClient(globalSettings, BitwardenClient.Cli, 30, 1),
            new ApiClient(globalSettings, BitwardenClient.DirectoryConnector, 30, 24)
        }.ToDictionary(c => c.ClientId);
    }

    public IDictionary<string, Client> ApiClients { get; private set; }
}
