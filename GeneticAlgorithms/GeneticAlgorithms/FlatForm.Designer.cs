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
            this.SystemPanel = new System.Windows.Forms.Panel();
            this.flatButton5 = new GeneticAlgorithms.FlatButton();
            this.SystemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemPanel
            // 
            this.SystemPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SystemPanel.Controls.Add(this.flatButton5);
            this.SystemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SystemPanel.Location = new System.Drawing.Point(0, 0);
            this.SystemPanel.Name = "SystemPanel";
            this.SystemPanel.Size = new System.Drawing.Size(699, 36);
            this.SystemPanel.TabIndex = 1;
            this.SystemPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseDown);
            this.SystemPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseMove);
            this.SystemPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SystemPanel_MouseUp);
            // 
            // flatButton5
            // 
            this.flatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Cross;
            this.flatButton5.ClickColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.ClickImage = global::GeneticAlgorithms.Properties.Resources.Cross_Click;
            this.flatButton5.HoverColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.HoverImage = global::GeneticAlgorithms.Properties.Resources.Cross_Hover;
            this.flatButton5.Location = new System.Drawing.Point(667, 5);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Size = new System.Drawing.Size(29, 28);
            this.flatButton5.TabIndex = 5;
            this.flatButton5.Text = "flatButton5";
            this.flatButton5.UseVisualStyleBackColor = false;
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(699, 500);
            this.Controls.Add(this.SystemPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlatForm";
            this.Text = "FlatForm";
            this.SystemPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButton flatButton5;
        private System.Windows.Forms.Panel SystemPanel;
    }
}