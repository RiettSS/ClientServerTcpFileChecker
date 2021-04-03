namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.portInputField = new System.Windows.Forms.TextBox();
            this.ipInputField = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directoryOutputField = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.pathInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveToServerInput = new System.Windows.Forms.TextBox();
            this.downloadFromClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.saveToClientInput = new System.Windows.Forms.TextBox();
            this.downloadInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.md5Server = new System.Windows.Forms.TextBox();
            this.md5Client = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.portInputField);
            this.panel1.Controls.Add(this.ipInputField);
            this.panel1.Controls.Add(this.portLabel);
            this.panel1.Controls.Add(this.ipLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 28);
            this.panel1.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(267, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 20);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portInputField
            // 
            this.portInputField.Location = new System.Drawing.Point(196, 4);
            this.portInputField.Name = "portInputField";
            this.portInputField.Size = new System.Drawing.Size(54, 20);
            this.portInputField.TabIndex = 3;
            // 
            // ipInputField
            // 
            this.ipInputField.Location = new System.Drawing.Point(26, 4);
            this.ipInputField.Name = "ipInputField";
            this.ipInputField.Size = new System.Drawing.Size(133, 20);
            this.ipInputField.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(165, 7);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(25, 13);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "port";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(5, 7);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(15, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "ip";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.directoryOutputField);
            this.panel2.Controls.Add(this.findButton);
            this.panel2.Controls.Add(this.pathInputField);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 394);
            this.panel2.TabIndex = 1;
            // 
            // directoryOutputField
            // 
            this.directoryOutputField.Location = new System.Drawing.Point(10, 28);
            this.directoryOutputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directoryOutputField.Multiline = true;
            this.directoryOutputField.Name = "directoryOutputField";
            this.directoryOutputField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.directoryOutputField.Size = new System.Drawing.Size(333, 356);
            this.directoryOutputField.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(267, 4);
            this.findButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 19);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // pathInputField
            // 
            this.pathInputField.Location = new System.Drawing.Point(40, 5);
            this.pathInputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pathInputField.Name = "pathInputField";
            this.pathInputField.Size = new System.Drawing.Size(210, 20);
            this.pathInputField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "path";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.saveToServerInput);
            this.panel3.Controls.Add(this.downloadFromClient);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.downloadButton);
            this.panel3.Controls.Add(this.saveToClientInput);
            this.panel3.Controls.Add(this.downloadInputField);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(370, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 207);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Client to server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server to client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveToServerInput
            // 
            this.saveToServerInput.Location = new System.Drawing.Point(85, 152);
            this.saveToServerInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveToServerInput.Name = "saveToServerInput";
            this.saveToServerInput.Size = new System.Drawing.Size(319, 20);
            this.saveToServerInput.TabIndex = 8;
            // 
            // downloadFromClient
            // 
            this.downloadFromClient.Location = new System.Drawing.Point(85, 126);
            this.downloadFromClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadFromClient.Name = "downloadFromClient";
            this.downloadFromClient.Size = new System.Drawing.Size(319, 20);
            this.downloadFromClient.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Download";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(326, 81);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(76, 21);
            this.downloadButton.TabIndex = 4;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // saveToClientInput
            // 
            this.saveToClientInput.Location = new System.Drawing.Point(85, 59);
            this.saveToClientInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveToClientInput.Name = "saveToClientInput";
            this.saveToClientInput.Size = new System.Drawing.Size(319, 20);
            this.saveToClientInput.TabIndex = 3;
            // 
            // downloadInputField
            // 
            this.downloadInputField.Location = new System.Drawing.Point(85, 33);
            this.downloadInputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadInputField.Name = "downloadInputField";
            this.downloadInputField.Size = new System.Drawing.Size(319, 20);
            this.downloadInputField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Download";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkButton);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.md5Server);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.md5Client);
            this.panel4.Location = new System.Drawing.Point(371, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 217);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "MD5 Hash Checker";
            // 
            // md5Server
            // 
            this.md5Server.Location = new System.Drawing.Point(84, 71);
            this.md5Server.Margin = new System.Windows.Forms.Padding(2);
            this.md5Server.Name = "md5Server";
            this.md5Server.Size = new System.Drawing.Size(319, 20);
            this.md5Server.TabIndex = 13;
            // 
            // md5Client
            // 
            this.md5Client.Location = new System.Drawing.Point(84, 37);
            this.md5Client.Margin = new System.Windows.Forms.Padding(2);
            this.md5Client.Name = "md5Client";
            this.md5Client.Size = new System.Drawing.Size(319, 20);
            this.md5Client.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Client";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Server";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(328, 96);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 16;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portInputField;
        private System.Windows.Forms.TextBox ipInputField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pathInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox directoryOutputField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox downloadInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveToClientInput;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox saveToServerInput;
        private System.Windows.Forms.TextBox downloadFromClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox md5Server;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox md5Client;
    }
}

