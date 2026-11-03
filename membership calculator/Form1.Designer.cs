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
            this.yoga_CheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.standardAdultButton = new System.Windows.Forms.RadioButton();
            this.childButton = new System.Windows.Forms.RadioButton();
            this.studentButton = new System.Windows.Forms.RadioButton();
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.membershipGroupBox = new System.Windows.Forms.GroupBox();
            this.option_GroupBox = new System.Windows.Forms.GroupBox();
            this.personal_Trainer_CheckBox = new System.Windows.Forms.CheckBox();
            this.karate_CheckBox = new System.Windows.Forms.CheckBox();
            this.membership_Length_GroupBox = new System.Windows.Forms.GroupBox();
            this.enter_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Fees_GroupBox = new System.Windows.Forms.GroupBox();
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
            // yoga_CheckBox
            // 
            this.yoga_CheckBox.Location = new System.Drawing.Point(15, 19);
            this.yoga_CheckBox.Name = "yoga_CheckBox";
            this.yoga_CheckBox.Size = new System.Drawing.Size(132, 41);
            this.yoga_CheckBox.TabIndex = 1;
            this.yoga_CheckBox.Text = "Yoga";
            this.yoga_CheckBox.UseVisualStyleBackColor = true;
            this.yoga_CheckBox.CheckedChanged += new System.EventHandler(this.yoga_CheckBox_CheckedChanged);
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
            this.membershipGroupBox.Controls.Add(this.seniorButton);
            this.membershipGroupBox.Controls.Add(this.studentButton);
            this.membershipGroupBox.Controls.Add(this.childButton);
            this.membershipGroupBox.Controls.Add(this.standardAdultButton);
            this.membershipGroupBox.Location = new System.Drawing.Point(52, 57);
            this.membershipGroupBox.Name = "membershipGroupBox";
            this.membershipGroupBox.Size = new System.Drawing.Size(199, 154);
            this.membershipGroupBox.TabIndex = 2;
            this.membershipGroupBox.TabStop = false;
            this.membershipGroupBox.Text = "Membership";
            this.membershipGroupBox.Enter += new System.EventHandler(this.membershipGroupBox_Enter);
            // 
            // option_GroupBox
            // 
            this.option_GroupBox.Controls.Add(this.personal_Trainer_CheckBox);
            this.option_GroupBox.Controls.Add(this.karate_CheckBox);
            this.option_GroupBox.Controls.Add(this.yoga_CheckBox);
            this.option_GroupBox.Location = new System.Drawing.Point(348, 57);
            this.option_GroupBox.Name = "option_GroupBox";
            this.option_GroupBox.Size = new System.Drawing.Size(214, 163);
            this.option_GroupBox.TabIndex = 4;
            this.option_GroupBox.TabStop = false;
            this.option_GroupBox.Text = "Options";
            this.option_GroupBox.Enter += new System.EventHandler(this.option_GroupBox_Enter);
            // 
            // personal_Trainer_CheckBox
            // 
            this.personal_Trainer_CheckBox.Location = new System.Drawing.Point(15, 89);
            this.personal_Trainer_CheckBox.Name = "personal_Trainer_CheckBox";
            this.personal_Trainer_CheckBox.Size = new System.Drawing.Size(132, 41);
            this.personal_Trainer_CheckBox.TabIndex = 3;
            this.personal_Trainer_CheckBox.Text = "Personal Trainer";
            this.personal_Trainer_CheckBox.UseVisualStyleBackColor = true;
            this.personal_Trainer_CheckBox.CheckedChanged += new System.EventHandler(this.personal_Trainer_CheckBox_CheckedChanged);
            // 
            // karate_CheckBox
            // 
            this.karate_CheckBox.Location = new System.Drawing.Point(15, 54);
            this.karate_CheckBox.Name = "karate_CheckBox";
            this.karate_CheckBox.Size = new System.Drawing.Size(132, 41);
            this.karate_CheckBox.TabIndex = 2;
            this.karate_CheckBox.Text = "Karate";
            this.karate_CheckBox.UseVisualStyleBackColor = true;
            this.karate_CheckBox.CheckedChanged += new System.EventHandler(this.karate_CheckBox_CheckedChanged);
            // 
            // membership_Length_GroupBox
            // 
            this.membership_Length_GroupBox.Controls.Add(this.enter_Name_TextBox);
            this.membership_Length_GroupBox.Location = new System.Drawing.Point(51, 245);
            this.membership_Length_GroupBox.Name = "membership_Length_GroupBox";
            this.membership_Length_GroupBox.Size = new System.Drawing.Size(200, 152);
            this.membership_Length_GroupBox.TabIndex = 5;
            this.membership_Length_GroupBox.TabStop = false;
            this.membership_Length_GroupBox.Text = "Membership Length";
            this.membership_Length_GroupBox.Enter += new System.EventHandler(this.membership_Length_GroupBox_Enter);
            // 
            // enter_Name_TextBox
            // 
            this.enter_Name_TextBox.Location = new System.Drawing.Point(41, 111);
            this.enter_Name_TextBox.Name = "enter_Name_TextBox";
            this.enter_Name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.enter_Name_TextBox.TabIndex = 0;
            this.enter_Name_TextBox.TextChanged += new System.EventHandler(this.enter_Name_TextBox_TextChanged);
            // 
            // Fees_GroupBox
            // 
            this.Fees_GroupBox.Controls.Add(this.total_Label);
            this.Fees_GroupBox.Controls.Add(this.monthly_Fee_Label);
            this.Fees_GroupBox.Location = new System.Drawing.Point(362, 245);
            this.Fees_GroupBox.Name = "Fees_GroupBox";
            this.Fees_GroupBox.Size = new System.Drawing.Size(200, 152);
            this.Fees_GroupBox.TabIndex = 6;
            this.Fees_GroupBox.TabStop = false;
            this.Fees_GroupBox.Text = "Fees";
            this.Fees_GroupBox.Enter += new System.EventHandler(this.Fees_GroupBox_Enter);
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(130, 76);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(31, 13);
            this.total_Label.TabIndex = 1;
            this.total_Label.Text = "Total";
            this.total_Label.Click += new System.EventHandler(this.total_Label_Click);
            // 
            // monthly_Fee_Label
            // 
            this.monthly_Fee_Label.AutoSize = true;
            this.monthly_Fee_Label.Location = new System.Drawing.Point(130, 48);
            this.monthly_Fee_Label.Name = "monthly_Fee_Label";
            this.monthly_Fee_Label.Size = new System.Drawing.Size(68, 13);
            this.monthly_Fee_Label.TabIndex = 0;
            this.monthly_Fee_Label.Text = "Monthly Fee:";
            this.monthly_Fee_Label.Click += new System.EventHandler(this.monthly_Fee_Label_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(92, 477);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 2;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(234, 477);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(75, 23);
            this.clear_Button.TabIndex = 7;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(408, 477);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 573);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.Fees_GroupBox);
            this.Controls.Add(this.membership_Length_GroupBox);
            this.Controls.Add(this.option_GroupBox);
            this.Controls.Add(this.membershipGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.membershipGroupBox.ResumeLayout(false);
            this.option_GroupBox.ResumeLayout(false);
            this.membership_Length_GroupBox.ResumeLayout(false);
            this.membership_Length_GroupBox.PerformLayout();
            this.Fees_GroupBox.ResumeLayout(false);
            this.Fees_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox yoga_CheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton standardAdultButton;
        private System.Windows.Forms.RadioButton childButton;
        private System.Windows.Forms.RadioButton studentButton;
        private System.Windows.Forms.RadioButton seniorButton;
        private System.Windows.Forms.GroupBox membershipGroupBox;
        private System.Windows.Forms.GroupBox option_GroupBox;
        private System.Windows.Forms.CheckBox personal_Trainer_CheckBox;
        private System.Windows.Forms.CheckBox karate_CheckBox;
        private System.Windows.Forms.GroupBox membership_Length_GroupBox;
        private System.Windows.Forms.TextBox enter_Name_TextBox;
        private System.Windows.Forms.GroupBox Fees_GroupBox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label monthly_Fee_Label;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

