
namespace Magic_8_Ball
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
            this.title = new System.Windows.Forms.Label();
            this.button8Ball = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(120, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 44);
            this.title.TabIndex = 0;
            this.title.Text = "Think of a Question";
            // 
            // button8Ball
            // 
            this.button8Ball.BackgroundImage = global::Magic_8_Ball.Properties.Resources._8ball;
            this.button8Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8Ball.FlatAppearance.BorderSize = 0;
            this.button8Ball.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8Ball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8Ball.Location = new System.Drawing.Point(126, 80);
            this.button8Ball.Name = "button8Ball";
            this.button8Ball.Size = new System.Drawing.Size(236, 237);
            this.button8Ball.TabIndex = 1;
            this.button8Ball.UseVisualStyleBackColor = true;
            this.button8Ball.Click += new System.EventHandler(this.button8Ball_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(126, 335);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(236, 44);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(476, 454);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button8Ball);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button8Ball;
        private System.Windows.Forms.Label outputLabel;
    }
}

