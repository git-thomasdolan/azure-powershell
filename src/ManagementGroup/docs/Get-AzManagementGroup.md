---
external help file:
Module Name: Az.ManagementGroup
online version: https://docs.microsoft.com/powershell/module/az.managementgroup/get-azmanagementgroup
schema: 2.0.0
---

# Get-AzManagementGroup

## SYNOPSIS
Get the details of the management group.\n

## SYNTAX

### List (Default)
```
Get-AzManagementGroup [-Skiptoken <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzManagementGroup -GroupId <String> [-Expand <String>] [-Filter <String>] [-Recurse]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzManagementGroup -InputObject <IManagementGroupIdentity> [-Expand <String>] [-Filter <String>] [-Recurse]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get the details of the management group.\n

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

### -Expand
The $expand=children query string parameter allows clients to request inclusion of children in the response payload.
$expand=path includes the path from the root group to the current group.
$expand=ancestors includes the ancestor Ids of the current group.

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
A filter which allows the exclusion of subscriptions from results (i.e.
'$filter=children.childType ne Subscription')

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentity
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
Parameter Sets: Get
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Recurse
The $recurse=true query string parameter allows clients to request inclusion of entire hierarchy in the response payload.
Note that $expand=children must be passed up if $recurse is set to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skiptoken
Page continuation token is only used if a previous operation returned a partial result.

If a previous response contains a nextLink element, the value of the nextLink element will include a token parameter that specifies a starting point to use for subsequent calls.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.IManagementGroupIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.Api20210401.IManagementGroup

### Microsoft.Azure.PowerShell.Cmdlets.ManagementGroup.Models.Api20210401.IManagementGroupInfo

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IManagementGroupIdentity>: Identity Parameter
  - `[GroupId <String>]`: Management Group ID.
  - `[Id <String>]`: Resource identity path
  - `[SubscriptionId <String>]`: Subscription ID.

## RELATED LINKS

