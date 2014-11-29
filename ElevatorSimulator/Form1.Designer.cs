namespace ElevatorSimulator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTenButton = new System.Windows.Forms.Button();
            this.elevatorListBox = new System.Windows.Forms.ListBox();
            this.floorZeroPersonButton = new System.Windows.Forms.Button();
            this.floorOnePersonButton = new System.Windows.Forms.Button();
            this.floorTwoPersonButton = new System.Windows.Forms.Button();
            this.floorThreePersonButton = new System.Windows.Forms.Button();
            this.floorFourPersonButton = new System.Windows.Forms.Button();
            this.floorFivePersonButton = new System.Windows.Forms.Button();
            this.randomPersonButton = new System.Windows.Forms.Button();
            this.floorZeroListBox = new System.Windows.Forms.ListBox();
            this.floorOneListBox = new System.Windows.Forms.ListBox();
            this.floorTwoListBox = new System.Windows.Forms.ListBox();
            this.floorThreeListBox = new System.Windows.Forms.ListBox();
            this.floorFourListBox = new System.Windows.Forms.ListBox();
            this.floorFiveListBox = new System.Windows.Forms.ListBox();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.oneStepButton = new System.Windows.Forms.Button();
            this.floorOne = new System.Windows.Forms.Label();
            this.floorTwo = new System.Windows.Forms.Label();
            this.floorThree = new System.Windows.Forms.Label();
            this.floorFour = new System.Windows.Forms.Label();
            this.floorFive = new System.Windows.Forms.Label();
            this.floorZero = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.automationTimer = new System.Windows.Forms.Timer(this.components);
            this.automateCheckBox = new System.Windows.Forms.CheckBox();
            this.automationTime = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tickLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automationTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1136, 752);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.automateCheckBox);
            this.tabPage1.Controls.Add(this.addTenButton);
            this.tabPage1.Controls.Add(this.elevatorListBox);
            this.tabPage1.Controls.Add(this.floorZeroPersonButton);
            this.tabPage1.Controls.Add(this.floorOnePersonButton);
            this.tabPage1.Controls.Add(this.floorTwoPersonButton);
            this.tabPage1.Controls.Add(this.floorThreePersonButton);
            this.tabPage1.Controls.Add(this.floorFourPersonButton);
            this.tabPage1.Controls.Add(this.floorFivePersonButton);
            this.tabPage1.Controls.Add(this.randomPersonButton);
            this.tabPage1.Controls.Add(this.floorZeroListBox);
            this.tabPage1.Controls.Add(this.floorOneListBox);
            this.tabPage1.Controls.Add(this.floorTwoListBox);
            this.tabPage1.Controls.Add(this.floorThreeListBox);
            this.tabPage1.Controls.Add(this.floorFourListBox);
            this.tabPage1.Controls.Add(this.floorFiveListBox);
            this.tabPage1.Controls.Add(this.currentStatusLabel);
            this.tabPage1.Controls.Add(this.oneStepButton);
            this.tabPage1.Controls.Add(this.floorOne);
            this.tabPage1.Controls.Add(this.floorTwo);
            this.tabPage1.Controls.Add(this.floorThree);
            this.tabPage1.Controls.Add(this.floorFour);
            this.tabPage1.Controls.Add(this.floorFive);
            this.tabPage1.Controls.Add(this.floorZero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GUI";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // addTenButton
            // 
            this.addTenButton.Location = new System.Drawing.Point(581, 642);
            this.addTenButton.Name = "addTenButton";
            this.addTenButton.Size = new System.Drawing.Size(75, 23);
            this.addTenButton.TabIndex = 51;
            this.addTenButton.Text = "Add 10";
            this.addTenButton.UseVisualStyleBackColor = true;
            this.addTenButton.Click += new System.EventHandler(this.addTenButton_Click);
            // 
            // elevatorListBox
            // 
            this.elevatorListBox.FormattingEnabled = true;
            this.elevatorListBox.Location = new System.Drawing.Point(498, 82);
            this.elevatorListBox.Name = "elevatorListBox";
            this.elevatorListBox.Size = new System.Drawing.Size(239, 381);
            this.elevatorListBox.TabIndex = 50;
            // 
            // floorZeroPersonButton
            // 
            this.floorZeroPersonButton.Location = new System.Drawing.Point(398, 582);
            this.floorZeroPersonButton.Name = "floorZeroPersonButton";
            this.floorZeroPersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorZeroPersonButton.TabIndex = 25;
            this.floorZeroPersonButton.Text = "Add Person";
            this.floorZeroPersonButton.UseVisualStyleBackColor = true;
            this.floorZeroPersonButton.Click += new System.EventHandler(this.floorZeroPersonButton_Click);
            // 
            // floorOnePersonButton
            // 
            this.floorOnePersonButton.Location = new System.Drawing.Point(398, 482);
            this.floorOnePersonButton.Name = "floorOnePersonButton";
            this.floorOnePersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorOnePersonButton.TabIndex = 24;
            this.floorOnePersonButton.Text = "Add Person";
            this.floorOnePersonButton.UseVisualStyleBackColor = true;
            this.floorOnePersonButton.Click += new System.EventHandler(this.floorOnePersonButton_Click);
            // 
            // floorTwoPersonButton
            // 
            this.floorTwoPersonButton.Location = new System.Drawing.Point(398, 382);
            this.floorTwoPersonButton.Name = "floorTwoPersonButton";
            this.floorTwoPersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorTwoPersonButton.TabIndex = 23;
            this.floorTwoPersonButton.Text = "Add Person";
            this.floorTwoPersonButton.UseVisualStyleBackColor = true;
            this.floorTwoPersonButton.Click += new System.EventHandler(this.floorTwoPersonButton_Click);
            // 
            // floorThreePersonButton
            // 
            this.floorThreePersonButton.Location = new System.Drawing.Point(398, 282);
            this.floorThreePersonButton.Name = "floorThreePersonButton";
            this.floorThreePersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorThreePersonButton.TabIndex = 22;
            this.floorThreePersonButton.Text = "Add Person";
            this.floorThreePersonButton.UseVisualStyleBackColor = true;
            this.floorThreePersonButton.Click += new System.EventHandler(this.floorThreePersonButton_Click);
            // 
            // floorFourPersonButton
            // 
            this.floorFourPersonButton.Location = new System.Drawing.Point(398, 182);
            this.floorFourPersonButton.Name = "floorFourPersonButton";
            this.floorFourPersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorFourPersonButton.TabIndex = 21;
            this.floorFourPersonButton.Text = "Add Person";
            this.floorFourPersonButton.UseVisualStyleBackColor = true;
            this.floorFourPersonButton.Click += new System.EventHandler(this.floorFourPersonButton_Click);
            // 
            // floorFivePersonButton
            // 
            this.floorFivePersonButton.Location = new System.Drawing.Point(398, 82);
            this.floorFivePersonButton.Name = "floorFivePersonButton";
            this.floorFivePersonButton.Size = new System.Drawing.Size(73, 83);
            this.floorFivePersonButton.TabIndex = 20;
            this.floorFivePersonButton.Text = "Add Person";
            this.floorFivePersonButton.UseVisualStyleBackColor = true;
            this.floorFivePersonButton.Click += new System.EventHandler(this.floorFivePersonButton_Click);
            // 
            // randomPersonButton
            // 
            this.randomPersonButton.Location = new System.Drawing.Point(581, 613);
            this.randomPersonButton.Name = "randomPersonButton";
            this.randomPersonButton.Size = new System.Drawing.Size(75, 23);
            this.randomPersonButton.TabIndex = 19;
            this.randomPersonButton.Text = "Add Person";
            this.randomPersonButton.UseVisualStyleBackColor = true;
            this.randomPersonButton.Click += new System.EventHandler(this.randomPersonButton_Click);
            // 
            // floorZeroListBox
            // 
            this.floorZeroListBox.FormattingEnabled = true;
            this.floorZeroListBox.Location = new System.Drawing.Point(46, 584);
            this.floorZeroListBox.Name = "floorZeroListBox";
            this.floorZeroListBox.Size = new System.Drawing.Size(266, 82);
            this.floorZeroListBox.TabIndex = 18;
            // 
            // floorOneListBox
            // 
            this.floorOneListBox.FormattingEnabled = true;
            this.floorOneListBox.Location = new System.Drawing.Point(46, 483);
            this.floorOneListBox.Name = "floorOneListBox";
            this.floorOneListBox.Size = new System.Drawing.Size(266, 82);
            this.floorOneListBox.TabIndex = 17;
            // 
            // floorTwoListBox
            // 
            this.floorTwoListBox.FormattingEnabled = true;
            this.floorTwoListBox.Location = new System.Drawing.Point(46, 383);
            this.floorTwoListBox.Name = "floorTwoListBox";
            this.floorTwoListBox.Size = new System.Drawing.Size(266, 82);
            this.floorTwoListBox.TabIndex = 16;
            // 
            // floorThreeListBox
            // 
            this.floorThreeListBox.FormattingEnabled = true;
            this.floorThreeListBox.Location = new System.Drawing.Point(46, 284);
            this.floorThreeListBox.Name = "floorThreeListBox";
            this.floorThreeListBox.Size = new System.Drawing.Size(266, 82);
            this.floorThreeListBox.TabIndex = 15;
            // 
            // floorFourListBox
            // 
            this.floorFourListBox.FormattingEnabled = true;
            this.floorFourListBox.Location = new System.Drawing.Point(46, 184);
            this.floorFourListBox.Name = "floorFourListBox";
            this.floorFourListBox.Size = new System.Drawing.Size(266, 82);
            this.floorFourListBox.TabIndex = 14;
            // 
            // floorFiveListBox
            // 
            this.floorFiveListBox.FormattingEnabled = true;
            this.floorFiveListBox.Location = new System.Drawing.Point(46, 84);
            this.floorFiveListBox.Name = "floorFiveListBox";
            this.floorFiveListBox.Size = new System.Drawing.Size(266, 82);
            this.floorFiveListBox.TabIndex = 13;
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Location = new System.Drawing.Point(208, 54);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(180, 13);
            this.currentStatusLabel.TabIndex = 12;
            this.currentStatusLabel.Text = "Current Status: GIVE ME A STATUS";
            // 
            // oneStepButton
            // 
            this.oneStepButton.Location = new System.Drawing.Point(662, 612);
            this.oneStepButton.Name = "oneStepButton";
            this.oneStepButton.Size = new System.Drawing.Size(75, 23);
            this.oneStepButton.TabIndex = 10;
            this.oneStepButton.Text = "One Step";
            this.oneStepButton.UseVisualStyleBackColor = true;
            this.oneStepButton.Click += new System.EventHandler(this.oneStepButton_Click);
            // 
            // floorOne
            // 
            this.floorOne.AutoSize = true;
            this.floorOne.BackColor = System.Drawing.Color.Gray;
            this.floorOne.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorOne.Location = new System.Drawing.Point(318, 482);
            this.floorOne.Name = "floorOne";
            this.floorOne.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorOne.Size = new System.Drawing.Size(73, 83);
            this.floorOne.TabIndex = 9;
            this.floorOne.Text = "1";
            this.floorOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorTwo
            // 
            this.floorTwo.AutoSize = true;
            this.floorTwo.BackColor = System.Drawing.Color.Gray;
            this.floorTwo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorTwo.Location = new System.Drawing.Point(318, 382);
            this.floorTwo.Name = "floorTwo";
            this.floorTwo.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorTwo.Size = new System.Drawing.Size(73, 83);
            this.floorTwo.TabIndex = 8;
            this.floorTwo.Text = "2";
            this.floorTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorThree
            // 
            this.floorThree.AutoSize = true;
            this.floorThree.BackColor = System.Drawing.Color.Gray;
            this.floorThree.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorThree.Location = new System.Drawing.Point(318, 282);
            this.floorThree.Name = "floorThree";
            this.floorThree.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorThree.Size = new System.Drawing.Size(73, 83);
            this.floorThree.TabIndex = 7;
            this.floorThree.Text = "3";
            this.floorThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorFour
            // 
            this.floorFour.AutoSize = true;
            this.floorFour.BackColor = System.Drawing.Color.Gray;
            this.floorFour.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorFour.Location = new System.Drawing.Point(318, 182);
            this.floorFour.Name = "floorFour";
            this.floorFour.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorFour.Size = new System.Drawing.Size(73, 83);
            this.floorFour.TabIndex = 6;
            this.floorFour.Text = "4";
            this.floorFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorFive
            // 
            this.floorFive.AutoSize = true;
            this.floorFive.BackColor = System.Drawing.Color.Gray;
            this.floorFive.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorFive.Location = new System.Drawing.Point(318, 82);
            this.floorFive.Name = "floorFive";
            this.floorFive.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorFive.Size = new System.Drawing.Size(73, 83);
            this.floorFive.TabIndex = 5;
            this.floorFive.Text = "5";
            this.floorFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floorZero
            // 
            this.floorZero.AutoSize = true;
            this.floorZero.BackColor = System.Drawing.Color.Gray;
            this.floorZero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.floorZero.Location = new System.Drawing.Point(318, 582);
            this.floorZero.Name = "floorZero";
            this.floorZero.Padding = new System.Windows.Forms.Padding(35, 35, 25, 35);
            this.floorZero.Size = new System.Drawing.Size(75, 83);
            this.floorZero.TabIndex = 4;
            this.floorZero.Text = "G";
            this.floorZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tickLabel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.automationTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // automationTimer
            // 
            this.automationTimer.Interval = 1000;
            this.automationTimer.Tick += new System.EventHandler(this.oneStepButton_Click);
            // 
            // automateCheckBox
            // 
            this.automateCheckBox.AutoSize = true;
            this.automateCheckBox.Location = new System.Drawing.Point(581, 582);
            this.automateCheckBox.Name = "automateCheckBox";
            this.automateCheckBox.Size = new System.Drawing.Size(71, 17);
            this.automateCheckBox.TabIndex = 52;
            this.automateCheckBox.Text = "Automate";
            this.automateCheckBox.UseVisualStyleBackColor = true;
            this.automateCheckBox.CheckedChanged += new System.EventHandler(this.automateCheckBox_CheckedChanged);
            // 
            // automationTime
            // 
            this.automationTime.LargeChange = 1000;
            this.automationTime.Location = new System.Drawing.Point(9, 317);
            this.automationTime.Maximum = 5000;
            this.automationTime.Minimum = 100;
            this.automationTime.Name = "automationTime";
            this.automationTime.Size = new System.Drawing.Size(723, 45);
            this.automationTime.SmallChange = 100;
            this.automationTime.TabIndex = 0;
            this.automationTime.TickFrequency = 100;
            this.automationTime.Value = 100;
            this.automationTime.Scroll += new System.EventHandler(this.automationTime_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Between Automation Ticks";
            // 
            // tickLabel
            // 
            this.tickLabel.AutoSize = true;
            this.tickLabel.Location = new System.Drawing.Point(176, 298);
            this.tickLabel.Name = "tickLabel";
            this.tickLabel.Size = new System.Drawing.Size(0, 13);
            this.tickLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 697);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automationTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label floorZero;
        private System.Windows.Forms.Label floorOne;
        private System.Windows.Forms.Label floorTwo;
        private System.Windows.Forms.Label floorThree;
        private System.Windows.Forms.Label floorFour;
        private System.Windows.Forms.Label floorFive;
        private System.Windows.Forms.Button oneStepButton;
        private System.Windows.Forms.Label currentStatusLabel;
        private System.Windows.Forms.ListBox floorZeroListBox;
        private System.Windows.Forms.ListBox floorOneListBox;
        private System.Windows.Forms.ListBox floorTwoListBox;
        private System.Windows.Forms.ListBox floorThreeListBox;
        private System.Windows.Forms.ListBox floorFourListBox;
        private System.Windows.Forms.ListBox floorFiveListBox;
        private System.Windows.Forms.Button floorZeroPersonButton;
        private System.Windows.Forms.Button floorOnePersonButton;
        private System.Windows.Forms.Button floorTwoPersonButton;
        private System.Windows.Forms.Button floorThreePersonButton;
        private System.Windows.Forms.Button floorFourPersonButton;
        private System.Windows.Forms.Button floorFivePersonButton;
        private System.Windows.Forms.Button randomPersonButton;
        private System.Windows.Forms.ListBox elevatorListBox;
        private System.Windows.Forms.Button addTenButton;
        private System.Windows.Forms.Timer automationTimer;
        private System.Windows.Forms.CheckBox automateCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar automationTime;
        private System.Windows.Forms.Label tickLabel;
    }
}

