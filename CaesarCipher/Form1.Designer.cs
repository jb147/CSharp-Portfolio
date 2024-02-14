namespace CaesarCipher
{
    partial class frmCaesarCipher
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
            this.rEncrypt = new System.Windows.Forms.RadioButton();
            this.rDecrypt = new System.Windows.Forms.RadioButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.btnKeyDecrease = new System.Windows.Forms.Button();
            this.btnKeyIncrease = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblMessageDisplay = new System.Windows.Forms.Label();
            this.tstShift = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rEncrypt
            // 
            this.rEncrypt.AutoSize = true;
            this.rEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEncrypt.Location = new System.Drawing.Point(121, 45);
            this.rEncrypt.Name = "rEncrypt";
            this.rEncrypt.Size = new System.Drawing.Size(88, 24);
            this.rEncrypt.TabIndex = 0;
            this.rEncrypt.TabStop = true;
            this.rEncrypt.Text = "Encrypt";
            this.rEncrypt.UseVisualStyleBackColor = true;
            this.rEncrypt.CheckedChanged += new System.EventHandler(this.rEncrypt_CheckedChanged);
            // 
            // rDecrypt
            // 
            this.rDecrypt.AutoSize = true;
            this.rDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDecrypt.Location = new System.Drawing.Point(261, 45);
            this.rDecrypt.Name = "rDecrypt";
            this.rDecrypt.Size = new System.Drawing.Size(89, 24);
            this.rDecrypt.TabIndex = 1;
            this.rDecrypt.TabStop = true;
            this.rDecrypt.Text = "Decrypt";
            this.rDecrypt.UseVisualStyleBackColor = true;
            this.rDecrypt.CheckedChanged += new System.EventHandler(this.rDecrypt_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(22, 107);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(418, 26);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(19, 88);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(115, 16);
            this.lblEntry.TabIndex = 3;
            this.lblEntry.Text = "Enter Message:";
            // 
            // btnKeyDecrease
            // 
            this.btnKeyDecrease.BackColor = System.Drawing.Color.Gray;
            this.btnKeyDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyDecrease.Location = new System.Drawing.Point(60, 176);
            this.btnKeyDecrease.Name = "btnKeyDecrease";
            this.btnKeyDecrease.Size = new System.Drawing.Size(106, 58);
            this.btnKeyDecrease.TabIndex = 4;
            this.btnKeyDecrease.Text = "<";
            this.btnKeyDecrease.UseVisualStyleBackColor = false;
            this.btnKeyDecrease.Click += new System.EventHandler(this.btnKeyDecrease_Click);
            // 
            // btnKeyIncrease
            // 
            this.btnKeyIncrease.BackColor = System.Drawing.Color.Gray;
            this.btnKeyIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyIncrease.Location = new System.Drawing.Point(272, 176);
            this.btnKeyIncrease.Name = "btnKeyIncrease";
            this.btnKeyIncrease.Size = new System.Drawing.Size(106, 58);
            this.btnKeyIncrease.TabIndex = 5;
            this.btnKeyIncrease.Text = ">";
            this.btnKeyIncrease.UseVisualStyleBackColor = false;
            this.btnKeyIncrease.Click += new System.EventHandler(this.btnKeyIncrease_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Red;
            this.lblKey.Location = new System.Drawing.Point(195, 176);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(52, 55);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "0";
            // 
            // lblMessageDisplay
            // 
            this.lblMessageDisplay.AutoSize = true;
            this.lblMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageDisplay.Location = new System.Drawing.Point(85, 280);
            this.lblMessageDisplay.Name = "lblMessageDisplay";
            this.lblMessageDisplay.Size = new System.Drawing.Size(310, 55);
            this.lblMessageDisplay.TabIndex = 7;
            this.lblMessageDisplay.Text = "Hello, World!";
            // 
            // tstShift
            // 
            this.tstShift.AutoSize = true;
            this.tstShift.Location = new System.Drawing.Point(43, 348);
            this.tstShift.Name = "tstShift";
            this.tstShift.Size = new System.Drawing.Size(31, 13);
            this.tstShift.TabIndex = 8;
            this.tstShift.Text = "Shift:";
            this.tstShift.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCaesarCipher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(487, 412);
            this.Controls.Add(this.tstShift);
            this.Controls.Add(this.lblMessageDisplay);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnKeyIncrease);
            this.Controls.Add(this.btnKeyDecrease);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rDecrypt);
            this.Controls.Add(this.rEncrypt);
            this.Name = "frmCaesarCipher";
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rEncrypt;
        private System.Windows.Forms.RadioButton rDecrypt;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Button btnKeyDecrease;
        private System.Windows.Forms.Button btnKeyIncrease;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblMessageDisplay;
        private System.Windows.Forms.Label tstShift;
    }
}

