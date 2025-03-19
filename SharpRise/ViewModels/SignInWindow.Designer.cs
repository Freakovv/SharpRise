namespace SharpRise
{
    partial class SignInWindow
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInWindow));
            border = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            layoutItems = new TableLayoutPanel();
            panelItems = new Panel();
            label1 = new Label();
            btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            btnForgot = new Guna.UI2.WinForms.Guna2Button();
            textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            textBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            textOR = new Label();
            separator1 = new Guna.UI2.WinForms.Guna2Separator();
            btnAuthGoogle = new Guna.UI2.WinForms.Guna2Button();
            layoutMainWindow = new TableLayoutPanel();
            btnLanguage = new Guna.UI2.WinForms.Guna2Button();
            btnGit = new Guna.UI2.WinForms.Guna2Button();
            head = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            textHead = new Label();
            dragMainWindow = new Guna.UI2.WinForms.Guna2DragControl(components);
            label2 = new Label();
            ShadowPanel.SuspendLayout();
            layoutItems.SuspendLayout();
            panelItems.SuspendLayout();
            layoutMainWindow.SuspendLayout();
            head.SuspendLayout();
            SuspendLayout();
            // 
            // border
            // 
            border.BorderRadius = 10;
            border.ContainerControl = this;
            border.DockIndicatorTransparencyValue = 0.6D;
            border.TransparentWhileDrag = true;
            // 
            // ShadowPanel
            // 
            ShadowPanel.BackColor = Color.Transparent;
            ShadowPanel.Controls.Add(layoutItems);
            resources.ApplyResources(ShadowPanel, "ShadowPanel");
            ShadowPanel.FillColor = Color.FromArgb(34, 35, 39);
            ShadowPanel.Name = "ShadowPanel";
            ShadowPanel.Radius = 5;
            ShadowPanel.ShadowColor = Color.Black;
            // 
            // layoutItems
            // 
            resources.ApplyResources(layoutItems, "layoutItems");
            layoutItems.Controls.Add(panelItems, 0, 1);
            layoutItems.Name = "layoutItems";
            // 
            // panelItems
            // 
            resources.ApplyResources(panelItems, "panelItems");
            panelItems.Controls.Add(label1);
            panelItems.Controls.Add(btnSignUp);
            panelItems.Controls.Add(btnSignIn);
            panelItems.Controls.Add(btnForgot);
            panelItems.Controls.Add(textBoxPassword);
            panelItems.Controls.Add(textBoxLogin);
            panelItems.Controls.Add(guna2Separator1);
            panelItems.Controls.Add(textOR);
            panelItems.Controls.Add(separator1);
            panelItems.Controls.Add(btnAuthGoogle);
            panelItems.Name = "panelItems";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(201, 201, 201);
            label1.Name = "label1";
            // 
            // btnSignUp
            // 
            btnSignUp.BorderRadius = 10;
            btnSignUp.CustomizableEdges = customizableEdges5;
            btnSignUp.DisabledState.BorderColor = Color.DarkGray;
            btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignUp.FillColor = Color.FromArgb(34, 35, 39);
            resources.ApplyResources(btnSignUp, "btnSignUp");
            btnSignUp.ForeColor = Color.FromArgb(201, 201, 201);
            btnSignUp.HoverState.FillColor = Color.FromArgb(34, 35, 39);
            btnSignUp.HoverState.ForeColor = Color.FromArgb(103, 149, 222);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.PressedDepth = 0;
            btnSignUp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSignUp.TextOffset = new Point(-10, 0);
            // 
            // btnSignIn
            // 
            btnSignIn.BorderRadius = 8;
            btnSignIn.CustomizableEdges = customizableEdges7;
            btnSignIn.DisabledState.BorderColor = Color.DarkGray;
            btnSignIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignIn.FillColor = Color.FromArgb(186, 67, 43);
            resources.ApplyResources(btnSignIn, "btnSignIn");
            btnSignIn.ForeColor = Color.FromArgb(225, 228, 231);
            btnSignIn.HoverState.FillColor = Color.FromArgb(207, 75, 50);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.PressedColor = Color.White;
            btnSignIn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            // 
            // btnForgot
            // 
            btnForgot.CustomizableEdges = customizableEdges9;
            btnForgot.DisabledState.BorderColor = Color.DarkGray;
            btnForgot.DisabledState.CustomBorderColor = Color.DarkGray;
            btnForgot.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnForgot.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnForgot.FillColor = Color.FromArgb(34, 35, 39);
            resources.ApplyResources(btnForgot, "btnForgot");
            btnForgot.ForeColor = Color.FromArgb(201, 201, 201);
            btnForgot.HoverState.FillColor = Color.FromArgb(34, 35, 39);
            btnForgot.HoverState.ForeColor = Color.FromArgb(103, 149, 222);
            btnForgot.Name = "btnForgot";
            btnForgot.PressedDepth = 0;
            btnForgot.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnForgot.TextOffset = new Point(-10, 0);
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderColor = Color.FromArgb(63, 63, 70);
            textBoxPassword.BorderRadius = 10;
            customizableEdges11.TopLeft = false;
            customizableEdges11.TopRight = false;
            textBoxPassword.CustomizableEdges = customizableEdges11;
            textBoxPassword.DefaultText = "";
            textBoxPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxPassword.FillColor = Color.FromArgb(39, 39, 42);
            textBoxPassword.FocusedState.BorderColor = Color.FromArgb(75, 85, 99);
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.IconLeft = Properties.Resources._lock;
            textBoxPassword.IconLeftOffset = new Point(3, 0);
            textBoxPassword.IconLeftSize = new Size(21, 23);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderForeColor = Color.FromArgb(113, 113, 122);
            textBoxPassword.PlaceholderText = "password";
            textBoxPassword.SelectedText = "";
            textBoxPassword.ShadowDecoration.CustomizableEdges = customizableEdges12;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BorderColor = Color.FromArgb(63, 63, 70);
            textBoxLogin.BorderRadius = 10;
            customizableEdges13.BottomLeft = false;
            customizableEdges13.BottomRight = false;
            textBoxLogin.CustomizableEdges = customizableEdges13;
            textBoxLogin.DefaultText = "";
            textBoxLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxLogin.FillColor = Color.FromArgb(39, 39, 42);
            textBoxLogin.FocusedState.BorderColor = Color.FromArgb(75, 85, 99);
            resources.ApplyResources(textBoxLogin, "textBoxLogin");
            textBoxLogin.IconLeft = Properties.Resources.mail;
            textBoxLogin.IconLeftOffset = new Point(3, 0);
            textBoxLogin.IconLeftSize = new Size(21, 21);
            textBoxLogin.MaxLength = 254;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderForeColor = Color.FromArgb(113, 113, 122);
            textBoxLogin.PlaceholderText = "email";
            textBoxLogin.SelectedText = "";
            textBoxLogin.ShadowDecoration.CustomizableEdges = customizableEdges14;
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(guna2Separator1, "guna2Separator1");
            guna2Separator1.FillColor = Color.FromArgb(63, 63, 70);
            guna2Separator1.Name = "guna2Separator1";
            // 
            // textOR
            // 
            resources.ApplyResources(textOR, "textOR");
            textOR.BackColor = Color.FromArgb(34, 35, 39);
            textOR.ForeColor = Color.FromArgb(63, 63, 70);
            textOR.Name = "textOR";
            // 
            // separator1
            // 
            resources.ApplyResources(separator1, "separator1");
            separator1.FillColor = Color.FromArgb(63, 63, 70);
            separator1.Name = "separator1";
            // 
            // btnAuthGoogle
            // 
            resources.ApplyResources(btnAuthGoogle, "btnAuthGoogle");
            btnAuthGoogle.BorderColor = Color.Gray;
            btnAuthGoogle.BorderRadius = 10;
            btnAuthGoogle.BorderThickness = 1;
            btnAuthGoogle.CustomizableEdges = customizableEdges15;
            btnAuthGoogle.DisabledState.BorderColor = Color.DarkGray;
            btnAuthGoogle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAuthGoogle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAuthGoogle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAuthGoogle.FillColor = Color.FromArgb(39, 39, 41);
            btnAuthGoogle.ForeColor = Color.FromArgb(225, 228, 231);
            btnAuthGoogle.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnAuthGoogle.Image = Properties.Resources.google;
            btnAuthGoogle.ImageAlign = HorizontalAlignment.Right;
            btnAuthGoogle.ImageOffset = new Point(60, 0);
            btnAuthGoogle.Name = "btnAuthGoogle";
            btnAuthGoogle.PressedDepth = 0;
            btnAuthGoogle.ShadowDecoration.CustomizableEdges = customizableEdges16;
            // 
            // layoutMainWindow
            // 
            resources.ApplyResources(layoutMainWindow, "layoutMainWindow");
            layoutMainWindow.Controls.Add(ShadowPanel, 1, 0);
            layoutMainWindow.Controls.Add(btnLanguage, 0, 0);
            layoutMainWindow.Controls.Add(btnGit, 2, 1);
            layoutMainWindow.Controls.Add(label2, 0, 1);
            layoutMainWindow.Name = "layoutMainWindow";
            // 
            // btnLanguage
            // 
            btnLanguage.BorderColor = Color.Gray;
            btnLanguage.BorderRadius = 10;
            btnLanguage.BorderThickness = 1;
            btnLanguage.CustomizableEdges = customizableEdges17;
            btnLanguage.DisabledState.BorderColor = Color.DarkGray;
            btnLanguage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLanguage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLanguage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLanguage.FillColor = Color.FromArgb(39, 39, 41);
            resources.ApplyResources(btnLanguage, "btnLanguage");
            btnLanguage.ForeColor = Color.White;
            btnLanguage.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.ShadowDecoration.CustomizableEdges = customizableEdges18;
            // 
            // btnGit
            // 
            resources.ApplyResources(btnGit, "btnGit");
            btnGit.BorderColor = Color.Gray;
            btnGit.BorderRadius = 10;
            btnGit.BorderThickness = 1;
            btnGit.CustomizableEdges = customizableEdges19;
            btnGit.DisabledState.BorderColor = Color.DarkGray;
            btnGit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGit.FillColor = Color.FromArgb(39, 39, 41);
            btnGit.ForeColor = Color.White;
            btnGit.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnGit.Image = (Image)resources.GetObject("btnGit.Image");
            btnGit.ImageAlign = HorizontalAlignment.Right;
            btnGit.Name = "btnGit";
            btnGit.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnGit.TextOffset = new Point(-10, 0);
            // 
            // head
            // 
            head.BackColor = Color.FromArgb(34, 35, 39);
            head.Controls.Add(btnMinimize);
            head.Controls.Add(btnExit);
            head.Controls.Add(textHead);
            head.CustomizableEdges = customizableEdges3;
            resources.ApplyResources(head, "head");
            head.Name = "head";
            head.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // btnMinimize
            // 
            btnMinimize.Animated = true;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.Transparent;
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.ForeColor = Color.FromArgb(34, 35, 39);
            btnMinimize.Image = Properties.Resources.minimize;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Animated = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.ForeColor = Color.FromArgb(34, 35, 39);
            btnExit.Image = Properties.Resources.close;
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Click += btnExit_Click;
            // 
            // textHead
            // 
            resources.ApplyResources(textHead, "textHead");
            textHead.ForeColor = Color.White;
            textHead.Name = "textHead";
            // 
            // dragMainWindow
            // 
            dragMainWindow.DockIndicatorTransparencyValue = 0.6D;
            dragMainWindow.TargetControl = head;
            dragMainWindow.TransparentWhileDrag = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // SignInWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 23, 27);
            Controls.Add(head);
            Controls.Add(layoutMainWindow);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SignInWindow";
            Opacity = 0D;
            ShadowPanel.ResumeLayout(false);
            layoutItems.ResumeLayout(false);
            panelItems.ResumeLayout(false);
            panelItems.PerformLayout();
            layoutMainWindow.ResumeLayout(false);
            layoutMainWindow.PerformLayout();
            head.ResumeLayout(false);
            head.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm border;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private TableLayoutPanel layoutMainWindow;
        private Guna.UI2.WinForms.Guna2GradientPanel head;
        private Guna.UI2.WinForms.Guna2Button btnLanguage;
        private Label textHead;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private TableLayoutPanel layoutItems;
        private Panel panelItems;
        private Guna.UI2.WinForms.Guna2Button btnAuthGoogle;
        private Guna.UI2.WinForms.Guna2DragControl dragMainWindow;
        private Guna.UI2.WinForms.Guna2Button btnGit;
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private Label textOR;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLogin;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2Button btnForgot;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Label label2;
    }
}