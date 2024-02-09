namespace LoanApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            label7 = new Label();
            txtCard = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtPeroid = new TextBox();
            txtRate = new TextBox();
            label5 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            saveBtn = new Button();
            clearBtn = new Button();
            groupOut = new GroupBox();
            lblOutInterest = new Label();
            label12 = new Label();
            lblOutPayment = new Label();
            label22 = new Label();
            lblOutRate = new Label();
            label19 = new Label();
            lblOutPeroid = new Label();
            label21 = new Label();
            lblOutAmount = new Label();
            label15 = new Label();
            lblOutAddress = new Label();
            lblOutGH = new Label();
            label8 = new Label();
            label11 = new Label();
            lblOutName = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupOut.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCard);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(77, 123);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 126);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 4;
            label7.Text = "Address:";
            // 
            // txtCard
            // 
            txtCard.Location = new Point(78, 78);
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(195, 27);
            txtCard.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "GH Card:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPeroid);
            groupBox2.Controls.Add(txtRate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAmount);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(367, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 166);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loan Info";
            // 
            // txtPeroid
            // 
            txtPeroid.Location = new Point(134, 76);
            txtPeroid.Name = "txtPeroid";
            txtPeroid.Size = new Size(139, 27);
            txtPeroid.TabIndex = 8;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(141, 119);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(132, 27);
            txtRate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 126);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 6;
            label5.Text = "Interest Rate (%):";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(128, 26);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(145, 27);
            txtAmount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 66);
            label3.Name = "label3";
            label3.Size = new Size(114, 40);
            label3.TabIndex = 1;
            label3.Text = "Payment Period:\r\n(in months)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 26);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Amount (GHS):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(271, 9);
            label6.Name = "label6";
            label6.Size = new Size(142, 38);
            label6.TabIndex = 5;
            label6.Text = "Loan App";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Green;
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(131, 248);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(133, 45);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Red;
            clearBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(428, 248);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(133, 45);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // groupOut
            // 
            groupOut.Controls.Add(lblOutInterest);
            groupOut.Controls.Add(label12);
            groupOut.Controls.Add(lblOutPayment);
            groupOut.Controls.Add(label22);
            groupOut.Controls.Add(lblOutRate);
            groupOut.Controls.Add(label19);
            groupOut.Controls.Add(lblOutPeroid);
            groupOut.Controls.Add(label21);
            groupOut.Controls.Add(lblOutAmount);
            groupOut.Controls.Add(label15);
            groupOut.Controls.Add(lblOutAddress);
            groupOut.Controls.Add(lblOutGH);
            groupOut.Controls.Add(label8);
            groupOut.Controls.Add(label11);
            groupOut.Controls.Add(lblOutName);
            groupOut.Controls.Add(label9);
            groupOut.Location = new Point(25, 299);
            groupOut.Name = "groupOut";
            groupOut.Size = new Size(633, 266);
            groupOut.TabIndex = 8;
            groupOut.TabStop = false;
            groupOut.Text = "Output";
            // 
            // lblOutInterest
            // 
            lblOutInterest.AutoSize = true;
            lblOutInterest.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutInterest.Location = new Point(156, 227);
            lblOutInterest.Name = "lblOutInterest";
            lblOutInterest.Size = new Size(109, 25);
            lblOutInterest.TabIndex = 23;
            lblOutInterest.Text = "OutInterest";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 227);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 22;
            label12.Text = "Total Interest:";
            // 
            // lblOutPayment
            // 
            lblOutPayment.AutoSize = true;
            lblOutPayment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutPayment.Location = new Point(464, 227);
            lblOutPayment.Name = "lblOutPayment";
            lblOutPayment.Size = new Size(116, 25);
            lblOutPayment.TabIndex = 21;
            lblOutPayment.Text = "OutPayment";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(325, 227);
            label22.Name = "label22";
            label22.Size = new Size(133, 25);
            label22.TabIndex = 20;
            label22.Text = "Total Payment:";
            // 
            // lblOutRate
            // 
            lblOutRate.AutoSize = true;
            lblOutRate.Location = new Point(445, 178);
            lblOutRate.Name = "lblOutRate";
            lblOutRate.Size = new Size(63, 20);
            lblOutRate.TabIndex = 19;
            lblOutRate.Text = "OutRate";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(325, 178);
            label19.Name = "label19";
            label19.Size = new Size(78, 20);
            label19.TabIndex = 18;
            label19.Text = "Loan Rate:";
            // 
            // lblOutPeroid
            // 
            lblOutPeroid.AutoSize = true;
            lblOutPeroid.Location = new Point(126, 141);
            lblOutPeroid.Name = "lblOutPeroid";
            lblOutPeroid.Size = new Size(75, 20);
            lblOutPeroid.TabIndex = 17;
            lblOutPeroid.Text = "OutPeroid";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(19, 141);
            label21.Name = "label21";
            label21.Size = new Size(90, 20);
            label21.TabIndex = 16;
            label21.Text = "Loan Peroid:";
            // 
            // lblOutAmount
            // 
            lblOutAmount.AutoSize = true;
            lblOutAmount.Location = new Point(131, 178);
            lblOutAmount.Name = "lblOutAmount";
            lblOutAmount.Size = new Size(86, 20);
            lblOutAmount.TabIndex = 13;
            lblOutAmount.Text = "OutAmount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 178);
            label15.Name = "label15";
            label15.Size = new Size(106, 20);
            label15.TabIndex = 12;
            label15.Text = "Initial Amount:";
            // 
            // lblOutAddress
            // 
            lblOutAddress.AutoSize = true;
            lblOutAddress.Location = new Point(93, 105);
            lblOutAddress.Name = "lblOutAddress";
            lblOutAddress.Size = new Size(86, 20);
            lblOutAddress.TabIndex = 11;
            lblOutAddress.Text = "OutAddress";
            // 
            // lblOutGH
            // 
            lblOutGH.AutoSize = true;
            lblOutGH.Location = new Point(93, 69);
            lblOutGH.Name = "lblOutGH";
            lblOutGH.Size = new Size(54, 20);
            lblOutGH.TabIndex = 10;
            lblOutGH.Text = "OutGH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 69);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 6;
            label8.Text = "GH Card:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 105);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 9;
            label11.Text = "Address:";
            // 
            // lblOutName
            // 
            lblOutName.AutoSize = true;
            lblOutName.Location = new Point(78, 33);
            lblOutName.Name = "lblOutName";
            lblOutName.Size = new Size(73, 20);
            lblOutName.TabIndex = 8;
            lblOutName.Text = "OutName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 33);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 7;
            label9.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(686, 586);
            Controls.Add(groupOut);
            Controls.Add(clearBtn);
            Controls.Add(saveBtn);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Loan App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupOut.ResumeLayout(false);
            groupOut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtCard;
        private GroupBox groupBox2;
        private TextBox txtAmount;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRate;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtPeroid;
        private Button saveBtn;
        private Button clearBtn;
        private GroupBox groupOut;
        private Label label8;
        private Label label11;
        private Label lblOutName;
        private Label label9;
        private Label lblOutAmount;
        private Label label15;
        private Label lblOutAddress;
        private Label lblOutGH;
        private Label lblOutMonthly;
        private Label label16;
        private Label lblOutRate;
        private Label label19;
        private Label lblOutPeroid;
        private Label label21;
        private Label label22;
        private Label lblOutPayment;
        private Label lblOutInterest;
        private Label label12;
    }
}
