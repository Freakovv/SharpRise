namespace SharpRise.ViewModels
{
    partial class SignUpWindow
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpWindow));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            head = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            textHead = new Label();
            border = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            dragMainWindow = new Guna.UI2.WinForms.Guna2DragControl(components);
            layoutMainWindow = new TableLayoutPanel();
            btnGit = new Guna.UI2.WinForms.Guna2Button();
            ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            head.SuspendLayout();
            layoutMainWindow.SuspendLayout();
            ShadowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // head
            // 
            head.BackColor = Color.FromArgb(34, 35, 39);
            head.Controls.Add(btnMinimize);
            head.Controls.Add(btnExit);
            head.Controls.Add(textHead);
            head.CustomizableEdges = customizableEdges3;
            head.Dock = DockStyle.Top;
            head.Location = new Point(0, 0);
            head.Name = "head";
            head.ShadowDecoration.CustomizableEdges = customizableEdges4;
            head.Size = new Size(1264, 25);
            head.TabIndex = 3;
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
            btnMinimize.Location = new Point(1219, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(18, 18);
            btnMinimize.TabIndex = 2;
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
            btnExit.Location = new Point(1243, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(18, 18);
            btnExit.TabIndex = 1;
            // 
            // textHead
            // 
            textHead.AutoSize = true;
            textHead.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textHead.ForeColor = Color.White;
            textHead.ImeMode = ImeMode.NoControl;
            textHead.Location = new Point(8, 4);
            textHead.Name = "textHead";
            textHead.Size = new Size(81, 19);
            textHead.TabIndex = 0;
            textHead.Text = "SharpRise";
            // 
            // border
            // 
            border.BorderRadius = 10;
            border.ContainerControl = this;
            border.DockIndicatorTransparencyValue = 0.6D;
            border.TransparentWhileDrag = true;
            // 
            // dragMainWindow
            // 
            dragMainWindow.DockIndicatorTransparencyValue = 0.6D;
            dragMainWindow.TargetControl = head;
            dragMainWindow.TransparentWhileDrag = false;
            // 
            // layoutMainWindow
            // 
            layoutMainWindow.ColumnCount = 3;
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutMainWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMainWindow.Controls.Add(btnGit, 2, 2);
            layoutMainWindow.Controls.Add(ShadowPanel, 1, 1);
            layoutMainWindow.Location = new Point(0, 25);
            layoutMainWindow.Margin = new Padding(3, 2, 3, 2);
            layoutMainWindow.Name = "layoutMainWindow";
            layoutMainWindow.RowCount = 3;
            layoutMainWindow.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            layoutMainWindow.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            layoutMainWindow.RowStyles.Add(new RowStyle());
            layoutMainWindow.Size = new Size(1261, 654);
            layoutMainWindow.TabIndex = 4;
            // 
            // btnGit
            // 
            btnGit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGit.BorderColor = Color.Gray;
            btnGit.BorderRadius = 10;
            btnGit.BorderThickness = 1;
            btnGit.CustomizableEdges = customizableEdges5;
            btnGit.DisabledState.BorderColor = Color.DarkGray;
            btnGit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGit.FillColor = Color.FromArgb(39, 39, 41);
            btnGit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGit.ForeColor = Color.White;
            btnGit.HoverState.FillColor = Color.FromArgb(24, 24, 27);
            btnGit.Image = (Image)resources.GetObject("btnGit.Image");
            btnGit.ImageAlign = HorizontalAlignment.Right;
            btnGit.Location = new Point(1166, 610);
            btnGit.Margin = new Padding(0, 0, 10, 10);
            btnGit.Name = "btnGit";
            btnGit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnGit.Size = new Size(85, 34);
            btnGit.TabIndex = 2;
            btnGit.Text = "GitHub ";
            btnGit.TextOffset = new Point(-10, 0);
            // 
            // ShadowPanel
            // 
            ShadowPanel.BackColor = Color.Transparent;
            ShadowPanel.Controls.Add(panel1);
            ShadowPanel.Dock = DockStyle.Fill;
            ShadowPanel.FillColor = Color.FromArgb(34, 35, 39);
            ShadowPanel.Location = new Point(255, 123);
            ShadowPanel.Name = "ShadowPanel";
            ShadowPanel.Radius = 5;
            ShadowPanel.ShadowColor = Color.Black;
            ShadowPanel.Size = new Size(750, 394);
            ShadowPanel.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Animated = true;
            textBoxEmail.BorderColor = Color.Empty;
            textBoxEmail.BorderRadius = 5;
            textBoxEmail.CustomizableEdges = customizableEdges7;
            textBoxEmail.DefaultText = "";
            textBoxEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxEmail.FillColor = Color.FromArgb(20, 20, 20);
            textBoxEmail.FocusedState.BorderColor = Color.FromArgb(63, 63, 70);
            textBoxEmail.FocusedState.FillColor = Color.FromArgb(30, 30, 30);
            textBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.HoverState.FillColor = Color.Black;
            textBoxEmail.Location = new Point(0, 0);
            textBoxEmail.Margin = new Padding(10, 3, 10, 3);
            textBoxEmail.MaxLength = 254;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "";
            textBoxEmail.SelectedText = "";
            textBoxEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textBoxEmail.Size = new Size(732, 36);
            textBoxEmail.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxEmail);
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 361);
            panel1.TabIndex = 0;
            // 
            // SignUpWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 23, 27);
            ClientSize = new Size(1264, 678);
            Controls.Add(head);
            Controls.Add(layoutMainWindow);
            DoubleBuffered = true;
            Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpWindow";
            head.ResumeLayout(false);
            head.PerformLayout();
            layoutMainWindow.ResumeLayout(false);
            ShadowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel head;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Label textHead;
        private Guna.UI2.WinForms.Guna2BorderlessForm border;
        private Guna.UI2.WinForms.Guna2DragControl dragMainWindow;
        private TableLayoutPanel layoutMainWindow;
        private Guna.UI2.WinForms.Guna2Button btnGit;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private Panel panel1;
    }
}