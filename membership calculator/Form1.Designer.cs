namespace membership_calculator
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
            this.components = new System.ComponentModel.Container();
            this.trainerCheckbox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.standardAdultButton = new System.Windows.Forms.RadioButton();
            this.childButton = new System.Windows.Forms.RadioButton();
            this.studentButton = new System.Windows.Forms.RadioButton();
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.membershipGroupBox = new System.Windows.Forms.GroupBox();
            this.option_GroupBox = new System.Windows.Forms.GroupBox();
            this.personalTrainerCheckbox = new System.Windows.Forms.CheckBox();
            this.instructorCheckbox = new System.Windows.Forms.CheckBox();
            this.membership_Length_GroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthTextbox = new System.Windows.Forms.TextBox();
            this.Fees_GroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyfee_label = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.total_Label = new System.Windows.Forms.Label();
            this.monthly_Fee_Label = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.membershipGroupBox.SuspendLayout();
            this.option_GroupBox.SuspendLayout();
            this.membership_Length_GroupBox.SuspendLayout();
            this.Fees_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainerCheckbox
            // 
            this.trainerCheckbox.Location = new System.Drawing.Point(15, 19);
            this.trainerCheckbox.Name = "trainerCheckbox";
            this.trainerCheckbox.Size = new System.Drawing.Size(132, 41);
            this.trainerCheckbox.TabIndex = 1;
            this.trainerCheckbox.Text = "Trainers";
            this.trainerCheckbox.UseVisualStyleBackColor = true;
            this.trainerCheckbox.CheckedChanged += new System.EventHandler(this.yoga_CheckBox_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // standardAdultButton
            // 
            this.standardAdultButton.Location = new System.Drawing.Point(17, 19);
            this.standardAdultButton.Name = "standardAdultButton";
            this.standardAdultButton.Size = new System.Drawing.Size(143, 35);
            this.standardAdultButton.TabIndex = 0;
            this.standardAdultButton.TabStop = true;
            this.standardAdultButton.Text = "Standard Adult";
            this.standardAdultButton.UseVisualStyleBackColor = true;
            this.standardAdultButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // childButton
            // 
            this.childButton.Location = new System.Drawing.Point(17, 50);
            this.childButton.Name = "childButton";
            this.childButton.Size = new System.Drawing.Size(143, 35);
            this.childButton.TabIndex = 1;
            this.childButton.TabStop = true;
            this.childButton.Text = "Child (12 and Under)";
            this.childButton.UseVisualStyleBackColor = true;
            this.childButton.CheckedChanged += new System.EventHandler(this.childButton_CheckedChanged);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(17, 78);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(143, 35);
            this.studentButton.TabIndex = 2;
            this.studentButton.TabStop = true;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.CheckedChanged += new System.EventHandler(this.studentButton_CheckedChanged);
            // 
            // seniorButton
            // 
            this.seniorButton.Location = new System.Drawing.Point(17, 104);
            this.seniorButton.Name = "seniorButton";
            this.seniorButton.Size = new System.Drawing.Size(143, 35);
            this.seniorButton.TabIndex = 3;
            this.seniorButton.TabStop = true;
            this.seniorButton.Text = "Senior Citizen";
            this.seniorButton.UseVisualStyleBackColor = true;
            this.seniorButton.CheckedChanged += new System.EventHandler(this.seniorButton_CheckedChanged);
            // 
            // membershipGroupBox
            // 
            this.membershipGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.membershipGroupBox.Controls.Add(this.seniorButton);
            this.membershipGroupBox.Controls.Add(this.studentButton);
            this.membershipGroupBox.Controls.Add(this.childButton);
            this.membershipGroupBox.Controls.Add(this.standardAdultButton);
            this.membershipGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.membershipGroupBox.Location = new System.Drawing.Point(52, 76);
            this.membershipGroupBox.Name = "membershipGroupBox";
            this.membershipGroupBox.Size = new System.Drawing.Size(224, 154);
            this.membershipGroupBox.TabIndex = 2;
            this.membershipGroupBox.TabStop = false;
            this.membershipGroupBox.Text = "Membership";
            this.membershipGroupBox.Enter += new System.EventHandler(this.membershipGroupBox_Enter);
            // 
            // option_GroupBox
            // 
            this.option_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.option_GroupBox.Controls.Add(this.personalTrainerCheckbox);
            this.option_GroupBox.Controls.Add(this.instructorCheckbox);
            this.option_GroupBox.Controls.Add(this.trainerCheckbox);
            this.option_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_GroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option_GroupBox.Location = new System.Drawing.Point(578, 76);
            this.option_GroupBox.Name = "option_GroupBox";
            this.option_GroupBox.Size = new System.Drawing.Size(214, 163);
            this.option_GroupBox.TabIndex = 4;
            this.option_GroupBox.TabStop = false;
            this.option_GroupBox.Text = "Options";
            this.option_GroupBox.Enter += new System.EventHandler(this.option_GroupBox_Enter);
            // 
            // personalTrainerCheckbox
            // 
            this.personalTrainerCheckbox.Location = new System.Drawing.Point(15, 89);
            this.personalTrainerCheckbox.Name = "personalTrainerCheckbox";
            this.personalTrainerCheckbox.Size = new System.Drawing.Size(132, 41);
            this.personalTrainerCheckbox.TabIndex = 3;
            this.personalTrainerCheckbox.Text = "Personal Trainer";
            this.personalTrainerCheckbox.UseVisualStyleBackColor = true;
            this.personalTrainerCheckbox.CheckedChanged += new System.EventHandler(this.personal_Trainer_CheckBox_CheckedChanged);
            // 
            // instructorCheckbox
            // 
            this.instructorCheckbox.Location = new System.Drawing.Point(15, 54);
            this.instructorCheckbox.Name = "instructorCheckbox";
            this.instructorCheckbox.Size = new System.Drawing.Size(132, 41);
            this.instructorCheckbox.TabIndex = 2;
            this.instructorCheckbox.Text = "Instructors";
            this.instructorCheckbox.UseVisualStyleBackColor = true;
            this.instructorCheckbox.CheckedChanged += new System.EventHandler(this.karate_CheckBox_CheckedChanged);
            // 
            // membership_Length_GroupBox
            // 
            this.membership_Length_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.membership_Length_GroupBox.Controls.Add(this.label1);
            this.membership_Length_GroupBox.Controls.Add(this.lengthTextbox);
            this.membership_Length_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership_Length_GroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.membership_Length_GroupBox.Location = new System.Drawing.Point(51, 302);
            this.membership_Length_GroupBox.Name = "membership_Length_GroupBox";
            this.membership_Length_GroupBox.Size = new System.Drawing.Size(255, 152);
            this.membership_Length_GroupBox.TabIndex = 5;
            this.membership_Length_GroupBox.TabStop = false;
            this.membership_Length_GroupBox.Text = "Membership Length";
            this.membership_Length_GroupBox.Enter += new System.EventHandler(this.membership_Length_GroupBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter membership length";
            // 
            // lengthTextbox
            // 
            this.lengthTextbox.Location = new System.Drawing.Point(41, 111);
            this.lengthTextbox.Name = "lengthTextbox";
            this.lengthTextbox.Size = new System.Drawing.Size(100, 24);
            this.lengthTextbox.TabIndex = 0;
            this.lengthTextbox.TextChanged += new System.EventHandler(this.enter_Name_TextBox_TextChanged);
            // 
            // Fees_GroupBox
            // 
            this.Fees_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Fees_GroupBox.Controls.Add(this.monthlyfee_label);
            this.Fees_GroupBox.Controls.Add(this.total);
            this.Fees_GroupBox.Controls.Add(this.total_Label);
            this.Fees_GroupBox.Controls.Add(this.monthly_Fee_Label);
            this.Fees_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees_GroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fees_GroupBox.Location = new System.Drawing.Point(556, 302);
            this.Fees_GroupBox.Name = "Fees_GroupBox";
            this.Fees_GroupBox.Size = new System.Drawing.Size(237, 164);
            this.Fees_GroupBox.TabIndex = 6;
            this.Fees_GroupBox.TabStop = false;
            this.Fees_GroupBox.Text = "Fees";
            this.Fees_GroupBox.Enter += new System.EventHandler(this.Fees_GroupBox_Enter);
            // 
            // monthlyfee_label
            // 
            this.monthlyfee_label.BackColor = System.Drawing.Color.White;
            this.monthlyfee_label.Location = new System.Drawing.Point(156, 52);
            this.monthlyfee_label.Name = "monthlyfee_label";
            this.monthlyfee_label.Size = new System.Drawing.Size(50, 16);
            this.monthlyfee_label.TabIndex = 3;
            this.monthlyfee_label.Text = "\r\n\r\n";
            this.monthlyfee_label.Click += new System.EventHandler(this.monthlyfee_label_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(156, 79);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(50, 16);
            this.total.TabIndex = 2;
            this.total.Click += new System.EventHandler(this.label2_Click);
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(20, 79);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(43, 16);
            this.total_Label.TabIndex = 1;
            this.total_Label.Text = "Total";
            this.total_Label.Click += new System.EventHandler(this.total_Label_Click);
            // 
            // monthly_Fee_Label
            // 
            this.monthly_Fee_Label.AutoSize = true;
            this.monthly_Fee_Label.Location = new System.Drawing.Point(20, 52);
            this.monthly_Fee_Label.Name = "monthly_Fee_Label";
            this.monthly_Fee_Label.Size = new System.Drawing.Size(95, 16);
            this.monthly_Fee_Label.TabIndex = 0;
            this.monthly_Fee_Label.Text = "Monthly Fee:";
            this.monthly_Fee_Label.Click += new System.EventHandler(this.monthly_Fee_Label_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.BackColor = System.Drawing.Color.Transparent;
            this.calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculate_button.Location = new System.Drawing.Point(92, 477);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(120, 27);
            this.calculate_button.TabIndex = 2;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = false;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.BackColor = System.Drawing.Color.Transparent;
            this.clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear_Button.Location = new System.Drawing.Point(399, 475);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(75, 31);
            this.clear_Button.TabIndex = 7;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = false;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_Button.Location = new System.Drawing.Point(631, 477);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 27);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::membership_calculator.Properties.Resources.pexels_olly_901439;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 570);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.Fees_GroupBox);
            this.Controls.Add(this.membership_Length_GroupBox);
            this.Controls.Add(this.option_GroupBox);
            this.Controls.Add(this.membershipGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Body Blitz Fitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.membershipGroupBox.ResumeLayout(false);
            this.option_GroupBox.ResumeLayout(false);
            this.membership_Length_GroupBox.ResumeLayout(false);
            this.membership_Length_GroupBox.PerformLayout();
            this.Fees_GroupBox.ResumeLayout(false);
            this.Fees_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox trainerCheckbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton standardAdultButton;
        private System.Windows.Forms.RadioButton childButton;
        private System.Windows.Forms.RadioButton studentButton;
        private System.Windows.Forms.RadioButton seniorButton;
        private System.Windows.Forms.GroupBox membershipGroupBox;
        private System.Windows.Forms.GroupBox option_GroupBox;
        private System.Windows.Forms.CheckBox personalTrainerCheckbox;
        private System.Windows.Forms.CheckBox instructorCheckbox;
        private System.Windows.Forms.GroupBox membership_Length_GroupBox;
        private System.Windows.Forms.TextBox lengthTextbox;
        private System.Windows.Forms.GroupBox Fees_GroupBox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label monthly_Fee_Label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monthlyfee_label;
        private System.Windows.Forms.Label total;
    }
}

