<!-- region Generated -->
# Az.ManagementGroup
This directory contains the PowerShell module for the ManagementGroup service.

---
## Status
[![Az.ManagementGroup](https://img.shields.io/powershellgallery/v/Az.ManagementGroup.svg?style=flat-square&label=Az.ManagementGroup "Az.ManagementGroup")](https://www.powershellgallery.com/packages/Az.ManagementGroup/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.2.3 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.ManagementGroup`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
# lock the commit
input-file:
# You need to specify your swagger files here.
  - https://github.com/git-thomasdolan/azure-rest-api-specs/tree/main/specification/managementgroups/resource-manager/Microsoft.Management/stable/2021-04-01/management.json
# If the swagger has not been put in the repo, you may uncomment the following line and refer to it locally

# For new RP, the version is 0.1.0
module-version: 0.1.0
# Normally, title is the service name
title: ManagementGroup
subject-prefix: $(service-name)

# If there are post APIs for some kinds of actions in the RP, you may need to 
# uncomment following line to support viaIdentity for these post APIs
# identity-correction-for-post: true

inlining-threshold: 50

directive:
  # Remove the unexpanded parameter set
  - where:
      variant: ^Create$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
    remove: true

  - where:
      model-name: ManagementGroupInfo
    set:
      format-table:
        properties:
          - Name
          - TenantId
          - DisplayName
          - "Id"
          - "Type"

  - where:
      model-name: ManagementGroup
    set:
      format-table:
        properties:
          - Id
          - Type
          - Name
          - TenantId
          - DisplayName
          - ParentId
          - ParentName
          - ParentDisplayName

```
