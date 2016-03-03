namespace TW.CashRegister.UI
{
    partial class CashRegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ddlPromotions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.btnSeeting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeeting);
            this.groupBox1.Controls.Add(this.lbProducts);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ddlPromotions);
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Location = new System.Drawing.Point(30, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置活动商品";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(335, 81);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(566, 160);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "[{\"PromotionID\": \"PromotionDiscount_0.95\"\", \"ProductID\" : [\"ITEM000001\",\"ITEM0000" +
    "03\"]},{\"PromotionID\": \"PromotionFree_2_f_1\"\", \"ProductID\" : [\"ITEM000005\"]}]";
            this.txtContent.TextChanged += new System.EventHandler(this.txtPromationSetting_TextChanged);
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 17);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(272, 392);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "[\r\n    \'ITEM000001\',\r\n    \'ITEM000001\',\r\n    \'ITEM000001\',\r\n    \'ITEM000001\',\r\n  " +
    "  \'ITEM000001\',\r\n    \'ITEM000003-2\',\r\n    \'ITEM000005\',\r\n    \'ITEM000005\',\r\n    " +
    "\'ITEM000005\'\r\n]\r\n";
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Location = new System.Drawing.Point(33, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 412);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Location = new System.Drawing.Point(387, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 409);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoce";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 17);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(566, 389);
            this.txtOutput.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(36, 290);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ddlPromotions
            // 
            this.ddlPromotions.FormattingEnabled = true;
            this.ddlPromotions.Location = new System.Drawing.Point(94, 31);
            this.ddlPromotions.Name = "ddlPromotions";
            this.ddlPromotions.Size = new System.Drawing.Size(121, 20);
            this.ddlPromotions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "活动";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(35, 91);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(53, 12);
            this.lblProducts.TabIndex = 5;
            this.lblProducts.Text = "商品列表";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 12;
            this.lbProducts.Location = new System.Drawing.Point(94, 81);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProducts.Size = new System.Drawing.Size(173, 160);
            this.lbProducts.TabIndex = 6;
            // 
            // btnSeeting
            // 
            this.btnSeeting.Location = new System.Drawing.Point(335, 28);
            this.btnSeeting.Name = "btnSeeting";
            this.btnSeeting.Size = new System.Drawing.Size(75, 23);
            this.btnSeeting.TabIndex = 7;
            this.btnSeeting.Text = "设置";
            this.btnSeeting.UseVisualStyleBackColor = true;
            this.btnSeeting.Click += new System.EventHandler(this.btnSeeting_Click);
            // 
            // CashRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashRegisterForm";
            this.Text = "收银机";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSeeting;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlPromotions;
    }
}

