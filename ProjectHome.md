OpenTF is an open source (BSD licensed) implementation of the Team Foundation assemblies and related client "TF". [Team Foundation](http://msdn2.microsoft.com/en-us/library/ms242904(VS.80).aspx) is a 'collection of collaborative technologies that support a team effort to deliver a product' from Microsoft that includes bug tracking, source control, and other capabilities.

This project focuses currently on the [SCM](http://en.wikipedia.org/wiki/Software_configuration_manageme) related libraries and tools. It includes a fairly functional version of the [TF client](http://msdn2.microsoft.com/en-us/library/cc31bk2e(vs.80).aspx) used to access the SCM capabilities of Team Foundation servers. In some respects, its usability [exceeds that of the standard TF tool](http://code.google.com/p/tf4mono/wiki/ClientDifferences). It also includes some subcommands from the TF Power Tool, and adds many additional commands, flexible option parsing, builtin help, and more.

Team Foundation does not do file attribute tracking, but the included TF client in this project leverages libmagic to implement file attribute tracking on unix platforms.

While currently focused on the SCM aspects of Team Foundation, the project roadmap includes an IRC change notification bot, a monodevelop plugin, an item tracking client, and a [gitweb](http://git.or.cz/gitwiki/Gitweb) inspired web-frontend.

For registered developers, [CodePlex](http://www.codeplex.com) is a publicly accessible example of a Team Foundation server used to host open source projects.