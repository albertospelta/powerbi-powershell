﻿using System.Management.Automation;
using Microsoft.PowerBI.Common.Api.Gateways.Entities;
using Microsoft.PowerBI.Common.Client;

namespace Microsoft.PowerBI.Commands.OnPremisesDataGateway
{
    [Cmdlet(CmdletVerb, CmdletName)]
    [OutputType(typeof(void))]
    public class SetOnPremisesDataGatewayTenantPolicy : PowerBIClientCmdlet
    {
        public const string CmdletName = "OnPremisesDataGatewayTenantPolicy";
        public const string CmdletVerb = VerbsCommon.Set;

        [Parameter(Mandatory = false)]
        public PolicyType ResourceGatewayInstallPolicy { get; set; }

        [Parameter(Mandatory = false)]
        public PolicyType PersonalGatewayInstallPolicy { get; set; }

        public override void ExecuteCmdlet()
        {
            using (var client = CreateClient())
            {
                var request = new UpdateGatewayPolicyRequest
                {
                    ResourceGatewayInstallPolicy = ResourceGatewayInstallPolicy,
                    PersonalGatewayInstallPolicy = PersonalGatewayInstallPolicy
                };

                var result = client.GatewaysV2.UpdateTenantPolicy(request).Result;
                Logger.WriteObject(result, true);
            }
        }
    }
}