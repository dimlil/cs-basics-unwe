namespace homework_9
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
            this.txt_FN = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.lbl_BGR = new System.Windows.Forms.Label();
            this.lbl_USD = new System.Windows.Forms.Label();
            this.lbl_EUR = new System.Windows.Forms.Label();
            this.lbl_BGN = new System.Windows.Forms.Label();
            this.txt_GBR = new System.Windows.Forms.TextBox();
            this.txt_USD = new System.Windows.Forms.TextBox();
            this.txt_EUR = new System.Windows.Forms.TextBox();
            this.txt_BGN = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_FN
            // 
            this.txt_FN.Enabled = false;
            this.txt_FN.Location = new System.Drawing.Point(537, 35);
            this.txt_FN.Name = "txt_FN";
            this.txt_FN.Size = new System.Drawing.Size(122, 20);
            this.txt_FN.TabIndex = 0;
            this.txt_FN.Text = "21180105";
            this.txt_FN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(122, 107);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 1;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(83, 110);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(33, 13);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Text = "Сума";
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Location = new System.Drawing.Point(484, 107);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(42, 13);
            this.lbl_currency.TabIndex = 3;
            this.lbl_currency.Text = "Валута";
            // 
            // comboBox_currency
            // 
            this.comboBox_currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_currency.FormattingEnabled = true;
            this.comboBox_currency.Items.AddRange(new object[] {
            "BGN",
            "EUR",
            "USD",
            "GBR"});
            this.comboBox_currency.Location = new System.Drawing.Point(537, 104);
            this.comboBox_currency.Name = "comboBox_currency";
            this.comboBox_currency.Size = new System.Drawing.Size(122, 21);
            this.comboBox_currency.TabIndex = 4;
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.lbl_BGR);
            this.groupBox_result.Controls.Add(this.lbl_USD);
            this.groupBox_result.Controls.Add(this.lbl_EUR);
            this.groupBox_result.Controls.Add(this.lbl_BGN);
            this.groupBox_result.Controls.Add(this.txt_GBR);
            this.groupBox_result.Controls.Add(this.txt_USD);
            this.groupBox_result.Controls.Add(this.txt_EUR);
            this.groupBox_result.Controls.Add(this.txt_BGN);
            this.groupBox_result.Location = new System.Drawing.Point(55, 168);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(200, 157);
            this.groupBox_result.TabIndex = 5;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Резултат";
            // 
            // lbl_BGR
            // 
            this.lbl_BGR.AutoSize = true;
            this.lbl_BGR.Location = new System.Drawing.Point(28, 115);
            this.lbl_BGR.Name = "lbl_BGR";
            this.lbl_BGR.Size = new System.Drawing.Size(30, 13);
            this.lbl_BGR.TabIndex = 12;
            this.lbl_BGR.Text = "BGR";
            // 
            // lbl_USD
            // 
            this.lbl_USD.AutoSize = true;
            this.lbl_USD.Location = new System.Drawing.Point(28, 89);
            this.lbl_USD.Name = "lbl_USD";
            this.lbl_USD.Size = new System.Drawing.Size(30, 13);
            this.lbl_USD.TabIndex = 11;
            this.lbl_USD.Text = "USD";
            // 
            // lbl_EUR
            // 
            this.lbl_EUR.AutoSize = true;
            this.lbl_EUR.Location = new System.Drawing.Point(28, 63);
            this.lbl_EUR.Name = "lbl_EUR";
            this.lbl_EUR.Size = new System.Drawing.Size(30, 13);
            this.lbl_EUR.TabIndex = 10;
            this.lbl_EUR.Text = "EUR";
            // 
            // lbl_BGN
            // 
            this.lbl_BGN.AutoSize = true;
            this.lbl_BGN.Location = new System.Drawing.Point(28, 37);
            this.lbl_BGN.Name = "lbl_BGN";
            this.lbl_BGN.Size = new System.Drawing.Size(30, 13);
            this.lbl_BGN.TabIndex = 6;
            this.lbl_BGN.Text = "BGN";
            // 
            // txt_GBR
            // 
            this.txt_GBR.Enabled = false;
            this.txt_GBR.Location = new System.Drawing.Point(67, 112);
            this.txt_GBR.Name = "txt_GBR";
            this.txt_GBR.Size = new System.Drawing.Size(100, 20);
            this.txt_GBR.TabIndex = 9;
            this.txt_GBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_USD
            // 
            this.txt_USD.Enabled = false;
            this.txt_USD.Location = new System.Drawing.Point(67, 86);
            this.txt_USD.Name = "txt_USD";
            this.txt_USD.Size = new System.Drawing.Size(100, 20);
            this.txt_USD.TabIndex = 8;
            this.txt_USD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EUR
            // 
            this.txt_EUR.Enabled = false;
            this.txt_EUR.Location = new System.Drawing.Point(67, 60);
            this.txt_EUR.Name = "txt_EUR";
            this.txt_EUR.Size = new System.Drawing.Size(100, 20);
            this.txt_EUR.TabIndex = 7;
            this.txt_EUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BGN
            // 
            this.txt_BGN.Enabled = false;
            this.txt_BGN.Location = new System.Drawing.Point(67, 34);
            this.txt_BGN.Name = "txt_BGN";
            this.txt_BGN.Size = new System.Drawing.Size(100, 20);
            this.txt_BGN.TabIndex = 6;
            this.txt_BGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(537, 195);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(122, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Изчисли";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(537, 231);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Изчисти";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.comboBox_currency);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_FN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FN;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.TextBox txt_BGN;
        private System.Windows.Forms.Label lbl_BGN;
        private System.Windows.Forms.TextBox txt_GBR;
        private System.Windows.Forms.TextBox txt_USD;
        private System.Windows.Forms.TextBox txt_EUR;
        private System.Windows.Forms.Label lbl_BGR;
        private System.Windows.Forms.Label lbl_USD;
        private System.Windows.Forms.Label lbl_EUR;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear;
    }
}

