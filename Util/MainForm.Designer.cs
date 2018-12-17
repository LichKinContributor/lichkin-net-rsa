namespace Util
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.publicKeyXML = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.primaryKeyXML = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.publicKeyPEM = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.primaryKeyPEM = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.decryptTextIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTextOut = new System.Windows.Forms.RichTextBox();
            this.publicKeyIn = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptTextIn = new System.Windows.Forms.RichTextBox();
            this.decryptTextOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.primaryKeyIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "生成";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 508);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.publicKeyXML);
            this.groupBox4.Location = new System.Drawing.Point(7, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 200);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "公钥";
            // 
            // publicKeyXML
            // 
            this.publicKeyXML.Location = new System.Drawing.Point(6, 20);
            this.publicKeyXML.Name = "publicKeyXML";
            this.publicKeyXML.ReadOnly = true;
            this.publicKeyXML.Size = new System.Drawing.Size(445, 174);
            this.publicKeyXML.TabIndex = 1;
            this.publicKeyXML.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.primaryKeyXML);
            this.groupBox3.Location = new System.Drawing.Point(7, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 275);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "私钥";
            // 
            // primaryKeyXML
            // 
            this.primaryKeyXML.Location = new System.Drawing.Point(6, 20);
            this.primaryKeyXML.Name = "primaryKeyXML";
            this.primaryKeyXML.ReadOnly = true;
            this.primaryKeyXML.Size = new System.Drawing.Size(445, 249);
            this.primaryKeyXML.TabIndex = 0;
            this.primaryKeyXML.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(502, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 508);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PEM";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.publicKeyPEM);
            this.groupBox5.Location = new System.Drawing.Point(7, 301);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 200);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "公钥";
            // 
            // publicKeyPEM
            // 
            this.publicKeyPEM.Location = new System.Drawing.Point(6, 21);
            this.publicKeyPEM.Name = "publicKeyPEM";
            this.publicKeyPEM.ReadOnly = true;
            this.publicKeyPEM.Size = new System.Drawing.Size(445, 174);
            this.publicKeyPEM.TabIndex = 2;
            this.publicKeyPEM.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.primaryKeyPEM);
            this.groupBox6.Location = new System.Drawing.Point(7, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(457, 275);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "私钥";
            // 
            // primaryKeyPEM
            // 
            this.primaryKeyPEM.Location = new System.Drawing.Point(6, 13);
            this.primaryKeyPEM.Name = "primaryKeyPEM";
            this.primaryKeyPEM.ReadOnly = true;
            this.primaryKeyPEM.Size = new System.Drawing.Size(445, 249);
            this.primaryKeyPEM.TabIndex = 1;
            this.primaryKeyPEM.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.decryptTextIn);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.encryptTextOut);
            this.groupBox7.Controls.Add(this.publicKeyIn);
            this.groupBox7.Location = new System.Drawing.Point(998, 41);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(774, 246);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "加密";
            // 
            // decryptTextIn
            // 
            this.decryptTextIn.Location = new System.Drawing.Point(53, 41);
            this.decryptTextIn.Name = "decryptTextIn";
            this.decryptTextIn.Size = new System.Drawing.Size(715, 21);
            this.decryptTextIn.TabIndex = 5;
            this.decryptTextIn.TextChanged += new System.EventHandler(this.decryptTextIn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "明文：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "公钥：";
            // 
            // encryptTextOut
            // 
            this.encryptTextOut.Location = new System.Drawing.Point(53, 68);
            this.encryptTextOut.Name = "encryptTextOut";
            this.encryptTextOut.ReadOnly = true;
            this.encryptTextOut.Size = new System.Drawing.Size(714, 165);
            this.encryptTextOut.TabIndex = 2;
            this.encryptTextOut.Text = "";
            // 
            // publicKeyIn
            // 
            this.publicKeyIn.Location = new System.Drawing.Point(53, 18);
            this.publicKeyIn.Name = "publicKeyIn";
            this.publicKeyIn.Size = new System.Drawing.Size(715, 21);
            this.publicKeyIn.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.primaryKeyIn);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.encryptTextIn);
            this.groupBox8.Controls.Add(this.decryptTextOut);
            this.groupBox8.Location = new System.Drawing.Point(998, 303);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(774, 246);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "解密";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "明文：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密文：";
            // 
            // encryptTextIn
            // 
            this.encryptTextIn.Location = new System.Drawing.Point(52, 47);
            this.encryptTextIn.Name = "encryptTextIn";
            this.encryptTextIn.Size = new System.Drawing.Size(715, 165);
            this.encryptTextIn.TabIndex = 2;
            this.encryptTextIn.Text = "";
            this.encryptTextIn.TextChanged += new System.EventHandler(this.encryptTextIn_TextChanged);
            // 
            // decryptTextOut
            // 
            this.decryptTextOut.Location = new System.Drawing.Point(53, 218);
            this.decryptTextOut.Name = "decryptTextOut";
            this.decryptTextOut.ReadOnly = true;
            this.decryptTextOut.Size = new System.Drawing.Size(714, 21);
            this.decryptTextOut.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "私钥：";
            // 
            // primaryKeyIn
            // 
            this.primaryKeyIn.Location = new System.Drawing.Point(52, 20);
            this.primaryKeyIn.Name = "primaryKeyIn";
            this.primaryKeyIn.Size = new System.Drawing.Size(715, 21);
            this.primaryKeyIn.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "密文：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 561);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RSA工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox publicKeyXML;
        private System.Windows.Forms.RichTextBox primaryKeyXML;
        private System.Windows.Forms.RichTextBox publicKeyPEM;
        private System.Windows.Forms.RichTextBox primaryKeyPEM;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox publicKeyIn;
        private System.Windows.Forms.RichTextBox encryptTextOut;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox encryptTextIn;
        private System.Windows.Forms.TextBox decryptTextOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decryptTextIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox primaryKeyIn;
        private System.Windows.Forms.Label label6;
    }
}

