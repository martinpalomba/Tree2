using System;
using System.Collections.Generic;
using System.Text;

using Common;

namespace TreeTest
{
	partial class MainForm
	{
		private void HookTreeEvents( ITree<Element> tree )
		{
			tree.Validate += new EventHandler<NodeTreeDataEventArgs<Element>>( Tree_Validate );
			tree.Clearing += new EventHandler( Tree_Clearing );
			tree.Cleared += new EventHandler( Tree_Cleared );
			tree.Setting += new EventHandler<NodeTreeDataEventArgs<Element>>( Tree_Setting );
			tree.SetDone += new EventHandler<NodeTreeDataEventArgs<Element>>( Tree_SetDone );
			tree.Inserting += new EventHandler<NodeTreeInsertEventArgs<Element>>( Tree_Inserting );
			tree.Inserted += new EventHandler<NodeTreeInsertEventArgs<Element>>( Tree_Inserted );
			tree.Cutting += new EventHandler( Tree_Cutting );
			tree.CutDone += new EventHandler( Tree_CutDone );
			tree.Copying += new EventHandler<NodeTreeNodeEventArgs<Element>>( Tree_Copying );
			tree.Copied += new EventHandler<NodeTreeNodeEventArgs<Element>>( Tree_Copied );
			tree.DeepCopying += new EventHandler<NodeTreeNodeEventArgs<Element>>( Tree_DeepCopying );
			tree.DeepCopied += new EventHandler<NodeTreeNodeEventArgs<Element>>( Tree_DeepCopied );
		}

		private void HookNodeEvents( INode<Element> node )
		{
			node.Validate += new EventHandler<NodeTreeDataEventArgs<Element>>( Node_Validate );
			node.Setting += new EventHandler<NodeTreeDataEventArgs<Element>>( Node_Setting );
			node.SetDone += new EventHandler<NodeTreeDataEventArgs<Element>>( Node_SetDone );
			node.Inserting += new EventHandler<NodeTreeInsertEventArgs<Element>>( Node_Inserting );
			node.Inserted += new EventHandler<NodeTreeInsertEventArgs<Element>>( Node_Inserted );
			node.Cutting += new EventHandler( Node_Cutting );
			node.CutDone += new EventHandler( Node_CutDone );
			node.Copying += new EventHandler<NodeTreeNodeEventArgs<Element>>( Node_Copying );
			node.Copied += new EventHandler<NodeTreeNodeEventArgs<Element>>( Node_Copied );
			node.DeepCopying += new EventHandler<NodeTreeNodeEventArgs<Element>>( Node_DeepCopying );
			node.DeepCopied += new EventHandler<NodeTreeNodeEventArgs<Element>>( Node_DeepCopied );
		}

		//-----------------------------------------------------------------------------
		// Tree

		private void Tree_Validate( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Validate : \"" + e.Data + "\"\r\n";
		}

		private void Tree_Clearing( object sender, EventArgs e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Clearing\r\n";
		}

		private void Tree_Cleared( object sender, EventArgs e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Cleared\r\n";
		}

		private void Tree_Setting( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Setting : \"" + e.Data + "\"\r\n";
		}

		private void Tree_SetDone( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : SetDone : \"" + e.Data + "\"\r\n";
		}

		private void Tree_Inserting( object sender, NodeTreeInsertEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Inserting " + e.Operation + " : \"" + e.Node + "\"\r\n";
		}

		private void Tree_Inserted( object sender, NodeTreeInsertEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Inserted " + e.Operation + " : \"" + e.Node + "\"\r\n";
		}

		private void Tree_Cutting( object sender, EventArgs e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Cutting\r\n";
		}

		private void Tree_CutDone( object sender, EventArgs e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : CutDone\r\n";
		}

		private void Tree_Copying( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Copying : \"" + e.Node + "\"\r\n";
		}

		private void Tree_Copied( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : Copied : \"" + e.Node + "\"\r\n";
		}

		private void Tree_DeepCopying( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : DeepCopying : \"" + e.Node + "\"\r\n";
		}

		private void Tree_DeepCopied( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Tree: Sender( \"" + sender + "\" ) : DeepCopied : \"" + e.Node + "\"\r\n";
		}

		//-----------------------------------------------------------------------------
		// Node

		private void Node_Validate( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Validate : \"" + e.Data + "\"\r\n";
		}

		private void Node_Setting( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Setting : \"" + e.Data + "\"\r\n";
		}

		private void Node_SetDone( object sender, NodeTreeDataEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : SetDone : \"" + e.Data + "\"\r\n";
		}

		private void Node_Inserting( object sender, NodeTreeInsertEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Inserting " + e.Operation + " : \"" + e.Node + "\"\r\n";
		}

		private void Node_Inserted( object sender, NodeTreeInsertEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Inserted " + e.Operation + " : \"" + e.Node + "\"\r\n";
		}

		private void Node_Cutting( object sender, EventArgs e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Cutting\r\n";
		}

		private void Node_CutDone( object sender, EventArgs e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : CutDone\r\n";
		}

		private void Node_Copying( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Copying : \"" + e.Node + "\"\r\n";
		}

		private void Node_Copied( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : Copied : \"" + e.Node + "\"\r\n";
		}

		private void Node_DeepCopying( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : DeepCopying : \"" + e.Node + "\"\r\n";
		}

		private void Node_DeepCopied( object sender, NodeTreeNodeEventArgs<Element> e )
		{
			EventOutput.Text += "Node: Sender( \"" + sender + "\" ) : DeepCopied : \"" + e.Node + "\"\r\n";
		}

		//-----------------------------------------------------------------------------

	}
}
