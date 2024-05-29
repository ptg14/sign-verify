namespace sign_verify
{
    partial class signverify
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
            TB_key = new TextBox();
            TB_pdf = new TextBox();
            TB_sign = new TextBox();
            BT_key = new Button();
            BT_pdf = new Button();
            BT_signature = new Button();
            rTB_log = new RichTextBox();
            BT_sign = new Button();
            BT_verify = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LB_result = new Label();
            SuspendLayout();
            // 
            // TB_key
            // 
            TB_key.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_key.Location = new Point(12, 32);
            TB_key.Name = "TB_key";
            TB_key.Size = new Size(296, 27);
            TB_key.TabIndex = 0;
            // 
            // TB_pdf
            // 
            TB_pdf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_pdf.Location = new Point(12, 85);
            TB_pdf.Name = "TB_pdf";
            TB_pdf.Size = new Size(296, 27);
            TB_pdf.TabIndex = 1;
            // 
            // TB_sign
            // 
            TB_sign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_sign.Location = new Point(12, 138);
            TB_sign.Name = "TB_sign";
            TB_sign.Size = new Size(296, 27);
            TB_sign.TabIndex = 2;
            // 
            // BT_key
            // 
            BT_key.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_key.Location = new Point(314, 32);
            BT_key.Name = "BT_key";
            BT_key.Size = new Size(94, 29);
            BT_key.TabIndex = 3;
            BT_key.Text = "Open";
            BT_key.UseVisualStyleBackColor = true;
            BT_key.Click += BT_key_Click;
            // 
            // BT_pdf
            // 
            BT_pdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_pdf.Location = new Point(314, 83);
            BT_pdf.Name = "BT_pdf";
            BT_pdf.Size = new Size(94, 29);
            BT_pdf.TabIndex = 4;
            BT_pdf.Text = "Open";
            BT_pdf.UseVisualStyleBackColor = true;
            BT_pdf.Click += BT_pdf_Click;
            // 
            // BT_signature
            // 
            BT_signature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BT_signature.Location = new Point(314, 136);
            BT_signature.Name = "BT_signature";
            BT_signature.Size = new Size(94, 29);
            BT_signature.TabIndex = 5;
            BT_signature.Text = "Open";
            BT_signature.UseVisualStyleBackColor = true;
            BT_signature.Click += BT_signature_Click;
            // 
            // rTB_log
            // 
            rTB_log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rTB_log.Location = new Point(12, 191);
            rTB_log.Name = "rTB_log";
            rTB_log.Size = new Size(395, 120);
            rTB_log.TabIndex = 6;
            rTB_log.Text = "";
            // 
            // BT_sign
            // 
            BT_sign.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BT_sign.Location = new Point(12, 317);
            BT_sign.Name = "BT_sign";
            BT_sign.Size = new Size(94, 29);
            BT_sign.TabIndex = 7;
            BT_sign.Text = "SIGN";
            BT_sign.UseVisualStyleBackColor = true;
            BT_sign.Click += BT_sign_Click;
            // 
            // BT_verify
            // 
            BT_verify.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BT_verify.Location = new Point(313, 317);
            BT_verify.Name = "BT_verify";
            BT_verify.Size = new Size(94, 29);
            BT_verify.TabIndex = 8;
            BT_verify.Text = "VERIFY";
            BT_verify.UseVisualStyleBackColor = true;
            BT_verify.Click += BT_verify_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 9;
            label1.Text = "Private key or Public key PATH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 10;
            label2.Text = "PDF PATH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 11;
            label3.Text = "Signature PATH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 12;
            label4.Text = "LOG";
            // 
            // LB_result
            // 
            LB_result.AutoSize = true;
            LB_result.Location = new Point(181, 321);
            LB_result.Name = "LB_result";
            LB_result.Size = new Size(0, 20);
            LB_result.TabIndex = 13;
            // 
            // signverify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 358);
            Controls.Add(LB_result);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BT_verify);
            Controls.Add(BT_sign);
            Controls.Add(rTB_log);
            Controls.Add(BT_signature);
            Controls.Add(BT_pdf);
            Controls.Add(BT_key);
            Controls.Add(TB_sign);
            Controls.Add(TB_pdf);
            Controls.Add(TB_key);
            Name = "signverify";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_key;
        private TextBox TB_pdf;
        private TextBox TB_sign;
        private Button BT_key;
        private Button BT_pdf;
        private Button BT_signature;
        private RichTextBox rTB_log;
        private Button BT_sign;
        private Button BT_verify;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LB_result;
    }
}
