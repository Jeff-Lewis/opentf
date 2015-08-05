A quick overview of the areas where the tf4mono TF client may be more useful and where it is currently less useful than the standard MS TF client.

# Shortcomings #
  1. Help documentation not as extensive.
  1. Not as many GUI popup dialogs.
  1. No current support for branch merges.
  1. No current support for graphical conflict resolution.
  1. Missing **branch**, **merge**, **resolve**, **unshelve**, and **[undelete](http://msdn2.microsoft.com/en-us/library/y7505w2x(VS.80).aspx)** commands.
  1. Implemented commands may not support all options available in standard TF client.

# Improvements #

## General ##
  1. Get Latest on Checkout option (will be in Orcas release of TF)
  1. "Preserve file modification times" option
  1. Multiple commands can be chained together in a single TF execution separated by the "%" character. For example, **tf online % checkin /comment:"applied patch 501"**. Commands can feed their output to the next command in the chain with %%, for example **tf ls-files /others %% add** to add all unknown files.
  1. Builtin general help and per-command help, accessible via **tf help**

&lt;cmd&gt;

**1. Supports file attributes on unix.
  1. Command argument ordering much more forgiving than standard client.
  1.**tf undo**with no args will undo all pending changes
  1.**tf explore**command for built in viewer GUI supporting multiple repository views, syntax highlighting, etc. (on unix platforms only in 0.5.2)
  1. Can display local workspace cache configuration with**tf show cache**(often very helpful when debugging TFS issues)**

## Diffs ##
  1. Unified diffs are actually appliable with gnu patch.
  1. Does tree wide diffs
  1. Can show what files you've changed locally but haven't checked out with **tf diff /modified**.
  1. Can show what files are out of date with latest server version with **tf diff /old**.
  1. Can show pending changes as a diff with **tf diff**.
  1. /ignorespace option for ignoring whitespace changes.

## Configuration ##
  1. **Supports read-write working folders**.
  1. Supports credential caching via XML files or the Gnome Keyring.

Numerous persisted configuration options are offered. Here's my config:
```
(/usr/local/src/opentf) tf config
Client Configuration:
  Checkin.Validate:	true
  Checkout.Latest:	true
  Credentials.Save:	true
  File.Excludes:	*.dll,*.pdb,core,.git/
  File.ReadWrite:	true
  Get.Recursive:	true
  History.DefaultToCwd:	true
  History.Detailed:	true
  History.Recursive:	true
  History.StopAfter:	10
  Online.Recursive:	true
  Server.Default:	10.100.1.88
```

## Powertool Commands ##
  1. Integrated tfpt **rollback** command.
  1. Integrated tfpt **treeclean** command.
  1. Integrated tfpt **online** command. Online command supports _/added, /modified, and /deleted_ options. Standard client only supports "/deleted". Also supports passing a list of files to speed up operation (rather than scanning the entire working folder). Useful in scenarios when you've applied a patch. Than do tf online `lsdiff <name of patch>`;

## Show Command ##

The **show** command can be used to explore many behind the scenes aspects of TFS.
A few example are shown below.

```
> tf help show

Show information about build configuration, cache settings, identity 
info, usage statistics, or registered tools.

Usage: show [ build | cache | ident | stats | tools ]

Options:
  /login:ARG        	Login name (also /Y:ARG)
  /server:ARG       	Server name. (also /S:ARG)
  /workspace:ARG    	Workspace name (also /W:ARG)

> tf show stats

Files:           3279591
Folders:         214276
Groups:          4822
Pending Changes: 182284
Shelvesets:      116
Users:           185
Workspaces:      119

>tf show tools

VersionControl
-----------------------------------------------------------------------------------------

ArtifactTypes: 

  Changeset
  Label
  LatestItemVersion
  VersionedItem

Databases: 

  TeamFoundation Logging DB: TfsActivityLogging on tfs-db01
  VersionControl DB: TfsVersionControl on tfs-db01

ServiceInterfaces: 

  Download: /VersionControl/v1.0/item.asmx
  IBISEnablement: /VersionControl/v1.0/integration.asmx
  IProjectMaintenance: /VersionControl/v1.0/integration.asmx
  ISCCAdmin: /VersionControl/v1.0/administration.asmx
  ISCCProvider: /VersionControl/v1.0/repository.asmx
  LinkingProviderService: /VersionControl/v1.0/integration.asmx
  Upload: /VersionControl/v1.0/upload.asmx
```

_tf show tools output truncated!_

## History Command ##

The history command supports the standard brief and detailed formats, as well as a "byowner" format that summarizes the changeset history by owner. For example,
```
(/usr/local/src/opentf) tf history "$/" /format:byowner /stopafter:300 
This could take some time... processing up to 300 changesets

STISTER: 67
STHAOO: 46
RHORET  : 42
RZEALTH: 24
JSELKO: 24
LMAHA   : 22
GVAMA: 20
JREED   : 17
JCOY  : 17
AWIMON  : 8
tatcuk : 8
XSTEWO: 5

Time Span: 10/2/2007 to 10/10/2007
Total   : 300
```


## File Listing ##

The **ls-files** command shows known, deleted, modified, old, or unknown files under the given path via the options _/deleted, /modified, /old, /unknown_ .