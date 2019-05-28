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
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(106, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1024, 586);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 602);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "MathProject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Timer PhysicsTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer DrawTimer;
    }
}

