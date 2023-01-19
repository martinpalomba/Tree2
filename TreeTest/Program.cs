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

    //svn2git svn://vsdesarrollo/Tree2  --notrunk --nobranches --notags --authors "f:\authors.txt" --verbose
}
