using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	public partial class ModeEnumerators : TreeTest.ModeBase
	{
		public ModeEnumerators()
		{
			InitializeComponent();
		}

		public override Mode Mode { get { return Mode.Enumerators; } }

		private void ShowResults( IEnumerableCollectionPair<Element> pair )
		{
			IEnumerable e = ( Nodes.Checked ) ? ( IEnumerable ) pair.Nodes : pair.Values;

			ShowResults( e );
		}

		private void ShowResults( IEnumerable e )
		{
			string s = String.Empty;

			foreach ( object o in e )
			{
				if ( o is INode<Element> ) s += "Node: ";

				s += o + "\n";
			}

			MessageBox.Show( s, "Tree Test" );
		}

		private void INodeEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode );
		}

		private void ITreeEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode.Tree );
		}

		private void AllEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode.All );
		}

		private void AllChildrenEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode.AllChildren );
		}

		private void DirectChildrenEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode.DirectChildren );
		}

		private void InReverseEnumerator_Click( object sender, EventArgs e )
		{
			ShowResults( CurrentNode.DirectChildrenInReverse );
		}

		private void ButtonCopyToArray_Click( object sender, EventArgs e )
		{
			INode<Element> n = CurrentNode;

			ICollection c = ( Nodes.Checked ) ? ( ICollection ) n.Nodes : n.Values;

			object[] a = new object[ n.Count ];

			c.CopyTo( a, 0 );

			ShowResults( a );
		}

	}
}

