
namespace TipCalculator
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
            this.billAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rightNoPerson = new System.Windows.Forms.Button();
            this.leftNoPerson = new System.Windows.Forms.Button();
            this.noPersonTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rightTip = new System.Windows.Forms.Button();
            this.leftTip = new System.Windows.Forms.Button();
            this.tipPercentTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.tipAmountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // billAmountTextBox
            // 
            this.billAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billAmountTextBox.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmountTextBox.Location = new System.Drawing.Point(4, 8);
            this.billAmountTextBox.Name = "billAmountTextBox";
            this.billAmountTextBox.Size = new System.Drawing.Size(251, 28);
            this.billAmountTextBox.TabIndex = 0;
            this.billAmountTextBox.Text = "0";
            this.billAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billAmountTextBox.TextChanged += new System.EventHandler(this.billAmountTextBox_TextChanged);
            this.billAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billAmountTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 264);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.billAmountTextBox);
            this.panel5.Location = new System.Drawing.Point(17, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 40);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rightNoPerson);
            this.panel4.Controls.Add(this.leftNoPerson);
            this.panel4.Controls.Add(this.noPersonTextBox);
            this.panel4.Location = new System.Drawing.Point(17, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 50);
            this.panel4.TabIndex = 7;
            // 
            // rightNoPerson
            // 
            this.rightNoPerson.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightNoPerson.Location = new System.Drawing.Point(196, 1);
            this.rightNoPerson.Name = "rightNoPerson";
            this.rightNoPerson.Size = new System.Drawing.Size(60, 47);
            this.rightNoPerson.TabIndex = 2;
            this.rightNoPerson.Text = "+";
            this.rightNoPerson.UseVisualStyleBackColor = true;
            this.rightNoPerson.Click += new System.EventHandler(this.rightNoPerson_Click);
            // 
            // leftNoPerson
            // 
            this.leftNoPerson.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftNoPerson.Location = new System.Drawing.Point(6, 1);
            this.leftNoPerson.Name = "leftNoPerson";
            this.leftNoPerson.Size = new System.Drawing.Size(60, 47);
            this.leftNoPerson.TabIndex = 1;
            this.leftNoPerson.Text = "-";
            this.leftNoPerson.UseVisualStyleBackColor = true;
            this.leftNoPerson.Click += new System.EventHandler(this.leftNoPerson_Click);
            // 
            // noPersonTextBox
            // 
            this.noPersonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noPersonTextBox.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPersonTextBox.Location = new System.Drawing.Point(72, 14);
            this.noPersonTextBox.Name = "noPersonTextBox";
            this.noPersonTextBox.Size = new System.Drawing.Size(118, 28);
            this.noPersonTextBox.TabIndex = 0;
            this.noPersonTextBox.Text = "0";
            this.noPersonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noPersonTextBox.TextChanged += new System.EventHandler(this.noPersonTextBox_TextChanged);
            this.noPersonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noPersonTextBox_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rightTip);
            this.panel3.Controls.Add(this.leftTip);
            this.panel3.Controls.Add(this.tipPercentTextBox);
            this.panel3.Location = new System.Drawing.Point(17, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 50);
            this.panel3.TabIndex = 6;
            // 
            // rightTip
            // 
            this.rightTip.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTip.Location = new System.Drawing.Point(196, 1);
            this.rightTip.Name = "rightTip";
            this.rightTip.Size = new System.Drawing.Size(60, 47);
            this.rightTip.TabIndex = 2;
            this.rightTip.Text = "+";
            this.rightTip.UseVisualStyleBackColor = true;
            this.rightTip.Click += new System.EventHandler(this.tipIncreaseValue);
            // 
            // leftTip
            // 
            this.leftTip.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTip.Location = new System.Drawing.Point(6, 1);
            this.leftTip.Name = "leftTip";
            this.leftTip.Size = new System.Drawing.Size(60, 47);
            this.leftTip.TabIndex = 1;
            this.leftTip.Text = "-";
            this.leftTip.UseVisualStyleBackColor = true;
            this.leftTip.Click += new System.EventHandler(this.tipDecreaseValue);
            // 
            // tipPercentTextBox
            // 
            this.tipPercentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipPercentTextBox.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipPercentTextBox.Location = new System.Drawing.Point(72, 14);
            this.tipPercentTextBox.Name = "tipPercentTextBox";
            this.tipPercentTextBox.Size = new System.Drawing.Size(118, 28);
            this.tipPercentTextBox.TabIndex = 0;
            this.tipPercentTextBox.Text = "0";
            this.tipPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipPercentTextBox.TextChanged += new System.EventHandler(this.tipPercentTextBox_TextChanged);
            this.tipPercentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipTextBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.messageLabel);
            this.panel2.Controls.Add(this.totalAmountLabel);
            this.panel2.Controls.Add(this.tipAmountLabel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(324, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 264);
            this.panel2.TabIndex = 7;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Crimson;
            this.messageLabel.Location = new System.Drawing.Point(7, 239);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 12;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(255, 163);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(0, 39);
            this.totalAmountLabel.TabIndex = 11;
            // 
            // tipAmountLabel
            // 
            this.tipAmountLabel.AutoSize = true;
            this.tipAmountLabel.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipAmountLabel.Location = new System.Drawing.Point(261, 52);
            this.tipAmountLabel.Name = "tipAmountLabel";
            this.tipAmountLabel.Size = new System.Drawing.Size(0, 39);
            this.tipAmountLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "per person";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(918, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox billAmountTextBox;
        private System.Windows.Forms.Label label1;
       // private NumericLeftRight tipPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
       // private NumericLeftRight noOfPeople;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label tipAmountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rightTip;
        private System.Windows.Forms.Button leftTip;
        private System.Windows.Forms.TextBox tipPercentTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button rightNoPerson;
        private System.Windows.Forms.Button leftNoPerson;
        private System.Windows.Forms.TextBox noPersonTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel5;
    }
}

