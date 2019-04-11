﻿using System.Runtime.Serialization;

namespace Microsoft.PowerBI.Common.Api.Gateways.Entities
{
    [DataContract]
    public enum GatewayType
    {
        [EnumMember] Resource,
        [EnumMember] Personal,
    }
}
