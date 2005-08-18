//
// AssemblyInfo.cs
//
// Author:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2003 Ximian, Inc.  http://www.ximian.com
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about the Microsoft.VisualBasic assembly

[assembly: AssemblyVersion (Consts.VsVersion)]
#if (!NET_2_0)
[assembly: SatelliteContractVersion (Consts.VsVersion)]
#endif

#if (ONLY_1_1)
[assembly: ComCompatibleVersion (7, 0, 3300, 0)]
[assembly: TypeLibVersion (7, 1)]
#endif

[assembly: AssemblyTitle("Microsoft Visual Basic .NET Runtime")]
[assembly: AssemblyDescription("Microsoft Visual Basic .NET Runtime")]
[assembly: AssemblyCompany("MONO development team")]
[assembly: AssemblyCopyright("(c) 2003 Various Authors")]

[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AllowPartiallyTrustedCallers()]

[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile("../msfinal.pub")]
