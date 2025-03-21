﻿namespace SharpRise.ViewModels
{
    partial class BeginAnimation
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
            timer_animation = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer_animation
            // 
            timer_animation.Interval = 5;
            timer_animation.Tick += timer_animation_Tick;
            // 
            // BeginAnimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Magenta;
            ClientSize = new Size(600, 600);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BeginAnimation";
            Opacity = 0D;
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeginAnimation";
            TopMost = true;
            TransparencyKey = Color.Magenta;
            FormClosing += BeginAnimation_FormClosing;
            Load += BeginAnimation_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer_animation;
    }
}