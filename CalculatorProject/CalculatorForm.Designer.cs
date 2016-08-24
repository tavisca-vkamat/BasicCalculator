namespace CalculatorProject
{
    partial class CalculatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.buttonOfEquals = new System.Windows.Forms.Button();
            this.buttonOfDivide = new System.Windows.Forms.Button();
            this.buttonOfMultiplication = new System.Windows.Forms.Button();
            this.buttonOfSubtraction = new System.Windows.Forms.Button();
            this.buttonOfAddition = new System.Windows.Forms.Button();
            this.buttonOfZero = new System.Windows.Forms.Button();
            this.buttonOfNine = new System.Windows.Forms.Button();
            this.buttonOfEight = new System.Windows.Forms.Button();
            this.buttonOfSeven = new System.Windows.Forms.Button();
            this.buttonOfSix = new System.Windows.Forms.Button();
            this.buttonOfFive = new System.Windows.Forms.Button();
            this.buttonOfFour = new System.Windows.Forms.Button();
            this.buttonOfThree = new System.Windows.Forms.Button();
            this.buttonOfTwo = new System.Windows.Forms.Button();
            this.buttonOfOne = new System.Windows.Forms.Button();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOfClear = new System.Windows.Forms.Button();
            this.buttonOfDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "=";
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(244, 65);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(91, 26);
            this.outputBox.TabIndex = 3;
            // 
            // buttonOfEquals
            // 
            this.buttonOfEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfEquals.Location = new System.Drawing.Point(24, 196);
            this.buttonOfEquals.Name = "buttonOfEquals";
            this.buttonOfEquals.Size = new System.Drawing.Size(75, 51);
            this.buttonOfEquals.TabIndex = 10;
            this.buttonOfEquals.Text = "=";
            this.buttonOfEquals.UseVisualStyleBackColor = true;
            this.buttonOfEquals.Click += new System.EventHandler(this.buttonOfEquals_Click);
            // 
            // buttonOfDivide
            // 
            this.buttonOfDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfDivide.Location = new System.Drawing.Point(279, 318);
            this.buttonOfDivide.Name = "buttonOfDivide";
            this.buttonOfDivide.Size = new System.Drawing.Size(56, 29);
            this.buttonOfDivide.TabIndex = 14;
            this.buttonOfDivide.Text = "/";
            this.buttonOfDivide.UseVisualStyleBackColor = true;
            this.buttonOfDivide.Click += new System.EventHandler(this.buttonOfDivide_Click);
            // 
            // buttonOfMultiplication
            // 
            this.buttonOfMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfMultiplication.Location = new System.Drawing.Point(218, 318);
            this.buttonOfMultiplication.Name = "buttonOfMultiplication";
            this.buttonOfMultiplication.Size = new System.Drawing.Size(56, 29);
            this.buttonOfMultiplication.TabIndex = 13;
            this.buttonOfMultiplication.Text = "*";
            this.buttonOfMultiplication.UseVisualStyleBackColor = true;
            this.buttonOfMultiplication.Click += new System.EventHandler(this.buttonOfMultiplication_Click);
            // 
            // buttonOfSubtraction
            // 
            this.buttonOfSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfSubtraction.Location = new System.Drawing.Point(156, 318);
            this.buttonOfSubtraction.Name = "buttonOfSubtraction";
            this.buttonOfSubtraction.Size = new System.Drawing.Size(56, 29);
            this.buttonOfSubtraction.TabIndex = 12;
            this.buttonOfSubtraction.Text = "-";
            this.buttonOfSubtraction.UseVisualStyleBackColor = true;
            this.buttonOfSubtraction.Click += new System.EventHandler(this.buttonOfSubtraction_Click);
            // 
            // buttonOfAddition
            // 
            this.buttonOfAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfAddition.Location = new System.Drawing.Point(94, 318);
            this.buttonOfAddition.Name = "buttonOfAddition";
            this.buttonOfAddition.Size = new System.Drawing.Size(56, 29);
            this.buttonOfAddition.TabIndex = 11;
            this.buttonOfAddition.Text = "+";
            this.buttonOfAddition.UseVisualStyleBackColor = true;
            this.buttonOfAddition.Click += new System.EventHandler(this.buttonOfAddition_Click);
            // 
            // buttonOfZero
            // 
            this.buttonOfZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfZero.Location = new System.Drawing.Point(201, 266);
            this.buttonOfZero.Name = "buttonOfZero";
            this.buttonOfZero.Size = new System.Drawing.Size(44, 29);
            this.buttonOfZero.TabIndex = 9;
            this.buttonOfZero.Text = "0";
            this.buttonOfZero.UseVisualStyleBackColor = true;
            this.buttonOfZero.Click += new System.EventHandler(this.buttonOfZero_Click);
            // 
            // buttonOfNine
            // 
            this.buttonOfNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfNine.Location = new System.Drawing.Point(260, 218);
            this.buttonOfNine.Name = "buttonOfNine";
            this.buttonOfNine.Size = new System.Drawing.Size(44, 29);
            this.buttonOfNine.TabIndex = 8;
            this.buttonOfNine.Text = "9";
            this.buttonOfNine.UseVisualStyleBackColor = true;
            this.buttonOfNine.Click += new System.EventHandler(this.buttonOfNine_Click);
            // 
            // buttonOfEight
            // 
            this.buttonOfEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfEight.Location = new System.Drawing.Point(201, 218);
            this.buttonOfEight.Name = "buttonOfEight";
            this.buttonOfEight.Size = new System.Drawing.Size(44, 29);
            this.buttonOfEight.TabIndex = 7;
            this.buttonOfEight.Text = "8";
            this.buttonOfEight.UseVisualStyleBackColor = true;
            this.buttonOfEight.Click += new System.EventHandler(this.buttonOfEight_Click);
            // 
            // buttonOfSeven
            // 
            this.buttonOfSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfSeven.Location = new System.Drawing.Point(142, 218);
            this.buttonOfSeven.Name = "buttonOfSeven";
            this.buttonOfSeven.Size = new System.Drawing.Size(44, 29);
            this.buttonOfSeven.TabIndex = 6;
            this.buttonOfSeven.Text = "7";
            this.buttonOfSeven.UseVisualStyleBackColor = true;
            this.buttonOfSeven.Click += new System.EventHandler(this.buttonOfSeven_Click);
            // 
            // buttonOfSix
            // 
            this.buttonOfSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfSix.Location = new System.Drawing.Point(260, 173);
            this.buttonOfSix.Name = "buttonOfSix";
            this.buttonOfSix.Size = new System.Drawing.Size(44, 29);
            this.buttonOfSix.TabIndex = 5;
            this.buttonOfSix.Text = "6";
            this.buttonOfSix.UseVisualStyleBackColor = true;
            this.buttonOfSix.Click += new System.EventHandler(this.buttonOfSix_Click);
            // 
            // buttonOfFive
            // 
            this.buttonOfFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfFive.Location = new System.Drawing.Point(201, 173);
            this.buttonOfFive.Name = "buttonOfFive";
            this.buttonOfFive.Size = new System.Drawing.Size(44, 29);
            this.buttonOfFive.TabIndex = 4;
            this.buttonOfFive.Text = "5";
            this.buttonOfFive.UseVisualStyleBackColor = true;
            this.buttonOfFive.Click += new System.EventHandler(this.buttonOfFive_Click);
            // 
            // buttonOfFour
            // 
            this.buttonOfFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfFour.Location = new System.Drawing.Point(142, 173);
            this.buttonOfFour.Name = "buttonOfFour";
            this.buttonOfFour.Size = new System.Drawing.Size(44, 29);
            this.buttonOfFour.TabIndex = 3;
            this.buttonOfFour.Text = "4";
            this.buttonOfFour.UseVisualStyleBackColor = true;
            this.buttonOfFour.Click += new System.EventHandler(this.buttonOfFour_Click);
            // 
            // buttonOfThree
            // 
            this.buttonOfThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfThree.Location = new System.Drawing.Point(260, 128);
            this.buttonOfThree.Name = "buttonOfThree";
            this.buttonOfThree.Size = new System.Drawing.Size(44, 29);
            this.buttonOfThree.TabIndex = 2;
            this.buttonOfThree.Text = "3";
            this.buttonOfThree.UseVisualStyleBackColor = true;
            this.buttonOfThree.Click += new System.EventHandler(this.buttonOfThree_Click);
            // 
            // buttonOfTwo
            // 
            this.buttonOfTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfTwo.Location = new System.Drawing.Point(201, 128);
            this.buttonOfTwo.Name = "buttonOfTwo";
            this.buttonOfTwo.Size = new System.Drawing.Size(44, 29);
            this.buttonOfTwo.TabIndex = 1;
            this.buttonOfTwo.Text = "2";
            this.buttonOfTwo.UseVisualStyleBackColor = true;
            this.buttonOfTwo.Click += new System.EventHandler(this.buttonOfTwo_Click);
            // 
            // buttonOfOne
            // 
            this.buttonOfOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfOne.Location = new System.Drawing.Point(142, 128);
            this.buttonOfOne.Name = "buttonOfOne";
            this.buttonOfOne.Size = new System.Drawing.Size(44, 29);
            this.buttonOfOne.TabIndex = 0;
            this.buttonOfOne.Text = "1";
            this.buttonOfOne.UseVisualStyleBackColor = true;
            this.buttonOfOne.Click += new System.EventHandler(this.buttonOfOne_Click);
            // 
            // inputBox1
            // 
            this.inputBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox1.Location = new System.Drawing.Point(24, 65);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(188, 26);
            this.inputBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Output";
            // 
            // buttonOfClear
            // 
            this.buttonOfClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfClear.Location = new System.Drawing.Point(24, 133);
            this.buttonOfClear.Name = "buttonOfClear";
            this.buttonOfClear.Size = new System.Drawing.Size(75, 44);
            this.buttonOfClear.TabIndex = 42;
            this.buttonOfClear.Text = "C";
            this.buttonOfClear.UseVisualStyleBackColor = true;
            this.buttonOfClear.Click += new System.EventHandler(this.buttonOfClear_Click);
            // 
            // buttonOfDecimal
            // 
            this.buttonOfDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfDecimal.Location = new System.Drawing.Point(142, 266);
            this.buttonOfDecimal.Name = "buttonOfDecimal";
            this.buttonOfDecimal.Size = new System.Drawing.Size(44, 29);
            this.buttonOfDecimal.TabIndex = 0;
            this.buttonOfDecimal.Text = ".";
            this.buttonOfDecimal.Click += new System.EventHandler(this.buttonOfDecimal_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 413);
            this.Controls.Add(this.buttonOfDecimal);
            this.Controls.Add(this.buttonOfClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.buttonOfEquals);
            this.Controls.Add(this.buttonOfDivide);
            this.Controls.Add(this.buttonOfMultiplication);
            this.Controls.Add(this.buttonOfSubtraction);
            this.Controls.Add(this.buttonOfAddition);
            this.Controls.Add(this.buttonOfZero);
            this.Controls.Add(this.buttonOfNine);
            this.Controls.Add(this.buttonOfEight);
            this.Controls.Add(this.buttonOfSeven);
            this.Controls.Add(this.buttonOfSix);
            this.Controls.Add(this.buttonOfFive);
            this.Controls.Add(this.buttonOfFour);
            this.Controls.Add(this.buttonOfThree);
            this.Controls.Add(this.buttonOfTwo);
            this.Controls.Add(this.buttonOfOne);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button buttonOfEquals;
        private System.Windows.Forms.Button buttonOfDivide;
        private System.Windows.Forms.Button buttonOfMultiplication;
        private System.Windows.Forms.Button buttonOfSubtraction;
        private System.Windows.Forms.Button buttonOfAddition;
        private System.Windows.Forms.Button buttonOfZero;
        private System.Windows.Forms.Button buttonOfNine;
        private System.Windows.Forms.Button buttonOfEight;
        private System.Windows.Forms.Button buttonOfSeven;
        private System.Windows.Forms.Button buttonOfSix;
        private System.Windows.Forms.Button buttonOfFive;
        private System.Windows.Forms.Button buttonOfFour;
        private System.Windows.Forms.Button buttonOfThree;
        private System.Windows.Forms.Button buttonOfTwo;
        private System.Windows.Forms.Button buttonOfOne;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOfClear;
        private System.Windows.Forms.Button buttonOfDecimal;
    }
}

