namespace SharpRise
{
    partial class AuthWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            border = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            layoutItems = new TableLayoutPanel();
            panelItems = new Panel();
            btnAuthGoogle = new Guna.UI2.WinForms.Guna2Button();
            layoutMainWindow = new TableLayoutPanel();
            btnLanguage = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            head = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            title = new Label();
            dragMainWindow = new Guna.UI2.WinForms.Guna2DragControl(components);
            ShadowPanel.SuspendLayout();
            layoutItems.SuspendLayout();
            panelItems.SuspendLayout();
            layoutMainWindow.SuspendLayout();
            head.SuspendLayout();
            SuspendLayout();
            // 
            // border
            // 
            border.AnimateWindow = true;
            border.BorderRadius = 10;
            border.ContainerControl = this;
            border.DockIndicatorTransparencyValue = 0.6D;
            border.TransparentWhileDrag = true;
            // 
            // ShadowPanel
            // 
            ShadowPanel.BackColor = Color.Transparent;
            ShadowPanel.Controls.Add(layoutItems);
            ShadowPanel.Dock = DockStyle.Fill;
            ShadowPanel.FillColor = Color.FromArgb(34, 35, 39);
            ShadowPanel.Location = new Point(462, 25);
            ShadowPanel.Margin = new Padding(3, 25, 3, 3);
            ShadowPanel.Name = "ShadowPanel";
            ShadowPanel.Radius = 5;
            ShadowPanel.ShadowColor = Color.Black;
            ShadowPanel.Size = new Size(354, 470);
            ShadowPanel.TabIndex = 0;
            // 
            // layoutItems
            // 
            layoutItems.ColumnCount = 1;
            layoutItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutItems.Controls.Add(panelItems, 0, 1);
            layoutItems.Dock = DockStyle.Fill;
            layoutItems.Location = new Point(0, 0);
            layoutItems.Name = "layoutItems";
            layoutItems.RowCount = 2;
            layoutItems.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            layoutItems.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            layoutItems.Size = new Size(354, 470);
            layoutItems.TabIndex = 0;
            // 
            // panelItems
            // 
            panelItems.Anchor = AnchorStyles.Top;
            panelItems.Controls.Add(btnAuthGoogle);
            panelItems.Location = new Point(22, 97);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(310, 344);
            panelItems.TabIndex = 0;
            // 
            // btnAuthGoogle
            // 
            btnAuthGoogle.Anchor = AnchorStyles.Top;
            btnAuthGoogle.BorderColor = Color.Gray;
            btnAuthGoogle.BorderRadius = 10;
            btnAuthGoogle.BorderThickness = 1;
            btnAuthGoogle.CustomizableEdges = customizableEdges5;
            btnAuthGoogle.DisabledState.BorderColor = Color.DarkGray;
            btnAuthGoogle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAuthGoogle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAuthGoogle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAuthGoogle.FillColor = Color.FromArgb(39, 39, 41);
            btnAuthGoogle.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuthGoogle.ForeColor = Color.White;
            btnAuthGoogle.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnAuthGoogle.Location = new Point(0, 5);
            btnAuthGoogle.Margin = new Padding(5, 3, 5, 3);
            btnAuthGoogle.Name = "btnAuthGoogle";
            btnAuthGoogle.PressedDepth = 0;
            btnAuthGoogle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAuthGoogle.Size = new Size(310, 39);
            btnAuthGoogle.TabIndex = 0;
            btnAuthGoogle.Text = "Sign in with Google";
            // 
            // layoutMainWindow
            // 
            layoutMainWindow.ColumnCount = 3;
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.93245F));
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1351051F));
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.93245F));
            layoutMainWindow.Controls.Add(ShadowPanel, 1, 0);
            layoutMainWindow.Controls.Add(btnLanguage, 0, 0);
            layoutMainWindow.Controls.Add(guna2Button1, 2, 1);
            layoutMainWindow.Location = new Point(0, 26);
            layoutMainWindow.Name = "layoutMainWindow";
            layoutMainWindow.RowCount = 2;
            layoutMainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 72.22222F));
            layoutMainWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 27.7777786F));
            layoutMainWindow.Size = new Size(1280, 690);
            layoutMainWindow.TabIndex = 1;
            // 
            // btnLanguage
            // 
            btnLanguage.BorderColor = Color.Gray;
            btnLanguage.BorderRadius = 10;
            btnLanguage.BorderThickness = 1;
            btnLanguage.CustomizableEdges = customizableEdges7;
            btnLanguage.DisabledState.BorderColor = Color.DarkGray;
            btnLanguage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLanguage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLanguage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLanguage.FillColor = Color.FromArgb(39, 39, 41);
            btnLanguage.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLanguage.ForeColor = Color.White;
            btnLanguage.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnLanguage.Location = new Point(10, 10);
            btnLanguage.Margin = new Padding(10, 10, 3, 3);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLanguage.Size = new Size(49, 26);
            btnLanguage.TabIndex = 1;
            btnLanguage.Text = "EN";
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guna2Button1.BorderColor = Color.Gray;
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(39, 39, 41);
            guna2Button1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            guna2Button1.Location = new Point(1137, 654);
            guna2Button1.Margin = new Padding(0, 0, 10, 10);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(133, 26);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "GitHub project";
            // 
            // head
            // 
            head.BackColor = Color.FromArgb(34, 35, 39);
            head.Controls.Add(btnMinimize);
            head.Controls.Add(btnExit);
            head.Controls.Add(title);
            head.CustomizableEdges = customizableEdges3;
            head.Dock = DockStyle.Top;
            head.Location = new Point(0, 0);
            head.Name = "head";
            head.ShadowDecoration.CustomizableEdges = customizableEdges4;
            head.Size = new Size(1280, 25);
            head.TabIndex = 2;
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
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.FromArgb(34, 35, 39);
            btnMinimize.Image = Properties.Resources.minimize;
            btnMinimize.Location = new Point(1231, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 2;
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
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(34, 35, 39);
            btnExit.Image = Properties.Resources.close;
            btnExit.Location = new Point(1255, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 1;
            btnExit.Click += btnExit_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(8, 4);
            title.Name = "title";
            title.Size = new Size(75, 18);
            title.TabIndex = 0;
            title.Text = "SharpRise";
            // 
            // dragMainWindow
            // 
            dragMainWindow.DockIndicatorTransparencyValue = 0.6D;
            dragMainWindow.TargetControl = head;
            dragMainWindow.UseTransparentDrag = true;
            // 
            // AuthWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 23, 27);
            ClientSize = new Size(1280, 717);
            Controls.Add(head);
            Controls.Add(layoutMainWindow);
            Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthWindow";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            ShadowPanel.ResumeLayout(false);
            layoutItems.ResumeLayout(false);
            panelItems.ResumeLayout(false);
            layoutMainWindow.ResumeLayout(false);
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
        private Label title;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private TableLayoutPanel layoutItems;
        private Panel panelItems;
        private Guna.UI2.WinForms.Guna2Button btnAuthGoogle;
        private Guna.UI2.WinForms.Guna2DragControl dragMainWindow;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}