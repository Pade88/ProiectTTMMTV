
namespace ProiectEAV
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
            this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.OficiiPostale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxOrase = new System.Windows.Forms.ComboBox();
            this.listBoxOrase = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.Location = new System.Drawing.Point(12, 12);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(953, 722);
            this.webView1.TabIndex = 0;
            // 
            // OficiiPostale
            // 
            this.OficiiPostale.FormattingEnabled = true;
            this.OficiiPostale.Location = new System.Drawing.Point(971, 41);
            this.OficiiPostale.Name = "OficiiPostale";
            this.OficiiPostale.Size = new System.Drawing.Size(272, 21);
            this.OficiiPostale.TabIndex = 1;
            this.OficiiPostale.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(972, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oficiu Postal";
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(971, 92);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(272, 20);
            this.textBoxCautare.TabIndex = 3;
            this.textBoxCautare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Street View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cautare";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(975, 194);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(272, 118);
            this.textBoxInfo.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1053, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adauga Oficiu Postal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxOrase
            // 
            this.comboBoxOrase.FormattingEnabled = true;
            this.comboBoxOrase.Location = new System.Drawing.Point(975, 344);
            this.comboBoxOrase.Name = "comboBoxOrase";
            this.comboBoxOrase.Size = new System.Drawing.Size(268, 21);
            this.comboBoxOrase.TabIndex = 8;
            this.comboBoxOrase.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrase_SelectedIndexChanged);
            this.comboBoxOrase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxOrase_MouseClick);
            // 
            // listBoxOrase
            // 
            this.listBoxOrase.FormattingEnabled = true;
            this.listBoxOrase.Location = new System.Drawing.Point(975, 387);
            this.listBoxOrase.Name = "listBoxOrase";
            this.listBoxOrase.Size = new System.Drawing.Size(268, 134);
            this.listBoxOrase.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(972, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Informatii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecteaza un oras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1250, 746);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxOrase);
            this.Controls.Add(this.comboBoxOrase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OficiiPostale);
            this.Controls.Add(this.webView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
        private System.Windows.Forms.ComboBox OficiiPostale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxOrase;
        private System.Windows.Forms.ListBox listBoxOrase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

