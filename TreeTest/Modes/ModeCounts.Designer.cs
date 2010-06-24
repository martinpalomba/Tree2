namespace TreeTest
{
	partial class ModeCounts
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BranchIndex = new System.Windows.Forms.TextBox();
			this.BranchCount = new System.Windows.Forms.TextBox();
			this.Depth = new System.Windows.Forms.TextBox();
			this.NodeCount = new System.Windows.Forms.TextBox();
			this.BranchIndexLabel = new System.Windows.Forms.Label();
			this.BranchCountLabel = new System.Windows.Forms.Label();
			this.DepthLabel = new System.Windows.Forms.Label();
			this.NodeCountLabel = new System.Windows.Forms.Label();
			this.TreeCount = new System.Windows.Forms.TextBox();
			this.TreeCountLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DirectChildCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BranchIndex
			// 
			this.BranchIndex.Location = new System.Drawing.Point( 101, 133 );
			this.BranchIndex.Name = "BranchIndex";
			this.BranchIndex.ReadOnly = true;
			this.BranchIndex.Size = new System.Drawing.Size( 100, 20 );
			this.BranchIndex.TabIndex = 11;
			// 
			// BranchCount
			// 
			this.BranchCount.Location = new System.Drawing.Point( 101, 107 );
			this.BranchCount.Name = "BranchCount";
			this.BranchCount.ReadOnly = true;
			this.BranchCount.Size = new System.Drawing.Size( 100, 20 );
			this.BranchCount.TabIndex = 9;
			// 
			// Depth
			// 
			this.Depth.Location = new System.Drawing.Point( 101, 81 );
			this.Depth.Name = "Depth";
			this.Depth.ReadOnly = true;
			this.Depth.Size = new System.Drawing.Size( 100, 20 );
			this.Depth.TabIndex = 7;
			// 
			// NodeCount
			// 
			this.NodeCount.Location = new System.Drawing.Point( 101, 29 );
			this.NodeCount.Name = "NodeCount";
			this.NodeCount.ReadOnly = true;
			this.NodeCount.Size = new System.Drawing.Size( 100, 20 );
			this.NodeCount.TabIndex = 3;
			// 
			// BranchIndexLabel
			// 
			this.BranchIndexLabel.AutoSize = true;
			this.BranchIndexLabel.Location = new System.Drawing.Point( 1, 137 );
			this.BranchIndexLabel.Name = "BranchIndexLabel";
			this.BranchIndexLabel.Size = new System.Drawing.Size( 70, 13 );
			this.BranchIndexLabel.TabIndex = 10;
			this.BranchIndexLabel.Text = "Branch Index";
			// 
			// BranchCountLabel
			// 
			this.BranchCountLabel.AutoSize = true;
			this.BranchCountLabel.Location = new System.Drawing.Point( 1, 111 );
			this.BranchCountLabel.Name = "BranchCountLabel";
			this.BranchCountLabel.Size = new System.Drawing.Size( 72, 13 );
			this.BranchCountLabel.TabIndex = 8;
			this.BranchCountLabel.Text = "Branch Count";
			// 
			// DepthLabel
			// 
			this.DepthLabel.AutoSize = true;
			this.DepthLabel.Location = new System.Drawing.Point( 1, 85 );
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size( 36, 13 );
			this.DepthLabel.TabIndex = 6;
			this.DepthLabel.Text = "Depth";
			// 
			// NodeCountLabel
			// 
			this.NodeCountLabel.AutoSize = true;
			this.NodeCountLabel.Location = new System.Drawing.Point( 1, 33 );
			this.NodeCountLabel.Name = "NodeCountLabel";
			this.NodeCountLabel.Size = new System.Drawing.Size( 64, 13 );
			this.NodeCountLabel.TabIndex = 2;
			this.NodeCountLabel.Text = "Node Count";
			// 
			// TreeCount
			// 
			this.TreeCount.Location = new System.Drawing.Point( 101, 3 );
			this.TreeCount.Name = "TreeCount";
			this.TreeCount.ReadOnly = true;
			this.TreeCount.Size = new System.Drawing.Size( 100, 20 );
			this.TreeCount.TabIndex = 1;
			// 
			// TreeCountLabel
			// 
			this.TreeCountLabel.AutoSize = true;
			this.TreeCountLabel.Location = new System.Drawing.Point( 1, 7 );
			this.TreeCountLabel.Name = "TreeCountLabel";
			this.TreeCountLabel.Size = new System.Drawing.Size( 60, 13 );
			this.TreeCountLabel.TabIndex = 0;
			this.TreeCountLabel.Text = "Tree Count";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 1, 59 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 92, 13 );
			this.label1.TabIndex = 4;
			this.label1.Text = "Direct Child Count";
			// 
			// DirectChildCount
			// 
			this.DirectChildCount.Location = new System.Drawing.Point( 101, 55 );
			this.DirectChildCount.Name = "DirectChildCount";
			this.DirectChildCount.ReadOnly = true;
			this.DirectChildCount.Size = new System.Drawing.Size( 100, 20 );
			this.DirectChildCount.TabIndex = 5;
			// 
			// ModeCounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.BranchIndex );
			this.Controls.Add( this.BranchCount );
			this.Controls.Add( this.DirectChildCount );
			this.Controls.Add( this.Depth );
			this.Controls.Add( this.NodeCount );
			this.Controls.Add( this.BranchIndexLabel );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.BranchCountLabel );
			this.Controls.Add( this.DepthLabel );
			this.Controls.Add( this.NodeCountLabel );
			this.Controls.Add( this.TreeCount );
			this.Controls.Add( this.TreeCountLabel );
			this.Name = "ModeCounts";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label DepthLabel;
		private System.Windows.Forms.TextBox BranchIndex;
		private System.Windows.Forms.TextBox BranchCount;
		private System.Windows.Forms.TextBox Depth;
		private System.Windows.Forms.TextBox NodeCount;
		private System.Windows.Forms.Label BranchIndexLabel;
		private System.Windows.Forms.Label BranchCountLabel;
		private System.Windows.Forms.Label NodeCountLabel;
		private System.Windows.Forms.TextBox TreeCount;
		private System.Windows.Forms.Label TreeCountLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox DirectChildCount;
	}
}
