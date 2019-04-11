﻿using System.Runtime.Serialization;

namespace Microsoft.PowerBI.Common.Api.Gateways.Entities
{
    [DataContract]
    public sealed class InstallerPrincipal
    {
        [DataMember(Name = "id")]
        public string PrincipalObjectId { get; set; }

        [DataMember(Name = "type")]
        public string GatewayType { get; set; }
    }
}
