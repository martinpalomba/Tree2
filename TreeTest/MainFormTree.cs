using System;
using System.Windows.Forms;

using Common;

namespace TreeTest
{
	partial class MainForm
	{

		//-----------------------------------------------------------------------------
		// OnFileNew

		private void OnFileNew()
		{
			do
			{
				EventOutput.Clear();
				_Tree.Clear();
				AddNodes( _Tree.Root, "", 0 );
			}
			while ( _Tree.Count < 10 || _Tree.Count > 20 );

			OnViewRefresh();

			_NewTreeIndex = 0;

			_Mode.OnNewTree();
		}

		private static Random Random = new Random();

		private void AddNodes( INode<Element> parent, string sParent, int iDepth )
		{
			if ( iDepth > 3 ) return;

			for ( int i = 0 ; Random.Next( 10 ) < 5 ; i++ )
			{
				string s = sParent + i;

				INode<Element> child = parent.AddChild( new Element( s ) );

				HookNodeEvents( child );

				AddNodes( child, s, iDepth + 1 );
			}
		}

		private void OnViewRefresh()
		{
			FillTreeView( _TreeView, _Tree );
			FillTreeView( _Clipboard, _TreeClipboard );
		}


		//-----------------------------------------------------------------------------
		// TreeViewUpdate

		private class TreeViewUpdate : IDisposable
		{
			private TreeView TreeView;

			public TreeViewUpdate( TreeView TreeView )
			{
				this.TreeView = TreeView;
				TreeView.BeginUpdate();
			}

			public void Dispose()
			{
				TreeView.EndUpdate();
			}
		}

		//-----------------------------------------------------------------------------
		// FillTreeView

		private static void FillTreeView( TreeView treeView, ITree<Element> tree )
		{
			object oSelected = null;
			if ( treeView.SelectedNode != null ) oSelected = treeView.SelectedNode.Tag;

			using ( new TreeViewUpdate( treeView ) )
			{
				treeView.Nodes.Clear();

				if ( tree == null ) return;

				TreeNode root = treeView.Nodes.Add( tree.Root.ToString() );
				root.Tag = tree.Root;

				TreeNode nSelected = AddNodes( root.Nodes, tree.Root, oSelected );

				treeView.ExpandAll();

				if ( nSelected != null )
					treeView.SelectedNode = nSelected;
				else
					if ( treeView.Nodes.Count > 0 )
						treeView.SelectedNode = treeView.Nodes[ 0 ];
			}
		}

		private static TreeNode AddNodes( TreeNodeCollection nodes, INode<Element> parent, object oSelected )
		{
			TreeNode nSelected = null;

			foreach ( INode<Element> child in parent.DirectChildren.Nodes )
			//			for ( INode<Element> child = parent.child ; child != null ; child = child.next )
			{
				TreeNode node = nodes.Add( child.ToString() );
				node.Tag = child;

				if ( child == oSelected ) nSelected = node;

				TreeNode n = AddNodes( node.Nodes, child, oSelected );
				if ( n != null ) nSelected = n;
			}

			return nSelected;
		}

		//-----------------------------------------------------------------------------
		// OnNewTreeClipboard

		private static int _NewTreeIndex = 0;

		private static ITree<Element> CreateNewTree()
		{
			string s = "New Tree " + _NewTreeIndex + ": ";

			ITree<Element> t = NodeTree<Element>.NewTree();
			t.AddChild( new Element( s + "1" ) );
			t.AddChild( new Element( s + "2" ) )
				.AddChild( new Element( s + "21" ) )
				.InsertNext( new Element( s + "22" ) )
					.AddChild( new Element( s + "221" ) );

			_NewTreeIndex++;

			return t;
		}

		private void OnNewTreeClipboard()
		{
			_TreeClipboard = CreateNewTree();

			_Mode.TreeClipboard = _TreeClipboard;

			OnViewRefresh();
		}

	}
}