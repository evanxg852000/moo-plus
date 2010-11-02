using System;
using System.Windows.Forms;

namespace Yalamo.Gui.Dock
{
	internal class DummyControl : Control
	{
		public DummyControl()
		{
			SetStyle(ControlStyles.Selectable, false);
		}
	}
}
