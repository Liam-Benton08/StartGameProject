namespace StartGameProject
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
            this.startgameButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startgameButton
            // 
            this.startgameButton.BackColor = System.Drawing.Color.Black;
            this.startgameButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgameButton.ForeColor = System.Drawing.Color.White;
            this.startgameButton.Location = new System.Drawing.Point(210, 150);
            this.startgameButton.Name = "startgameButton";
            this.startgameButton.Size = new System.Drawing.Size(393, 148);
            this.startgameButton.TabIndex = 0;
            this.startgameButton.Text = "Start Game";
            this.startgameButton.UseVisualStyleBackColor = false;
            this.startgameButton.Click += new System.EventHandler(this.startganeButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(1000, 1000);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(454, 60);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Game starting in 3...";
            // 
            // outputLabel2
            // 
            this.outputLabel2.BackColor = System.Drawing.Color.LimeGreen;
            this.outputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel2.Location = new System.Drawing.Point(1000, 1000);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(176, 125);
            this.outputLabel2.TabIndex = 2;
            this.outputLabel2.Text = "Go";
            this.outputLabel2.Click += new System.EventHandler(this.outputLabel2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(210, 205);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(393, 40);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(830, 474);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startgameButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YOOOO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgameButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

