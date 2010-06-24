namespace TreeTest
{
	partial class ModeElement
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
			this.Copy = new System.Windows.Forms.Button();
			this.DeepCopy = new System.Windows.Forms.Button();
			this.Cut = new System.Windows.Forms.Button();
			this.Remove = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Element = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ContainsElement = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// Copy
			// 
			this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Copy.Location = new System.Drawing.Point( 39, 145 );
			this.Copy.Name = "Copy";
			this.Copy.Size = new System.Drawing.Size( 160, 23 );
			this.Copy.TabIndex = 34;
			this.Copy.Text = "Copy";
			this.Copy.Click += new System.EventHandler( this.Copy_Click );
			// 
			// DeepCopy
			// 
			this.DeepCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DeepCopy.Location = new System.Drawing.Point( 39, 174 );
			this.DeepCopy.Name = "DeepCopy";
			this.DeepCopy.Size = new System.Drawing.Size( 160, 23 );
			this.DeepCopy.TabIndex = 35;
			this.DeepCopy.Text = "Deep Copy";
			this.DeepCopy.Click += new System.EventHandler( this.DeepCopy_Click );
			// 
			// Cut
			// 
			this.Cut.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Cut.Location = new System.Drawing.Point( 39, 116 );
			this.Cut.Name = "Cut";
			this.Cut.Size = new System.Drawing.Size( 160, 23 );
			this.Cut.TabIndex = 33;
			this.Cut.Text = "Cut";
			this.Cut.Click += new System.EventHandler( this.Cut_Click );
			// 
			// Remove
			// 
			this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Remove.Location = new System.Drawing.Point( 39, 232 );
			this.Remove.Name = "Remove";
			this.Remove.Size = new System.Drawing.Size( 160, 23 );
			this.Remove.TabIndex = 36;
			this.Remove.Text = "Remove";
			this.Remove.Click += new System.EventHandler( this.Remove_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 36, 33 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 45, 13 );
			this.label1.TabIndex = 37;
			this.label1.Text = "Element";
			// 
			// Element
			// 
			this.Element.Location = new System.Drawing.Point( 99, 30 );
			this.Element.Name = "Element";
			this.Element.Size = new System.Drawing.Size( 100, 20 );
			this.Element.TabIndex = 38;
			this.Element.Text = "0";
			this.Element.TextChanged += new System.EventHandler( this.Element_TextChanged );
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 59, 76 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 89, 13 );
			this.label2.TabIndex = 39;
			this.label2.Text = "Contains Element";
			// 
			// ContainsElement
			// 
			this.ContainsElement.AutoSize = true;
			this.ContainsElement.Location = new System.Drawing.Point( 165, 76 );
			this.ContainsElement.Name = "ContainsElement";
			this.ContainsElement.Size = new System.Drawing.Size( 15, 14 );
			this.ContainsElement.TabIndex = 40;
			this.ContainsElement.UseVisualStyleBackColor = true;
			// 
			// ModeElement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this.ContainsElement );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.Element );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.Copy );
			this.Controls.Add( this.DeepCopy );
			this.Controls.Add( this.Cut );
			this.Controls.Add( this.Remove );
			this.Name = "ModeElement";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Copy;
		private System.Windows.Forms.Button DeepCopy;
		private System.Windows.Forms.Button Cut;
		private System.Windows.Forms.Button Remove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Element;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox ContainsElement;
	}
}
