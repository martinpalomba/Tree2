using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeNode : TreeTest.ModeBase
	{
		public ModeNode()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Node; } }

		private static int _NewElement = 0;

		public override void OnNewTree()
		{
			_NewElement = 0;
		}

		private static Element CreateNewElement()
		{
			return new Element( "New Element " + _NewElement++ );
		}

		private void SetData_Click( object sender, EventArgs e )
		{
			CurrentNode.Data = CreateNewElement();

			OnRefreshTree();
		}

		private void Cut_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.Cut();

			OnSetTreeClipboard( tree );
		}

		private void Copy_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.Copy();

			OnSetTreeClipboard( tree );
		}

		private void DeepCopy_Click( object sender, EventArgs e )
		{
			ITree<Element> tree = CurrentNode.DeepCopy();

			OnSetTreeClipboard( tree );
		}

		private void Remove_Click( object sender, EventArgs e )
		{
			CurrentNode.Remove();

			OnRefreshTree();
		}

	}
}

