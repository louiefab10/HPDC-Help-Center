namespace HPDC_Help_Center
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelIPAdd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelPCName = new MetroFramework.Controls.MetroLabel();
            this.labelOSVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(74, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IP Address:";
            // 
            // labelIPAdd
            // 
            this.labelIPAdd.AutoSize = true;
            this.labelIPAdd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelIPAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelIPAdd.Location = new System.Drawing.Point(228, 108);
            this.labelIPAdd.Name = "labelIPAdd";
            this.labelIPAdd.Size = new System.Drawing.Size(84, 25);
            this.labelIPAdd.TabIndex = 1;
            this.labelIPAdd.Text = "127.0.0.1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(74, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(148, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Computer Name:";
            // 
            // labelPCName
            // 
            this.labelPCName.AutoSize = true;
            this.labelPCName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelPCName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPCName.Location = new System.Drawing.Point(228, 158);
            this.labelPCName.Name = "labelPCName";
            this.labelPCName.Size = new System.Drawing.Size(88, 25);
            this.labelPCName.TabIndex = 3;
            this.labelPCName.Text = "PC NAME";
            // 
            // labelOSVersion
            // 
            this.labelOSVersion.AutoSize = true;
            this.labelOSVersion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelOSVersion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelOSVersion.Location = new System.Drawing.Point(228, 215);
            this.labelOSVersion.Name = "labelOSVersion";
            this.labelOSVersion.Size = new System.Drawing.Size(114, 25);
            this.labelOSVersion.TabIndex = 5;
            this.labelOSVersion.Text = "OS VERSION";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(74, 215);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "OS Version:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOSVersion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelPCName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.labelIPAdd);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "HPDC Help Center";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelIPAdd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelPCName;
        private MetroFramework.Controls.MetroLabel labelOSVersion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

