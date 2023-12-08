
namespace Math_Game_Project
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coQuizzType = new System.Windows.Forms.ComboBox();
            this.coOeprationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumOfQuis = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numNumberOfTimes = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfQuis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quizz Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(188, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oepration Type :";
            // 
            // coQuizzType
            // 
            this.coQuizzType.BackColor = System.Drawing.Color.Silver;
            this.coQuizzType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coQuizzType.ForeColor = System.Drawing.Color.DarkRed;
            this.coQuizzType.FormattingEnabled = true;
            this.coQuizzType.Items.AddRange(new object[] {
            "Esay",
            "Mid",
            "Hard",
            "Extrem",
            "Mixd"});
            this.coQuizzType.Location = new System.Drawing.Point(503, 26);
            this.coQuizzType.Name = "coQuizzType";
            this.coQuizzType.Size = new System.Drawing.Size(121, 32);
            this.coQuizzType.TabIndex = 4;
            this.coQuizzType.Text = "Esay";
            // 
            // coOeprationType
            // 
            this.coOeprationType.BackColor = System.Drawing.Color.Silver;
            this.coOeprationType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coOeprationType.ForeColor = System.Drawing.Color.DarkRed;
            this.coOeprationType.FormattingEnabled = true;
            this.coOeprationType.Items.AddRange(new object[] {
            "Add",
            "Sub",
            "Mult",
            "Divid"});
            this.coOeprationType.Location = new System.Drawing.Point(503, 93);
            this.coOeprationType.Name = "coOeprationType";
            this.coOeprationType.Size = new System.Drawing.Size(121, 32);
            this.coOeprationType.TabIndex = 5;
            this.coOeprationType.Text = "Sub";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numbers Of Qusitions :";
            // numericNumOfQuis
            // 
            this.numericNumOfQuis.BackColor = System.Drawing.Color.Silver;
            this.numericNumOfQuis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNumOfQuis.ForeColor = System.Drawing.Color.DarkRed;
            this.numericNumOfQuis.Location = new System.Drawing.Point(503, 158);
            this.numericNumOfQuis.Name = "numericNumOfQuis";
            this.numericNumOfQuis.Size = new System.Drawing.Size(120, 32);
            this.numericNumOfQuis.TabIndex = 7;
            this.numericNumOfQuis.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numbers Of Time :";
            // 
            // numNumberOfTimes
            // 
            this.numNumberOfTimes.BackColor = System.Drawing.Color.Silver;
            this.numNumberOfTimes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfTimes.ForeColor = System.Drawing.Color.DarkRed;
            this.numNumberOfTimes.Location = new System.Drawing.Point(503, 215);
            this.numNumberOfTimes.Name = "numNumberOfTimes";
            this.numNumberOfTimes.Size = new System.Drawing.Size(120, 32);
            this.numNumberOfTimes.TabIndex = 9;
            this.numNumberOfTimes.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game_Project.Properties.Resources.maths;
            this.pictureBox1.Location = new System.Drawing.Point(-78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1222, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 537);
            this.Controls.Add(this.numNumberOfTimes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericNumOfQuis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coOeprationType);
            this.Controls.Add(this.coQuizzType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfQuis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox coQuizzType;
        private System.Windows.Forms.ComboBox coOeprationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNumOfQuis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numNumberOfTimes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

