namespace WinFormsAvaliacao2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_num1 = new TextBox();
            txt_num5 = new TextBox();
            txt_num4 = new TextBox();
            txt_num3 = new TextBox();
            txt_num2 = new TextBox();
            txt_estrela2 = new TextBox();
            txt_estrela1 = new TextBox();
            label9 = new Label();
            lbl_chaveVenc = new Label();
            txtbox_info = new TextBox();
            btn_Jogar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 84);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 100;
            label1.Text = "1º Número";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 216);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 104;
            label2.Text = "5º Número";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 183);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 103;
            label3.Text = "4º Número";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 150);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 102;
            label4.Text = "3º Número";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 117);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 101;
            label5.Text = "2º Número";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(18, 7);
            label6.Name = "label6";
            label6.Size = new Size(154, 63);
            label6.TabIndex = 5;
            label6.Text = "Insira a sua aposta:\r\nnúmeros de 1 a 50\r\nestrelas de 1 a 12";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 289);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 106;
            label7.Text = "2ª Estrela";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 259);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 105;
            label8.Text = "1ª Estrela";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(120, 84);
            txt_num1.Margin = new Padding(3, 2, 3, 2);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(29, 23);
            txt_num1.TabIndex = 0;
            txt_num1.KeyPress += txt_num1_KeyPress;
            // 
            // txt_num5
            // 
            txt_num5.Enabled = false;
            txt_num5.Location = new Point(120, 216);
            txt_num5.Margin = new Padding(3, 2, 3, 2);
            txt_num5.Name = "txt_num5";
            txt_num5.Size = new Size(29, 23);
            txt_num5.TabIndex = 4;
            txt_num5.KeyPress += txt_num5_KeyPress;
            // 
            // txt_num4
            // 
            txt_num4.Enabled = false;
            txt_num4.Location = new Point(120, 183);
            txt_num4.Margin = new Padding(3, 2, 3, 2);
            txt_num4.Name = "txt_num4";
            txt_num4.Size = new Size(29, 23);
            txt_num4.TabIndex = 3;
            txt_num4.KeyPress += txt_num4_KeyPress;
            // 
            // txt_num3
            // 
            txt_num3.Enabled = false;
            txt_num3.Location = new Point(120, 150);
            txt_num3.Margin = new Padding(3, 2, 3, 2);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(29, 23);
            txt_num3.TabIndex = 2;
            txt_num3.KeyPress += txt_num3_KeyPress;
            // 
            // txt_num2
            // 
            txt_num2.Enabled = false;
            txt_num2.Location = new Point(120, 117);
            txt_num2.Margin = new Padding(3, 2, 3, 2);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(29, 23);
            txt_num2.TabIndex = 1;
            txt_num2.KeyPress += txt_num2_KeyPress;
            // 
            // txt_estrela2
            // 
            txt_estrela2.Enabled = false;
            txt_estrela2.Location = new Point(120, 289);
            txt_estrela2.Margin = new Padding(3, 2, 3, 2);
            txt_estrela2.Name = "txt_estrela2";
            txt_estrela2.Size = new Size(29, 23);
            txt_estrela2.TabIndex = 6;
            txt_estrela2.KeyPress += txt_estrela2_KeyPress;
            // 
            // txt_estrela1
            // 
            txt_estrela1.Enabled = false;
            txt_estrela1.Location = new Point(120, 259);
            txt_estrela1.Margin = new Padding(3, 2, 3, 2);
            txt_estrela1.Name = "txt_estrela1";
            txt_estrela1.Size = new Size(29, 23);
            txt_estrela1.TabIndex = 5;
            txt_estrela1.KeyPress += txt_estrela1_KeyPress;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(266, 12);
            label9.Name = "label9";
            label9.Size = new Size(186, 42);
            label9.TabIndex = 15;
            label9.Text = "A chave vencedora é:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_chaveVenc
            // 
            lbl_chaveVenc.BackColor = SystemColors.ActiveBorder;
            lbl_chaveVenc.Enabled = false;
            lbl_chaveVenc.ForeColor = Color.DarkGreen;
            lbl_chaveVenc.Location = new Point(458, 12);
            lbl_chaveVenc.Name = "lbl_chaveVenc";
            lbl_chaveVenc.Size = new Size(214, 42);
            lbl_chaveVenc.TabIndex = 16;
            // 
            // txtbox_info
            // 
            txtbox_info.Location = new Point(266, 81);
            txtbox_info.Margin = new Padding(3, 2, 3, 2);
            txtbox_info.Multiline = true;
            txtbox_info.Name = "txtbox_info";
            txtbox_info.Size = new Size(406, 228);
            txtbox_info.TabIndex = 17;
            // 
            // btn_Jogar
            // 
            btn_Jogar.BackColor = Color.Transparent;
            btn_Jogar.BackgroundImageLayout = ImageLayout.None;
            btn_Jogar.Enabled = false;
            btn_Jogar.FlatStyle = FlatStyle.System;
            btn_Jogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Jogar.Location = new Point(180, 84);
            btn_Jogar.Margin = new Padding(3, 2, 3, 2);
            btn_Jogar.Name = "btn_Jogar";
            btn_Jogar.Size = new Size(66, 228);
            btn_Jogar.TabIndex = 7;
            btn_Jogar.Text = "J\r\nO\r\nG\r\nA\r\nR";
            btn_Jogar.UseVisualStyleBackColor = false;
            btn_Jogar.Click += btn_Jogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 320);
            Controls.Add(btn_Jogar);
            Controls.Add(txtbox_info);
            Controls.Add(lbl_chaveVenc);
            Controls.Add(label9);
            Controls.Add(txt_estrela1);
            Controls.Add(txt_estrela2);
            Controls.Add(txt_num2);
            Controls.Add(txt_num3);
            Controls.Add(txt_num4);
            Controls.Add(txt_num5);
            Controls.Add(txt_num1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_num1;
        private TextBox txt_num5;
        private TextBox txt_num4;
        private TextBox txt_num3;
        private TextBox txt_num2;
        private TextBox txt_estrela2;
        private TextBox txt_estrela1;
        private Label label9;
        private Label lbl_chaveVenc;
        private TextBox txtbox_info;
        private Button btn_Jogar;
    }
}
