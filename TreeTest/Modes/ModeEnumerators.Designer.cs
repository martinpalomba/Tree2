namespace TreeTest
{
	partial class ModeEnumerators
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
			this.DirectChildrenEnumerator = new System.Windows.Forms.Button();
			this.INodeEnumerator = new System.Windows.Forms.Button();
			this.ButtonITreeEnumerator = new System.Windows.Forms.Button();
			this.InReverseEnumerator = new System.Windows.Forms.Button();
			this.AllChildrenEnumerator = new System.Windows.Forms.Button();
			this.ButtonCopyToArray = new System.Windows.Forms.Button();
			this.Nodes = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.AllEnumerator = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DirectChildrenEnumerator
			// 
			this.DirectChildrenEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DirectChildrenEnumerator.Location = new System.Drawing.Point( 39, 187 );
			this.DirectChildrenEnumerator.Name = "DirectChildrenEnumerator";
			this.DirectChildrenEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.DirectChildrenEnumerator.TabIndex = 48;
			this.DirectChildrenEnumerator.Text = "Direct Children";
			this.DirectChildrenEnumerator.Click += new System.EventHandler( this.DirectChildrenEnumerator_Click );
			// 
			// INodeEnumerator
			// 
			this.INodeEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.INodeEnumerator.Location = new System.Drawing.Point( 39, 68 );
			this.INodeEnumerator.Name = "INodeEnumerator";
			this.INodeEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.INodeEnumerator.TabIndex = 45;
			this.INodeEnumerator.Text = "INode";
			this.INodeEnumerator.Click += new System.EventHandler( this.INodeEnumerator_Click );
			// 
			// ButtonITreeEnumerator
			// 
			this.ButtonITreeEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ButtonITreeEnumerator.Location = new System.Drawing.Point( 39, 100 );
			this.ButtonITreeEnumerator.Name = "ButtonITreeEnumerator";
			this.ButtonITreeEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.ButtonITreeEnumerator.TabIndex = 46;
			this.ButtonITreeEnumerator.Text = "ITree";
			this.ButtonITreeEnumerator.Click += new System.EventHandler( this.ITreeEnumerator_Click );
			// 
			// InReverseEnumerator
			// 
			this.InReverseEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.InReverseEnumerator.Location = new System.Drawing.Point( 39, 216 );
			this.InReverseEnumerator.Name = "InReverseEnumerator";
			this.InReverseEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.InReverseEnumerator.TabIndex = 50;
			this.InReverseEnumerator.Text = "In Reverse";
			this.InReverseEnumerator.Click += new System.EventHandler( this.InReverseEnumerator_Click );
			// 
			// AllChildrenEnumerator
			// 
			this.AllChildrenEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AllChildrenEnumerator.Location = new System.Drawing.Point( 39, 158 );
			this.AllChildrenEnumerator.Name = "AllChildrenEnumerator";
			this.AllChildrenEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.AllChildrenEnumerator.TabIndex = 47;
			this.AllChildrenEnumerator.Text = "AllChildren";
			this.AllChildrenEnumerator.Click += new System.EventHandler( this.AllChildrenEnumerator_Click );
			// 
			// ButtonCopyToArray
			// 
			this.ButtonCopyToArray.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ButtonCopyToArray.Location = new System.Drawing.Point( 39, 274 );
			this.ButtonCopyToArray.Name = "ButtonCopyToArray";
			this.ButtonCopyToArray.Size = new System.Drawing.Size( 160, 23 );
			this.ButtonCopyToArray.TabIndex = 51;
			this.ButtonCopyToArray.Text = "Copy To Array";
			this.ButtonCopyToArray.Click += new System.EventHandler( this.ButtonCopyToArray_Click );
			// 
			// Nodes
			// 
			this.Nodes.AutoSize = true;
			this.Nodes.Location = new System.Drawing.Point( 60, 23 );
			this.Nodes.Name = "Nodes";
			this.Nodes.Size = new System.Drawing.Size( 56, 17 );
			this.Nodes.TabIndex = 52;
			this.Nodes.Text = "Nodes";
			this.Nodes.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point( 122, 23 );
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size( 57, 17 );
			this.radioButton2.TabIndex = 53;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Values";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// AllEnumerator
			// 
			this.AllEnumerator.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.AllEnumerator.Location = new System.Drawing.Point( 39, 129 );
			this.AllEnumerator.Name = "AllEnumerator";
			this.AllEnumerator.Size = new System.Drawing.Size( 160, 23 );
			this.AllEnumerator.TabIndex = 46;
			this.AllEnumerator.Text = "All";
			this.AllEnumerator.Click += new System.EventHandler( this.AllEnumerator_Click );
			// 
			// ModeEnumerators
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this.radioButton2 );
			this.Controls.Add( this.Nodes );
			this.Controls.Add( this.DirectChildrenEnumerator );
			this.Controls.Add( this.INodeEnumerator );
			this.Controls.Add( this.AllEnumerator );
			this.Controls.Add( this.ButtonITreeEnumerator );
			this.Controls.Add( this.InReverseEnumerator );
			this.Controls.Add( this.AllChildrenEnumerator );
			this.Controls.Add( this.ButtonCopyToArray );
			this.Name = "ModeEnumerators";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button DirectChildrenEnumerator;
		private System.Windows.Forms.Button INodeEnumerator;
		private System.Windows.Forms.Button ButtonITreeEnumerator;
		private System.Windows.Forms.Button InReverseEnumerator;
		private System.Windows.Forms.Button AllChildrenEnumerator;
		private System.Windows.Forms.Button ButtonCopyToArray;
		private System.Windows.Forms.RadioButton Nodes;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button AllEnumerator;
	}
}
