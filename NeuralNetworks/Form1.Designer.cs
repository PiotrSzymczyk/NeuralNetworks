namespace NeuralNetworks
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eval = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.epochCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxError = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isAdaline = new System.Windows.Forms.CheckBox();
            this.learn = new System.Windows.Forms.Button();
            this.gain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.theresholdVal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.weightsVal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.biasVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inputs (space separated):";
            // 
            // dataset
            // 
            this.dataset.Location = new System.Drawing.Point(100, 12);
            this.dataset.Name = "dataset";
            this.dataset.Size = new System.Drawing.Size(141, 20);
            this.dataset.TabIndex = 1;
            this.dataset.Text = "And.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Learning dataset:";
            // 
            // inputs
            // 
            this.inputs.Location = new System.Drawing.Point(144, 13);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(97, 20);
            this.inputs.TabIndex = 3;
            this.inputs.Text = "0 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.eval);
            this.panel1.Controls.Add(this.resultBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 97);
            this.panel1.TabIndex = 4;
            // 
            // eval
            // 
            this.eval.Location = new System.Drawing.Point(7, 65);
            this.eval.Name = "eval";
            this.eval.Size = new System.Drawing.Size(233, 23);
            this.eval.TabIndex = 6;
            this.eval.Text = "Evaluate";
            this.eval.UseVisualStyleBackColor = true;
            this.eval.Click += new System.EventHandler(this.eval_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(92, 39);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(149, 20);
            this.resultBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.epochCount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.maxError);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.isAdaline);
            this.panel2.Controls.Add(this.learn);
            this.panel2.Controls.Add(this.gain);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 179);
            this.panel2.TabIndex = 5;
            // 
            // epochCount
            // 
            this.epochCount.Location = new System.Drawing.Point(99, 65);
            this.epochCount.Name = "epochCount";
            this.epochCount.Size = new System.Drawing.Size(142, 20);
            this.epochCount.TabIndex = 11;
            this.epochCount.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Max epoch count:";
            // 
            // maxError
            // 
            this.maxError.Enabled = false;
            this.maxError.Location = new System.Drawing.Point(99, 115);
            this.maxError.Name = "maxError";
            this.maxError.Size = new System.Drawing.Size(141, 20);
            this.maxError.TabIndex = 9;
            this.maxError.Text = "0,08";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max error:";
            // 
            // isAdaline
            // 
            this.isAdaline.AutoSize = true;
            this.isAdaline.Location = new System.Drawing.Point(81, 93);
            this.isAdaline.Name = "isAdaline";
            this.isAdaline.Size = new System.Drawing.Size(72, 17);
            this.isAdaline.TabIndex = 7;
            this.isAdaline.Text = "ADALINE";
            this.isAdaline.UseVisualStyleBackColor = true;
            this.isAdaline.CheckedChanged += new System.EventHandler(this.isAdaline_CheckedChanged);
            // 
            // learn
            // 
            this.learn.Location = new System.Drawing.Point(6, 146);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(233, 23);
            this.learn.TabIndex = 5;
            this.learn.Text = "Learn";
            this.learn.UseVisualStyleBackColor = true;
            this.learn.Click += new System.EventHandler(this.learn_Click);
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(100, 38);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(141, 20);
            this.gain.TabIndex = 4;
            this.gain.Text = "0,01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gain:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.theresholdVal);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.weightsVal);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.biasVal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(15, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 98);
            this.panel3.TabIndex = 6;
            // 
            // theresholdVal
            // 
            this.theresholdVal.AutoSize = true;
            this.theresholdVal.Location = new System.Drawing.Point(97, 68);
            this.theresholdVal.Name = "theresholdVal";
            this.theresholdVal.Size = new System.Drawing.Size(13, 13);
            this.theresholdVal.TabIndex = 5;
            this.theresholdVal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Threshold";
            // 
            // weightsVal
            // 
            this.weightsVal.AutoSize = true;
            this.weightsVal.Location = new System.Drawing.Point(97, 44);
            this.weightsVal.Name = "weightsVal";
            this.weightsVal.Size = new System.Drawing.Size(22, 13);
            this.weightsVal.TabIndex = 3;
            this.weightsVal.Text = "0 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Input weights";
            // 
            // biasVal
            // 
            this.biasVal.AutoSize = true;
            this.biasVal.Location = new System.Drawing.Point(97, 20);
            this.biasVal.Name = "biasVal";
            this.biasVal.Size = new System.Drawing.Size(13, 13);
            this.biasVal.TabIndex = 1;
            this.biasVal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eval;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button learn;
        private System.Windows.Forms.TextBox gain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isAdaline;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label theresholdVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label weightsVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label biasVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epochCount;
        private System.Windows.Forms.Label label8;
    }
}

