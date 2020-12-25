namespace SuperShopMainV1._00.ui_ux_Desingn
{
    partial class PaymentConfirmationForm
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
            System.Windows.Forms.Label paytotal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentConfirmationForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.paymentconfirm = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paycusto = new System.Windows.Forms.Label();
            this.paycustomername = new System.Windows.Forms.TextBox();
            this.paymentmethodlebel = new System.Windows.Forms.Label();
            this.paymentmethodselector = new System.Windows.Forms.ComboBox();
            this.confirmpaymentbtn = new System.Windows.Forms.Label();
            paytotal = new System.Windows.Forms.Label();
            this.paymentconfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 516);
            this.listBox1.TabIndex = 0;
            // 
            // paymentconfirm
            // 
            this.paymentconfirm.BackColor = System.Drawing.Color.Transparent;
            this.paymentconfirm.Controls.Add(this.paycustomername);
            this.paymentconfirm.Controls.Add(this.paycusto);
            this.paymentconfirm.Controls.Add(this.textBox1);
            this.paymentconfirm.Controls.Add(paytotal);
            this.paymentconfirm.Location = new System.Drawing.Point(313, 0);
            this.paymentconfirm.Name = "paymentconfirm";
            this.paymentconfirm.Size = new System.Drawing.Size(373, 224);
            this.paymentconfirm.TabIndex = 1;
            // 
            // paytotal
            // 
            paytotal.AutoSize = true;
            paytotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            paytotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paytotal.ForeColor = System.Drawing.Color.Black;
            paytotal.Location = new System.Drawing.Point(3, 36);
            paytotal.Name = "paytotal";
            paytotal.Size = new System.Drawing.Size(118, 37);
            paytotal.TabIndex = 0;
            paytotal.Text = "TOTAL:";
            paytotal.Click += new System.EventHandler(this.paytotal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 36);
            this.textBox1.TabIndex = 1;
            // 
            // paycusto
            // 
            this.paycusto.AutoSize = true;
            this.paycusto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paycusto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paycusto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paycusto.Location = new System.Drawing.Point(3, 93);
            this.paycusto.Name = "paycusto";
            this.paycusto.Size = new System.Drawing.Size(166, 24);
            this.paycusto.TabIndex = 2;
            this.paycusto.Text = "Customer Name:";
            // 
            // paycustomername
            // 
            this.paycustomername.Location = new System.Drawing.Point(3, 120);
            this.paycustomername.Name = "paycustomername";
            this.paycustomername.Size = new System.Drawing.Size(308, 20);
            this.paycustomername.TabIndex = 3;
            // 
            // paymentmethodlebel
            // 
            this.paymentmethodlebel.AutoSize = true;
            this.paymentmethodlebel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentmethodlebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentmethodlebel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paymentmethodlebel.Location = new System.Drawing.Point(313, 247);
            this.paymentmethodlebel.Name = "paymentmethodlebel";
            this.paymentmethodlebel.Size = new System.Drawing.Size(229, 24);
            this.paymentmethodlebel.TabIndex = 4;
            this.paymentmethodlebel.Text = "Select Payment Method";
            // 
            // paymentmethodselector
            // 
            this.paymentmethodselector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentmethodselector.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymentmethodselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentmethodselector.FormattingEnabled = true;
            this.paymentmethodselector.Items.AddRange(new object[] {
            "BKASH",
            "DBBL",
            "VISA",
            "MASTER",
            "CASH"});
            this.paymentmethodselector.Location = new System.Drawing.Point(313, 274);
            this.paymentmethodselector.Name = "paymentmethodselector";
            this.paymentmethodselector.Size = new System.Drawing.Size(301, 21);
            this.paymentmethodselector.TabIndex = 9;
            // 
            // confirmpaymentbtn
            // 
            this.confirmpaymentbtn.AutoSize = true;
            this.confirmpaymentbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmpaymentbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpaymentbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmpaymentbtn.Location = new System.Drawing.Point(529, 441);
            this.confirmpaymentbtn.Name = "confirmpaymentbtn";
            this.confirmpaymentbtn.Size = new System.Drawing.Size(144, 41);
            this.confirmpaymentbtn.TabIndex = 4;
            this.confirmpaymentbtn.Text = "Confirm";
            // 
            // PaymentConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperShopMainV1._00.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(698, 516);
            this.Controls.Add(this.confirmpaymentbtn);
            this.Controls.Add(this.paymentmethodselector);
            this.Controls.Add(this.paymentmethodlebel);
            this.Controls.Add(this.paymentconfirm);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentConfirmationForm";
            this.Text = "Select Payment Method";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.PaymentConfirmationForm_Load);
            this.paymentconfirm.ResumeLayout(false);
            this.paymentconfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel paymentconfirm;
        private System.Windows.Forms.TextBox paycustomername;
        private System.Windows.Forms.Label paycusto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label paymentmethodlebel;
        private System.Windows.Forms.ComboBox paymentmethodselector;
        private System.Windows.Forms.Label confirmpaymentbtn;
    }
}