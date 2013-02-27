namespace PomodoroTimer
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workSecomndsTextbox = new System.Windows.Forms.TextBox();
            this.breakMinutesTextBox = new System.Windows.Forms.TextBox();
            this.longBreakMinutesTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hideToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.showTimeCorrectionCheckBox = new System.Windows.Forms.CheckBox();
            this.windowNotifCheckBox = new System.Windows.Forms.CheckBox();
            this.minimizeWhenStartCheckBox = new System.Windows.Forms.CheckBox();
            this.tb_remindPeriod = new System.Windows.Forms.TextBox();
            this.cb_remind = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work duration (min.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Break duration (min.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Long break duration (min.)";
            // 
            // workSecomndsTextbox
            // 
            this.workSecomndsTextbox.Location = new System.Drawing.Point(15, 26);
            this.workSecomndsTextbox.Name = "workSecomndsTextbox";
            this.workSecomndsTextbox.Size = new System.Drawing.Size(100, 20);
            this.workSecomndsTextbox.TabIndex = 3;
            // 
            // breakMinutesTextBox
            // 
            this.breakMinutesTextBox.Location = new System.Drawing.Point(17, 65);
            this.breakMinutesTextBox.Name = "breakMinutesTextBox";
            this.breakMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.breakMinutesTextBox.TabIndex = 3;
            // 
            // longBreakMinutesTextBox
            // 
            this.longBreakMinutesTextBox.Location = new System.Drawing.Point(16, 104);
            this.longBreakMinutesTextBox.Name = "longBreakMinutesTextBox";
            this.longBreakMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.longBreakMinutesTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(15, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(96, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hideToTrayCheckBox
            // 
            this.hideToTrayCheckBox.AutoSize = true;
            this.hideToTrayCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hideToTrayCheckBox.Location = new System.Drawing.Point(15, 199);
            this.hideToTrayCheckBox.Name = "hideToTrayCheckBox";
            this.hideToTrayCheckBox.Size = new System.Drawing.Size(80, 17);
            this.hideToTrayCheckBox.TabIndex = 6;
            this.hideToTrayCheckBox.Text = "Hide to tray";
            this.hideToTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // showTimeCorrectionCheckBox
            // 
            this.showTimeCorrectionCheckBox.AutoSize = true;
            this.showTimeCorrectionCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showTimeCorrectionCheckBox.Location = new System.Drawing.Point(15, 176);
            this.showTimeCorrectionCheckBox.Name = "showTimeCorrectionCheckBox";
            this.showTimeCorrectionCheckBox.Size = new System.Drawing.Size(125, 17);
            this.showTimeCorrectionCheckBox.TabIndex = 6;
            this.showTimeCorrectionCheckBox.Text = "Show time correction";
            this.showTimeCorrectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowNotifCheckBox
            // 
            this.windowNotifCheckBox.AutoSize = true;
            this.windowNotifCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.windowNotifCheckBox.Location = new System.Drawing.Point(16, 153);
            this.windowNotifCheckBox.Name = "windowNotifCheckBox";
            this.windowNotifCheckBox.Size = new System.Drawing.Size(146, 17);
            this.windowNotifCheckBox.TabIndex = 7;
            this.windowNotifCheckBox.Text = "Show window notification";
            this.windowNotifCheckBox.UseVisualStyleBackColor = true;
            // 
            // minimizeWhenStartCheckBox
            // 
            this.minimizeWhenStartCheckBox.AutoSize = true;
            this.minimizeWhenStartCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeWhenStartCheckBox.Location = new System.Drawing.Point(16, 130);
            this.minimizeWhenStartCheckBox.Name = "minimizeWhenStartCheckBox";
            this.minimizeWhenStartCheckBox.Size = new System.Drawing.Size(101, 17);
            this.minimizeWhenStartCheckBox.TabIndex = 7;
            this.minimizeWhenStartCheckBox.Text = "Minimize at start";
            this.minimizeWhenStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // tb_remindPeriod
            // 
            this.tb_remindPeriod.Location = new System.Drawing.Point(6, 72);
            this.tb_remindPeriod.Name = "tb_remindPeriod";
            this.tb_remindPeriod.Size = new System.Drawing.Size(100, 20);
            this.tb_remindPeriod.TabIndex = 3;
            // 
            // cb_remind
            // 
            this.cb_remind.AutoSize = true;
            this.cb_remind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_remind.Location = new System.Drawing.Point(9, 19);
            this.cb_remind.Name = "cb_remind";
            this.cb_remind.Size = new System.Drawing.Size(129, 17);
            this.cb_remind.TabIndex = 7;
            this.cb_remind.Text = "Remind when paused";
            this.cb_remind.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Remind period (sec.)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_remind);
            this.groupBox1.Controls.Add(this.tb_remindPeriod);
            this.groupBox1.Location = new System.Drawing.Point(169, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remind";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimizeWhenStartCheckBox);
            this.Controls.Add(this.windowNotifCheckBox);
            this.Controls.Add(this.showTimeCorrectionCheckBox);
            this.Controls.Add(this.hideToTrayCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.longBreakMinutesTextBox);
            this.Controls.Add(this.breakMinutesTextBox);
            this.Controls.Add(this.workSecomndsTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workSecomndsTextbox;
        private System.Windows.Forms.TextBox breakMinutesTextBox;
        private System.Windows.Forms.TextBox longBreakMinutesTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox hideToTrayCheckBox;
        private System.Windows.Forms.CheckBox showTimeCorrectionCheckBox;
        private System.Windows.Forms.CheckBox windowNotifCheckBox;
        private System.Windows.Forms.CheckBox minimizeWhenStartCheckBox;
        private System.Windows.Forms.TextBox tb_remindPeriod;
        private System.Windows.Forms.CheckBox cb_remind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}