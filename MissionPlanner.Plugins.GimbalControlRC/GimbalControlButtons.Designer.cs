namespace MissionPlanner.Plugins.GimbalControlRC
{
    partial class GimbalControlButtons
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
            this.zoomIn = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.btnReatract = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.joystickEnable = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(8, 8);
            this.zoomIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(65, 19);
            this.zoomIn.TabIndex = 0;
            this.zoomIn.Text = "Zoom in";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(9, 30);
            this.zoomOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(65, 19);
            this.zoomOut.TabIndex = 1;
            this.zoomOut.Text = "Zoom out";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // btnReatract
            // 
            this.btnReatract.Location = new System.Drawing.Point(77, 8);
            this.btnReatract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReatract.Name = "btnReatract";
            this.btnReatract.Size = new System.Drawing.Size(65, 19);
            this.btnReatract.TabIndex = 7;
            this.btnReatract.Text = "Reatract";
            this.btnReatract.UseVisualStyleBackColor = true;
            this.btnReatract.Click += new System.EventHandler(this.btnReatract_Click);
            // 
            // btnNeutral
            // 
            this.btnNeutral.Location = new System.Drawing.Point(77, 30);
            this.btnNeutral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(65, 19);
            this.btnNeutral.TabIndex = 8;
            this.btnNeutral.Text = "Neutral";
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.Click += new System.EventHandler(this.btnNeutral_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // joystickEnable
            // 
            this.joystickEnable.AutoSize = true;
            this.joystickEnable.Enabled = false;
            this.joystickEnable.Location = new System.Drawing.Point(9, 53);
            this.joystickEnable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joystickEnable.Name = "joystickEnable";
            this.joystickEnable.Size = new System.Drawing.Size(64, 17);
            this.joystickEnable.TabIndex = 15;
            this.joystickEnable.Text = "Joystick";
            this.joystickEnable.UseVisualStyleBackColor = true;
            this.joystickEnable.CheckedChanged += new System.EventHandler(this.joystickEnable_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(8, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "X Reverse";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(94, 75);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Y Reverse";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // GimbalControlButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 258);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.joystickEnable);
            this.Controls.Add(this.btnNeutral);
            this.Controls.Add(this.btnReatract);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.zoomIn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(219, 222);
            this.Name = "GimbalControlButtons";
            this.Text = " Gimbal control";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button btnReatract;
        private System.Windows.Forms.Button btnNeutral;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.CheckBox joystickEnable;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}