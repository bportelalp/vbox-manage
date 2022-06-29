namespace BP.VBoxManage
{
    partial class MainWindow
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
            this.logOutput = new System.Windows.Forms.TextBox();
            this.btnState = new System.Windows.Forms.Button();
            this.cbVMs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutput
            // 
            this.logOutput.Location = new System.Drawing.Point(59, 151);
            this.logOutput.Multiline = true;
            this.logOutput.Name = "logOutput";
            this.logOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logOutput.Size = new System.Drawing.Size(671, 245);
            this.logOutput.TabIndex = 0;
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(73, 63);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(85, 68);
            this.btnState.TabIndex = 1;
            this.btnState.Text = "Estado";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // cbVMs
            // 
            this.cbVMs.FormattingEnabled = true;
            this.cbVMs.Location = new System.Drawing.Point(187, 17);
            this.cbVMs.Name = "cbVMs";
            this.cbVMs.Size = new System.Drawing.Size(229, 23);
            this.cbVMs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Máquina virtual";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(164, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 68);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Arrancar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(255, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 68);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVMs);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.logOutput);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox logOutput;
        private Button btnState;
        private ComboBox cbVMs;
        private Label label1;
        private Button btnStart;
        private Button btnStop;
    }
}