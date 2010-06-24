namespace TreeTest
{
	partial class ModeSerialization
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
			this.Serialize = new System.Windows.Forms.Button();
			this.Deserialize = new System.Windows.Forms.Button();
			this.ViewFile = new System.Windows.Forms.Button();
			this.Binary = new System.Windows.Forms.RadioButton();
			this.XML = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// Serialize
			// 
			this.Serialize.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Serialize.Location = new System.Drawing.Point( 39, 130 );
			this.Serialize.Name = "Serialize";
			this.Serialize.Size = new System.Drawing.Size( 160, 23 );
			this.Serialize.TabIndex = 23;
			this.Serialize.Text = "Serialize";
			this.Serialize.Click += new System.EventHandler( this.Serialize_Click );
			// 
			// Deserialize
			// 
			this.Deserialize.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Deserialize.Location = new System.Drawing.Point( 39, 194 );
			this.Deserialize.Name = "Deserialize";
			this.Deserialize.Size = new System.Drawing.Size( 160, 23 );
			this.Deserialize.TabIndex = 22;
			this.Deserialize.Text = "Deserialize";
			this.Deserialize.Click += new System.EventHandler( this.Deserialize_Click );
			// 
			// ViewFile
			// 
			this.ViewFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ViewFile.Location = new System.Drawing.Point( 39, 162 );
			this.ViewFile.Name = "ViewFile";
			this.ViewFile.Size = new System.Drawing.Size( 160, 23 );
			this.ViewFile.TabIndex = 21;
			this.ViewFile.Text = "View file";
			this.ViewFile.Click += new System.EventHandler( this.ViewFile_Click );
			// 
			// Binary
			// 
			this.Binary.AutoSize = true;
			this.Binary.Checked = true;
			this.Binary.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Binary.Location = new System.Drawing.Point( 39, 41 );
			this.Binary.Name = "Binary";
			this.Binary.Size = new System.Drawing.Size( 60, 18 );
			this.Binary.TabIndex = 24;
			this.Binary.TabStop = true;
			this.Binary.Text = "Binary";
			this.Binary.UseVisualStyleBackColor = true;
			// 
			// XML
			// 
			this.XML.AutoSize = true;
			this.XML.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.XML.Location = new System.Drawing.Point( 39, 64 );
			this.XML.Name = "XML";
			this.XML.Size = new System.Drawing.Size( 53, 18 );
			this.XML.TabIndex = 25;
			this.XML.Text = "XML";
			this.XML.UseVisualStyleBackColor = true;
			// 
			// ModeSerialization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this.XML );
			this.Controls.Add( this.Binary );
			this.Controls.Add( this.Serialize );
			this.Controls.Add( this.Deserialize );
			this.Controls.Add( this.ViewFile );
			this.Name = "ModeSerialization";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Serialize;
		private System.Windows.Forms.Button Deserialize;
		private System.Windows.Forms.Button ViewFile;
		private System.Windows.Forms.RadioButton Binary;
		private System.Windows.Forms.RadioButton XML;
	}
}
