//
// TeamFoundationPad.cs
//
// Authors:
//	Joel Reed (joelwreed@gmail.com)
//
// Copyright (C) 2007 Joel Reed
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
using System.Resources;

using MonoDevelop.Core;
using MonoDevelop.Core.Properties;
using MonoDevelop.Ide.Gui.Pads;
using MonoDevelop.Components.Commands;

namespace MonoDevelop.VersionControl.TeamFoundation
{
	public class TeamFoundationPad : TreeViewPad
	{
		public TeamFoundationPad () : base ()
		{
			//			MonoQueryService service = (MonoQueryService) ServiceManager.GetService (typeof (MonoQueryService));
			//service.Providers.Changed += new EventHandler (OnProvidersChanged);
		}
		
		public override void Initialize (NodeBuilder[] builders, TreePadOption[] options)
		{
			base.Initialize (builders, options);
			OnProvidersChanged (this, null);
		}
		
		//		[CommandHandler (MonoQueryCommands.RefreshProviderList)]
		public void Refresh ()
		{
			OnProvidersChanged (this, null);
		}
		
		protected virtual void OnProvidersChanged (object sender, EventArgs args)
		{
			//MonoQueryService service = (MonoQueryService) ServiceManager.GetService (typeof (MonoQueryService));
			Clear ();
			//LoadTree (service.Providers);
		}
	}
}
