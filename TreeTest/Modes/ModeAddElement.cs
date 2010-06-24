using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeAddElement : TreeTest.ModeBase
	{
		public ModeAddElement()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.AddElement; } }

		private static int _NewElement = 0;

		public override void OnNewTree()
		{
			_NewElement = 0;
		}

		private static Element CreateNewElement()
		{
			return new Element( "New Element " + _NewElement++ );
		}

		private void InsertPrevious_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertPrevious( CreateNewElement() );

			OnRefreshTree();
		}

		private void InsertNext_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertNext( CreateNewElement() );

			OnRefreshTree();
		}

		private void InsertChild_Click( object sender, EventArgs e )
		{
			CurrentNode.InsertChild( CreateNewElement() );

			OnRefreshTree();
		}

		private void Add_Click( object sender, EventArgs e )
		{
			CurrentNode.Add( CreateNewElement() );

			OnRefreshTree();
		}

		private void AddChild_Click( object sender, EventArgs e )
		{
			CurrentNode.AddChild( CreateNewElement() );

			OnRefreshTree();
		}
	}
}

