namespace MTDSpoofer_GUI
{
    partial class south_africa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(south_africa));
            spoofall = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            dnsflush = new MetroFramework.Controls.MetroCheckBox();
            windowslogs = new MetroFramework.Controls.MetroCheckBox();
            tempfi = new MetroFramework.Controls.MetroCheckBox();
            wintempp = new MetroFramework.Controls.MetroCheckBox();
            tcpp = new MetroFramework.Controls.MetroCheckBox();
            wifireset = new MetroFramework.Controls.MetroCheckBox();
            chromecookies = new MetroFramework.Controls.MetroCheckBox();
            firefoxcookies = new MetroFramework.Controls.MetroCheckBox();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            fivemm = new MetroFramework.Controls.MetroCheckBox();
            unlinkxbox = new MetroFramework.Controls.MetroCheckBox();
            unlinkdc = new MetroFramework.Controls.MetroCheckBox();
            SuspendLayout();
            // 
            // spoofall
            // 
            spoofall.Animated = true;
            spoofall.AutoRoundedCorners = true;
            spoofall.BackColor = Color.Transparent;
            spoofall.BorderColor = Color.White;
            spoofall.BorderRadius = 15;
            spoofall.BorderThickness = 1;
            spoofall.CustomBorderColor = Color.Transparent;
            spoofall.DisabledState.BorderColor = Color.DarkGray;
            spoofall.DisabledState.CustomBorderColor = Color.DarkGray;
            spoofall.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            spoofall.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            spoofall.FillColor = Color.Transparent;
            spoofall.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            spoofall.ForeColor = Color.White;
            spoofall.Location = new Point(21, 307);
            spoofall.Name = "spoofall";
            spoofall.PressedDepth = 60;
            spoofall.Size = new Size(263, 32);
            spoofall.TabIndex = 18;
            spoofall.Text = "Start Cleaning";
            spoofall.Click += spoofall_Click;
            // 
            // dnsflush
            // 
            dnsflush.AutoSize = true;
            dnsflush.Location = new Point(26, 87);
            dnsflush.Name = "dnsflush";
            dnsflush.Size = new Size(74, 15);
            dnsflush.Style = MetroFramework.MetroColorStyle.Magenta;
            dnsflush.TabIndex = 26;
            dnsflush.Text = "FlushDNS";
            dnsflush.Theme = MetroFramework.MetroThemeStyle.Dark;
            dnsflush.UseVisualStyleBackColor = true;
            dnsflush.CheckedChanged += dnsflush_CheckedChanged;
            // 
            // windowslogs
            // 
            windowslogs.AutoSize = true;
            windowslogs.Location = new Point(26, 255);
            windowslogs.Name = "windowslogs";
            windowslogs.Size = new Size(100, 15);
            windowslogs.Style = MetroFramework.MetroColorStyle.Magenta;
            windowslogs.TabIndex = 27;
            windowslogs.Text = "Windows Logs";
            windowslogs.Theme = MetroFramework.MetroThemeStyle.Dark;
            windowslogs.UseVisualStyleBackColor = true;
            windowslogs.CheckedChanged += windowslogs_CheckedChanged;
            // 
            // tempfi
            // 
            tempfi.AutoSize = true;
            tempfi.Location = new Point(26, 213);
            tempfi.Name = "tempfi";
            tempfi.Size = new Size(105, 15);
            tempfi.Style = MetroFramework.MetroColorStyle.Magenta;
            tempfi.TabIndex = 28;
            tempfi.Text = "Temporary Files";
            tempfi.Theme = MetroFramework.MetroThemeStyle.Dark;
            tempfi.UseVisualStyleBackColor = true;
            tempfi.CheckedChanged += tempfi_CheckedChanged;
            // 
            // wintempp
            // 
            wintempp.AutoSize = true;
            wintempp.Location = new Point(26, 234);
            wintempp.Name = "wintempp";
            wintempp.Size = new Size(140, 15);
            wintempp.Style = MetroFramework.MetroColorStyle.Magenta;
            wintempp.TabIndex = 29;
            wintempp.Text = "Windows Temp Folder";
            wintempp.Theme = MetroFramework.MetroThemeStyle.Dark;
            wintempp.UseVisualStyleBackColor = true;
            wintempp.CheckedChanged += wintempp_CheckedChanged;
            // 
            // tcpp
            // 
            tcpp.AutoSize = true;
            tcpp.Location = new Point(26, 108);
            tcpp.Name = "tcpp";
            tcpp.Size = new Size(74, 15);
            tcpp.Style = MetroFramework.MetroColorStyle.Magenta;
            tcpp.TabIndex = 30;
            tcpp.Text = "TCP Reset";
            tcpp.Theme = MetroFramework.MetroThemeStyle.Dark;
            tcpp.UseVisualStyleBackColor = true;
            tcpp.CheckedChanged += tcpp_CheckedChanged;
            // 
            // wifireset
            // 
            wifireset.AutoSize = true;
            wifireset.Location = new Point(26, 129);
            wifireset.Name = "wifireset";
            wifireset.Size = new Size(99, 15);
            wifireset.Style = MetroFramework.MetroColorStyle.Magenta;
            wifireset.TabIndex = 32;
            wifireset.Text = "Full WIFI Reset";
            wifireset.Theme = MetroFramework.MetroThemeStyle.Dark;
            wifireset.UseVisualStyleBackColor = true;
            wifireset.CheckedChanged += wifireset_CheckedChanged;
            // 
            // chromecookies
            // 
            chromecookies.AutoSize = true;
            chromecookies.Location = new Point(180, 87);
            chromecookies.Name = "chromecookies";
            chromecookies.Size = new Size(111, 15);
            chromecookies.Style = MetroFramework.MetroColorStyle.Magenta;
            chromecookies.TabIndex = 36;
            chromecookies.Text = "Chrome Cookies";
            chromecookies.Theme = MetroFramework.MetroThemeStyle.Dark;
            chromecookies.UseVisualStyleBackColor = true;
            chromecookies.CheckedChanged += chromecookies_CheckedChanged;
            // 
            // firefoxcookies
            // 
            firefoxcookies.AutoSize = true;
            firefoxcookies.Location = new Point(180, 108);
            firefoxcookies.Name = "firefoxcookies";
            firefoxcookies.Size = new Size(104, 15);
            firefoxcookies.Style = MetroFramework.MetroColorStyle.Magenta;
            firefoxcookies.TabIndex = 37;
            firefoxcookies.Text = "Firefox Cookies";
            firefoxcookies.Theme = MetroFramework.MetroThemeStyle.Dark;
            firefoxcookies.UseVisualStyleBackColor = true;
            firefoxcookies.CheckedChanged += firefoxcookies_CheckedChanged;
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Location = new Point(21, 199);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(0, 0);
            metroLabel4.Style = MetroFramework.MetroColorStyle.Magenta;
            metroLabel4.TabIndex = 38;
            metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // fivemm
            // 
            fivemm.AutoSize = true;
            fivemm.Location = new Point(26, 192);
            fivemm.Name = "fivemm";
            fivemm.Size = new Size(55, 15);
            fivemm.Style = MetroFramework.MetroColorStyle.Magenta;
            fivemm.TabIndex = 40;
            fivemm.Text = "FiveM";
            fivemm.Theme = MetroFramework.MetroThemeStyle.Dark;
            fivemm.UseVisualStyleBackColor = true;
            fivemm.CheckedChanged += fivemm_CheckedChanged;
            // 
            // unlinkxbox
            // 
            unlinkxbox.AutoSize = true;
            unlinkxbox.Location = new Point(26, 150);
            unlinkxbox.Name = "unlinkxbox";
            unlinkxbox.Size = new Size(50, 15);
            unlinkxbox.Style = MetroFramework.MetroColorStyle.Magenta;
            unlinkxbox.TabIndex = 44;
            unlinkxbox.Text = "Xbox";
            unlinkxbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            unlinkxbox.UseVisualStyleBackColor = true;
            unlinkxbox.CheckedChanged += unlinkxbox_CheckedChanged;
            // 
            // unlinkdc
            // 
            unlinkdc.AutoSize = true;
            unlinkdc.Location = new Point(26, 171);
            unlinkdc.Name = "unlinkdc";
            unlinkdc.Size = new Size(63, 15);
            unlinkdc.Style = MetroFramework.MetroColorStyle.Magenta;
            unlinkdc.TabIndex = 45;
            unlinkdc.Text = "Discord";
            unlinkdc.Theme = MetroFramework.MetroThemeStyle.Dark;
            unlinkdc.UseVisualStyleBackColor = true;
            unlinkdc.CheckedChanged += unlinkdc_CheckedChanged;
            // 
            // south_africa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(313, 352);
            Controls.Add(unlinkdc);
            Controls.Add(unlinkxbox);
            Controls.Add(fivemm);
            Controls.Add(metroLabel4);
            Controls.Add(firefoxcookies);
            Controls.Add(chromecookies);
            Controls.Add(wifireset);
            Controls.Add(tcpp);
            Controls.Add(wintempp);
            Controls.Add(tempfi);
            Controls.Add(windowslogs);
            Controls.Add(dnsflush);
            Controls.Add(spoofall);
            
            Name = "south_africa";
            Resizable = false;
            ShadowType = MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Black;
            Text = "Cleaner";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += south_africa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton spoofall;
        private MetroFramework.Controls.MetroCheckBox dnsflush;
        private MetroFramework.Controls.MetroCheckBox windowslogs;
        private MetroFramework.Controls.MetroCheckBox tempfi;
        private MetroFramework.Controls.MetroCheckBox wintempp;
        private MetroFramework.Controls.MetroCheckBox tcpp;
        private MetroFramework.Controls.MetroCheckBox wifireset;
        private MetroFramework.Controls.MetroCheckBox chromecookies;
        private MetroFramework.Controls.MetroCheckBox firefoxcookies;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox fivemm;
        private MetroFramework.Controls.MetroCheckBox unlinkxbox;
        private MetroFramework.Controls.MetroCheckBox unlinkdc;
    }
}