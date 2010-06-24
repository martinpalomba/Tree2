namespace TreeTest
{
	partial class ModeControl
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
			this._Mode = new System.Windows.Forms.ComboBox();
			this._Panel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// _Mode
			// 
			this._Mode.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this._Mode.DropDownHeight = 145;
			this._Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._Mode.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._Mode.FormattingEnabled = true;
			this._Mode.IntegralHeight = false;
			this._Mode.Location = new System.Drawing.Point( 0, 0 );
			this._Mode.Name = "_Mode";
			this._Mode.Size = new System.Drawing.Size( 238, 21 );
			this._Mode.TabIndex = 0;
			this._Mode.SelectedIndexChanged += new System.EventHandler( this._Mode_SelectedIndexChanged );
			// 
			// _Panel
			// 
			this._Panel.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this._Panel.Location = new System.Drawing.Point( 0, 27 );
			this._Panel.Name = "_Panel";
			this._Panel.Size = new System.Drawing.Size( 238, 317 );
			this._Panel.TabIndex = 1;
			this._Panel.Visible = false;
			// 
			// ModeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this._Panel );
			this.Controls.Add( this._Mode );
			this.Name = "ModeControl";
			this.Size = new System.Drawing.Size( 238, 344 );
			this.Load += new System.EventHandler( this.ModeControl_Load );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ComboBox _Mode;
		private System.Windows.Forms.Panel _Panel;


	}
}
