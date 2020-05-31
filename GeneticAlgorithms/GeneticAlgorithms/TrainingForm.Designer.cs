namespace GeneticAlgorithms
{
    partial class TrainingForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TrainButton = new GeneticAlgorithms.FlatButton();
            this.GenerationProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.GraphsBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualizationBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerationSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TrainingParameters = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GamesComboBox = new System.Windows.Forms.ComboBox();
            this.MutationRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MutationProbability = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.HiddenNeurons = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GamesToPlay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GenerationsCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProceedToNext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SaveButton = new GeneticAlgorithms.FlatButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GraphsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizationBox)).BeginInit();
            this.TrainingParameters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(600, 300);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // TrainButton
            // 
            this.TrainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TrainButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TrainButton.ClickImage = null;
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TrainButton.ForeColor = System.Drawing.Color.White;
            this.TrainButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.TrainButton.HoverImage = null;
            this.TrainButton.Location = new System.Drawing.Point(12, 643);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(127, 75);
            this.TrainButton.TabIndex = 3;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // GenerationProgress
            // 
            this.GenerationProgress.Location = new System.Drawing.Point(159, 675);
            this.GenerationProgress.Maximum = 10000;
            this.GenerationProgress.Name = "GenerationProgress";
            this.GenerationProgress.Size = new System.Drawing.Size(453, 43);
            this.GenerationProgress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output console";
            // 
            // GraphsBox
            // 
            this.GraphsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GraphsBox.Location = new System.Drawing.Point(643, 73);
            this.GraphsBox.Name = "GraphsBox";
            this.GraphsBox.Size = new System.Drawing.Size(600, 300);
            this.GraphsBox.TabIndex = 6;
            this.GraphsBox.TabStop = false;
            this.GraphsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphsBox_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Training graph";
            // 
            // VisualizationBox
            // 
            this.VisualizationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.VisualizationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisualizationBox.Location = new System.Drawing.Point(643, 428);
            this.VisualizationBox.Name = "VisualizationBox";
            this.VisualizationBox.Size = new System.Drawing.Size(600, 417);
            this.VisualizationBox.TabIndex = 8;
            this.VisualizationBox.TabStop = false;
            this.VisualizationBox.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualizationBox_Paint);
            this.VisualizationBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VisualizationBox_MouseDown);
            this.VisualizationBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VisualizationBox_MouseMove);
            this.VisualizationBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VisualizationBox_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(638, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model visualization";
            // 
            // GenerationSize
            // 
            this.GenerationSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GenerationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenerationSize.ForeColor = System.Drawing.Color.White;
            this.GenerationSize.Location = new System.Drawing.Point(21, 119);
            this.GenerationSize.Name = "GenerationSize";
            this.GenerationSize.Size = new System.Drawing.Size(150, 26);
            this.GenerationSize.TabIndex = 10;
            this.GenerationSize.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Generation size";
            // 
            // TrainingParameters
            // 
            this.TrainingParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TrainingParameters.Controls.Add(this.label10);
            this.TrainingParameters.Controls.Add(this.GamesComboBox);
            this.TrainingParameters.Controls.Add(this.MutationRate);
            this.TrainingParameters.Controls.Add(this.label11);
            this.TrainingParameters.Controls.Add(this.MutationProbability);
            this.TrainingParameters.Controls.Add(this.label12);
            this.TrainingParameters.Controls.Add(this.HiddenNeurons);
            this.TrainingParameters.Controls.Add(this.label9);
            this.TrainingParameters.Controls.Add(this.GamesToPlay);
            this.TrainingParameters.Controls.Add(this.label8);
            this.TrainingParameters.Controls.Add(this.MaxScore);
            this.TrainingParameters.Controls.Add(this.label7);
            this.TrainingParameters.Controls.Add(this.GenerationsCount);
            this.TrainingParameters.Controls.Add(this.label6);
            this.TrainingParameters.Controls.Add(this.ProceedToNext);
            this.TrainingParameters.Controls.Add(this.label5);
            this.TrainingParameters.Controls.Add(this.GenerationSize);
            this.TrainingParameters.Controls.Add(this.label4);
            this.TrainingParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TrainingParameters.ForeColor = System.Drawing.Color.White;
            this.TrainingParameters.Location = new System.Drawing.Point(12, 417);
            this.TrainingParameters.Name = "TrainingParameters";
            this.TrainingParameters.Size = new System.Drawing.Size(600, 211);
            this.TrainingParameters.TabIndex = 12;
            this.TrainingParameters.TabStop = false;
            this.TrainingParameters.Text = "Training parameters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Game";
            // 
            // GamesComboBox
            // 
            this.GamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GamesComboBox.FormattingEnabled = true;
            this.GamesComboBox.Items.AddRange(new object[] {
            "Flappy bird",
            "Dino"});
            this.GamesComboBox.Location = new System.Drawing.Point(21, 67);
            this.GamesComboBox.Name = "GamesComboBox";
            this.GamesComboBox.Size = new System.Drawing.Size(150, 28);
            this.GamesComboBox.TabIndex = 26;
            // 
            // MutationRate
            // 
            this.MutationRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MutationRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MutationRate.ForeColor = System.Drawing.Color.White;
            this.MutationRate.Location = new System.Drawing.Point(421, 119);
            this.MutationRate.Name = "MutationRate";
            this.MutationRate.Size = new System.Drawing.Size(150, 26);
            this.MutationRate.TabIndex = 24;
            this.MutationRate.Text = "0.25";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(418, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mutation rate";
            // 
            // MutationProbability
            // 
            this.MutationProbability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MutationProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MutationProbability.ForeColor = System.Drawing.Color.White;
            this.MutationProbability.Location = new System.Drawing.Point(421, 67);
            this.MutationProbability.Name = "MutationProbability";
            this.MutationProbability.Size = new System.Drawing.Size(150, 26);
            this.MutationProbability.TabIndex = 22;
            this.MutationProbability.Text = "0.25";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(418, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mutation Probability";
            // 
            // HiddenNeurons
            // 
            this.HiddenNeurons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HiddenNeurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HiddenNeurons.ForeColor = System.Drawing.Color.White;
            this.HiddenNeurons.Location = new System.Drawing.Point(421, 171);
            this.HiddenNeurons.Name = "HiddenNeurons";
            this.HiddenNeurons.Size = new System.Drawing.Size(150, 26);
            this.HiddenNeurons.TabIndex = 20;
            this.HiddenNeurons.Text = "4 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(418, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Hidden neurons";
            // 
            // GamesToPlay
            // 
            this.GamesToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GamesToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GamesToPlay.ForeColor = System.Drawing.Color.White;
            this.GamesToPlay.Location = new System.Drawing.Point(221, 171);
            this.GamesToPlay.Name = "GamesToPlay";
            this.GamesToPlay.Size = new System.Drawing.Size(150, 26);
            this.GamesToPlay.TabIndex = 18;
            this.GamesToPlay.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(217, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Games to play";
            // 
            // MaxScore
            // 
            this.MaxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.MaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MaxScore.ForeColor = System.Drawing.Color.White;
            this.MaxScore.Location = new System.Drawing.Point(221, 119);
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.Size = new System.Drawing.Size(150, 26);
            this.MaxScore.TabIndex = 16;
            this.MaxScore.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max score";
            // 
            // GenerationsCount
            // 
            this.GenerationsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GenerationsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenerationsCount.ForeColor = System.Drawing.Color.White;
            this.GenerationsCount.Location = new System.Drawing.Point(221, 67);
            this.GenerationsCount.Name = "GenerationsCount";
            this.GenerationsCount.Size = new System.Drawing.Size(150, 26);
            this.GenerationsCount.TabIndex = 14;
            this.GenerationsCount.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(217, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Generations";
            // 
            // ProceedToNext
            // 
            this.ProceedToNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ProceedToNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProceedToNext.ForeColor = System.Drawing.Color.White;
            this.ProceedToNext.Location = new System.Drawing.Point(21, 171);
            this.ProceedToNext.Name = "ProceedToNext";
            this.ProceedToNext.Size = new System.Drawing.Size(150, 26);
            this.ProceedToNext.TabIndex = 12;
            this.ProceedToNext.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Proceed to next";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(154, 643);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 29);
            this.label13.TabIndex = 13;
            this.label13.Text = "Generation progress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.SaveButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 724);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 121);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(383, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Save model after training on disk";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SaveButton.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveButton.ClickImage = null;
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.SaveButton.HoverImage = null;
            this.SaveButton.Location = new System.Drawing.Point(422, 23);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(161, 80);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save model";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "model";
            this.saveFileDialog1.FileName = "newModel";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1263, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TrainingParameters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisualizationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GraphsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerationProgress);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TrainingForm";
            this.Text = "TrainingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrainingForm_FormClosed);
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.TrainButton, 0);
            this.Controls.SetChildIndex(this.GenerationProgress, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GraphsBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.VisualizationBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TrainingParameters, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GraphsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizationBox)).EndInit();
            this.TrainingParameters.ResumeLayout(false);
            this.TrainingParameters.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private FlatButton TrainButton;
        private System.Windows.Forms.ProgressBar GenerationProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GraphsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox VisualizationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GenerationSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox TrainingParameters;
        private System.Windows.Forms.TextBox ProceedToNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GenerationsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GamesToPlay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MutationRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MutationProbability;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox HiddenNeurons;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GamesComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private FlatButton SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}