//
// AssemblyInfo.cs
//
// Author:
//   Joel Reed (joelwreed@gmail.com)
//
// Copyright (C) 2007 Joel Reed
using System;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion ("1.0.0")]
[assembly: SatelliteContractVersion ("1.0.0")]

[assembly: AssemblyTitle("Microsoft.TeamFoundation.VersionControl.Common.dll")]
[assembly: AssemblyDescription("Microsoft.TeamFoundation.VersionControl.Common.dll")]
[assembly: AssemblyConfiguration("Development version")]
[assembly: AssemblyCompany("MONO development team")]
[assembly: AssemblyProduct("MONO CLI")]
[assembly: AssemblyCopyright("(c) 2006 Various Authors")]
[assembly: AssemblyTrademark("")]
#if TARGET_JVM
[assembly: CLSCompliant(false)]
#else
[assembly: CLSCompliant(true)]
#endif

[assembly: ComVisible(false)]
[assembly: AssemblyDefaultAlias("Microsoft.TeamFoundation.VersionControl.Common.dll")]
[assembly: AssemblyInformationalVersion("0.0.0.1")]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile("../msfinal.pub")]
