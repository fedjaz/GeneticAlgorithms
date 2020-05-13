namespace GeneticAlgorithms
{
    partial class FlatForm
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
            this.CaptionBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new GeneticAlgorithms.FlatButton();
            this.CloseButton = new GeneticAlgorithms.FlatButton();
            this.CaptionBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptionBar
            // 
            this.CaptionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CaptionBar.Controls.Add(this.MinimizeButton);
            this.CaptionBar.Controls.Add(this.CloseButton);
            this.CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.CaptionBar.Name = "CaptionBar";
            this.CaptionBar.Size = new System.Drawing.Size(699, 36);
            this.CaptionBar.TabIndex = 1;
            this.CaptionBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseDown);
            this.CaptionBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseMove);
            this.CaptionBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MinimizeButton.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Minimize;
            this.MinimizeButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MinimizeButton.ClickImage = global::GeneticAlgorithms.Properties.Resources.Minimize;
            this.MinimizeButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MinimizeButton.HoverImage = global::GeneticAlgorithms.Properties.Resources.Minimize_Hover;
            this.MinimizeButton.Location = new System.Drawing.Point(632, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 28);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseButton.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Cross;
            this.CloseButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseButton.ClickImage = global::GeneticAlgorithms.Properties.Resources.Cross_Click;
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseButton.HoverImage = global::GeneticAlgorithms.Properties.Resources.Cross_Hover;
            this.CloseButton.Location = new System.Drawing.Point(667, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 28);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 500);
            this.Controls.Add(this.CaptionBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FlatForm";
            this.Text = "FlatForm";
            this.CaptionBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButton CloseButton;
        private System.Windows.Forms.Panel CaptionBar;
        private FlatButton MinimizeButton;
    }
}