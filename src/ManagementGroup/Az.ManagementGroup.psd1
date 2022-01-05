@{
  GUID = '98ccd675-94b5-4014-a12e-6af11a342cfe'
  RootModule = './Az.ManagementGroup.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: ManagementGroup cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.ManagementGroup.private.dll'
  FormatsToProcess = './Az.ManagementGroup.format.ps1xml'
  FunctionsToExport = 'Get-AzManagementGroup', 'Get-AzManagementGroupDescendant', 'Get-AzManagementGroupEntity', 'Get-AzManagementGroupHierarchySetting', 'Get-AzManagementGroupSubscription', 'Get-AzManagementGroupSubscriptionUnderManagementGroup', 'Invoke-AzManagementGroupTenantBackfillStatus', 'New-AzManagementGroup', 'New-AzManagementGroupHierarchySetting', 'New-AzManagementGroupSubscription', 'Remove-AzManagementGroup', 'Remove-AzManagementGroupHierarchySetting', 'Remove-AzManagementGroupSubscription', 'Set-AzManagementGroup', 'Set-AzManagementGroupHierarchySetting', 'Start-AzManagementGroupTenantBackfill', 'Test-AzManagementGroupNameAvailability', 'Update-AzManagementGroup', 'Update-AzManagementGroupHierarchySetting', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'ManagementGroup'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
