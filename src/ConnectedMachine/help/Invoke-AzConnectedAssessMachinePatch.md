---
external help file:
Module Name: Az.ConnectedMachine
online version: https://learn.microsoft.com/powershell/module/az.connectedmachine/invoke-azconnectedassessmachinepatch
schema: 2.0.0
---

# Invoke-AzConnectedAssessMachinePatch

## SYNOPSIS
The operation to assess patches on a hybrid machine identity in Azure.

## SYNTAX

### Assess (Default)
```
Invoke-AzConnectedAssessMachinePatch -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssessViaIdentity
```
Invoke-AzConnectedAssessMachinePatch -InputObject <IConnectedMachineIdentity> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The operation to assess patches on a hybrid machine identity in Azure.

## EXAMPLES

### Example 1: Invoke assess patches
```powershell
Invoke-AzConnectedAssessMachinePatch -Name testMachine -ResourceGroupName az-sdk-test
```

```output
AssessmentActivityId                 LastModifiedDateTime OSType  PatchServiceUsed RebootPending StartDateTime       StartedBy  Status
--------------------                 -------------------- ------  ---------------- ------------- -------------       ---------  ------
3e456d9e-9789-4427-b631-84c587afeade 8/2/2023 7:59:25 AM  Windows WU               False         7/28/2023 7:56:18 AM User      Succeed
```

Invoke machine patches.

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

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity
Parameter Sets: AssessViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the hybrid machine.

```yaml
Type: System.String
Parameter Sets: Assess
Aliases:

Required: True
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

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: Assess
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: Assess
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
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

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.IMachineAssessPatchesResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IConnectedMachineIdentity>`: Identity Parameter
  - `[ExtensionName <String>]`: The name of the machine extension.
  - `[ExtensionType <String>]`: The extensionType of the Extension being received.
  - `[GroupName <String>]`: The name of the private link resource.
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: The location of the Extension being received.
  - `[MachineName <String>]`: The name of the hybrid machine.
  - `[Name <String>]`: The name of the hybrid machine.
  - `[PrivateEndpointConnectionName <String>]`: The name of the private endpoint connection.
  - `[PrivateLinkScopeId <String>]`: The id (Guid) of the Azure Arc PrivateLinkScope resource.
  - `[Publisher <String>]`: The publisher of the Extension being received.
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[ScopeName <String>]`: The name of the Azure Arc PrivateLinkScope resource.
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[Version <String>]`: The version of the Extension being received.

## RELATED LINKS

