namespace Calculator
{
    partial class Calculator
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
            this.nine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(130, 61);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(47, 23);
            this.nine.TabIndex = 0;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(130, 90);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(47, 23);
            this.six.TabIndex = 0;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(183, 90);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(47, 23);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(130, 119);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(47, 23);
            this.three.TabIndex = 0;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(183, 119);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(47, 23);
            this.times.TabIndex = 1;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(183, 148);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(47, 23);
            this.div.TabIndex = 1;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(24, 61);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(47, 23);
            this.seven.TabIndex = 100;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(24, 90);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(47, 23);
            this.four.TabIndex = 0;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(24, 119);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(47, 23);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(130, 148);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(47, 23);
            this.dec.TabIndex = 0;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(77, 61);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(47, 23);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(77, 119);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(47, 23);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(77, 90);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(47, 23);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(24, 148);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(100, 23);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(236, 61);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(47, 23);
            this.button17.TabIndex = 1;
            this.button17.Text = "C";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(236, 90);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(47, 23);
            this.sub.TabIndex = 1;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(236, 119);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(47, 52);
            this.equal.TabIndex = 0;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button20_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(24, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(259, 29);
            this.result.TabIndex = 2;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.equation.Location = new System.Drawing.Point(33, 18);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(100, 20);
            this.equation.TabIndex = 3;
            this.equation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 207);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.five);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.two);
            this.Controls.Add(this.times);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.four);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(328, 246);
            this.MinimumSize = new System.Drawing.Size(328, 246);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox equation;
    }
}

