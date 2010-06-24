namespace TreeTest
{
	partial class ModeNode
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
			this.Cut = new System.Windows.Forms.Button();
			this.Copy = new System.Windows.Forms.Button();
			this.DeepCopy = new System.Windows.Forms.Button();
			this.Remove = new System.Windows.Forms.Button();
			this.SetData = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// Cut
			// 
			this.Cut.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Cut.Location = new System.Drawing.Point( 39, 61 );
			this.Cut.Name = "Cut";
			this.Cut.Size = new System.Drawing.Size( 160, 23 );
			this.Cut.TabIndex = 26;
			this.Cut.Text = "Cut";
			this.Cut.Click += new System.EventHandler( this.Cut_Click );
			// 
			// Copy
			// 
			this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Copy.Location = new System.Drawing.Point( 39, 90 );
			this.Copy.Name = "Copy";
			this.Copy.Size = new System.Drawing.Size( 160, 23 );
			this.Copy.TabIndex = 27;
			this.Copy.Text = "Copy";
			this.Copy.Click += new System.EventHandler( this.Copy_Click );
			// 
			// DeepCopy
			// 
			this.DeepCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DeepCopy.Location = new System.Drawing.Point( 39, 119 );
			this.DeepCopy.Name = "DeepCopy";
			this.DeepCopy.Size = new System.Drawing.Size( 160, 23 );
			this.DeepCopy.TabIndex = 28;
			this.DeepCopy.Text = "Deep Copy";
			this.DeepCopy.Click += new System.EventHandler( this.DeepCopy_Click );
			// 
			// Remove
			// 
			this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Remove.Location = new System.Drawing.Point( 39, 177 );
			this.Remove.Name = "Remove";
			this.Remove.Size = new System.Drawing.Size( 160, 23 );
			this.Remove.TabIndex = 29;
			this.Remove.Text = "Remove";
			this.Remove.Click += new System.EventHandler( this.Remove_Click );
			// 
			// SetData
			// 
			this.SetData.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SetData.Location = new System.Drawing.Point( 39, 3 );
			this.SetData.Name = "SetData";
			this.SetData.Size = new System.Drawing.Size( 160, 23 );
			this.SetData.TabIndex = 25;
			this.SetData.Text = "Set Data";
			this.SetData.Click += new System.EventHandler( this.SetData_Click );
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
			this.tableLayoutPanel1.Size = new System.Drawing.Size( 200, 100 );
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ModeNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this.Cut );
			this.Controls.Add( this.Copy );
			this.Controls.Add( this.DeepCopy );
			this.Controls.Add( this.Remove );
			this.Controls.Add( this.SetData );
			this.Name = "ModeNode";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Button Cut;
		private System.Windows.Forms.Button Copy;
		private System.Windows.Forms.Button DeepCopy;
		private System.Windows.Forms.Button Remove;
		private System.Windows.Forms.Button SetData;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
