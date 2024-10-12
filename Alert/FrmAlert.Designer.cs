namespace Alert
{
    partial class FrmAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlert));
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.BtnSuccess = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.BtnWarning = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.toggleSwitch1 = new Alert.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(770, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSuccess
            // 
            this.BtnSuccess.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSuccess.FlatAppearance.BorderSize = 0;
            this.BtnSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuccess.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSuccess.Location = new System.Drawing.Point(559, 214);
            this.BtnSuccess.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSuccess.Name = "BtnSuccess";
            this.BtnSuccess.Size = new System.Drawing.Size(150, 35);
            this.BtnSuccess.TabIndex = 1;
            this.BtnSuccess.Text = "Success";
            this.BtnSuccess.UseVisualStyleBackColor = false;
            this.BtnSuccess.Click += new System.EventHandler(this.BtnSuccess_Click);
            // 
            // BtnError
            // 
            this.BtnError.BackColor = System.Drawing.Color.LightPink;
            this.BtnError.FlatAppearance.BorderSize = 0;
            this.BtnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnError.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnError.Location = new System.Drawing.Point(391, 214);
            this.BtnError.Margin = new System.Windows.Forms.Padding(0);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(150, 35);
            this.BtnError.TabIndex = 2;
            this.BtnError.Text = "Error";
            this.BtnError.UseVisualStyleBackColor = false;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // BtnWarning
            // 
            this.BtnWarning.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnWarning.FlatAppearance.BorderSize = 0;
            this.BtnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWarning.ForeColor = System.Drawing.Color.Goldenrod;
            this.BtnWarning.Location = new System.Drawing.Point(226, 214);
            this.BtnWarning.Margin = new System.Windows.Forms.Padding(0);
            this.BtnWarning.Name = "BtnWarning";
            this.BtnWarning.Size = new System.Drawing.Size(150, 35);
            this.BtnWarning.TabIndex = 3;
            this.BtnWarning.Text = "Warning";
            this.BtnWarning.UseVisualStyleBackColor = false;
            this.BtnWarning.Click += new System.EventHandler(this.BtnWarning_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.LightBlue;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnInfo.Location = new System.Drawing.Point(65, 214);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(150, 35);
            this.BtnInfo.TabIndex = 4;
            this.BtnInfo.Text = "Information";
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.toggleSwitch1.IsOn = false;
            this.toggleSwitch1.LabelColor = System.Drawing.Color.White;
            this.toggleSwitch1.Location = new System.Drawing.Point(391, 84);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffColor = System.Drawing.Color.Red;
            this.toggleSwitch1.OffLabel = "OFF";
            this.toggleSwitch1.OnColor = System.Drawing.Color.Green;
            this.toggleSwitch1.OnLabel = "ON";
            this.toggleSwitch1.Radius = 20;
            this.toggleSwitch1.Size = new System.Drawing.Size(100, 40);
            this.toggleSwitch1.SwitchColor = System.Drawing.Color.White;
            this.toggleSwitch1.TabIndex = 5;
            // 
            // FrmAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnWarning);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.BtnSuccess);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Button BtnSuccess;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.Button BtnWarning;
        private System.Windows.Forms.Button BtnInfo;
        private ToggleSwitch toggleSwitch1;
    }
}

