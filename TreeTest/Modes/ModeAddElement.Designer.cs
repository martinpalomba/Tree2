namespace TreeTest
{
	partial class ModeAddElement
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
			this.Add = new System.Windows.Forms.Button();
			this.AddChild = new System.Windows.Forms.Button();
			this.InsertChild = new System.Windows.Forms.Button();
			this.InsertNext = new System.Windows.Forms.Button();
			this.InsertPrevious = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Add.Location = new System.Drawing.Point( 39, 90 );
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size( 160, 23 );
			this.Add.TabIndex = 15;
			this.Add.Text = "Add";
			this.Add.Click += new System.EventHandler( this.Add_Click );
			// 
			// AddChild
			// 
			this.AddChild.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AddChild.Location = new System.Drawing.Point( 39, 119 );
			this.AddChild.Name = "AddChild";
			this.AddChild.Size = new System.Drawing.Size( 160, 23 );
			this.AddChild.TabIndex = 16;
			this.AddChild.Text = "Add Child";
			this.AddChild.Click += new System.EventHandler( this.AddChild_Click );
			// 
			// InsertChild
			// 
			this.InsertChild.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.InsertChild.Location = new System.Drawing.Point( 39, 61 );
			this.InsertChild.Name = "InsertChild";
			this.InsertChild.Size = new System.Drawing.Size( 160, 23 );
			this.InsertChild.TabIndex = 14;
			this.InsertChild.Text = "Insert Child";
			this.InsertChild.Click += new System.EventHandler( this.InsertChild_Click );
			// 
			// InsertNext
			// 
			this.InsertNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.InsertNext.Location = new System.Drawing.Point( 39, 32 );
			this.InsertNext.Name = "InsertNext";
			this.InsertNext.Size = new System.Drawing.Size( 160, 23 );
			this.InsertNext.TabIndex = 13;
			this.InsertNext.Text = "Insert Next";
			this.InsertNext.Click += new System.EventHandler( this.InsertNext_Click );
			// 
			// InsertPrevious
			// 
			this.InsertPrevious.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.InsertPrevious.Location = new System.Drawing.Point( 39, 3 );
			this.InsertPrevious.Name = "InsertPrevious";
			this.InsertPrevious.Size = new System.Drawing.Size( 160, 23 );
			this.InsertPrevious.TabIndex = 12;
			this.InsertPrevious.Text = "Insert Previous";
			this.InsertPrevious.Click += new System.EventHandler( this.InsertPrevious_Click );
			// 
			// ModeAddElement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this.Add );
			this.Controls.Add( this.AddChild );
			this.Controls.Add( this.InsertChild );
			this.Controls.Add( this.InsertNext );
			this.Controls.Add( this.InsertPrevious );
			this.Name = "ModeAddElement";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button AddChild;
		private System.Windows.Forms.Button InsertChild;
		private System.Windows.Forms.Button InsertNext;
		private System.Windows.Forms.Button InsertPrevious;
	}
}
