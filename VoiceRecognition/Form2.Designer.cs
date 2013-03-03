namespace VoiceRecognition
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grammar_tree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.word_confidence_text = new System.Windows.Forms.TextBox();
            this.Recognized_words_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grammar_tree
            // 
            this.grammar_tree.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.grammar_tree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grammar_tree.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grammar_tree.Location = new System.Drawing.Point(12, 25);
            this.grammar_tree.Name = "grammar_tree";
            this.grammar_tree.Size = new System.Drawing.Size(165, 271);
            this.grammar_tree.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(11, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(92, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grammar Tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Word Confidence";
            // 
            // word_confidence_text
            // 
            this.word_confidence_text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.word_confidence_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.word_confidence_text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.word_confidence_text.Location = new System.Drawing.Point(183, 25);
            this.word_confidence_text.Name = "word_confidence_text";
            this.word_confidence_text.Size = new System.Drawing.Size(164, 20);
            this.word_confidence_text.TabIndex = 6;
            // 
            // Recognized_words_text
            // 
            this.Recognized_words_text.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Recognized_words_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Recognized_words_text.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Recognized_words_text.Location = new System.Drawing.Point(183, 64);
            this.Recognized_words_text.Multiline = true;
            this.Recognized_words_text.Name = "Recognized_words_text";
            this.Recognized_words_text.Size = new System.Drawing.Size(164, 232);
            this.Recognized_words_text.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recognized Words";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(359, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Recognized_words_text);
            this.Controls.Add(this.word_confidence_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grammar_tree);
            this.Enabled = false;
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView grammar_tree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox word_confidence_text;
        private System.Windows.Forms.TextBox Recognized_words_text;
        private System.Windows.Forms.Label label4;
    }
}