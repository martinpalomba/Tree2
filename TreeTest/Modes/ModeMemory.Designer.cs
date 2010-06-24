namespace TreeTest
{
	partial class ModeMemory
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
			this._RunTest = new System.Windows.Forms.Button();
			this._Memory = new System.Windows.Forms.TextBox();
			this._Time = new System.Windows.Forms.TextBox();
			this._Iterations = new System.Windows.Forms.ComboBox();
			this._AddEventHandler = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// _RunTest
			// 
			this._RunTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._RunTest.Location = new System.Drawing.Point( 39, 109 );
			this._RunTest.Name = "_RunTest";
			this._RunTest.Size = new System.Drawing.Size( 160, 23 );
			this._RunTest.TabIndex = 2;
			this._RunTest.Text = "Run Test";
			this._RunTest.UseVisualStyleBackColor = true;
			this._RunTest.Click += new System.EventHandler( this._RunTest_Click );
			// 
			// _Memory
			// 
			this._Memory.Location = new System.Drawing.Point( 39, 190 );
			this._Memory.Name = "_Memory";
			this._Memory.Size = new System.Drawing.Size( 160, 20 );
			this._Memory.TabIndex = 4;
			// 
			// _Time
			// 
			this._Time.Location = new System.Drawing.Point( 39, 164 );
			this._Time.Name = "_Time";
			this._Time.Size = new System.Drawing.Size( 160, 20 );
			this._Time.TabIndex = 3;
			// 
			// _Iterations
			// 
			this._Iterations.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._Iterations.FormattingEnabled = true;
			this._Iterations.Items.AddRange( new object[] {
            "100",
            "1000",
            "10000",
            "100000",
            "1000000"} );
			this._Iterations.Location = new System.Drawing.Point( 39, 32 );
			this._Iterations.Name = "_Iterations";
			this._Iterations.Size = new System.Drawing.Size( 160, 21 );
			this._Iterations.TabIndex = 0;
			this._Iterations.SelectedIndexChanged += new System.EventHandler( this._Iterations_SelectedIndexChanged );
			this._Iterations.TextUpdate += new System.EventHandler( this._Iterations_TextUpdate );
			// 
			// _AddEventHandler
			// 
			this._AddEventHandler.AutoSize = true;
			this._AddEventHandler.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._AddEventHandler.Location = new System.Drawing.Point( 39, 59 );
			this._AddEventHandler.Name = "_AddEventHandler";
			this._AddEventHandler.Size = new System.Drawing.Size( 122, 18 );
			this._AddEventHandler.TabIndex = 1;
			this._AddEventHandler.Text = "Add Event Handler";
			this._AddEventHandler.UseVisualStyleBackColor = true;
			this._AddEventHandler.CheckedChanged += new System.EventHandler( this._AddEventHandler_CheckedChanged );
			// 
			// ModeMemory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.Controls.Add( this._AddEventHandler );
			this.Controls.Add( this._Iterations );
			this.Controls.Add( this._Time );
			this.Controls.Add( this._Memory );
			this.Controls.Add( this._RunTest );
			this.Name = "ModeMemory";
			this.Size = new System.Drawing.Size( 238, 317 );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _RunTest;
		private System.Windows.Forms.TextBox _Memory;
		private System.Windows.Forms.TextBox _Time;
		private System.Windows.Forms.ComboBox _Iterations;
		private System.Windows.Forms.CheckBox _AddEventHandler;
	}
}
