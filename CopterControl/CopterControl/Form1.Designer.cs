namespace CopterControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COM_NUM = new System.Windows.Forms.ComboBox();
            this.COM_Baud = new System.Windows.Forms.ComboBox();
            this.COM_button = new System.Windows.Forms.Button();
            this.COM_Update = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Roll_Send = new System.Windows.Forms.Button();
            this.Pitch_Send = new System.Windows.Forms.Button();
            this.Yaw_Send = new System.Windows.Forms.Button();
            this.Throttle_Send = new System.Windows.Forms.Button();
            this.Mode_Set = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Roll_BOX = new System.Windows.Forms.ComboBox();
            this.Pitch_BOX = new System.Windows.Forms.ComboBox();
            this.Yaw_BOX = new System.Windows.Forms.ComboBox();
            this.Throttle_Box = new System.Windows.Forms.ComboBox();
            this.Mode_Box = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mode_Box);
            this.groupBox1.Controls.Add(this.Throttle_Box);
            this.groupBox1.Controls.Add(this.Yaw_BOX);
            this.groupBox1.Controls.Add(this.Pitch_BOX);
            this.groupBox1.Controls.Add(this.Roll_BOX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Mode_Set);
            this.groupBox1.Controls.Add(this.Throttle_Send);
            this.groupBox1.Controls.Add(this.Yaw_Send);
            this.groupBox1.Controls.Add(this.Pitch_Send);
            this.groupBox1.Controls.Add(this.Roll_Send);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制区";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(291, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 444);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数区";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(577, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 444);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "显示区";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "串    口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "波特率：";
            // 
            // COM_NUM
            // 
            this.COM_NUM.FormattingEnabled = true;
            this.COM_NUM.Location = new System.Drawing.Point(109, 22);
            this.COM_NUM.Name = "COM_NUM";
            this.COM_NUM.Size = new System.Drawing.Size(100, 20);
            this.COM_NUM.TabIndex = 5;
            // 
            // COM_Baud
            // 
            this.COM_Baud.FormattingEnabled = true;
            this.COM_Baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "57600",
            "115200"});
            this.COM_Baud.Location = new System.Drawing.Point(108, 55);
            this.COM_Baud.Name = "COM_Baud";
            this.COM_Baud.Size = new System.Drawing.Size(101, 20);
            this.COM_Baud.TabIndex = 6;
            // 
            // COM_button
            // 
            this.COM_button.Location = new System.Drawing.Point(229, 23);
            this.COM_button.Name = "COM_button";
            this.COM_button.Size = new System.Drawing.Size(75, 23);
            this.COM_button.TabIndex = 7;
            this.COM_button.Text = "打开串口";
            this.COM_button.UseVisualStyleBackColor = true;
            this.COM_button.Click += new System.EventHandler(this.COM_button_Click);
            // 
            // COM_Update
            // 
            this.COM_Update.Location = new System.Drawing.Point(229, 51);
            this.COM_Update.Name = "COM_Update";
            this.COM_Update.Size = new System.Drawing.Size(75, 23);
            this.COM_Update.TabIndex = 8;
            this.COM_Update.Text = "更新串口";
            this.COM_Update.UseVisualStyleBackColor = true;
            this.COM_Update.Click += new System.EventHandler(this.COM_Update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "降落";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "返航";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "急停";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "解锁";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Roll_Send
            // 
            this.Roll_Send.Location = new System.Drawing.Point(181, 106);
            this.Roll_Send.Name = "Roll_Send";
            this.Roll_Send.Size = new System.Drawing.Size(62, 23);
            this.Roll_Send.TabIndex = 4;
            this.Roll_Send.Text = "发送roll";
            this.Roll_Send.UseVisualStyleBackColor = true;
            this.Roll_Send.Click += new System.EventHandler(this.Roll_Send_Click);
            // 
            // Pitch_Send
            // 
            this.Pitch_Send.Location = new System.Drawing.Point(181, 151);
            this.Pitch_Send.Name = "Pitch_Send";
            this.Pitch_Send.Size = new System.Drawing.Size(75, 23);
            this.Pitch_Send.TabIndex = 5;
            this.Pitch_Send.Text = "发送pitch";
            this.Pitch_Send.UseVisualStyleBackColor = true;
            this.Pitch_Send.Click += new System.EventHandler(this.Pitch_Send_Click);
            // 
            // Yaw_Send
            // 
            this.Yaw_Send.Location = new System.Drawing.Point(181, 184);
            this.Yaw_Send.Name = "Yaw_Send";
            this.Yaw_Send.Size = new System.Drawing.Size(75, 23);
            this.Yaw_Send.TabIndex = 6;
            this.Yaw_Send.Text = "发送yaw";
            this.Yaw_Send.UseVisualStyleBackColor = true;
            this.Yaw_Send.Click += new System.EventHandler(this.Yaw_Send_Click);
            // 
            // Throttle_Send
            // 
            this.Throttle_Send.Location = new System.Drawing.Point(181, 221);
            this.Throttle_Send.Name = "Throttle_Send";
            this.Throttle_Send.Size = new System.Drawing.Size(75, 23);
            this.Throttle_Send.TabIndex = 7;
            this.Throttle_Send.Text = "发送油门";
            this.Throttle_Send.UseVisualStyleBackColor = true;
            this.Throttle_Send.Click += new System.EventHandler(this.Throttle_Send_Click);
            // 
            // Mode_Set
            // 
            this.Mode_Set.Location = new System.Drawing.Point(181, 259);
            this.Mode_Set.Name = "Mode_Set";
            this.Mode_Set.Size = new System.Drawing.Size(75, 23);
            this.Mode_Set.TabIndex = 8;
            this.Mode_Set.Text = "飞行模式";
            this.Mode_Set.UseVisualStyleBackColor = true;
            this.Mode_Set.Click += new System.EventHandler(this.Mode_Set_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "翻滚";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "俯仰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "偏航";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "油门";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(20, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "模式";
            // 
            // Roll_BOX
            // 
            this.Roll_BOX.AutoCompleteCustomSource.AddRange(new string[] {
            "-4500",
            "-4000",
            "-3500",
            "-3000",
            "-2500",
            "-2000",
            "-1500",
            "-1000",
            "-500",
            "0",
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500"});
            this.Roll_BOX.FormattingEnabled = true;
            this.Roll_BOX.Location = new System.Drawing.Point(65, 106);
            this.Roll_BOX.Name = "Roll_BOX";
            this.Roll_BOX.Size = new System.Drawing.Size(100, 20);
            this.Roll_BOX.TabIndex = 14;
            // 
            // Pitch_BOX
            // 
            this.Pitch_BOX.AutoCompleteCustomSource.AddRange(new string[] {
            "-4500",
            "-4000",
            "-3500",
            "-3000",
            "-2500",
            "-2000",
            "-1500",
            "-1000",
            "-500",
            "0",
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500"});
            this.Pitch_BOX.FormattingEnabled = true;
            this.Pitch_BOX.Location = new System.Drawing.Point(67, 150);
            this.Pitch_BOX.Name = "Pitch_BOX";
            this.Pitch_BOX.Size = new System.Drawing.Size(98, 20);
            this.Pitch_BOX.TabIndex = 15;
            // 
            // Yaw_BOX
            // 
            this.Yaw_BOX.AutoCompleteCustomSource.AddRange(new string[] {
            "-4500",
            "-4000",
            "-3500",
            "-3000",
            "-2500",
            "-2000",
            "-1500",
            "-1000",
            "-500",
            "0",
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500"});
            this.Yaw_BOX.FormattingEnabled = true;
            this.Yaw_BOX.Location = new System.Drawing.Point(67, 187);
            this.Yaw_BOX.Name = "Yaw_BOX";
            this.Yaw_BOX.Size = new System.Drawing.Size(98, 20);
            this.Yaw_BOX.TabIndex = 16;
            // 
            // Throttle_Box
            // 
            this.Throttle_Box.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.Throttle_Box.FormattingEnabled = true;
            this.Throttle_Box.Location = new System.Drawing.Point(65, 226);
            this.Throttle_Box.Name = "Throttle_Box";
            this.Throttle_Box.Size = new System.Drawing.Size(98, 20);
            this.Throttle_Box.TabIndex = 17;
            // 
            // Mode_Box
            // 
            this.Mode_Box.FormattingEnabled = true;
            this.Mode_Box.Items.AddRange(new object[] {
            "自稳",
            "定高",
            "悬停"});
            this.Mode_Box.Location = new System.Drawing.Point(65, 262);
            this.Mode_Box.Name = "Mode_Box";
            this.Mode_Box.Size = new System.Drawing.Size(100, 20);
            this.Mode_Box.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 550);
            this.Controls.Add(this.COM_Update);
            this.Controls.Add(this.COM_button);
            this.Controls.Add(this.COM_Baud);
            this.Controls.Add(this.COM_NUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "四旋翼控制平台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COM_NUM;
        private System.Windows.Forms.ComboBox COM_Baud;
        private System.Windows.Forms.Button COM_button;
        private System.Windows.Forms.Button COM_Update;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox Mode_Box;
        private System.Windows.Forms.ComboBox Throttle_Box;
        private System.Windows.Forms.ComboBox Yaw_BOX;
        private System.Windows.Forms.ComboBox Pitch_BOX;
        private System.Windows.Forms.ComboBox Roll_BOX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Mode_Set;
        private System.Windows.Forms.Button Throttle_Send;
        private System.Windows.Forms.Button Yaw_Send;
        private System.Windows.Forms.Button Pitch_Send;
        private System.Windows.Forms.Button Roll_Send;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

