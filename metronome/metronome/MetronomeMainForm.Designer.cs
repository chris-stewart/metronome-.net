namespace metronome
{
	partial class MetronomeMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.timeSigBox = new System.Windows.Forms.TextBox();
            this.tempoBox = new System.Windows.Forms.TextBox();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.timeSigLabelLeft = new System.Windows.Forms.Label();
            this.tempoLabelLeft = new System.Windows.Forms.Label();
            this.measureLabelLeft = new System.Windows.Forms.Label();
            this.timeSigLabelRight = new System.Windows.Forms.Label();
            this.tempoLabelRight = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.songOrderBox = new System.Windows.Forms.ListBox();
            this.stop_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.measureLabelRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeSigBox
            // 
            this.timeSigBox.Location = new System.Drawing.Point(87, 12);
            this.timeSigBox.Name = "timeSigBox";
            this.timeSigBox.Size = new System.Drawing.Size(100, 20);
            this.timeSigBox.TabIndex = 0;
            // 
            // tempoBox
            // 
            this.tempoBox.Location = new System.Drawing.Point(87, 41);
            this.tempoBox.Name = "tempoBox";
            this.tempoBox.Size = new System.Drawing.Size(100, 20);
            this.tempoBox.TabIndex = 1;
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(87, 67);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(100, 20);
            this.measureBox.TabIndex = 2;
            // 
            // timeSigLabelLeft
            // 
            this.timeSigLabelLeft.AutoSize = true;
            this.timeSigLabelLeft.Location = new System.Drawing.Point(3, 15);
            this.timeSigLabelLeft.Name = "timeSigLabelLeft";
            this.timeSigLabelLeft.Size = new System.Drawing.Size(78, 13);
            this.timeSigLabelLeft.TabIndex = 3;
            this.timeSigLabelLeft.Text = "Time Signature";
            // 
            // tempoLabelLeft
            // 
            this.tempoLabelLeft.AutoSize = true;
            this.tempoLabelLeft.Location = new System.Drawing.Point(41, 44);
            this.tempoLabelLeft.Name = "tempoLabelLeft";
            this.tempoLabelLeft.Size = new System.Drawing.Size(40, 13);
            this.tempoLabelLeft.TabIndex = 4;
            this.tempoLabelLeft.Text = "Tempo";
            // 
            // measureLabelLeft
            // 
            this.measureLabelLeft.AutoSize = true;
            this.measureLabelLeft.Location = new System.Drawing.Point(28, 70);
            this.measureLabelLeft.Name = "measureLabelLeft";
            this.measureLabelLeft.Size = new System.Drawing.Size(53, 13);
            this.measureLabelLeft.TabIndex = 5;
            this.measureLabelLeft.Text = "Measures";
            // 
            // timeSigLabelRight
            // 
            this.timeSigLabelRight.AutoSize = true;
            this.timeSigLabelRight.Location = new System.Drawing.Point(193, 15);
            this.timeSigLabelRight.Name = "timeSigLabelRight";
            this.timeSigLabelRight.Size = new System.Drawing.Size(21, 13);
            this.timeSigLabelRight.TabIndex = 6;
            this.timeSigLabelRight.Text = "/ 4";
            // 
            // tempoLabelRight
            // 
            this.tempoLabelRight.AutoSize = true;
            this.tempoLabelRight.Location = new System.Drawing.Point(193, 44);
            this.tempoLabelRight.Name = "tempoLabelRight";
            this.tempoLabelRight.Size = new System.Drawing.Size(27, 13);
            this.tempoLabelRight.TabIndex = 7;
            this.tempoLabelRight.Text = "bpm";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(98, 93);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add Section";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // play_button
            // 
            this.play_button.Location = new System.Drawing.Point(261, 98);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(75, 23);
            this.play_button.TabIndex = 9;
            this.play_button.Text = "Play song!";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // songOrderBox
            // 
            this.songOrderBox.FormattingEnabled = true;
            this.songOrderBox.Location = new System.Drawing.Point(12, 187);
            this.songOrderBox.Name = "songOrderBox";
            this.songOrderBox.Size = new System.Drawing.Size(243, 134);
            this.songOrderBox.TabIndex = 10;
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(248, 127);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(105, 23);
            this.stop_button.TabIndex = 11;
            this.stop_button.Text = "Stop this racket!";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(261, 298);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 12;
            this.reset_button.Text = "Reset Song";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove Selected Section";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // measureLabelRight
            // 
            this.measureLabelRight.AutoSize = true;
            this.measureLabelRight.Location = new System.Drawing.Point(194, 73);
            this.measureLabelRight.Name = "measureLabelRight";
            this.measureLabelRight.Size = new System.Drawing.Size(0, 13);
            this.measureLabelRight.TabIndex = 14;
            // 
            // MetronomeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 326);
            this.Controls.Add(this.measureLabelRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.songOrderBox);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.tempoLabelRight);
            this.Controls.Add(this.timeSigLabelRight);
            this.Controls.Add(this.measureLabelLeft);
            this.Controls.Add(this.tempoLabelLeft);
            this.Controls.Add(this.timeSigLabelLeft);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.tempoBox);
            this.Controls.Add(this.timeSigBox);
            this.Name = "MetronomeMainForm";
            this.Text = "Drummer\'s Metronome";
            this.Load += new System.EventHandler(this.MetronomeMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox timeSigBox;
		private System.Windows.Forms.TextBox tempoBox;
		private System.Windows.Forms.TextBox measureBox;
		private System.Windows.Forms.Label timeSigLabelLeft;
		private System.Windows.Forms.Label tempoLabelLeft;
		private System.Windows.Forms.Label measureLabelLeft;
		private System.Windows.Forms.Label timeSigLabelRight;
		private System.Windows.Forms.Label tempoLabelRight;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button play_button;
		private System.Windows.Forms.ListBox songOrderBox;
		private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label measureLabelRight;
	}
}

