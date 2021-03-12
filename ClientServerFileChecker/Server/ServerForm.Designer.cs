namespace Server
{
    partial class ServerForm
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
            this.ServerConsole = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipInputField = new System.Windows.Forms.TextBox();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.portInputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ServerConsole
            // 
            this.ServerConsole.Location = new System.Drawing.Point(16, 44);
            this.ServerConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerConsole.Multiline = true;
            this.ServerConsole.Name = "ServerConsole";
            this.ServerConsole.ReadOnly = true;
            this.ServerConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ServerConsole.Size = new System.Drawing.Size(1033, 494);
            this.ServerConsole.TabIndex = 0;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(17, 16);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(19, 17);
            this.ipLabel.TabIndex = 1;
            this.ipLabel.Text = "ip";
            // 
            // ipInputField
            // 
            this.ipInputField.Location = new System.Drawing.Point(47, 12);
            this.ipInputField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipInputField.Name = "ipInputField";
            this.ipInputField.Size = new System.Drawing.Size(172, 22);
            this.ipInputField.TabIndex = 2;
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(345, 12);
            this.StartServerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(109, 25);
            this.StartServerButton.TabIndex = 3;
            this.StartServerButton.Text = "Start";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(228, 16);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(33, 17);
            this.portLabel.TabIndex = 4;
            this.portLabel.Text = "port";
            // 
            // portInputField
            // 
            this.portInputField.Location = new System.Drawing.Point(269, 12);
            this.portInputField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portInputField.Name = "portInputField";
            this.portInputField.Size = new System.Drawing.Size(67, 22);
            this.portInputField.TabIndex = 5;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.portInputField);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.ipInputField);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ServerConsole);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerConsole;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipInputField;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portInputField;
    }
}

