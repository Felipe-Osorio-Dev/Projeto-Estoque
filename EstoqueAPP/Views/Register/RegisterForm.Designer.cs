namespace EstoqueAPP.Views.Register
{
    partial class RegisterForm
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
            dateTimeValidate = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            numericAmount = new NumericUpDown();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            SuspendLayout();
            // 
            // dateTimeValidate
            // 
            dateTimeValidate.Format = DateTimePickerFormat.Short;
            dateTimeValidate.Location = new Point(283, 126);
            dateTimeValidate.MinDate = new DateTime(2026, 6, 29, 0, 0, 0, 0);
            dateTimeValidate.Name = "dateTimeValidate";
            dateTimeValidate.Size = new Size(167, 23);
            dateTimeValidate.TabIndex = 0;
            dateTimeValidate.Value = new DateTime(2026, 6, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            // 
            // numericAmount
            // 
            numericAmount.Location = new Point(48, 126);
            numericAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(167, 23);
            numericAmount.TabIndex = 3;
            numericAmount.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 31);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "EAN:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 108);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 108);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Validade:";
            // 
            // btnRegister
            // 
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Location = new Point(283, 203);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(375, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(494, 251);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(numericAmount);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dateTimeValidate);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeValidate;
        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericAmount;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
        private Button btnCancel;
    }
}