namespace Task1_WF
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
            lblValue = new Label();
            lblResult = new Label();
            txtbValue = new TextBox();
            txtbResult = new TextBox();
            panel1 = new Panel();
            lablpanel = new Label();
            raidobtnMTMeter = new RadioButton();
            radiobtnMTMile = new RadioButton();
            radiobtnMTKilo = new RadioButton();
            btnConvert = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblValue.Location = new Point(69, 114);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(55, 19);
            lblValue.TabIndex = 0;
            lblValue.Text = "Value:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(69, 198);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 19);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // txtbValue
            // 
            txtbValue.Location = new Point(161, 114);
            txtbValue.Name = "txtbValue";
            txtbValue.Size = new Size(140, 27);
            txtbValue.TabIndex = 2;
            txtbValue.TextChanged += txtbValue_TextChanged;
            // 
            // txtbResult
            // 
            txtbResult.Location = new Point(161, 194);
            txtbResult.Name = "txtbResult";
            txtbResult.ReadOnly = true;
            txtbResult.ScrollBars = ScrollBars.Horizontal;
            txtbResult.Size = new Size(140, 27);
            txtbResult.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(lablpanel);
            panel1.Controls.Add(raidobtnMTMeter);
            panel1.Controls.Add(radiobtnMTMile);
            panel1.Controls.Add(radiobtnMTKilo);
            panel1.Location = new Point(380, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 191);
            panel1.TabIndex = 4;
            // 
            // lablpanel
            // 
            lablpanel.AutoSize = true;
            lablpanel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lablpanel.ForeColor = Color.Red;
            lablpanel.Location = new Point(21, 89);
            lablpanel.Name = "lablpanel";
            lablpanel.Size = new Size(106, 19);
            lablpanel.TabIndex = 5;
            lablpanel.Text = "Choose Unit:";
            // 
            // raidobtnMTMeter
            // 
            raidobtnMTMeter.AutoSize = true;
            raidobtnMTMeter.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            raidobtnMTMeter.Location = new Point(163, 143);
            raidobtnMTMeter.Name = "raidobtnMTMeter";
            raidobtnMTMeter.Size = new Size(127, 21);
            raidobtnMTMeter.TabIndex = 2;
            raidobtnMTMeter.TabStop = true;
            raidobtnMTMeter.Text = "Mile To Meter";
            raidobtnMTMeter.UseVisualStyleBackColor = true;
            // 
            // radiobtnMTMile
            // 
            radiobtnMTMile.AutoSize = true;
            radiobtnMTMile.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radiobtnMTMile.Location = new Point(163, 87);
            radiobtnMTMile.Name = "radiobtnMTMile";
            radiobtnMTMile.Size = new Size(127, 21);
            radiobtnMTMile.TabIndex = 1;
            radiobtnMTMile.TabStop = true;
            radiobtnMTMile.Text = "Meter To Mile";
            radiobtnMTMile.UseVisualStyleBackColor = true;
            // 
            // radiobtnMTKilo
            // 
            radiobtnMTKilo.AutoSize = true;
            radiobtnMTKilo.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radiobtnMTKilo.Location = new Point(163, 34);
            radiobtnMTKilo.Name = "radiobtnMTKilo";
            radiobtnMTKilo.Size = new Size(163, 21);
            radiobtnMTKilo.TabIndex = 0;
            radiobtnMTKilo.TabStop = true;
            radiobtnMTKilo.Text = "Meter To Kilometer";
            radiobtnMTKilo.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(0, 192, 0);
            btnConvert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(333, 347);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(panel1);
            Controls.Add(txtbResult);
            Controls.Add(txtbValue);
            Controls.Add(lblResult);
            Controls.Add(lblValue);
            Name = "Form1";
            Text = "Converter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValue;
        private Label lblResult;
        private TextBox txtbValue;
        private TextBox txtbResult;
        private Panel panel1;
        private Label lablpanel;
        private RadioButton raidobtnMTMeter;
        private RadioButton radiobtnMTMile;
        private RadioButton radiobtnMTKilo;
        private Button btnConvert;
    }
}