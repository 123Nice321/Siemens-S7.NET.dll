namespace 西门子PLC通讯测试
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but断开连接 = new System.Windows.Forms.Button();
            this.but连接 = new System.Windows.Forms.Button();
            this.text端口 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label4测试 = new System.Windows.Forms.Label();
            this.text测试值VW = new System.Windows.Forms.TextBox();
            this.textPLC寄存器VW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but读取 = new System.Windows.Forms.Button();
            this.labelVW = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelVD = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textPLC寄存器VD = new System.Windows.Forms.TextBox();
            this.text测试值VD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPLC寄存器VB = new System.Windows.Forms.TextBox();
            this.but写入VB = new System.Windows.Forms.Button();
            this.text测试值VB = new System.Windows.Forms.TextBox();
            this.labelVB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPLC寄存器位 = new System.Windows.Forms.TextBox();
            this.but写入位Bool = new System.Windows.Forms.Button();
            this.label位 = new System.Windows.Forms.Label();
            this.text测试值位bool = new System.Windows.Forms.DomainUpDown();
            this.but写入VW1 = new System.Windows.Forms.Button();
            this.but写入VD1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "西门子PLC  S7.net通讯测试";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but断开连接);
            this.groupBox1.Controls.Add(this.but连接);
            this.groupBox1.Controls.Add(this.text端口);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textIP);
            this.groupBox1.Controls.Add(this.label4测试);
            this.groupBox1.Location = new System.Drawing.Point(11, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(714, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接PLC TCP/IP 端口号";
            // 
            // but断开连接
            // 
            this.but断开连接.Font = new System.Drawing.Font("宋体", 10F);
            this.but断开连接.Location = new System.Drawing.Point(555, 18);
            this.but断开连接.Margin = new System.Windows.Forms.Padding(2);
            this.but断开连接.Name = "but断开连接";
            this.but断开连接.Size = new System.Drawing.Size(110, 45);
            this.but断开连接.TabIndex = 5;
            this.but断开连接.Text = "断开连接";
            this.but断开连接.UseVisualStyleBackColor = true;
            this.but断开连接.Click += new System.EventHandler(this.But断开连接_Click);
            // 
            // but连接
            // 
            this.but连接.Font = new System.Drawing.Font("宋体", 10F);
            this.but连接.Location = new System.Drawing.Point(432, 18);
            this.but连接.Margin = new System.Windows.Forms.Padding(2);
            this.but连接.Name = "but连接";
            this.but连接.Size = new System.Drawing.Size(91, 45);
            this.but连接.TabIndex = 4;
            this.but连接.Text = "连接";
            this.but连接.UseVisualStyleBackColor = true;
            this.but连接.Click += new System.EventHandler(this.But连接_Click);
            // 
            // text端口
            // 
            this.text端口.Font = new System.Drawing.Font("宋体", 12F);
            this.text端口.Location = new System.Drawing.Point(312, 19);
            this.text端口.Margin = new System.Windows.Forms.Padding(2);
            this.text端口.Name = "text端口";
            this.text端口.Size = new System.Drawing.Size(78, 26);
            this.text端口.TabIndex = 3;
            this.text端口.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(253, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址";
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("宋体", 12F);
            this.textIP.Location = new System.Drawing.Point(80, 19);
            this.textIP.Margin = new System.Windows.Forms.Padding(2);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(168, 26);
            this.textIP.TabIndex = 0;
            this.textIP.Text = "192.168.2.1";
            // 
            // label4测试
            // 
            this.label4测试.AutoSize = true;
            this.label4测试.Font = new System.Drawing.Font("宋体", 15F);
            this.label4测试.Location = new System.Drawing.Point(312, 73);
            this.label4测试.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4测试.Name = "label4测试";
            this.label4测试.Size = new System.Drawing.Size(89, 20);
            this.label4测试.TabIndex = 3;
            this.label4测试.Text = "状态显示";
            // 
            // text测试值VW
            // 
            this.text测试值VW.Font = new System.Drawing.Font("宋体", 12F);
            this.text测试值VW.Location = new System.Drawing.Point(287, 218);
            this.text测试值VW.Margin = new System.Windows.Forms.Padding(2);
            this.text测试值VW.Multiline = true;
            this.text测试值VW.Name = "text测试值VW";
            this.text测试值VW.Size = new System.Drawing.Size(74, 27);
            this.text测试值VW.TabIndex = 4;
            // 
            // textPLC寄存器VW
            // 
            this.textPLC寄存器VW.Font = new System.Drawing.Font("宋体", 12F);
            this.textPLC寄存器VW.Location = new System.Drawing.Point(109, 217);
            this.textPLC寄存器VW.Margin = new System.Windows.Forms.Padding(2);
            this.textPLC寄存器VW.Multiline = true;
            this.textPLC寄存器VW.Name = "textPLC寄存器VW";
            this.textPLC寄存器VW.Size = new System.Drawing.Size(94, 27);
            this.textPLC寄存器VW.TabIndex = 7;
            this.textPLC寄存器VW.Text = "DB1.DBW0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(11, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "VW寄存器";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(217, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "测试值";
            // 
            // but读取
            // 
            this.but读取.Font = new System.Drawing.Font("宋体", 12F);
            this.but读取.Location = new System.Drawing.Point(617, 161);
            this.but读取.Name = "but读取";
            this.but读取.Size = new System.Drawing.Size(85, 50);
            this.but读取.TabIndex = 9;
            this.but读取.Text = "读数据";
            this.but读取.UseVisualStyleBackColor = true;
            this.but读取.Click += new System.EventHandler(this.But读取_Click);
            // 
            // labelVW
            // 
            this.labelVW.AutoSize = true;
            this.labelVW.Font = new System.Drawing.Font("宋体", 25F);
            this.labelVW.Location = new System.Drawing.Point(22, 432);
            this.labelVW.Name = "labelVW";
            this.labelVW.Size = new System.Drawing.Size(185, 34);
            this.labelVW.TabIndex = 10;
            this.labelVW.Text = "显示点位VW";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelVD
            // 
            this.labelVD.AutoSize = true;
            this.labelVD.Font = new System.Drawing.Font("宋体", 25F);
            this.labelVD.Location = new System.Drawing.Point(22, 486);
            this.labelVD.Name = "labelVD";
            this.labelVD.Size = new System.Drawing.Size(185, 34);
            this.labelVD.TabIndex = 11;
            this.labelVD.Text = "显示点位VD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(217, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "测试值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(11, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "VD寄存器";
            // 
            // textPLC寄存器VD
            // 
            this.textPLC寄存器VD.Font = new System.Drawing.Font("宋体", 12F);
            this.textPLC寄存器VD.Location = new System.Drawing.Point(109, 250);
            this.textPLC寄存器VD.Margin = new System.Windows.Forms.Padding(2);
            this.textPLC寄存器VD.Multiline = true;
            this.textPLC寄存器VD.Name = "textPLC寄存器VD";
            this.textPLC寄存器VD.Size = new System.Drawing.Size(94, 27);
            this.textPLC寄存器VD.TabIndex = 14;
            this.textPLC寄存器VD.Text = "DB1.DBD0";
            // 
            // text测试值VD
            // 
            this.text测试值VD.Font = new System.Drawing.Font("宋体", 12F);
            this.text测试值VD.Location = new System.Drawing.Point(287, 251);
            this.text测试值VD.Margin = new System.Windows.Forms.Padding(2);
            this.text测试值VD.Multiline = true;
            this.text测试值VD.Name = "text测试值VD";
            this.text测试值VD.Size = new System.Drawing.Size(74, 27);
            this.text测试值VD.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(217, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "测试值";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(11, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "VB寄存器";
            // 
            // textPLC寄存器VB
            // 
            this.textPLC寄存器VB.Font = new System.Drawing.Font("宋体", 12F);
            this.textPLC寄存器VB.Location = new System.Drawing.Point(109, 183);
            this.textPLC寄存器VB.Margin = new System.Windows.Forms.Padding(2);
            this.textPLC寄存器VB.Multiline = true;
            this.textPLC寄存器VB.Name = "textPLC寄存器VB";
            this.textPLC寄存器VB.Size = new System.Drawing.Size(94, 27);
            this.textPLC寄存器VB.TabIndex = 20;
            this.textPLC寄存器VB.Text = "DB1.DBB0";
            // 
            // but写入VB
            // 
            this.but写入VB.Font = new System.Drawing.Font("宋体", 10F);
            this.but写入VB.Location = new System.Drawing.Point(379, 184);
            this.but写入VB.Margin = new System.Windows.Forms.Padding(2);
            this.but写入VB.Name = "but写入VB";
            this.but写入VB.Size = new System.Drawing.Size(74, 26);
            this.but写入VB.TabIndex = 19;
            this.but写入VB.Text = "写入";
            this.but写入VB.UseVisualStyleBackColor = true;
            this.but写入VB.Click += new System.EventHandler(this.But写入VB_Click);
            // 
            // text测试值VB
            // 
            this.text测试值VB.Font = new System.Drawing.Font("宋体", 12F);
            this.text测试值VB.Location = new System.Drawing.Point(287, 184);
            this.text测试值VB.Margin = new System.Windows.Forms.Padding(2);
            this.text测试值VB.Multiline = true;
            this.text测试值VB.Name = "text测试值VB";
            this.text测试值VB.Size = new System.Drawing.Size(74, 27);
            this.text测试值VB.TabIndex = 17;
            // 
            // labelVB
            // 
            this.labelVB.AutoSize = true;
            this.labelVB.Font = new System.Drawing.Font("宋体", 25F);
            this.labelVB.Location = new System.Drawing.Point(22, 383);
            this.labelVB.Name = "labelVB";
            this.labelVB.Size = new System.Drawing.Size(185, 34);
            this.labelVB.TabIndex = 22;
            this.labelVB.Text = "显示点位VB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(217, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "测试值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(11, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "位寄存器";
            // 
            // textPLC寄存器位
            // 
            this.textPLC寄存器位.Font = new System.Drawing.Font("宋体", 12F);
            this.textPLC寄存器位.Location = new System.Drawing.Point(109, 149);
            this.textPLC寄存器位.Margin = new System.Windows.Forms.Padding(2);
            this.textPLC寄存器位.Multiline = true;
            this.textPLC寄存器位.Name = "textPLC寄存器位";
            this.textPLC寄存器位.Size = new System.Drawing.Size(94, 27);
            this.textPLC寄存器位.TabIndex = 26;
            this.textPLC寄存器位.Text = "M0.0";
            // 
            // but写入位Bool
            // 
            this.but写入位Bool.Font = new System.Drawing.Font("宋体", 10F);
            this.but写入位Bool.Location = new System.Drawing.Point(379, 150);
            this.but写入位Bool.Margin = new System.Windows.Forms.Padding(2);
            this.but写入位Bool.Name = "but写入位Bool";
            this.but写入位Bool.Size = new System.Drawing.Size(74, 26);
            this.but写入位Bool.TabIndex = 25;
            this.but写入位Bool.Text = "写入";
            this.but写入位Bool.UseVisualStyleBackColor = true;
            this.but写入位Bool.Click += new System.EventHandler(this.But写入位Bool_Click);
            // 
            // label位
            // 
            this.label位.AutoSize = true;
            this.label位.Font = new System.Drawing.Font("宋体", 25F);
            this.label位.Location = new System.Drawing.Point(22, 338);
            this.label位.Name = "label位";
            this.label位.Size = new System.Drawing.Size(151, 34);
            this.label位.TabIndex = 28;
            this.label位.Text = "显示点位";
            // 
            // text测试值位bool
            // 
            this.text测试值位bool.Font = new System.Drawing.Font("宋体", 12F);
            this.text测试值位bool.Items.Add("False");
            this.text测试值位bool.Items.Add("True");
            this.text测试值位bool.Location = new System.Drawing.Point(287, 155);
            this.text测试值位bool.Name = "text测试值位bool";
            this.text测试值位bool.Size = new System.Drawing.Size(74, 26);
            this.text测试值位bool.TabIndex = 29;
            this.text测试值位bool.Text = "true";
            // 
            // but写入VW1
            // 
            this.but写入VW1.Location = new System.Drawing.Point(379, 215);
            this.but写入VW1.Name = "but写入VW1";
            this.but写入VW1.Size = new System.Drawing.Size(74, 30);
            this.but写入VW1.TabIndex = 30;
            this.but写入VW1.Text = "写入";
            this.but写入VW1.UseVisualStyleBackColor = true;
            this.but写入VW1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // but写入VD1
            // 
            this.but写入VD1.Location = new System.Drawing.Point(379, 247);
            this.but写入VD1.Name = "but写入VD1";
            this.but写入VD1.Size = new System.Drawing.Size(74, 30);
            this.but写入VD1.TabIndex = 31;
            this.but写入VD1.Text = "写入";
            this.but写入VD1.UseVisualStyleBackColor = true;
            this.but写入VD1.Click += new System.EventHandler(this.But写入VD1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 557);
            this.Controls.Add(this.but写入VD1);
            this.Controls.Add(this.but写入VW1);
            this.Controls.Add(this.text测试值位bool);
            this.Controls.Add(this.label位);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPLC寄存器位);
            this.Controls.Add(this.but写入位Bool);
            this.Controls.Add(this.labelVB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textPLC寄存器VB);
            this.Controls.Add(this.but写入VB);
            this.Controls.Add(this.text测试值VB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPLC寄存器VD);
            this.Controls.Add(this.text测试值VD);
            this.Controls.Add(this.labelVD);
            this.Controls.Add(this.labelVW);
            this.Controls.Add(this.but读取);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPLC寄存器VW);
            this.Controls.Add(this.text测试值VW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text端口;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Button but连接;
        private System.Windows.Forms.Button but断开连接;
        private System.Windows.Forms.Label label4测试;
        private System.Windows.Forms.TextBox text测试值VW;
        private System.Windows.Forms.TextBox textPLC寄存器VW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but读取;
        private System.Windows.Forms.Label labelVW;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelVD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPLC寄存器VD;
        private System.Windows.Forms.TextBox text测试值VD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPLC寄存器VB;
        private System.Windows.Forms.Button but写入VB;
        private System.Windows.Forms.TextBox text测试值VB;
        private System.Windows.Forms.Label labelVB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPLC寄存器位;
        private System.Windows.Forms.Button but写入位Bool;
        private System.Windows.Forms.Label label位;
        private System.Windows.Forms.DomainUpDown text测试值位bool;
        private System.Windows.Forms.Button but写入VW1;
        private System.Windows.Forms.Button but写入VD1;
    }
}

