﻿namespace MCB.Core.Domain.Abstractions.Services.Inputs;

public abstract record ServiceInputBase
{
    // Properties
    public Guid TenantId { get; }
    public string ExecutionUser { get; }
    public string SourcePlatform { get; }

    // Constructors
    protected ServiceInputBase(Guid tenantId, string executionUser, string sourcePlatform)
    {
        TenantId = tenantId;
        ExecutionUser = executionUser;
        SourcePlatform = sourcePlatform;
    }
}