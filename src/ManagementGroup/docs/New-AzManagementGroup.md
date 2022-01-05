---
external help file:
Module Name: Az.ManagementGroup
online version: https://docs.microsoft.com/powershell/module/az.managementgroup/new-azmanagementgroup
schema: 2.0.0
---

# New-AzManagementGroup

## SYNOPSIS
Create or update a management group.\nIf a management group is already created and a subsequent create request is issued with different properties, the management group properties will be updated.\n

## SYNTAX

### CreateExpanded (Default)
```
New-AzManagementGroup -GroupId <String> [-DisplayName <String>] [-Name <String>] [-ParentId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzManagementGroup -InputObject <IManagementGroupIdentity>
 -CreateManagementGroupRequest <ICreateManagementGroupRequest> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create or update a management group.\nIf a management group is already created and a subsequent create request is issued with different properties, the management group properties will be updated.\n

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreateManagementGroupRequest
Management group creation parameters.
To construct, see NOTES section for CREATEMANAGEMENTGROUPREQUEST properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.Api20210401.ICreateManagementGroupRequest
Parameter Sets: CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The friendly name of the management group.
If no value is passed then this field will be set to the groupId.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
Management Group ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.IManagementGroupIdentity
Parameter Sets: CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the management group.
For example, 00000000-0000-0000-0000-000000000000

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentId
The fully qualified ID for the parent management group.
For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.Api20210401.ICreateManagementGroupRequest

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.IManagementGroupIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.Api20210401.IManagementGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


CREATEMANAGEMENTGROUPREQUEST <ICreateManagementGroupRequest>: Management group creation parameters.
  - `[DisplayName <String>]`: The friendly name of the management group. If no value is passed then this  field will be set to the groupId.
  - `[Name <String>]`: The name of the management group. For example, 00000000-0000-0000-0000-000000000000
  - `[ParentId <String>]`: The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000

INPUTOBJECT <IManagementGroupIdentity>: Identity Parameter
  - `[GroupId <String>]`: Management Group ID.
  - `[Id <String>]`: Resource identity path
  - `[SubscriptionId <String>]`: Subscription ID.

## RELATED LINKS

