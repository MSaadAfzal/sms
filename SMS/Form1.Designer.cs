namespace SMS
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.radius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.navBar = new System.Windows.Forms.FlowLayoutPanel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.seperator = new Bunifu.Framework.UI.BunifuSeparator();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.forward = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backward = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.topBar = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logo3 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.seperator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.basePanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.admin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ops = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ps = new Bunifu.Framework.UI.BunifuThinButton2();
            this.loginPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.close = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textboxID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.textboxPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ellipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transitions = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).BeginInit();
            this.basePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.ElipseRadius = 10;
            this.radius.TargetControl = this;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.Black;
            this.navBar.Controls.Add(this.logo1);
            this.navBar.Controls.Add(this.bunifuGradientPanel1);
            this.transitions.SetDecoration(this.navBar, BunifuAnimatorNS.DecorationType.None);
            this.navBar.Location = new System.Drawing.Point(-8, 1);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(115, 790);
            this.navBar.TabIndex = 0;
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.logo1, BunifuAnimatorNS.DecorationType.None);
            this.logo1.Image = ((System.Drawing.Image)(resources.GetObject("logo1.Image")));
            this.logo1.Location = new System.Drawing.Point(3, 3);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(140, 143);
            this.logo1.TabIndex = 3;
            this.logo1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.seperator);
            this.bunifuGradientPanel1.Controls.Add(this.logout);
            this.bunifuGradientPanel1.Controls.Add(this.settings);
            this.bunifuGradientPanel1.Controls.Add(this.forward);
            this.bunifuGradientPanel1.Controls.Add(this.backward);
            this.bunifuGradientPanel1.Controls.Add(this.home);
            this.transitions.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 152);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(112, 808);
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.seperator, BunifuAnimatorNS.DecorationType.None);
            this.seperator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.seperator.LineThickness = 4;
            this.seperator.Location = new System.Drawing.Point(14, 8);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(88, 10);
            this.seperator.TabIndex = 10;
            this.seperator.Transparency = 255;
            this.seperator.Vertical = false;
            // 
            // logout
            // 
            this.logout.Activecolor = System.Drawing.Color.DarkGray;
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.BorderRadius = 0;
            this.logout.ButtonText = "";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.DisabledColor = System.Drawing.Color.Gray;
            this.logout.Iconcolor = System.Drawing.Color.Transparent;
            this.logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("logout.Iconimage")));
            this.logout.Iconimage_right = null;
            this.logout.Iconimage_right_Selected = null;
            this.logout.Iconimage_Selected = null;
            this.logout.IconMarginLeft = 40;
            this.logout.IconMarginRight = 0;
            this.logout.IconRightVisible = true;
            this.logout.IconRightZoom = 0D;
            this.logout.IconVisible = true;
            this.logout.IconZoom = 70D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(2, 493);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(112, 64);
            this.logout.TabIndex = 9;
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Textcolor = System.Drawing.Color.Black;
            this.logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // settings
            // 
            this.settings.Activecolor = System.Drawing.Color.DarkGray;
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings.BorderRadius = 0;
            this.settings.ButtonText = "";
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.settings, BunifuAnimatorNS.DecorationType.None);
            this.settings.DisabledColor = System.Drawing.Color.Gray;
            this.settings.Iconcolor = System.Drawing.Color.Transparent;
            this.settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("settings.Iconimage")));
            this.settings.Iconimage_right = null;
            this.settings.Iconimage_right_Selected = null;
            this.settings.Iconimage_Selected = null;
            this.settings.IconMarginLeft = 40;
            this.settings.IconMarginRight = 0;
            this.settings.IconRightVisible = true;
            this.settings.IconRightZoom = 0D;
            this.settings.IconVisible = true;
            this.settings.IconZoom = 70D;
            this.settings.IsTab = false;
            this.settings.Location = new System.Drawing.Point(0, 388);
            this.settings.Name = "settings";
            this.settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.settings.OnHoverTextColor = System.Drawing.Color.White;
            this.settings.selected = false;
            this.settings.Size = new System.Drawing.Size(112, 64);
            this.settings.TabIndex = 9;
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Textcolor = System.Drawing.Color.Black;
            this.settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // forward
            // 
            this.forward.Activecolor = System.Drawing.Color.DarkGray;
            this.forward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forward.BorderRadius = 0;
            this.forward.ButtonText = "";
            this.forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.forward, BunifuAnimatorNS.DecorationType.None);
            this.forward.DisabledColor = System.Drawing.Color.Gray;
            this.forward.Iconcolor = System.Drawing.Color.Transparent;
            this.forward.Iconimage = ((System.Drawing.Image)(resources.GetObject("forward.Iconimage")));
            this.forward.Iconimage_right = null;
            this.forward.Iconimage_right_Selected = null;
            this.forward.Iconimage_Selected = null;
            this.forward.IconMarginLeft = 40;
            this.forward.IconMarginRight = 0;
            this.forward.IconRightVisible = true;
            this.forward.IconRightZoom = 0D;
            this.forward.IconVisible = true;
            this.forward.IconZoom = 70D;
            this.forward.IsTab = false;
            this.forward.Location = new System.Drawing.Point(0, 173);
            this.forward.Name = "forward";
            this.forward.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.forward.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.forward.OnHoverTextColor = System.Drawing.Color.White;
            this.forward.selected = false;
            this.forward.Size = new System.Drawing.Size(112, 64);
            this.forward.TabIndex = 9;
            this.forward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forward.Textcolor = System.Drawing.Color.Black;
            this.forward.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // backward
            // 
            this.backward.Activecolor = System.Drawing.Color.DarkGray;
            this.backward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backward.BorderRadius = 0;
            this.backward.ButtonText = "";
            this.backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.backward, BunifuAnimatorNS.DecorationType.None);
            this.backward.DisabledColor = System.Drawing.Color.Gray;
            this.backward.Iconcolor = System.Drawing.Color.Transparent;
            this.backward.Iconimage = ((System.Drawing.Image)(resources.GetObject("backward.Iconimage")));
            this.backward.Iconimage_right = null;
            this.backward.Iconimage_right_Selected = null;
            this.backward.Iconimage_Selected = null;
            this.backward.IconMarginLeft = 40;
            this.backward.IconMarginRight = 0;
            this.backward.IconRightVisible = true;
            this.backward.IconRightZoom = 0D;
            this.backward.IconVisible = true;
            this.backward.IconZoom = 70D;
            this.backward.IsTab = false;
            this.backward.Location = new System.Drawing.Point(2, 279);
            this.backward.Name = "backward";
            this.backward.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.backward.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.backward.OnHoverTextColor = System.Drawing.Color.White;
            this.backward.selected = false;
            this.backward.Size = new System.Drawing.Size(112, 64);
            this.backward.TabIndex = 9;
            this.backward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backward.Textcolor = System.Drawing.Color.Black;
            this.backward.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backward.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // home
            // 
            this.home.Activecolor = System.Drawing.Color.DarkGray;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.BorderRadius = 0;
            this.home.ButtonText = "";
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.home, BunifuAnimatorNS.DecorationType.None);
            this.home.DisabledColor = System.Drawing.Color.Gray;
            this.home.Iconcolor = System.Drawing.Color.Transparent;
            this.home.Iconimage = ((System.Drawing.Image)(resources.GetObject("home.Iconimage")));
            this.home.Iconimage_right = null;
            this.home.Iconimage_right_Selected = null;
            this.home.Iconimage_Selected = null;
            this.home.IconMarginLeft = 40;
            this.home.IconMarginRight = 0;
            this.home.IconRightVisible = true;
            this.home.IconRightZoom = 0D;
            this.home.IconVisible = true;
            this.home.IconZoom = 70D;
            this.home.IsTab = false;
            this.home.Location = new System.Drawing.Point(0, 72);
            this.home.Name = "home";
            this.home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.home.OnHoverTextColor = System.Drawing.Color.White;
            this.home.selected = false;
            this.home.Size = new System.Drawing.Size(112, 64);
            this.home.TabIndex = 9;
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Textcolor = System.Drawing.Color.Black;
            this.home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.DarkRed;
            this.topBar.Controls.Add(this.heading);
            this.topBar.Controls.Add(this.logo);
            this.topBar.Controls.Add(this.closeButton);
            this.transitions.SetDecoration(this.topBar, BunifuAnimatorNS.DecorationType.None);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1292, 93);
            this.topBar.TabIndex = 1;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.transitions.SetDecoration(this.heading, BunifuAnimatorNS.DecorationType.None);
            this.heading.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.heading.Location = new System.Drawing.Point(133, 20);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(467, 49);
            this.heading.TabIndex = 4;
            this.heading.Text = "SMS SECURITY SYSTEM";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-5, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 143);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.White;
            this.closeButton.ActiveForecolor = System.Drawing.Color.Black;
            this.closeButton.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.closeButton.BackColor = System.Drawing.Color.DarkRed;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = "X";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.DarkRed;
            this.closeButton.IdleForecolor = System.Drawing.Color.White;
            this.closeButton.IdleLineColor = System.Drawing.Color.Brown;
            this.closeButton.Location = new System.Drawing.Point(1249, 6);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 54);
            this.closeButton.TabIndex = 6;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logo3
            // 
            this.logo3.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.logo3, BunifuAnimatorNS.DecorationType.None);
            this.logo3.Image = ((System.Drawing.Image)(resources.GetObject("logo3.Image")));
            this.logo3.Location = new System.Drawing.Point(-18, 0);
            this.logo3.Name = "logo3";
            this.logo3.Size = new System.Drawing.Size(150, 151);
            this.logo3.TabIndex = 4;
            this.logo3.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.label, BunifuAnimatorNS.DecorationType.None);
            this.label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(518, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 33);
            this.label.TabIndex = 7;
            this.label.Text = "Login Panel";
            // 
            // seperator1
            // 
            this.seperator1.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.seperator1, BunifuAnimatorNS.DecorationType.None);
            this.seperator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seperator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.seperator1.LineThickness = 3;
            this.seperator1.Location = new System.Drawing.Point(556, 51);
            this.seperator1.Name = "seperator1";
            this.seperator1.Size = new System.Drawing.Size(97, 14);
            this.seperator1.TabIndex = 8;
            this.seperator1.Transparency = 255;
            this.seperator1.Vertical = false;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.White;
            this.basePanel.Controls.Add(this.buttonsPanel);
            this.basePanel.Controls.Add(this.loginPanel);
            this.basePanel.Controls.Add(this.label);
            this.basePanel.Controls.Add(this.seperator1);
            this.transitions.SetDecoration(this.basePanel, BunifuAnimatorNS.DecorationType.None);
            this.basePanel.Location = new System.Drawing.Point(141, 113);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(1111, 665);
            this.basePanel.TabIndex = 9;
            this.basePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.basePanel_Paint);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsPanel.BackgroundImage")));
            this.buttonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsPanel.Controls.Add(this.admin);
            this.buttonsPanel.Controls.Add(this.ops);
            this.buttonsPanel.Controls.Add(this.bm);
            this.buttonsPanel.Controls.Add(this.ps);
            this.transitions.SetDecoration(this.buttonsPanel, BunifuAnimatorNS.DecorationType.None);
            this.buttonsPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.buttonsPanel.GradientBottomRight = System.Drawing.Color.White;
            this.buttonsPanel.GradientTopLeft = System.Drawing.Color.AliceBlue;
            this.buttonsPanel.GradientTopRight = System.Drawing.Color.Ivory;
            this.buttonsPanel.Location = new System.Drawing.Point(149, 112);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Quality = 5;
            this.buttonsPanel.Size = new System.Drawing.Size(929, 485);
            this.buttonsPanel.TabIndex = 9;
            // 
            // admin
            // 
            this.admin.ActiveBorderThickness = 1;
            this.admin.ActiveCornerRadius = 20;
            this.admin.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.admin.ActiveForecolor = System.Drawing.Color.FloralWhite;
            this.admin.ActiveLineColor = System.Drawing.Color.White;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin.BackgroundImage")));
            this.admin.ButtonText = "Admin - Login";
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.admin, BunifuAnimatorNS.DecorationType.None);
            this.admin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Black;
            this.admin.IdleBorderThickness = 1;
            this.admin.IdleCornerRadius = 20;
            this.admin.IdleFillColor = System.Drawing.Color.White;
            this.admin.IdleForecolor = System.Drawing.Color.Black;
            this.admin.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.admin.Location = new System.Drawing.Point(165, 86);
            this.admin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(230, 140);
            this.admin.TabIndex = 4;
            this.admin.TabStop = false;
            this.admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // ops
            // 
            this.ops.ActiveBorderThickness = 1;
            this.ops.ActiveCornerRadius = 20;
            this.ops.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.ops.ActiveForecolor = System.Drawing.Color.FloralWhite;
            this.ops.ActiveLineColor = System.Drawing.Color.White;
            this.ops.BackColor = System.Drawing.Color.Transparent;
            this.ops.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ops.BackgroundImage")));
            this.ops.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ops.ButtonText = "Operation Supervisor";
            this.ops.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.ops, BunifuAnimatorNS.DecorationType.None);
            this.ops.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ops.ForeColor = System.Drawing.Color.Black;
            this.ops.IdleBorderThickness = 1;
            this.ops.IdleCornerRadius = 20;
            this.ops.IdleFillColor = System.Drawing.Color.White;
            this.ops.IdleForecolor = System.Drawing.Color.Black;
            this.ops.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.ops.Location = new System.Drawing.Point(571, 86);
            this.ops.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ops.Name = "ops";
            this.ops.Size = new System.Drawing.Size(230, 140);
            this.ops.TabIndex = 4;
            this.ops.TabStop = false;
            this.ops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ops.Click += new System.EventHandler(this.ops_Click);
            // 
            // bm
            // 
            this.bm.ActiveBorderThickness = 1;
            this.bm.ActiveCornerRadius = 20;
            this.bm.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.bm.ActiveForecolor = System.Drawing.Color.FloralWhite;
            this.bm.ActiveLineColor = System.Drawing.Color.White;
            this.bm.BackColor = System.Drawing.Color.Transparent;
            this.bm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bm.BackgroundImage")));
            this.bm.ButtonText = "Branch Manager";
            this.bm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.bm, BunifuAnimatorNS.DecorationType.None);
            this.bm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bm.ForeColor = System.Drawing.Color.Black;
            this.bm.IdleBorderThickness = 1;
            this.bm.IdleCornerRadius = 20;
            this.bm.IdleFillColor = System.Drawing.Color.White;
            this.bm.IdleForecolor = System.Drawing.Color.Black;
            this.bm.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.bm.Location = new System.Drawing.Point(165, 269);
            this.bm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bm.Name = "bm";
            this.bm.Size = new System.Drawing.Size(230, 140);
            this.bm.TabIndex = 4;
            this.bm.TabStop = false;
            this.bm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bm.Click += new System.EventHandler(this.bm_Click);
            // 
            // ps
            // 
            this.ps.ActiveBorderThickness = 1;
            this.ps.ActiveCornerRadius = 20;
            this.ps.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.ps.ActiveForecolor = System.Drawing.Color.FloralWhite;
            this.ps.ActiveLineColor = System.Drawing.Color.White;
            this.ps.BackColor = System.Drawing.Color.Transparent;
            this.ps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ps.BackgroundImage")));
            this.ps.ButtonText = "Patrolling Supervisor";
            this.ps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.ps, BunifuAnimatorNS.DecorationType.None);
            this.ps.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ps.ForeColor = System.Drawing.Color.Black;
            this.ps.IdleBorderThickness = 1;
            this.ps.IdleCornerRadius = 20;
            this.ps.IdleFillColor = System.Drawing.Color.White;
            this.ps.IdleForecolor = System.Drawing.Color.Black;
            this.ps.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.ps.Location = new System.Drawing.Point(571, 265);
            this.ps.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(230, 140);
            this.ps.TabIndex = 4;
            this.ps.TabStop = false;
            this.ps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ps.Click += new System.EventHandler(this.ps_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.close);
            this.loginPanel.Controls.Add(this.logIn);
            this.loginPanel.Controls.Add(this.textboxID);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Controls.Add(this.IDlabel);
            this.loginPanel.Controls.Add(this.textboxPass);
            this.transitions.SetDecoration(this.loginPanel, BunifuAnimatorNS.DecorationType.None);
            this.loginPanel.GradientBottomLeft = System.Drawing.Color.Silver;
            this.loginPanel.GradientBottomRight = System.Drawing.Color.White;
            this.loginPanel.GradientTopLeft = System.Drawing.Color.White;
            this.loginPanel.GradientTopRight = System.Drawing.Color.Linen;
            this.loginPanel.Location = new System.Drawing.Point(370, 138);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Quality = 10;
            this.loginPanel.Size = new System.Drawing.Size(456, 429);
            this.loginPanel.TabIndex = 3;
            // 
            // close
            // 
            this.close.ActiveBorderThickness = 1;
            this.close.ActiveCornerRadius = 20;
            this.close.ActiveFillColor = System.Drawing.Color.White;
            this.close.ActiveForecolor = System.Drawing.Color.Black;
            this.close.ActiveLineColor = System.Drawing.Color.Transparent;
            this.close.BackColor = System.Drawing.Color.White;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.ButtonText = "X";
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.close, BunifuAnimatorNS.DecorationType.None);
            this.close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.IdleBorderThickness = 1;
            this.close.IdleCornerRadius = 20;
            this.close.IdleFillColor = System.Drawing.Color.Transparent;
            this.close.IdleForecolor = System.Drawing.Color.Black;
            this.close.IdleLineColor = System.Drawing.Color.Gray;
            this.close.Location = new System.Drawing.Point(415, 6);
            this.close.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 45);
            this.close.TabIndex = 7;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // logIn
            // 
            this.logIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logIn.BorderRadius = 0;
            this.logIn.ButtonText = "     Login";
            this.logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitions.SetDecoration(this.logIn, BunifuAnimatorNS.DecorationType.None);
            this.logIn.DisabledColor = System.Drawing.Color.Gray;
            this.logIn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Iconcolor = System.Drawing.Color.Transparent;
            this.logIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("logIn.Iconimage")));
            this.logIn.Iconimage_right = null;
            this.logIn.Iconimage_right_Selected = null;
            this.logIn.Iconimage_Selected = null;
            this.logIn.IconMarginLeft = 0;
            this.logIn.IconMarginRight = 0;
            this.logIn.IconRightVisible = true;
            this.logIn.IconRightZoom = 0D;
            this.logIn.IconVisible = true;
            this.logIn.IconZoom = 20D;
            this.logIn.IsTab = false;
            this.logIn.Location = new System.Drawing.Point(303, 303);
            this.logIn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.logIn.Name = "logIn";
            this.logIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.logIn.OnHoverTextColor = System.Drawing.Color.White;
            this.logIn.selected = false;
            this.logIn.Size = new System.Drawing.Size(133, 41);
            this.logIn.TabIndex = 2;
            this.logIn.Text = "     Login";
            this.logIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logIn.Textcolor = System.Drawing.Color.White;
            this.logIn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // textboxID
            // 
            this.textboxID.BackColor = System.Drawing.Color.White;
            this.textboxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitions.SetDecoration(this.textboxID, BunifuAnimatorNS.DecorationType.None);
            this.textboxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxID.HintForeColor = System.Drawing.Color.Empty;
            this.textboxID.HintText = "user-name";
            this.textboxID.isPassword = false;
            this.textboxID.LineFocusedColor = System.Drawing.Color.Black;
            this.textboxID.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxID.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.textboxID.LineThickness = 3;
            this.textboxID.Location = new System.Drawing.Point(222, 88);
            this.textboxID.Margin = new System.Windows.Forms.Padding(4);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(214, 33);
            this.textboxID.TabIndex = 10;
            this.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.passLabel, BunifuAnimatorNS.DecorationType.None);
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(29, 194);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(143, 30);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Password : ";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.transitions.SetDecoration(this.IDlabel, BunifuAnimatorNS.DecorationType.None);
            this.IDlabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(29, 91);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(58, 30);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID : ";
            // 
            // textboxPass
            // 
            this.textboxPass.BackColor = System.Drawing.Color.White;
            this.textboxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitions.SetDecoration(this.textboxPass, BunifuAnimatorNS.DecorationType.None);
            this.textboxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxPass.HintForeColor = System.Drawing.Color.Empty;
            this.textboxPass.HintText = "•••••••";
            this.textboxPass.isPassword = true;
            this.textboxPass.LineFocusedColor = System.Drawing.Color.Black;
            this.textboxPass.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxPass.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.textboxPass.LineThickness = 3;
            this.textboxPass.Location = new System.Drawing.Point(222, 194);
            this.textboxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPass.Name = "textboxPass";
            this.textboxPass.Size = new System.Drawing.Size(214, 33);
            this.textboxPass.TabIndex = 10;
            this.textboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ellipse
            // 
            this.ellipse.ElipseRadius = 39;
            this.ellipse.TargetControl = this.basePanel;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ElipseRadius = 40;
            this.buttonPanel.TargetControl = this.buttonsPanel;
            // 
            // transitions
            // 
            this.transitions.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transitions.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transitions.DefaultAnimation = animation1;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1292, 720);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.logo3);
            this.transitions.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse radius;
        private System.Windows.Forms.FlowLayoutPanel navBar;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.PictureBox logo3;
        private Bunifu.Framework.UI.BunifuThinButton2 closeButton;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Label label;
        private Bunifu.Framework.UI.BunifuSeparator seperator1;
        private Bunifu.Framework.UI.BunifuElipse ellipse;
        private Bunifu.Framework.UI.BunifuFlatButton home;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuSeparator seperator;
        private Bunifu.Framework.UI.BunifuFlatButton forward;
        private Bunifu.Framework.UI.BunifuFlatButton settings;
        private Bunifu.Framework.UI.BunifuFlatButton backward;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton logIn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label IDlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxID;
        private Bunifu.Framework.UI.BunifuGradientPanel loginPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 close;
        private Bunifu.Framework.UI.BunifuGradientPanel buttonsPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 admin;
        private Bunifu.Framework.UI.BunifuThinButton2 ops;
        private Bunifu.Framework.UI.BunifuThinButton2 bm;
        private Bunifu.Framework.UI.BunifuThinButton2 ps;
        private Bunifu.Framework.UI.BunifuElipse buttonPanel;
        private BunifuAnimatorNS.BunifuTransition transitions;
    }
}

