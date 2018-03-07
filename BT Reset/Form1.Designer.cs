namespace BT_Reset
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
            this.Lbl_Desc_BTSystemService = new System.Windows.Forms.Label();
            this.Lbl_Desc_ServiceStatus = new System.Windows.Forms.Label();
            this.Label_SystemStatus = new System.Windows.Forms.Label();
            this.Label_IntegrationStatus = new System.Windows.Forms.Label();
            this.Label_Desc_IntegrationService = new System.Windows.Forms.Label();
            this.Label_PrintStatus = new System.Windows.Forms.Label();
            this.Label_Desc_PrintSchedService = new System.Windows.Forms.Label();
            this.Button_Restart = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.DEBUG_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Desc_BTSystemService
            // 
            this.Lbl_Desc_BTSystemService.AutoSize = true;
            this.Lbl_Desc_BTSystemService.Location = new System.Drawing.Point(40, 61);
            this.Lbl_Desc_BTSystemService.Name = "Lbl_Desc_BTSystemService";
            this.Lbl_Desc_BTSystemService.Size = new System.Drawing.Size(139, 13);
            this.Lbl_Desc_BTSystemService.TabIndex = 0;
            this.Lbl_Desc_BTSystemService.Text = "BarTender System Service: ";
            // 
            // Lbl_Desc_ServiceStatus
            // 
            this.Lbl_Desc_ServiceStatus.AutoSize = true;
            this.Lbl_Desc_ServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Desc_ServiceStatus.Location = new System.Drawing.Point(104, 19);
            this.Lbl_Desc_ServiceStatus.Name = "Lbl_Desc_ServiceStatus";
            this.Lbl_Desc_ServiceStatus.Size = new System.Drawing.Size(120, 20);
            this.Lbl_Desc_ServiceStatus.TabIndex = 1;
            this.Lbl_Desc_ServiceStatus.Text = "Services Status";
            // 
            // Label_SystemStatus
            // 
            this.Label_SystemStatus.AutoSize = true;
            this.Label_SystemStatus.BackColor = System.Drawing.Color.LightGreen;
            this.Label_SystemStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_SystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SystemStatus.Location = new System.Drawing.Point(185, 56);
            this.Label_SystemStatus.Name = "Label_SystemStatus";
            this.Label_SystemStatus.Size = new System.Drawing.Size(78, 22);
            this.Label_SystemStatus.TabIndex = 2;
            this.Label_SystemStatus.Text = "Running";
            // 
            // Label_IntegrationStatus
            // 
            this.Label_IntegrationStatus.AutoSize = true;
            this.Label_IntegrationStatus.BackColor = System.Drawing.Color.LightGreen;
            this.Label_IntegrationStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_IntegrationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IntegrationStatus.Location = new System.Drawing.Point(185, 99);
            this.Label_IntegrationStatus.Name = "Label_IntegrationStatus";
            this.Label_IntegrationStatus.Size = new System.Drawing.Size(78, 22);
            this.Label_IntegrationStatus.TabIndex = 4;
            this.Label_IntegrationStatus.Text = "Running";
            // 
            // Label_Desc_IntegrationService
            // 
            this.Label_Desc_IntegrationService.AutoSize = true;
            this.Label_Desc_IntegrationService.Location = new System.Drawing.Point(24, 104);
            this.Label_Desc_IntegrationService.Name = "Label_Desc_IntegrationService";
            this.Label_Desc_IntegrationService.Size = new System.Drawing.Size(155, 13);
            this.Label_Desc_IntegrationService.TabIndex = 3;
            this.Label_Desc_IntegrationService.Text = "BarTender Integration Service: ";
            // 
            // Label_PrintStatus
            // 
            this.Label_PrintStatus.AutoSize = true;
            this.Label_PrintStatus.BackColor = System.Drawing.Color.LightGreen;
            this.Label_PrintStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label_PrintStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PrintStatus.Location = new System.Drawing.Point(185, 149);
            this.Label_PrintStatus.Name = "Label_PrintStatus";
            this.Label_PrintStatus.Size = new System.Drawing.Size(78, 22);
            this.Label_PrintStatus.TabIndex = 6;
            this.Label_PrintStatus.Text = "Running";
            // 
            // Label_Desc_PrintSchedService
            // 
            this.Label_Desc_PrintSchedService.AutoSize = true;
            this.Label_Desc_PrintSchedService.Location = new System.Drawing.Point(40, 154);
            this.Label_Desc_PrintSchedService.Name = "Label_Desc_PrintSchedService";
            this.Label_Desc_PrintSchedService.Size = new System.Drawing.Size(138, 13);
            this.Label_Desc_PrintSchedService.TabIndex = 5;
            this.Label_Desc_PrintSchedService.Text = "BarTender Print Scheduler: ";
            // 
            // Button_Restart
            // 
            this.Button_Restart.Location = new System.Drawing.Point(27, 245);
            this.Button_Restart.Name = "Button_Restart";
            this.Button_Restart.Size = new System.Drawing.Size(85, 42);
            this.Button_Restart.TabIndex = 7;
            this.Button_Restart.Text = "Restart Services";
            this.Button_Restart.UseVisualStyleBackColor = true;
            this.Button_Restart.Click += new System.EventHandler(this.Button_Restart_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(43, 192);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(88, 36);
            this.Button_Stop.TabIndex = 8;
            this.Button_Stop.Text = "DEBUG Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(185, 192);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(89, 36);
            this.Button_Start.TabIndex = 9;
            this.Button_Start.Text = "DEBUG Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // DEBUG_Refresh
            // 
            this.DEBUG_Refresh.Location = new System.Drawing.Point(148, 245);
            this.DEBUG_Refresh.Name = "DEBUG_Refresh";
            this.DEBUG_Refresh.Size = new System.Drawing.Size(89, 42);
            this.DEBUG_Refresh.TabIndex = 10;
            this.DEBUG_Refresh.Text = "DEBUG Refresh";
            this.DEBUG_Refresh.UseVisualStyleBackColor = true;
            this.DEBUG_Refresh.Click += new System.EventHandler(this.DEBUG_Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 299);
            this.Controls.Add(this.DEBUG_Refresh);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Restart);
            this.Controls.Add(this.Label_PrintStatus);
            this.Controls.Add(this.Label_Desc_PrintSchedService);
            this.Controls.Add(this.Label_IntegrationStatus);
            this.Controls.Add(this.Label_Desc_IntegrationService);
            this.Controls.Add(this.Label_SystemStatus);
            this.Controls.Add(this.Lbl_Desc_ServiceStatus);
            this.Controls.Add(this.Lbl_Desc_BTSystemService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Desc_BTSystemService;
        private System.Windows.Forms.Label Lbl_Desc_ServiceStatus;
        private System.Windows.Forms.Label Label_SystemStatus;
        private System.Windows.Forms.Label Label_IntegrationStatus;
        private System.Windows.Forms.Label Label_Desc_IntegrationService;
        private System.Windows.Forms.Label Label_PrintStatus;
        private System.Windows.Forms.Label Label_Desc_PrintSchedService;
        private System.Windows.Forms.Button Button_Restart;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button DEBUG_Refresh;
    }
}

