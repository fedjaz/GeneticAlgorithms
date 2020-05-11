﻿namespace GeneticAlgorithms
{
    partial class MainMenuForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatButton4 = new GeneticAlgorithms.FlatButton();
            this.flatButton3 = new GeneticAlgorithms.FlatButton();
            this.flatButton2 = new GeneticAlgorithms.FlatButton();
            this.flatButton1 = new GeneticAlgorithms.FlatButton();
            this.flatButton5 = new GeneticAlgorithms.FlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.flatButton5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // flatButton4
            // 
            this.flatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(92)))), ((int)(((byte)(244)))));
            this.flatButton4.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Dino;
            this.flatButton4.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.flatButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(121)))), ((int)(((byte)(249)))));
            this.flatButton4.Location = new System.Drawing.Point(191, 176);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(300, 72);
            this.flatButton4.TabIndex = 4;
            this.flatButton4.Text = "flatButton4";
            this.flatButton4.UseVisualStyleBackColor = false;
            // 
            // flatButton3
            // 
            this.flatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(216)))), ((int)(((byte)(16)))));
            this.flatButton3.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.FlappyBird;
            this.flatButton3.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.flatButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(244)))), ((int)(((byte)(104)))));
            this.flatButton3.Location = new System.Drawing.Point(191, 71);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Size = new System.Drawing.Size(300, 72);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "flatButton3";
            this.flatButton3.UseVisualStyleBackColor = false;
            // 
            // flatButton2
            // 
            this.flatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(114)))), ((int)(((byte)(4)))));
            this.flatButton2.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Breakout;
            this.flatButton2.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.flatButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(142)))), ((int)(((byte)(52)))));
            this.flatButton2.Location = new System.Drawing.Point(191, 281);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(300, 72);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "flatButton2";
            this.flatButton2.UseVisualStyleBackColor = false;
            // 
            // flatButton1
            // 
            this.flatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.flatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flatButton1.BackgroundImage")));
            this.flatButton1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flatButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.flatButton1.Location = new System.Drawing.Point(191, 386);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(300, 72);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "flatButton1";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Cross;
            this.flatButton5.ClickColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.HoverColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.Location = new System.Drawing.Point(635, 5);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Size = new System.Drawing.Size(29, 28);
            this.flatButton5.TabIndex = 5;
            this.flatButton5.Text = "flatButton5";
            this.flatButton5.UseVisualStyleBackColor = false;
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(676, 486);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.flatButton3);
            this.Controls.Add(this.flatButton2);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatButton flatButton1;
        private FlatButton flatButton2;
        private FlatButton flatButton3;
        private FlatButton flatButton4;
        private FlatButton flatButton5;
    }
}

