namespace UI.FormFill
{
    partial class FormTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valuePassportCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.valuePlace = new System.Windows.Forms.NumericUpDown();
            this.valuePrice = new System.Windows.Forms.NumericUpDown();
            this.valueDate = new System.Windows.Forms.DateTimePicker();
            this.valueCredits = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.valuePlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время";
            // 
            // valueFullName
            // 
            this.valueFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueFullName.Location = new System.Drawing.Point(172, 119);
            this.valueFullName.Name = "valueFullName";
            this.valueFullName.Size = new System.Drawing.Size(336, 29);
            this.valueFullName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // valuePassportCode
            // 
            this.valuePassportCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuePassportCode.Location = new System.Drawing.Point(172, 153);
            this.valuePassportCode.Name = "valuePassportCode";
            this.valuePassportCode.Size = new System.Drawing.Size(336, 29);
            this.valuePassportCode.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Код паспорта";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(496, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // valuePlace
            // 
            this.valuePlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuePlace.Location = new System.Drawing.Point(172, 12);
            this.valuePlace.Name = "valuePlace";
            this.valuePlace.Size = new System.Drawing.Size(83, 29);
            this.valuePlace.TabIndex = 12;
            // 
            // valuePrice
            // 
            this.valuePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuePrice.Location = new System.Drawing.Point(172, 47);
            this.valuePrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.valuePrice.Name = "valuePrice";
            this.valuePrice.Size = new System.Drawing.Size(83, 29);
            this.valuePrice.TabIndex = 13;
            // 
            // valueDate
            // 
            this.valueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueDate.Location = new System.Drawing.Point(172, 82);
            this.valueDate.Name = "valueDate";
            this.valueDate.Size = new System.Drawing.Size(200, 29);
            this.valueDate.TabIndex = 14;
            // 
            // valueCredits
            // 
            this.valueCredits.AutoSize = true;
            this.valueCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueCredits.Location = new System.Drawing.Point(172, 188);
            this.valueCredits.Name = "valueCredits";
            this.valueCredits.Size = new System.Drawing.Size(81, 25);
            this.valueCredits.TabIndex = 15;
            this.valueCredits.Text = "Льготы";
            this.valueCredits.UseVisualStyleBackColor = true;
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 275);
            this.Controls.Add(this.valueCredits);
            this.Controls.Add(this.valueDate);
            this.Controls.Add(this.valuePrice);
            this.Controls.Add(this.valuePlace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.valuePassportCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valueFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            ((System.ComponentModel.ISupportInitialize)(this.valuePlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox valueFullName;
        private Label label4;
        private Label label2;
        private TextBox valuePassportCode;
        private Label label6;
        private Button btnAdd;
        private NumericUpDown valuePlace;
        private NumericUpDown valuePrice;
        private DateTimePicker valueDate;
        private CheckBox valueCredits;
    }
}