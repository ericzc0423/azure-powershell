---
external help file:
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/new-azapplicationgatewaywafpolicy
schema: 2.0.0
---

# New-AzApplicationGatewayWafPolicy

## SYNOPSIS
Creates or update policy with specified rule set name within a resource group.

## SYNTAX

### Create (Default)
```
New-AzApplicationGatewayWafPolicy -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-WafPolicy <IWebApplicationFirewallPolicy>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded
```
New-AzApplicationGatewayWafPolicy -Name <String> -ResourceGroupName <String> -SubscriptionId <String>
 [-CustomRule <IWebApplicationFirewallCustomRule[]>] [-EnabledState <WebApplicationFirewallEnabledState>]
 [-Etag <String>] [-Id <String>] [-Location <String>] [-Mode <WebApplicationFirewallMode>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzApplicationGatewayWafPolicy -InputObject <INetworkIdentity>
 [-CustomRule <IWebApplicationFirewallCustomRule[]>] [-EnabledState <WebApplicationFirewallEnabledState>]
 [-Etag <String>] [-Id <String>] [-Location <String>] [-Mode <WebApplicationFirewallMode>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-AzApplicationGatewayWafPolicy -InputObject <INetworkIdentity> [-WafPolicy <IWebApplicationFirewallPolicy>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Creates or update policy with specified rule set name within a resource group.

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

### -CustomRule
Describes custom rules inside the policy
To construct, see NOTES section for CUSTOMRULE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IWebApplicationFirewallCustomRule[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -EnabledState
Describes if the policy is in enabled state or disabled state

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.WebApplicationFirewallEnabledState
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Etag
Gets a unique read-only string that changes whenever the resource is updated.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Resource ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Mode
Describes if it is in detection mode or prevention mode at policy level

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Support.WebApplicationFirewallMode
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the policy.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases: PolicyName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WafPolicy
Defines web application firewall policy.
To construct, see NOTES section for WAFPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IWebApplicationFirewallPolicy
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.INetworkIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IWebApplicationFirewallPolicy

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IWebApplicationFirewallPolicy

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### CUSTOMRULE <IWebApplicationFirewallCustomRule[]>: Describes custom rules inside the policy
  - `Action <WebApplicationFirewallAction>`: Type of Actions
  - `MatchCondition <IMatchCondition[]>`: List of match conditions
    - `MatchValue <String[]>`: Match value
    - `MatchVariable <IMatchVariable[]>`: List of match variables
      - `VariableName <WebApplicationFirewallMatchVariable>`: Match Variable
      - `[Selector <String>]`: Describes field of the matchVariable collection
    - `Operator <WebApplicationFirewallOperator>`: Describes operator to be matched
    - `[NegationConditon <Boolean?>]`: Describes if this is negate condition or not
    - `[Transform <WebApplicationFirewallTransform[]>]`: List of transforms
  - `Priority <Int32>`: Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value
  - `RuleType <WebApplicationFirewallRuleType>`: Describes type of rule
  - `[Name <String>]`: Gets name of the resource that is unique within a policy. This name can be used to access the resource.

#### WAFPOLICY <IWebApplicationFirewallPolicy>: Defines web application firewall policy.
  - `[Id <String>]`: Resource ID.
  - `[Location <String>]`: Resource location.
  - `[Tag <IResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[CustomRule <IWebApplicationFirewallCustomRule[]>]`: Describes custom rules inside the policy
    - `Action <WebApplicationFirewallAction>`: Type of Actions
    - `MatchCondition <IMatchCondition[]>`: List of match conditions
      - `MatchValue <String[]>`: Match value
      - `MatchVariable <IMatchVariable[]>`: List of match variables
        - `VariableName <WebApplicationFirewallMatchVariable>`: Match Variable
        - `[Selector <String>]`: Describes field of the matchVariable collection
      - `Operator <WebApplicationFirewallOperator>`: Describes operator to be matched
      - `[NegationConditon <Boolean?>]`: Describes if this is negate condition or not
      - `[Transform <WebApplicationFirewallTransform[]>]`: List of transforms
    - `Priority <Int32>`: Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value
    - `RuleType <WebApplicationFirewallRuleType>`: Describes type of rule
    - `[Name <String>]`: Gets name of the resource that is unique within a policy. This name can be used to access the resource.
  - `[Etag <String>]`: Gets a unique read-only string that changes whenever the resource is updated.
  - `[PolicySettingEnabledState <WebApplicationFirewallEnabledState?>]`: Describes if the policy is in enabled state or disabled state
  - `[PolicySettingMode <WebApplicationFirewallMode?>]`: Describes if it is in detection mode  or prevention mode at policy level

## RELATED LINKS
