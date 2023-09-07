namespace Lab2
{
    partial class Form1
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
            lblName = new Label();
            lblEmail = new Label();
            lblHobbies = new Label();
            lblGender = new Label();
            txtBxName = new TextBox();
            txtBxEmail = new TextBox();
            radbtnMale = new RadioButton();
            radbtnFemale = new RadioButton();
            chkBxTennis = new CheckBox();
            chkBxFootball = new CheckBox();
            chkBxSwim = new CheckBox();
            btnRegister = new Button();
            lblMistakeName = new Label();
            lblMistakeEmail = new Label();
            lblMistakeHobbies = new Label();
            lblRegisterSucc = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(22, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(22, 116);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbies.Location = new Point(25, 285);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(81, 23);
            lblHobbies.TabIndex = 2;
            lblHobbies.Text = "Hobbies:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(22, 194);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 23);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender:";
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(87, 54);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(206, 27);
            txtBxName.TabIndex = 4;
            // 
            // txtBxEmail
            // 
            txtBxEmail.Location = new Point(87, 112);
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(206, 27);
            txtBxEmail.TabIndex = 5;
            // 
            // radbtnMale
            // 
            radbtnMale.AutoSize = true;
            radbtnMale.Location = new Point(137, 193);
            radbtnMale.Name = "radbtnMale";
            radbtnMale.Size = new Size(63, 24);
            radbtnMale.TabIndex = 6;
            radbtnMale.TabStop = true;
            radbtnMale.Text = "Male";
            radbtnMale.UseVisualStyleBackColor = true;
            // 
            // radbtnFemale
            // 
            radbtnFemale.AutoSize = true;
            radbtnFemale.Location = new Point(273, 195);
            radbtnFemale.Name = "radbtnFemale";
            radbtnFemale.Size = new Size(78, 24);
            radbtnFemale.TabIndex = 7;
            radbtnFemale.TabStop = true;
            radbtnFemale.Text = "Female";
            radbtnFemale.TextAlign = ContentAlignment.MiddleCenter;
            radbtnFemale.UseVisualStyleBackColor = true;
            // 
            // chkBxTennis
            // 
            chkBxTennis.AutoSize = true;
            chkBxTennis.Location = new Point(278, 286);
            chkBxTennis.Name = "chkBxTennis";
            chkBxTennis.Size = new Size(72, 24);
            chkBxTennis.TabIndex = 8;
            chkBxTennis.Text = "Tennis";
            chkBxTennis.UseVisualStyleBackColor = true;
            // 
            // chkBxFootball
            // 
            chkBxFootball.AutoSize = true;
            chkBxFootball.Location = new Point(137, 285);
            chkBxFootball.Name = "chkBxFootball";
            chkBxFootball.Size = new Size(86, 24);
            chkBxFootball.TabIndex = 9;
            chkBxFootball.Text = "Football";
            chkBxFootball.UseVisualStyleBackColor = true;
            // 
            // chkBxSwim
            // 
            chkBxSwim.AutoSize = true;
            chkBxSwim.Location = new Point(401, 286);
            chkBxSwim.Name = "chkBxSwim";
            chkBxSwim.Size = new Size(101, 24);
            chkBxSwim.TabIndex = 10;
            chkBxSwim.Text = "Swimming";
            chkBxSwim.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(289, 351);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblMistakeName
            // 
            lblMistakeName.AutoSize = true;
            lblMistakeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMistakeName.ForeColor = Color.Red;
            lblMistakeName.Location = new Point(350, 58);
            lblMistakeName.Name = "lblMistakeName";
            lblMistakeName.Size = new Size(0, 20);
            lblMistakeName.TabIndex = 12;
            // 
            // lblMistakeEmail
            // 
            lblMistakeEmail.AutoSize = true;
            lblMistakeEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMistakeEmail.ForeColor = Color.Red;
            lblMistakeEmail.Location = new Point(348, 118);
            lblMistakeEmail.Name = "lblMistakeEmail";
            lblMistakeEmail.Size = new Size(0, 20);
            lblMistakeEmail.TabIndex = 13;
            // 
            // lblMistakeHobbies
            // 
            lblMistakeHobbies.AutoSize = true;
            lblMistakeHobbies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMistakeHobbies.ForeColor = Color.Red;
            lblMistakeHobbies.Location = new Point(529, 289);
            lblMistakeHobbies.Name = "lblMistakeHobbies";
            lblMistakeHobbies.Size = new Size(0, 20);
            lblMistakeHobbies.TabIndex = 14;
            // 
            // lblRegisterSucc
            // 
            lblRegisterSucc.AutoSize = true;
            lblRegisterSucc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegisterSucc.ForeColor = Color.LimeGreen;
            lblRegisterSucc.Location = new Point(223, 406);
            lblRegisterSucc.Name = "lblRegisterSucc";
            lblRegisterSucc.Size = new Size(0, 20);
            lblRegisterSucc.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegisterSucc);
            Controls.Add(lblMistakeHobbies);
            Controls.Add(lblMistakeEmail);
            Controls.Add(lblMistakeName);
            Controls.Add(btnRegister);
            Controls.Add(chkBxSwim);
            Controls.Add(chkBxFootball);
            Controls.Add(chkBxTennis);
            Controls.Add(radbtnFemale);
            Controls.Add(radbtnMale);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxName);
            Controls.Add(lblGender);
            Controls.Add(lblHobbies);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Registeration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMistakeName;
        private Label lblEmail;
        private Label lblName;
        private Label lblHobbies;
        private Label lblGender;
        private TextBox txtBxName;
        private TextBox txtBxEmail;
        private RadioButton radbtnMale;
        private RadioButton radbtnFemale;
        private CheckBox chkBxTennis;
        private CheckBox chkBxFootball;
        private CheckBox chkBxSwim;
        private Button btnRegister;
        private Label lblMistakeEmail;
        private Label lblMistakeHobbies;
        private Label lblRegisterSucc;
    }
}