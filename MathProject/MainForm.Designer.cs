namespace MathProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PhysicsTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sunMassTextBox = new System.Windows.Forms.TextBox();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(151, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(979, 586);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // PhysicsTimer
            // 
            this.PhysicsTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "->";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // DrawTimer
            // 
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.label4);
            this.settingsGroupBox.Controls.Add(this.sunMassTextBox);
            this.settingsGroupBox.Controls.Add(this.label3);
            this.settingsGroupBox.Controls.Add(this.speedTextBox);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.RadiusTextBox);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Controls.Add(this.massTextBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 41);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(121, 200);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(15, 110);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(15, 71);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            this.RadiusTextBox.Text = "10";
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.RadiusTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass";
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(15, 32);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 0;
            this.massTextBox.Text = "10";
            this.massTextBox.TextChanged += new System.EventHandler(this.massTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sun mass";
            // 
            // sunMassTextBox
            // 
            this.sunMassTextBox.Location = new System.Drawing.Point(6, 174);
            this.sunMassTextBox.Name = "sunMassTextBox";
            this.sunMassTextBox.Size = new System.Drawing.Size(100, 20);
            this.sunMassTextBox.TabIndex = 5;
            this.sunMassTextBox.Text = "400";
            this.sunMassTextBox.TextChanged += new System.EventHandler(this.sunMassTextBox_TextChanged);
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.Location = new System.Drawing.Point(14, 279);
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.timeTrackBar.TabIndex = 1;
            this.timeTrackBar.Value = 5;
            this.timeTrackBar.Scroll += new System.EventHandler(this.timeTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time speed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTrackBar);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "MathProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer PhysicsTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sunMassTextBox;
        private System.Windows.Forms.TrackBar timeTrackBar;
        private System.Windows.Forms.Label label5;
    }
}

