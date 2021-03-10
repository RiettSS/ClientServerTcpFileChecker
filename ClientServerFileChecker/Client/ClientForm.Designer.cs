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
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipInputField = new System.Windows.Forms.TextBox();
            this.portInputField = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(361, 28);
            this.panel1.TabIndex = 0;
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
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(165, 7);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(25, 13);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "port";
            // 
            // ipInputField
            // 
            this.ipInputField.Location = new System.Drawing.Point(26, 4);
            this.ipInputField.Name = "ipInputField";
            this.ipInputField.Size = new System.Drawing.Size(133, 20);
            this.ipInputField.TabIndex = 2;
            // 
            // portInputField
            // 
            this.portInputField.Location = new System.Drawing.Point(196, 4);
            this.portInputField.Name = "portInputField";
            this.portInputField.Size = new System.Drawing.Size(54, 20);
            this.portInputField.TabIndex = 3;
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
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox portInputField;
        private System.Windows.Forms.TextBox ipInputField;
    }
}

