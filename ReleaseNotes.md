# Version 0.6 - Feb 4, 2008 #

A development release with the following changes:

## New Features ##
  1. CRUISECONTROL: add support for date range queries to the history command, e.g. version:"D2006-10-01T01:01:01Z~D2006-12-13T20:00:00Z"
  1. CRUISECONTROL: add -noprompt option
  1. CRUISECONTROL: add support for username@domain -login syntax
  1. TFSBOT: add new IRC commit notification daemon.
  1. add alpha-quality MonoDevelop addin, with debian package
  1. implement "tf shelve 

&lt;name&gt;

 

&lt;path&gt;

" to create new shelvesets
  1. implement "tf shelve /delete 

&lt;name&gt;

" for deleting shelvesets
  1. implement "tf merges 

&lt;src&gt;

 

&lt;dest&gt;

" for listing merge points
  1. implement "tf diff /ignorespace" option
  1. implement "tf rollback 

&lt;changeset&gt;

" for undoing a changeset. NOTE: only useful if no one else has changed the file since then.
  1. add Get.ChangesetMtimes setting: By enabling this option, the TF will set the modification time of any file subsequently fetched to the date of the last changeset in which the file was modified. Warning: this mode of operation can significantly slow down "tf get".
  1. add Get.DefaultToCwd setting: By enabling this option, the TF client will look for updates starting with the current working folder instead of pulling updates from all registered working folders.
  1. add Workspace.Default setting: If the TF client cannot determine the active workspace, first from the "/workspace:" option, and second the workspace cache, then it will use the Workspace.Default setting if non-null.

## Bugfixes ##
  1. BUGFIX: tf history with stopAfter > 256 shouldn't emit duplicate entries (thanks to dion.olsthoorn for the report & fix)
  1. BUGFIX: tf online 

&lt;path&gt;

 shouldn't croak if 

&lt;path&gt;

 is an add awaiting its first checkin
  1. BUGFIX: tf undo 

&lt;paths&gt;

 shouldn't undo all local changes
  1. BUGFIX: when parsing changeset and shelveset datetimes don't drop the time portion
  1. BUGFIX: insert trailing tabs after filenames (a/b) in diffs to help diffutils grok filenames with spaces
  1. BUGFIX: make sure tf ls-files 

&lt;paths&gt;

 is not passed a filename
  1. BUGFIX: set proper checkin time (by passing 0, not DateTime.Now - doh!)
  1. BUGFIX: fix tf ls-files /others breakage on windows for subdirectories
  1. BUGFIX: update local workspace cache when "tf workspaces" command called.
  1. BUGFIX: fix [issue #8](https://code.google.com/p/opentf/issues/detail?id=#8) "tf config expects ~/.tf/ to already exist"
  1. BUGFIX: teach tf that diffing binary files should print short "Binary files $1 and $2 differ" message
  1. BUGFIX: teach status command how to deal with locked files
  1. BUGFIX: teach tf branches command about server paths
  1. BUGFIX: don't clobber workspace info cache when there are >1 TFS server
  1. BUGFIX: update build for monodevelop 0.18.1 changes
  1. API: Microsoft.TeamFoundation.Common: Artifact, ArtifactId, ILinking, LinkFilter, LinkingUtilities, ServiceInterfaces
  1. API: Microsoft.TeamFoundation.VersionControl.Client: ShelvingOptions, ChangesetMerge

# Version 0.5.2 - Oct 11, 2007 #

A development release with the following changes:

## New Features ##

  1. add VS2005 project files and solution for building opentf on Windows
  1. add spec file for building RPMs on OpenSuse
  1. add "lock" command
  1. add "show stats" command to show server statistics
  1. add "show tools" command to show registered tools
  1. add "show build" command to show build configuration
  1. add "show ident" command to show server account information
  1. rename "tf cache" to "tf show cache"
  1. implement "tf changeset /latest" and test case
  1. implement "tf history /user:FOO" for filtering history queries by user
  1. implement "tf history /version:

&lt;vspec&gt;

" - but not ranges!
  1. add "tf history /format:byowner" and test case
  1. add "tf version" command to print program version number
  1. add "Server.Default" setting
  1. teach File.Excludes to support directory specifications as well as file glob patterns
  1. teach tf shelveset the "name;owner" syntax for specifying a shelveset

## Bugfixes ##

  1. BUGFIX: rework exit codes throughout for more consistency
  1. BUGFIX: tf shelveset /owner:

&lt;owner&gt;

 should filter results by owner
  1. BUGFIX: add column headers to history /format:brief output
  1. BUGFIX: tf get /force shouldn't set preview mode!
  1. BUGFIX: properly label renames in tf status output
  1. BUGFIX: make sure all files in a directory are read-write before attempting to delete a directory containing these files
  1. BUGFIX: handle QueryHistory requests with maxCount > 256

## API Enhancements ##

  1. The following classes were added (partial implementations): ICredentialsProvider, ArtifactType, ChangeType, Database, IGroupSecurityService, IRegistration, Identity, IdentityType, QueryMembership, OutboundLinkType, RegistrationEntry, SearchFactor and ServiceInterface classes

  1. Implement VersionControlServer.GetLatestChangesetId
  1. Implement TeamFoundationServer.CheckAuthentication
  1. Started work on Microsoft.TeamFoundation.WorkItemTracking.Client assembly

# Version 0.5.1 #

A development release with the following changes:

## New Features ##

  1. add **tf explore** command for visually browsing a repository, sortable changeview columns, control-c to copy a changelist entry
  1. add gtk login dialog for missing auth credentials
  1. **tf undo** with no args will undo all local changes, previously the command required at least one filename or path
  1. add usage guidance for each command, displayed via **tf help foo**
  1. report on UndonePendingChange events (which can happen if file upload fails on checkin for example)
  1. all commands now support reading arguments from stdin
  1. command chaining now supports output piping using %%. Implemented for ls-files and diff /q commands only! For example, you can say **tf ls-files /others %% add** to add all unknown files to the repository.
  1. support wildcards in checkout paths
  1. teach **tf workspaces** command to filter by workspace name if requested
  1. 8 new test cases for tf client program

## Bugfixes ##
  1. BUGFIX: **tf rename**

&lt;olddir&gt;

 

&lt;newdir&gt;

**should work now
  1. BUGFIX: teach diff /modified to check file hashes before reporting a modified file
  1. BUGFIX: when told to delete a directory, delete files within them too
  1. BUGFIX: implement CheckAuthentication call - this makes adding large numbers of files more reliable as it prevents NTML authentication timeout related failures
  1. BUGFIX: on windows, must do case insensitive path comparisons when looking for cached workspace info
  1. BUGFIX: tf online**

&lt;list-of-files&gt;

 didn't pickup deletes to pend
  1. BUGFIX: GetLocalWorkspaceInfo(string path) should trim workspaceinfo directory separators before looking for a match
  1. BUGFIX: TryGetServerItemForLocalItem and TryGetLocalItemForServerItem should find longest match
  1. BUGFIX: teach tf workfold /unmap to accept relative paths
  1. BUGFIX: always sort items in an ItemSet (sorts tf dir output for example)

# Version 0.5.0 #

A development release with the following changes:

## New Features ##
  1. Add "tf shelvesets" command (brief output only)
  1. Add support for writable working folders
  1. Implement tf help 

&lt;cmd&gt;

 with display of valid options for each command.
  1. Add "tf branches" command (limited testing)
  1. Add tf online <list of files>
  1. Add tf diff /brief option
  1. Support for tf add /recursive 

&lt;path&gt;


  1. 20 new test cases for tf client program
  1. Add "tf help /list" helper for shell completion
  1. Add progress indicator to GetCommand when setting permissions
  1. Add History.StopAfter setting option
  1. Add --disable-magic configure option for windows/cygwin users
  1. Add configure option "--with-mslibs=

&lt;dir&gt;

" to build just the TF client using the standard MS Team Foundation Assemblies

## Bugfixes ##

  1. BUGFIX: don't try to upload new directories on checkin, only files
  1. BUGFIX: Command.VerifiedFullPaths should accept directories too
  1. BUGFIX: shell wrapper tf should quote $@ so /C:"This is my comment" will work
  1. BUGFIX: uninstall man page and pkg-config file too
  1. BUGFIX: fix /format:detailed output for added files in history cmd
  1. BUGFIX: tf delete 

&lt;folder&gt;

 should actually delete the folder
  1. BUGFIX: honor excludeFiles setting in tf ls-files /writable

# Version 0.4.7 #

A maintenance release with the following updates:

## New Features ##
  1. Implement label and unlabel commands.
  1. Add "cache" command which shows workspace cache settings.
  1. Add /added, /modified, /deleted flags to Online command to show just additions, just modifications, or just deletions respectively. These flags may be combined. With no flags, all changes are incorporated.
  1. Add tf diff /modified option to show locally modified files as a unified diff. Can be used to review changes before using the online command.
  1. Add File.Excludes config option. Use in "online" command.
  1. Add Online.Recursive setting. Make default non-recursive to match standard MS client.
  1. Add tf ls-files /writable option (mainly for windows users)

## Bugfixes ##
  1. BUGFIX: Fixed multiple issues related to running tf4mono on windows. These include deleting read-only files and deleting files still open, which succeed on unix platforms, but not on windows.
  1. BUGFIX: Online command on windows. Replace server item path separator with platform path separator.
  1. BUGFIX: Replace windows path separators in diff headers with nix path separator so /usr/bin/patch is happy
  1. BUGFIX: Show deleted files in tf status as state "Deleted" not "544"
  1. BUGFIX: Compare file hashes when looking for modifications in tf online command. Previously just looked for files marked writable.

# Version 0.4.6 #

A maintenance release with the following updates:

  1. Add Checkout.Latest option to ensure checkout of latest version of file    rather than workspace version. This is a common complaint of TFS users - that the latest version is not checked out by default. An option like "Checkout.Latest" has been added to the next version of the Visual Studio TFS client.
  1. Add Get.Recursive and History.DefaultToCwd config options for those looking to override the less helpful defaults of the standard client.
  1. BUGFIX: when uploading new/changed files, send correct file length. Reported by Martin Woodward - many thanks.
  1. BUGFIX: several diff fixes, including off by one error for files not ending in "\n", new file diff format fixes, and B file context calculation fixes
  1. BUGFIX: Online, TreeClean, and ls-files command should pull item list based on WorkspaceVersion not LatestVersion.
  1. BUGFIX: dont print blank lines for directories and new files for ls-files /old subcommand.
  1. BUGFIX: send local version updates to server after pending deletes.
  1. BUGFIX: trailing slash on path confused online command
  1. BUGFIX: add support for local paths to dir subcommand, and output listing in a more unix-y format (which is, imho, far more useful)
  1. HELP: Warn that invalid options can be mistaken for paths.
  1. HELP: Add more CodePlex usage examples to README

# Version 0.4.4 #

## Major Feature Additions ##
  1. add diff command with support for diff against server latest, diff of pending changes, diff view of any changeset.
  1. add basic version of TF Power Tool 1.1 "online" command to tf.exe, includes /preview mode.
  1. add basic version of TF Power Tool 1.2 "treeclean" command to tf.exe, includes /preview mode.
  1. add support for response file processing and multiple commands on a single command line, please see documentation for usage
  1. add changeset and help commands
  1. add configure command with options "Checkin.Validate", "Credentials.Save", and "History.Recursive". See man page for more details.
  1. if "Credentials.Save" is set to true, the tf client can load/store credentials from the gnome-keyring or TfClient.config.


## Minor Enhancements ##

  1. read server setings from cache file, don't need /server quite as much now
  1. add /format:detailed option to history command

  1. undoing a delete restores the file now
  1. numerous API additions including: WorkspaceVersionSpec, IDiffItem, DiffItemVersionedFile, DiffOutputType, DiffOptionFlags, DiffOptions, Conflict**, ExceptionEvent** types and more
  1. add DisplayString property for all VersionSpec classes
  1. prompts for password if not provided on the command line
  1. better man page and error messages
  1. more test cases

## Bugfixes ##

Many bugfixes from running TF client against Microsoft's TFS assemblies

  1. BUGFIX: when a file is checked in mark it should be marked read-only
  1. BUGFIX: do case insensitive string comparisons in ls-files and online commands on windows, and use Path.DirectorySeparatorChar
  1. BUGFIX: GetLocalWorkspaceInfo should find longest matching path, not first matching path
  1. BUGFIX: tf get should use CWD only to find workspace
  1. BUGFIX: properly handle checkin of files marked read-only
  1. BUGFIX: on windows find correct TFS VersionControl.config file

# Version 0.4.2 #
  1. tf.exe supports two new commands: "ls-files" and "properties". ls-files has options to show modified, out-of-date, unknown, and locally deleted file listings. This functionality doesn't exist in the Microsoft tf.exe client, and may be a reason to run tf4mono tf.exe on Windows.
  1. tf.exe undo command restores original file from server to local repository now
  1. tf.exe now compiles/runs on MS CLR.
  1. Add support for querying ExtendedItems.
  1. Debian packages via "make dist"
  1. Add GettingEventHandler, PendingChangeEventHandler, ProcessingChangeEventHandler, and OperationStatus.
  1. Many bug fixes were made to APIs, and client utility while testing on Windows.
  1. Start of MonoDevelop plugin based on Subversion plugin. Work in progress.
  1. Lots of code cleanups and bug fixes. Improved handling of ~/.tf/VersionControl.config cache.

# Version 0.4 #
Adds support for the add, delete, checkout, checkin, history and rename commands. Support for computing file permissions via libmagic also added, as TFS servers do not themselves track/store file permissions. Many API additions, bug fixes, and documentation updates
were also made.

# Version 0.3 #
Much better support for tracking a repository, including new files, deleted files, and renames. A preliminary man page has been added, and utility commands like add, delete, checkout, and rename modify the state of the server. The checkin command has a mysterious bug which prevents these modifications from being added back to the repository,
but that should be cleaned up soon.