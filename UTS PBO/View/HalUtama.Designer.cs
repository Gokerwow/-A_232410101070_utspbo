namespace UTS_PBO
{
    partial class HalUtama
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
            btnLogin = new Button();
            btnRegister = new Button();
            btnInventaris = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(302, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 49);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(302, 261);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 49);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnInventaris
            // 
            btnInventaris.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventaris.Location = new Point(302, 178);
            btnInventaris.Name = "btnInventaris";
            btnInventaris.Size = new Size(187, 49);
            btnInventaris.TabIndex = 7;
            btnInventaris.Text = "INVENTARIS";
            btnInventaris.UseVisualStyleBackColor = true;
            btnInventaris.Click += btnInventaris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 114);
            label2.Name = "label2";
            label2.Size = new Size(288, 22);
            label2.TabIndex = 6;
            label2.Text = "Apa Yang Ingin Anda Lakukan?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 54);
            label1.Name = "label1";
            label1.Size = new Size(334, 44);
            label1.TabIndex = 5;
            label1.Text = "SELAMAT DATANG";
            // 
            // HalUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(btnInventaris);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalUtama";
            Text = "HalUtama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnInventaris;
        private Label label2;
        private Label label1;
    }
}