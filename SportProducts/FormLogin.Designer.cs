namespace SportProducts
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            pictureBoxLogo = new PictureBox();
            buttonLogin = new Button();
            buttonGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(145, 177);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(178, 26);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 268);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(178, 26);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(208, 135);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(52, 19);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(205, 226);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(58, 19);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Icon;
            pictureBoxLogo.Location = new Point(184, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 97, 238);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(167, 317);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(135, 37);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(67, 97, 238);
            buttonGuest.FlatAppearance.BorderSize = 0;
            buttonGuest.FlatStyle = FlatStyle.Flat;
            buttonGuest.ForeColor = Color.White;
            buttonGuest.Location = new Point(167, 377);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(135, 37);
            buttonGuest.TabIndex = 6;
            buttonGuest.Text = "Гость";
            buttonGuest.UseVisualStyleBackColor = false;
            buttonGuest.Click += ButtonGuest_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(buttonGuest);
            Controls.Add(buttonLogin);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private Label labelPassword;
        private PictureBox pictureBoxLogo;
        private Button buttonLogin;
        private Button buttonGuest;
    }
}
