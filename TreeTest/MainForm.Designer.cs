namespace TreeTest
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._TreeView = new System.Windows.Forms.TreeView();
			this._Clipboard = new System.Windows.Forms.TreeView();
			this._NewTree = new System.Windows.Forms.Button();
			this._ClearTree = new System.Windows.Forms.Button();
			this._NewTreeClipboard = new System.Windows.Forms.Button();
			this._ClearTreeClipboard = new System.Windows.Forms.Button();
			this.EventOutput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ClearEvents = new System.Windows.Forms.Button();
			this._Mode = new TreeTest.ModeControl();
			this.SuspendLayout();
			// 
			// _TreeView
			// 
			this._TreeView.FullRowSelect = true;
			this._TreeView.HideSelection = false;
			this._TreeView.Location = new System.Drawing.Point( 12, 34 );
			this._TreeView.Name = "_TreeView";
			this._TreeView.ShowRootLines = false;
			this._TreeView.Size = new System.Drawing.Size( 160, 344 );
			this._TreeView.TabIndex = 2;
			this._TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.TreeView_AfterSelect );
			// 
			// _Clipboard
			// 
			this._Clipboard.FullRowSelect = true;
			this._Clipboard.HideSelection = false;
			this._Clipboard.Location = new System.Drawing.Point( 422, 34 );
			this._Clipboard.Name = "_Clipboard";
			this._Clipboard.ShowRootLines = false;
			this._Clipboard.Size = new System.Drawing.Size( 160, 344 );
			this._Clipboard.TabIndex = 2;
			// 
			// _NewTree
			// 
			this._NewTree.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._NewTree.Location = new System.Drawing.Point( 12, 384 );
			this._NewTree.Name = "_NewTree";
			this._NewTree.Size = new System.Drawing.Size( 75, 23 );
			this._NewTree.TabIndex = 4;
			this._NewTree.Text = "New";
			this._NewTree.UseVisualStyleBackColor = true;
			this._NewTree.Click += new System.EventHandler( this._NewTree_Click );
			// 
			// _ClearTree
			// 
			this._ClearTree.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._ClearTree.Location = new System.Drawing.Point( 97, 384 );
			this._ClearTree.Name = "_ClearTree";
			this._ClearTree.Size = new System.Drawing.Size( 75, 23 );
			this._ClearTree.TabIndex = 4;
			this._ClearTree.Text = "Clear";
			this._ClearTree.UseVisualStyleBackColor = true;
			this._ClearTree.Click += new System.EventHandler( this._ClearTree_Click );
			// 
			// _NewTreeClipboard
			// 
			this._NewTreeClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._NewTreeClipboard.Location = new System.Drawing.Point( 422, 384 );
			this._NewTreeClipboard.Name = "_NewTreeClipboard";
			this._NewTreeClipboard.Size = new System.Drawing.Size( 75, 23 );
			this._NewTreeClipboard.TabIndex = 4;
			this._NewTreeClipboard.Text = "New";
			this._NewTreeClipboard.UseVisualStyleBackColor = true;
			this._NewTreeClipboard.Click += new System.EventHandler( this._NewTreeClipboard_Click );
			// 
			// _ClearTreeClipboard
			// 
			this._ClearTreeClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._ClearTreeClipboard.Location = new System.Drawing.Point( 507, 384 );
			this._ClearTreeClipboard.Name = "_ClearTreeClipboard";
			this._ClearTreeClipboard.Size = new System.Drawing.Size( 75, 23 );
			this._ClearTreeClipboard.TabIndex = 4;
			this._ClearTreeClipboard.Text = "Clear";
			this._ClearTreeClipboard.UseVisualStyleBackColor = true;
			this._ClearTreeClipboard.Click += new System.EventHandler( this._ClearTreeClipboard_Click );
			// 
			// EventOutput
			// 
			this.EventOutput.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.EventOutput.Location = new System.Drawing.Point( 12, 413 );
			this.EventOutput.Multiline = true;
			this.EventOutput.Name = "EventOutput";
			this.EventOutput.ReadOnly = true;
			this.EventOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.EventOutput.Size = new System.Drawing.Size( 570, 148 );
			this.EventOutput.TabIndex = 7;
			this.EventOutput.WordWrap = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 65, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 55, 13 );
			this.label1.TabIndex = 8;
			this.label1.Text = "Main Tree";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 268, 9 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 58, 13 );
			this.label2.TabIndex = 9;
			this.label2.Text = "Operations";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 473, 9 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 59, 13 );
			this.label3.TabIndex = 10;
			this.label3.Text = "Temp Tree";
			// 
			// ClearEvents
			// 
			this.ClearEvents.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ClearEvents.Location = new System.Drawing.Point( 217, 384 );
			this.ClearEvents.Name = "ClearEvents";
			this.ClearEvents.Size = new System.Drawing.Size( 160, 23 );
			this.ClearEvents.TabIndex = 22;
			this.ClearEvents.Text = "Clear Events";
			this.ClearEvents.Click += new System.EventHandler( this.ClearEvents_Click );
			// 
			// _Mode
			// 
			this._Mode.Location = new System.Drawing.Point( 178, 34 );
			this._Mode.Name = "_Mode";
			this._Mode.Size = new System.Drawing.Size( 238, 344 );
			this._Mode.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 594, 568 );
			this.Controls.Add( this.ClearEvents );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.EventOutput );
			this.Controls.Add( this._ClearTreeClipboard );
			this.Controls.Add( this._ClearTree );
			this.Controls.Add( this._NewTreeClipboard );
			this.Controls.Add( this._NewTree );
			this.Controls.Add( this._Mode );
			this.Controls.Add( this._Clipboard );
			this.Controls.Add( this._TreeView );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tree Test";
			this.Load += new System.EventHandler( this.MainForm_Load );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView _TreeView;
		private ModeControl _Mode;
		private System.Windows.Forms.TreeView _Clipboard;
		private System.Windows.Forms.Button _NewTree;
		private System.Windows.Forms.Button _ClearTree;
		private System.Windows.Forms.Button _NewTreeClipboard;
		private System.Windows.Forms.Button _ClearTreeClipboard;
		private System.Windows.Forms.TextBox EventOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ClearEvents;
	}
}