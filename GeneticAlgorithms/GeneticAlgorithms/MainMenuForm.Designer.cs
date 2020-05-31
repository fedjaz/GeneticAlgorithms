namespace GeneticAlgorithms
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
            this.DinoButton = new GeneticAlgorithms.FlatButton();
            this.FlappyBirdButton = new GeneticAlgorithms.FlatButton();
            this.TrainButton = new GeneticAlgorithms.FlatButton();
            this.flatButton5 = new GeneticAlgorithms.FlatButton();
            this.SuspendLayout();
            // 
            // DinoButton
            // 
            this.DinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(92)))), ((int)(((byte)(244)))));
            this.DinoButton.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Dino;
            this.DinoButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(70)))), ((int)(((byte)(210)))));
            this.DinoButton.ClickImage = null;
            this.DinoButton.Enabled = false;
            this.DinoButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(121)))), ((int)(((byte)(249)))));
            this.DinoButton.HoverImage = null;
            this.DinoButton.Location = new System.Drawing.Point(177, 185);
            this.DinoButton.Name = "DinoButton";
            this.DinoButton.Size = new System.Drawing.Size(287, 67);
            this.DinoButton.TabIndex = 4;
            this.DinoButton.UseVisualStyleBackColor = false;
            this.DinoButton.Click += new System.EventHandler(this.DinoButton_Click);
            // 
            // FlappyBirdButton
            // 
            this.FlappyBirdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(216)))), ((int)(((byte)(16)))));
            this.FlappyBirdButton.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.FlappyBird;
            this.FlappyBirdButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.FlappyBirdButton.ClickImage = null;
            this.FlappyBirdButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(244)))), ((int)(((byte)(104)))));
            this.FlappyBirdButton.HoverImage = null;
            this.FlappyBirdButton.Location = new System.Drawing.Point(177, 73);
            this.FlappyBirdButton.Name = "FlappyBirdButton";
            this.FlappyBirdButton.Size = new System.Drawing.Size(287, 67);
            this.FlappyBirdButton.TabIndex = 3;
            this.FlappyBirdButton.UseVisualStyleBackColor = false;
            this.FlappyBirdButton.Click += new System.EventHandler(this.FlappyBirdButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TrainButton.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Train;
            this.TrainButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TrainButton.ClickImage = null;
            this.TrainButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.TrainButton.HoverImage = null;
            this.TrainButton.Location = new System.Drawing.Point(177, 297);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(287, 67);
            this.TrainButton.TabIndex = 1;
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.BackgroundImage = global::GeneticAlgorithms.Properties.Resources.Cross;
            this.flatButton5.ClickColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.ClickImage = null;
            this.flatButton5.HoverColor = System.Drawing.Color.DarkSlateBlue;
            this.flatButton5.HoverImage = null;
            this.flatButton5.Location = new System.Drawing.Point(635, 5);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Size = new System.Drawing.Size(29, 28);
            this.flatButton5.TabIndex = 5;
            this.flatButton5.Text = "flatButton5";
            this.flatButton5.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(657, 433);
            this.Controls.Add(this.DinoButton);
            this.Controls.Add(this.FlappyBirdButton);
            this.Controls.Add(this.TrainButton);
            this.Name = "MainMenuForm";
            this.Text = "Main menu";
            this.Controls.SetChildIndex(this.TrainButton, 0);
            this.Controls.SetChildIndex(this.FlappyBirdButton, 0);
            this.Controls.SetChildIndex(this.DinoButton, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private FlatButton TrainButton;
        private FlatButton FlappyBirdButton;
        private FlatButton DinoButton;
        private FlatButton flatButton5;
    }
}

