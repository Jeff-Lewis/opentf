# Introduction #

The OpenTF IRC change notification bot joins the server/channel of your choosing, then spits out the following when someone makes a commit to the repository:

```
<tfsbot> Changset: 35699 by DOM\USER on 2/3/2008 10:35:21 PM
<tfsbot> Comment: compile.fix
<tfsbot> Url: http://10.1.1.80:8080/VersionControl/Changeset.aspx?artifactMoniker=35699&webView=true
```

# Configuration #

To configure tfsbot.exe, modify the configuration settings in tfsbot.exe.config:

```
<?xml version="1.0" encoding="utf-8"?>                                                    
<configuration><appSettings>
  <add key="irc.server" value="" />
  <add key="irc.channel" value="" />
  <add key="irc.nick" value="tfsbot" />
  <add key="tfs.url" value="" />
  <add key="tfs.domain" value="" />
  <add key="tfs.username" value="" />
  <add key="tfs.password" value="" />
</appSettings></configuration>
```