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
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//
//
// $Revision: 1.1 $
// $Modtime: $
// $Log: HelpEventArgs.cs,v $
// Revision 1.1  2004/07/09 05:21:25  pbartok
// - Initial check-in
//
//

// COMPLETE

using System.Drawing;

namespace System.Windows.Forms {
	public class HelpEventArgs : EventArgs {
		private Point	mouse_position;
		private bool	event_handled;

		#region Public Constructors
		public HelpEventArgs(System.Drawing.Point mousePos) {
			this.mouse_position=mousePos;
			this.event_handled=false;
		}
		#endregion	// Public Constructors

		#region Public Instance Properties
		public bool Handled {
			get {
				return this.event_handled;
			}

			set {
				this.event_handled=value;
			}
		}

		public Point MousePos {
			get {
				return this.mouse_position;
			}
		}
		#endregion	// Public Instance Properties
	}
}
