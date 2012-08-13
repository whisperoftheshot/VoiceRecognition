namespace VoiceRecognition
{
    partial class Form1
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
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.commandname = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.computername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.names_list = new System.Windows.Forms.ListBox();
            this.paths_list = new System.Windows.Forms.ListBox();
            this.save_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_button = new System.Windows.Forms.Button();
            this.open_file_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_word_confidence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.start_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.start_button.Location = new System.Drawing.Point(22, 78);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.stop_button.Location = new System.Drawing.Point(103, 78);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 2;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recognized Commands";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Application files|*.exe";
            this.openFileDialog1.Title = "Select File";
            // 
            // commandname
            // 
            this.commandname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.commandname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.commandname.Location = new System.Drawing.Point(25, 276);
            this.commandname.Name = "commandname";
            this.commandname.Size = new System.Drawing.Size(315, 13);
            this.commandname.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.add_button.Location = new System.Drawing.Point(103, 295);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // open_button
            // 
            this.open_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.open_button.Location = new System.Drawing.Point(22, 295);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 6;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Command Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // computername
            // 
            this.computername.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.computername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.computername.Location = new System.Drawing.Point(60, 53);
            this.computername.Name = "computername";
            this.computername.Size = new System.Drawing.Size(219, 16);
            this.computername.TabIndex = 9;
            this.computername.Text = "Computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(291, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Listening";
            this.label4.Visible = false;
            // 
            // names_list
            // 
            this.names_list.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.names_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.names_list.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.names_list.FormattingEnabled = true;
            this.names_list.Location = new System.Drawing.Point(22, 144);
            this.names_list.Name = "names_list";
            this.names_list.Size = new System.Drawing.Size(116, 104);
            this.names_list.TabIndex = 12;
            // 
            // paths_list
            // 
            this.paths_list.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.paths_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paths_list.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.paths_list.FormattingEnabled = true;
            this.paths_list.Location = new System.Drawing.Point(144, 144);
            this.paths_list.MultiColumn = true;
            this.paths_list.Name = "paths_list";
            this.paths_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.paths_list.Size = new System.Drawing.Size(196, 104);
            this.paths_list.TabIndex = 13;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.save_button.Location = new System.Drawing.Point(265, 78);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.delete_button.Location = new System.Drawing.Point(184, 295);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 16;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // open_file_button
            // 
            this.open_file_button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.open_file_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open_file_button.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.open_file_button.Location = new System.Drawing.Point(184, 78);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(75, 23);
            this.open_file_button.TabIndex = 17;
            this.open_file_button.Text = "Load";
            this.open_file_button.UseVisualStyleBackColor = false;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(359, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(359, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Word Confidence";
            // 
            // text_word_confidence
            // 
            this.text_word_confidence.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.text_word_confidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_word_confidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_word_confidence.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.text_word_confidence.Location = new System.Drawing.Point(362, 94);
            this.text_word_confidence.Name = "text_word_confidence";
            this.text_word_confidence.Size = new System.Drawing.Size(103, 16);
            this.text_word_confidence.TabIndex = 20;
            this.text_word_confidence.Text = "0.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(300, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Error";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(490, 337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_word_confidence);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.open_file_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.paths_list);
            this.Controls.Add(this.names_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.computername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.commandname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Speech Launcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox commandname;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox computername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox names_list;
        private System.Windows.Forms.ListBox paths_list;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_word_confidence;
        private System.Windows.Forms.Label label7;
    }
}

