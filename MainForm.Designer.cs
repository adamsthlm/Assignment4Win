namespace Assignment4Win
{
    partial class MainForm
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
            this.grBoxNewParty = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lbltotalNumber = new System.Windows.Forms.Label();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.grBoxAddGuest = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listAllGuests = new System.Windows.Forms.ListBox();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.grBoxNewParty.SuspendLayout();
            this.grBoxAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxNewParty
            // 
            this.grBoxNewParty.Controls.Add(this.txtAmount);
            this.grBoxNewParty.Controls.Add(this.textBox1);
            this.grBoxNewParty.Controls.Add(this.lblCostPerPerson);
            this.grBoxNewParty.Controls.Add(this.lbltotalNumber);
            this.grBoxNewParty.Controls.Add(this.btnCreateParty);
            this.grBoxNewParty.Location = new System.Drawing.Point(25, 42);
            this.grBoxNewParty.Name = "grBoxNewParty";
            this.grBoxNewParty.Size = new System.Drawing.Size(413, 150);
            this.grBoxNewParty.TabIndex = 0;
            this.grBoxNewParty.TabStop = false;
            this.grBoxNewParty.Text = "New Party";
            this.grBoxNewParty.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(208, 59);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(25, 59);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(81, 13);
            this.lblCostPerPerson.TabIndex = 2;
            this.lblCostPerPerson.Text = "Cost per person";
            // 
            // lbltotalNumber
            // 
            this.lbltotalNumber.AutoSize = true;
            this.lbltotalNumber.Location = new System.Drawing.Point(25, 37);
            this.lbltotalNumber.Name = "lbltotalNumber";
            this.lbltotalNumber.Size = new System.Drawing.Size(115, 13);
            this.lbltotalNumber.TabIndex = 1;
            this.lbltotalNumber.Text = "Total number of guests";
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(142, 98);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(102, 30);
            this.btnCreateParty.TabIndex = 0;
            this.btnCreateParty.Text = "Create List";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // grBoxAddGuest
            // 
            this.grBoxAddGuest.Controls.Add(this.button3);
            this.grBoxAddGuest.Controls.Add(this.txtLastname);
            this.grBoxAddGuest.Controls.Add(this.txtfirstName);
            this.grBoxAddGuest.Controls.Add(this.label5);
            this.grBoxAddGuest.Controls.Add(this.label4);
            this.grBoxAddGuest.Location = new System.Drawing.Point(25, 225);
            this.grBoxAddGuest.Name = "grBoxAddGuest";
            this.grBoxAddGuest.Size = new System.Drawing.Size(413, 142);
            this.grBoxAddGuest.TabIndex = 1;
            this.grBoxAddGuest.TabStop = false;
            this.grBoxAddGuest.Text = "Invite Guests";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(142, 57);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(166, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Location = new System.Drawing.Point(142, 34);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(166, 20);
            this.txtfirstName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // listAllGuests
            // 
            this.listAllGuests.FormattingEnabled = true;
            this.listAllGuests.Location = new System.Drawing.Point(526, 55);
            this.listAllGuests.Name = "listAllGuests";
            this.listAllGuests.Size = new System.Drawing.Size(328, 381);
            this.listAllGuests.TabIndex = 2;
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestList.Location = new System.Drawing.Point(624, 28);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(91, 24);
            this.lblGuestList.TabIndex = 3;
            this.lblGuestList.Text = "Guest List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Number of guests";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(212, 404);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(103, 15);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Not inplemented yet";
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(212, 436);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(105, 15);
            this.lblNumberOfGuests.TabIndex = 9;
            this.lblNumberOfGuests.Text = "Not implemented yet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 529);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGuestList);
            this.Controls.Add(this.listAllGuests);
            this.Controls.Add(this.grBoxAddGuest);
            this.Controls.Add(this.grBoxNewParty);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Party Organizer by Extremist programmer Carl-Adam Berglund v1.02 alfa";
            this.grBoxNewParty.ResumeLayout(false);
            this.grBoxNewParty.PerformLayout();
            this.grBoxAddGuest.ResumeLayout(false);
            this.grBoxAddGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxNewParty;
        private System.Windows.Forms.GroupBox grBoxAddGuest;
        private System.Windows.Forms.ListBox listAllGuests;
        private System.Windows.Forms.Label lblGuestList;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Label lbltotalNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumberOfGuests;
    }
}

