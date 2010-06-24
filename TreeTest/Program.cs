using System;
using System.Windows.Forms;

namespace TreeTest
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.DoEvents();

			Application.Run( new MainForm() );
		}
	}
}
