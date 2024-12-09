namespace GameLab3
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
            this.GameStatusLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Player1Label2 = new System.Windows.Forms.Label();
            this.Player2Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameStatusLabel1
            // 
            this.GameStatusLabel1.AutoSize = true;
            this.GameStatusLabel1.Location = new System.Drawing.Point(753, 9);
            this.GameStatusLabel1.Name = "GameStatusLabel1";
            this.GameStatusLabel1.Size = new System.Drawing.Size(35, 13);
            this.GameStatusLabel1.TabIndex = 3;
            this.GameStatusLabel1.Text = "label1";
            this.GameStatusLabel1.Click += new System.EventHandler(this.GameStatusLabel1_Click);

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "StartGameButton ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "SaveGameButton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "LoadGameButton ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Player1Label2
            // 
            this.Player1Label2.AutoSize = true;
            this.Player1Label2.Location = new System.Drawing.Point(297, 123);
            this.Player1Label2.Name = "Player1Label2";
            this.Player1Label2.Size = new System.Drawing.Size(35, 13);
            this.Player1Label2.TabIndex = 4;
            this.Player1Label2.Text = "label2";
            // 
            // Player2Label2
            // 
            this.Player2Label2.AutoSize = true;
            this.Player2Label2.Location = new System.Drawing.Point(415, 123);
            this.Player2Label2.Name = "Player2Label2";
            this.Player2Label2.Size = new System.Drawing.Size(35, 13);
            this.Player2Label2.TabIndex = 5;
            this.Player2Label2.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2Label2);
            this.Controls.Add(this.Player1Label2);
            this.Controls.Add(this.GameStatusLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Player1Label2;
        private System.Windows.Forms.Label Player2Label2;
    }
}