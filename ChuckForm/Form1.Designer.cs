
namespace ChuckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBTN = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokeBTN
            // 
            this.getJokeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getJokeBTN.Location = new System.Drawing.Point(233, 175);
            this.getJokeBTN.Name = "getJokeBTN";
            this.getJokeBTN.Size = new System.Drawing.Size(75, 23);
            this.getJokeBTN.TabIndex = 0;
            this.getJokeBTN.Text = "Get Joke!";
            this.getJokeBTN.UseVisualStyleBackColor = true;
            this.getJokeBTN.Click += new System.EventHandler(this.getJokeBTN_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(12, 12);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(296, 157);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke, I dare you!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 334);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.getJokeBTN);
            this.Name = "Form1";
            this.Text = "Chuck Norris Jokes Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBTN;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

