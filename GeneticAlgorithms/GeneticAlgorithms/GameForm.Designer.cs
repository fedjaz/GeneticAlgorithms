namespace GeneticAlgorithms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.GameBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModelStatus = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.Label();
            this.AverageScore = new System.Windows.Forms.Label();
            this.CompatibleGame = new System.Windows.Forms.Label();
            this.LoadButton = new GeneticAlgorithms.FlatButton();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameBox
            // 
            this.GameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameBox.Location = new System.Drawing.Point(0, 28);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(1000, 500);
            this.GameBox.TabIndex = 2;
            this.GameBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(13, 545);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 33);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Enable neural network";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModelStatus);
            this.groupBox1.Controls.Add(this.ModelName);
            this.groupBox1.Controls.Add(this.AverageScore);
            this.groupBox1.Controls.Add(this.CompatibleGame);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(430, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded model information";
            // 
            // ModelStatus
            // 
            this.ModelStatus.AutoSize = true;
            this.ModelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModelStatus.ForeColor = System.Drawing.Color.Red;
            this.ModelStatus.Location = new System.Drawing.Point(6, 153);
            this.ModelStatus.Name = "ModelStatus";
            this.ModelStatus.Size = new System.Drawing.Size(484, 25);
            this.ModelStatus.TabIndex = 11;
            this.ModelStatus.Text = "This model is damaged or incompatible with this game!";
            this.ModelStatus.Visible = false;
            // 
            // ModelName
            // 
            this.ModelName.AutoSize = true;
            this.ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModelName.ForeColor = System.Drawing.Color.White;
            this.ModelName.Location = new System.Drawing.Point(6, 32);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(131, 25);
            this.ModelName.TabIndex = 10;
            this.ModelName.Text = "Model name: ";
            // 
            // AverageScore
            // 
            this.AverageScore.AutoSize = true;
            this.AverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AverageScore.ForeColor = System.Drawing.Color.White;
            this.AverageScore.Location = new System.Drawing.Point(6, 82);
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.Size = new System.Drawing.Size(145, 25);
            this.AverageScore.TabIndex = 9;
            this.AverageScore.Text = "Average score:";
            // 
            // CompatibleGame
            // 
            this.CompatibleGame.AutoSize = true;
            this.CompatibleGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CompatibleGame.ForeColor = System.Drawing.Color.White;
            this.CompatibleGame.Location = new System.Drawing.Point(6, 57);
            this.CompatibleGame.Name = "CompatibleGame";
            this.CompatibleGame.Size = new System.Drawing.Size(176, 25);
            this.CompatibleGame.TabIndex = 8;
            this.CompatibleGame.Text = "Compatible game: ";
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.LoadButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoadButton.ClickImage = null;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.LoadButton.HoverImage = null;
            this.LoadButton.Location = new System.Drawing.Point(366, 32);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(170, 60);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load model";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.InfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBox.ForeColor = System.Drawing.Color.White;
            this.InfoBox.Location = new System.Drawing.Point(13, 584);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.Size = new System.Drawing.Size(339, 149);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Model files|*.model";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1000, 763);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.checkBox1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.GameBox, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.InfoBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlatButton LoadButton;
        private System.Windows.Forms.Label CompatibleGame;
        private System.Windows.Forms.Label ModelStatus;
        private System.Windows.Forms.Label ModelName;
        private System.Windows.Forms.Label AverageScore;
        private System.Windows.Forms.RichTextBox InfoBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}