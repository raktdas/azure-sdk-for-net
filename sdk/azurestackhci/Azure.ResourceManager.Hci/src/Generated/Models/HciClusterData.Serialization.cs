// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CloudManagementEndpoint))
            {
                writer.WritePropertyName("cloudManagementEndpoint"u8);
                writer.WriteStringValue(CloudManagementEndpoint);
            }
            if (Optional.IsDefined(AadClientId))
            {
                writer.WritePropertyName("aadClientId"u8);
                writer.WriteStringValue(AadClientId.Value);
            }
            if (Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId.Value);
            }
            if (Optional.IsDefined(AadApplicationObjectId))
            {
                writer.WritePropertyName("aadApplicationObjectId"u8);
                writer.WriteStringValue(AadApplicationObjectId.Value);
            }
            if (Optional.IsDefined(AadServicePrincipalObjectId))
            {
                writer.WritePropertyName("aadServicePrincipalObjectId"u8);
                writer.WriteStringValue(AadServicePrincipalObjectId.Value);
            }
            if (Optional.IsDefined(DesiredProperties))
            {
                writer.WritePropertyName("desiredProperties"u8);
                writer.WriteObjectValue(DesiredProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HciClusterData DeserializeHciClusterData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<HciClusterStatus> status = default;
            Optional<Guid> cloudId = default;
            Optional<string> cloudManagementEndpoint = default;
            Optional<Guid> aadClientId = default;
            Optional<Guid> aadTenantId = default;
            Optional<Guid> aadApplicationObjectId = default;
            Optional<Guid> aadServicePrincipalObjectId = default;
            Optional<HciClusterDesiredProperties> desiredProperties = default;
            Optional<HciClusterReportedProperties> reportedProperties = default;
            Optional<float> trialDaysRemaining = default;
            Optional<string> billingModel = default;
            Optional<DateTimeOffset> registrationTimestamp = default;
            Optional<DateTimeOffset> lastSyncTimestamp = default;
            Optional<DateTimeOffset> lastBillingTimestamp = default;
            Optional<string> serviceEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new HciClusterStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cloudId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cloudId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("cloudManagementEndpoint"u8))
                        {
                            cloudManagementEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadClientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aadClientId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aadTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadApplicationObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aadApplicationObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("aadServicePrincipalObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aadServicePrincipalObjectId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("desiredProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            desiredProperties = HciClusterDesiredProperties.DeserializeHciClusterDesiredProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reportedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reportedProperties = HciClusterReportedProperties.DeserializeHciClusterReportedProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trialDaysRemaining"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trialDaysRemaining = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("billingModel"u8))
                        {
                            billingModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            registrationTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSyncTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastBillingTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastBillingTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceEndpoint"u8))
                        {
                            serviceEndpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HciClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), Optional.ToNullable(cloudId), cloudManagementEndpoint.Value, Optional.ToNullable(aadClientId), Optional.ToNullable(aadTenantId), Optional.ToNullable(aadApplicationObjectId), Optional.ToNullable(aadServicePrincipalObjectId), desiredProperties.Value, reportedProperties.Value, Optional.ToNullable(trialDaysRemaining), billingModel.Value, Optional.ToNullable(registrationTimestamp), Optional.ToNullable(lastSyncTimestamp), Optional.ToNullable(lastBillingTimestamp), serviceEndpoint.Value);
        }
    }
}
