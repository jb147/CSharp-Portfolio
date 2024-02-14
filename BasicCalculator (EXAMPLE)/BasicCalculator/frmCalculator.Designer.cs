
namespace BasicCalculator
{
    partial class frmCalculator
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
            this.components = new System.ComponentModel.Container();
            this.butOne = new System.Windows.Forms.Button();
            this.butTwo = new System.Windows.Forms.Button();
            this.butThree = new System.Windows.Forms.Button();
            this.butSix = new System.Windows.Forms.Button();
            this.butFive = new System.Windows.Forms.Button();
            this.butFour = new System.Windows.Forms.Button();
            this.butNine = new System.Windows.Forms.Button();
            this.butEight = new System.Windows.Forms.Button();
            this.butSeven = new System.Windows.Forms.Button();
            this.butZero = new System.Windows.Forms.Button();
            this.butDecimal = new System.Windows.Forms.Button();
            this.butEquals = new System.Windows.Forms.Button();
            this.butSubtraction = new System.Windows.Forms.Button();
            this.butAddition = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.txtInputResult = new System.Windows.Forms.TextBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // butOne
            // 
            this.butOne.BackColor = System.Drawing.Color.LightGray;
            this.butOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOne.Location = new System.Drawing.Point(26, 168);
            this.butOne.Name = "butOne";
            this.butOne.Size = new System.Drawing.Size(40, 39);
            this.butOne.TabIndex = 16;
            this.butOne.Text = "1";
            this.butOne.UseVisualStyleBackColor = false;
            this.butOne.Click += new System.EventHandler(this.butOne_Click);
            // 
            // butTwo
            // 
            this.butTwo.BackColor = System.Drawing.Color.LightGray;
            this.butTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTwo.Location = new System.Drawing.Point(72, 168);
            this.butTwo.Name = "butTwo";
            this.butTwo.Size = new System.Drawing.Size(40, 39);
            this.butTwo.TabIndex = 15;
            this.butTwo.Text = "2";
            this.butTwo.UseVisualStyleBackColor = false;
            this.butTwo.Click += new System.EventHandler(this.butTwo_Click);
            // 
            // butThree
            // 
            this.butThree.BackColor = System.Drawing.Color.LightGray;
            this.butThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThree.Location = new System.Drawing.Point(118, 168);
            this.butThree.Name = "butThree";
            this.butThree.Size = new System.Drawing.Size(40, 39);
            this.butThree.TabIndex = 14;
            this.butThree.Text = "3";
            this.butThree.UseVisualStyleBackColor = false;
            this.butThree.Click += new System.EventHandler(this.butThree_Click);
            // 
            // butSix
            // 
            this.butSix.BackColor = System.Drawing.Color.LightGray;
            this.butSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSix.Location = new System.Drawing.Point(118, 123);
            this.butSix.Name = "butSix";
            this.butSix.Size = new System.Drawing.Size(40, 39);
            this.butSix.TabIndex = 11;
            this.butSix.Text = "6";
            this.butSix.UseVisualStyleBackColor = false;
            this.butSix.Click += new System.EventHandler(this.butSix_Click);
            // 
            // butFive
            // 
            this.butFive.BackColor = System.Drawing.Color.LightGray;
            this.butFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFive.Location = new System.Drawing.Point(72, 123);
            this.butFive.Name = "butFive";
            this.butFive.Size = new System.Drawing.Size(40, 39);
            this.butFive.TabIndex = 12;
            this.butFive.Text = "5";
            this.butFive.UseVisualStyleBackColor = false;
            this.butFive.Click += new System.EventHandler(this.butFive_Click);
            // 
            // butFour
            // 
            this.butFour.BackColor = System.Drawing.Color.LightGray;
            this.butFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFour.Location = new System.Drawing.Point(26, 123);
            this.butFour.Name = "butFour";
            this.butFour.Size = new System.Drawing.Size(40, 39);
            this.butFour.TabIndex = 13;
            this.butFour.Text = "4";
            this.butFour.UseVisualStyleBackColor = false;
            this.butFour.Click += new System.EventHandler(this.butFour_Click);
            // 
            // butNine
            // 
            this.butNine.BackColor = System.Drawing.Color.LightGray;
            this.butNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNine.Location = new System.Drawing.Point(118, 78);
            this.butNine.Name = "butNine";
            this.butNine.Size = new System.Drawing.Size(40, 39);
            this.butNine.TabIndex = 8;
            this.butNine.Text = "9";
            this.butNine.UseVisualStyleBackColor = false;
            this.butNine.Click += new System.EventHandler(this.butNine_Click);
            // 
            // butEight
            // 
            this.butEight.BackColor = System.Drawing.Color.LightGray;
            this.butEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEight.Location = new System.Drawing.Point(72, 78);
            this.butEight.Name = "butEight";
            this.butEight.Size = new System.Drawing.Size(40, 39);
            this.butEight.TabIndex = 9;
            this.butEight.Text = "8";
            this.butEight.UseVisualStyleBackColor = false;
            this.butEight.Click += new System.EventHandler(this.butEight_Click);
            // 
            // butSeven
            // 
            this.butSeven.BackColor = System.Drawing.Color.LightGray;
            this.butSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSeven.Location = new System.Drawing.Point(26, 78);
            this.butSeven.Name = "butSeven";
            this.butSeven.Size = new System.Drawing.Size(40, 39);
            this.butSeven.TabIndex = 10;
            this.butSeven.Text = "7";
            this.butSeven.UseVisualStyleBackColor = false;
            this.butSeven.Click += new System.EventHandler(this.butSeven_Click);
            // 
            // butZero
            // 
            this.butZero.BackColor = System.Drawing.Color.LightGray;
            this.butZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butZero.Location = new System.Drawing.Point(26, 213);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(86, 39);
            this.butZero.TabIndex = 7;
            this.butZero.Text = "0";
            this.butZero.UseVisualStyleBackColor = false;
            this.butZero.Click += new System.EventHandler(this.butZero_Click);
            // 
            // butDecimal
            // 
            this.butDecimal.BackColor = System.Drawing.Color.LightGray;
            this.butDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDecimal.Location = new System.Drawing.Point(118, 213);
            this.butDecimal.Name = "butDecimal";
            this.butDecimal.Size = new System.Drawing.Size(40, 39);
            this.butDecimal.TabIndex = 6;
            this.butDecimal.Text = ".";
            this.butDecimal.UseVisualStyleBackColor = false;
            this.butDecimal.Click += new System.EventHandler(this.butDecimal_Click);
            // 
            // butEquals
            // 
            this.butEquals.BackColor = System.Drawing.Color.LightGray;
            this.butEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEquals.Location = new System.Drawing.Point(164, 168);
            this.butEquals.Name = "butEquals";
            this.butEquals.Size = new System.Drawing.Size(40, 84);
            this.butEquals.TabIndex = 3;
            this.butEquals.Text = "=";
            this.butEquals.UseVisualStyleBackColor = false;
            this.butEquals.Click += new System.EventHandler(this.butEquals_Click);
            // 
            // butSubtraction
            // 
            this.butSubtraction.BackColor = System.Drawing.Color.LightGray;
            this.butSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubtraction.Location = new System.Drawing.Point(164, 123);
            this.butSubtraction.Name = "butSubtraction";
            this.butSubtraction.Size = new System.Drawing.Size(40, 39);
            this.butSubtraction.TabIndex = 4;
            this.butSubtraction.Text = "-";
            this.butSubtraction.UseVisualStyleBackColor = false;
            this.butSubtraction.Click += new System.EventHandler(this.butSubtraction_Click);
            // 
            // butAddition
            // 
            this.butAddition.BackColor = System.Drawing.Color.LightGray;
            this.butAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddition.Location = new System.Drawing.Point(164, 78);
            this.butAddition.Name = "butAddition";
            this.butAddition.Size = new System.Drawing.Size(40, 39);
            this.butAddition.TabIndex = 5;
            this.butAddition.Text = "+";
            this.butAddition.UseVisualStyleBackColor = false;
            this.butAddition.Click += new System.EventHandler(this.butAddition_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.LightGray;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.Location = new System.Drawing.Point(210, 78);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(40, 174);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "C";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // txtInputResult
            // 
            this.txtInputResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtInputResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputResult.Location = new System.Drawing.Point(26, 46);
            this.txtInputResult.Name = "txtInputResult";
            this.txtInputResult.ReadOnly = true;
            this.txtInputResult.Size = new System.Drawing.Size(224, 26);
            this.txtInputResult.TabIndex = 1;
            this.txtInputResult.Text = "0";
            this.txtInputResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEquation
            // 
            this.txtEquation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquation.Enabled = false;
            this.txtEquation.Location = new System.Drawing.Point(26, 20);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.ReadOnly = true;
            this.txtEquation.Size = new System.Drawing.Size(224, 13);
            this.txtEquation.TabIndex = 0;
            this.txtEquation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 265);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.txtInputResult);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butEquals);
            this.Controls.Add(this.butSubtraction);
            this.Controls.Add(this.butAddition);
            this.Controls.Add(this.butDecimal);
            this.Controls.Add(this.butZero);
            this.Controls.Add(this.butNine);
            this.Controls.Add(this.butEight);
            this.Controls.Add(this.butSeven);
            this.Controls.Add(this.butSix);
            this.Controls.Add(this.butFive);
            this.Controls.Add(this.butFour);
            this.Controls.Add(this.butThree);
            this.Controls.Add(this.butTwo);
            this.Controls.Add(this.butOne);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOne;
        private System.Windows.Forms.Button butTwo;
        private System.Windows.Forms.Button butThree;
        private System.Windows.Forms.Button butSix;
        private System.Windows.Forms.Button butFive;
        private System.Windows.Forms.Button butFour;
        private System.Windows.Forms.Button butNine;
        private System.Windows.Forms.Button butEight;
        private System.Windows.Forms.Button butSeven;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.Button butDecimal;
        private System.Windows.Forms.Button butEquals;
        private System.Windows.Forms.Button butSubtraction;
        private System.Windows.Forms.Button butAddition;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox txtInputResult;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Timer timer1;
    }
}

