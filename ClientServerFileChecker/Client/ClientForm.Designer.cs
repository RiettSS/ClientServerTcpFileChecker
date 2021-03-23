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
            this.downloadButton = new System.Windows.Forms.Button();
            this.saveToClientInput = new System.Windows.Forms.TextBox();
            this.downloadInputField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(13, 46);
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
            this.findButton.Location = new System.Drawing.Point(267, 3);
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
            this.pathInputField.Location = new System.Drawing.Point(40, 3);
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
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(321, 59);
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
            this.saveToClientInput.Location = new System.Drawing.Point(80, 37);
            this.saveToClientInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveToClientInput.Name = "saveToClientInput";
            this.saveToClientInput.Size = new System.Drawing.Size(319, 20);
            this.saveToClientInput.TabIndex = 3;
            // 
            // downloadInputField
            // 
            this.downloadInputField.Location = new System.Drawing.Point(80, 11);
            this.downloadInputField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadInputField.Name = "downloadInputField";
            this.downloadInputField.Size = new System.Drawing.Size(319, 20);
            this.downloadInputField.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Download";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(547, 315);
            this.testButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(56, 19);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testButton);
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
        private System.Windows.Forms.Button testButton;
    }
}

