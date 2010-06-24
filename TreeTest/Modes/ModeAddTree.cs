using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeAddTree : TreeTest.ModeBase
	{
		public ModeAddTree()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.AddTree; } }

		private void InsertPrevious_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertPrevious( TreeClipboard );

			OnRefreshTree();
		}

		private void InsertNext_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertNext( TreeClipboard );

			OnRefreshTree();
		}

		private void InsertChild_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertChild( TreeClipboard );

			OnRefreshTree();
		}

		private void Add_Click( object sender, EventArgs e )
		{
			CurrentNode.Add( TreeClipboard );

			OnRefreshTree();
		}

		private void AddChild_Click( object sender, EventArgs e )
		{
			CurrentNode.AddChild( TreeClipboard );

			OnRefreshTree();
		}
	}
}

