namespace MyStopwatch
{
    partial class stopwatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stopwatchForm));
            this.pauseButton = new MetroFramework.Controls.MetroButton();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.restartButton = new MetroFramework.Controls.MetroButton();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelDots2 = new System.Windows.Forms.Label();
            this.labelDots1 = new System.Windows.Forms.Label();
            this.labelHrs = new System.Windows.Forms.Label();
            this.labelDot = new System.Windows.Forms.Label();
            this.labelMs = new System.Windows.Forms.Label();
            this.saveAsButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.loadButton = new MetroFramework.Controls.MetroButton();
            this.SaveItemButton = new MetroFramework.Controls.MetroButton();
            this.itemNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pauseButton.Location = new System.Drawing.Point(103, 234);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(50, 56);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.UseSelectable = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(47, 234);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(50, 56);
            this.startButton.TabIndex = 2;
            this.startButton.UseSelectable = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stopButton.Location = new System.Drawing.Point(159, 234);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 56);
            this.stopButton.TabIndex = 4;
            this.stopButton.UseSelectable = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restartButton.Location = new System.Drawing.Point(215, 234);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(50, 56);
            this.restartButton.TabIndex = 3;
            this.restartButton.UseSelectable = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // labelMin
            // 
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("Verdana", 32.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMin.Location = new System.Drawing.Point(75, 114);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(101, 60);
            this.labelMin.TabIndex = 8;
            this.labelMin.Text = "00";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSec
            // 
            this.labelSec.BackColor = System.Drawing.Color.Transparent;
            this.labelSec.Font = new System.Drawing.Font("Verdana", 32.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSec.Location = new System.Drawing.Point(150, 114);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(99, 60);
            this.labelSec.TabIndex = 9;
            this.labelSec.Text = "00";
            this.labelSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDots2
            // 
            this.labelDots2.BackColor = System.Drawing.Color.Transparent;
            this.labelDots2.Font = new System.Drawing.Font("Swis721 Cn BT", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDots2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDots2.Location = new System.Drawing.Point(151, 126);
            this.labelDots2.Name = "labelDots2";
            this.labelDots2.Size = new System.Drawing.Size(17, 48);
            this.labelDots2.TabIndex = 11;
            this.labelDots2.Text = ":";
            // 
            // labelDots1
            // 
            this.labelDots1.BackColor = System.Drawing.Color.Transparent;
            this.labelDots1.Font = new System.Drawing.Font("Swis721 Cn BT", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDots1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDots1.Location = new System.Drawing.Point(73, 126);
            this.labelDots1.Name = "labelDots1";
            this.labelDots1.Size = new System.Drawing.Size(17, 48);
            this.labelDots1.TabIndex = 14;
            this.labelDots1.Text = ":";
            // 
            // labelHrs
            // 
            this.labelHrs.BackColor = System.Drawing.Color.Transparent;
            this.labelHrs.Font = new System.Drawing.Font("Verdana", 32.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHrs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHrs.Location = new System.Drawing.Point(-4, 114);
            this.labelHrs.Name = "labelHrs";
            this.labelHrs.Size = new System.Drawing.Size(101, 60);
            this.labelHrs.TabIndex = 13;
            this.labelHrs.Text = "00";
            this.labelHrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDot
            // 
            this.labelDot.BackColor = System.Drawing.Color.Transparent;
            this.labelDot.Font = new System.Drawing.Font("Swis721 Cn BT", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDot.Location = new System.Drawing.Point(223, 132);
            this.labelDot.Name = "labelDot";
            this.labelDot.Size = new System.Drawing.Size(17, 48);
            this.labelDot.TabIndex = 12;
            this.labelDot.Text = ".";
            // 
            // labelMs
            // 
            this.labelMs.BackColor = System.Drawing.Color.Transparent;
            this.labelMs.Font = new System.Drawing.Font("Verdana", 32.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMs.Location = new System.Drawing.Point(229, 114);
            this.labelMs.Name = "labelMs";
            this.labelMs.Size = new System.Drawing.Size(115, 60);
            this.labelMs.TabIndex = 15;
            this.labelMs.Text = "000";
            this.labelMs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveAsButton
            // 
            this.saveAsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAsButton.Location = new System.Drawing.Point(609, 291);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(100, 36);
            this.saveAsButton.TabIndex = 16;
            this.saveAsButton.Text = "Save as";
            this.saveAsButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveAsButton.UseSelectable = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveButton.Location = new System.Drawing.Point(492, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 17;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveButton.UseSelectable = true;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadButton.Location = new System.Drawing.Point(374, 291);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 36);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load";
            this.loadButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadButton.UseSelectable = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveItemButton.Location = new System.Drawing.Point(609, 249);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(100, 36);
            this.SaveItemButton.TabIndex = 20;
            this.SaveItemButton.Text = "Save item";
            this.SaveItemButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveItemButton.UseSelectable = true;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // itemNameTextbox
            // 
            // 
            // 
            // 
            this.itemNameTextbox.CustomButton.Image = null;
            this.itemNameTextbox.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.itemNameTextbox.CustomButton.Name = "";
            this.itemNameTextbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.itemNameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itemNameTextbox.CustomButton.TabIndex = 1;
            this.itemNameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itemNameTextbox.CustomButton.UseSelectable = true;
            this.itemNameTextbox.CustomButton.Visible = false;
            this.itemNameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.itemNameTextbox.Lines = new string[] {
        "Enter item name"};
            this.itemNameTextbox.Location = new System.Drawing.Point(374, 249);
            this.itemNameTextbox.MaxLength = 32767;
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.PasswordChar = '\0';
            this.itemNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemNameTextbox.SelectedText = "";
            this.itemNameTextbox.SelectionLength = 0;
            this.itemNameTextbox.SelectionStart = 0;
            this.itemNameTextbox.ShortcutsEnabled = true;
            this.itemNameTextbox.Size = new System.Drawing.Size(218, 36);
            this.itemNameTextbox.TabIndex = 21;
            this.itemNameTextbox.Text = "Enter item name";
            this.itemNameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.itemNameTextbox.UseSelectable = true;
            this.itemNameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itemNameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.itemNameTextbox.Click += new System.EventHandler(this.itemNameTextbox_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.DimGray;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.timestamp});
            this.listView.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(374, 48);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(335, 185);
            this.listView.TabIndex = 22;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item name";
            this.itemName.Width = 110;
            // 
            // timestamp
            // 
            this.timestamp.Text = "Timestamp";
            this.timestamp.Width = 200;
            // 
            // stopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 360);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.itemNameTextbox);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.labelDot);
            this.Controls.Add(this.labelMs);
            this.Controls.Add(this.labelDots1);
            this.Controls.Add(this.labelHrs);
            this.Controls.Add(this.labelDots2);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pauseButton);
            this.MinimumSize = new System.Drawing.Size(750, 360);
            this.Name = "stopwatchForm";
            this.Text = "Stopwatch";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton pauseButton;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroButton restartButton;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelDots2;
        private System.Windows.Forms.Label labelDots1;
        private System.Windows.Forms.Label labelHrs;
        private System.Windows.Forms.Label labelDot;
        private System.Windows.Forms.Label labelMs;
        private MetroFramework.Controls.MetroButton saveAsButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton loadButton;
        private MetroFramework.Controls.MetroButton SaveItemButton;
        private MetroFramework.Controls.MetroTextBox itemNameTextbox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader timestamp;
    }
}

