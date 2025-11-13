namespace Practice_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question01Button = new System.Windows.Forms.Button();
            this.question1OutputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.question2Button = new System.Windows.Forms.Button();
            this.question2TextBox = new System.Windows.Forms.TextBox();
            this.question2OutputLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.question3Button = new System.Windows.Forms.Button();
            this.q3Int1Text = new System.Windows.Forms.TextBox();
            this.q3int2Text = new System.Windows.Forms.TextBox();
            this.question3OutputLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(732, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practice Quiz - Wed Nov 12 Input, Output and Variables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question 01";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "When the user hits the button, the label below should output Happy Hump Day";
            // 
            // question01Button
            // 
            this.question01Button.Location = new System.Drawing.Point(5, 147);
            this.question01Button.Name = "question01Button";
            this.question01Button.Size = new System.Drawing.Size(243, 35);
            this.question01Button.TabIndex = 3;
            this.question01Button.Text = "Question 01";
            this.question01Button.UseVisualStyleBackColor = true;
            this.question01Button.Click += new System.EventHandler(this.question01Button_Click);
            // 
            // question1OutputLabel
            // 
            this.question1OutputLabel.Location = new System.Drawing.Point(1, 185);
            this.question1OutputLabel.Name = "question1OutputLabel";
            this.question1OutputLabel.Size = new System.Drawing.Size(247, 47);
            this.question1OutputLabel.TabIndex = 4;
            this.question1OutputLabel.Text = "question1OutputLabel";
            this.question1OutputLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Question 02";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 75);
            this.label5.TabIndex = 6;
            this.label5.Text = "The user will enter their name.  The label will output \"Hello USERNAME\" (replace " +
    "USERNAME with the users input";
            // 
            // question2Button
            // 
            this.question2Button.Location = new System.Drawing.Point(5, 417);
            this.question2Button.Name = "question2Button";
            this.question2Button.Size = new System.Drawing.Size(286, 35);
            this.question2Button.TabIndex = 7;
            this.question2Button.Text = "Question 02";
            this.question2Button.UseVisualStyleBackColor = true;
            this.question2Button.Click += new System.EventHandler(this.question2Button_Click);
            // 
            // question2TextBox
            // 
            this.question2TextBox.Location = new System.Drawing.Point(5, 385);
            this.question2TextBox.Name = "question2TextBox";
            this.question2TextBox.Size = new System.Drawing.Size(286, 31);
            this.question2TextBox.TabIndex = 8;
            // 
            // question2OutputLabel
            // 
            this.question2OutputLabel.Location = new System.Drawing.Point(1, 455);
            this.question2OutputLabel.Name = "question2OutputLabel";
            this.question2OutputLabel.Size = new System.Drawing.Size(319, 47);
            this.question2OutputLabel.TabIndex = 9;
            this.question2OutputLabel.Text = "question2OutputLabel";
            this.question2OutputLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(477, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question 03";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 183);
            this.label7.TabIndex = 11;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // question3Button
            // 
            this.question3Button.Location = new System.Drawing.Point(479, 324);
            this.question3Button.Name = "question3Button";
            this.question3Button.Size = new System.Drawing.Size(259, 35);
            this.question3Button.TabIndex = 12;
            this.question3Button.Text = "Question 03";
            this.question3Button.UseVisualStyleBackColor = true;
            this.question3Button.Click += new System.EventHandler(this.question3Button_Click);
            // 
            // q3Int1Text
            // 
            this.q3Int1Text.Location = new System.Drawing.Point(479, 281);
            this.q3Int1Text.Name = "q3Int1Text";
            this.q3Int1Text.Size = new System.Drawing.Size(100, 31);
            this.q3Int1Text.TabIndex = 13;
            // 
            // q3int2Text
            // 
            this.q3int2Text.Location = new System.Drawing.Point(638, 281);
            this.q3int2Text.Name = "q3int2Text";
            this.q3int2Text.Size = new System.Drawing.Size(100, 31);
            this.q3int2Text.TabIndex = 14;
            // 
            // question3OutputLabel
            // 
            this.question3OutputLabel.Location = new System.Drawing.Point(477, 388);
            this.question3OutputLabel.Name = "question3OutputLabel";
            this.question3OutputLabel.Size = new System.Drawing.Size(295, 47);
            this.question3OutputLabel.TabIndex = 15;
            this.question3OutputLabel.Text = "question3OutputLabel";
            this.question3OutputLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(585, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(509, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 84);
            this.label9.TabIndex = 17;
            this.label9.Text = "when you are finished push your quiz to github";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(267, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 75);
            this.label10.TabIndex = 18;
            this.label10.Text = "Question 1 - 2 marks, Question 2 - 3 marks, Question 3 - 5 marks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.question3OutputLabel);
            this.Controls.Add(this.q3int2Text);
            this.Controls.Add(this.q3Int1Text);
            this.Controls.Add(this.question3Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.question2OutputLabel);
            this.Controls.Add(this.question2TextBox);
            this.Controls.Add(this.question2Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.question1OutputLabel);
            this.Controls.Add(this.question01Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Practice Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button question01Button;
        private System.Windows.Forms.Label question1OutputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button question2Button;
        private System.Windows.Forms.TextBox question2TextBox;
        private System.Windows.Forms.Label question2OutputLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button question3Button;
        private System.Windows.Forms.TextBox q3Int1Text;
        private System.Windows.Forms.TextBox q3int2Text;
        private System.Windows.Forms.Label question3OutputLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

