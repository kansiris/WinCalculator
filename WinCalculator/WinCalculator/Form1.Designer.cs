namespace WinCalculator
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
            this.txtResultBox = new System.Windows.Forms.TextBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCubeRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultBox
            // 
            this.txtResultBox.ForeColor = System.Drawing.Color.Blue;
            this.txtResultBox.Location = new System.Drawing.Point(2, 12);
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.ReadOnly = true;
            this.txtResultBox.Size = new System.Drawing.Size(241, 20);
            this.txtResultBox.TabIndex = 0;
            this.txtResultBox.Text = "0";
            this.txtResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.ForeColor = System.Drawing.Color.Red;
            this.btnBackSpace.Location = new System.Drawing.Point(2, 39);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(78, 27);
            this.btnBackSpace.TabIndex = 1;
            this.btnBackSpace.Text = "Backspace";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCE
            // 
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Location = new System.Drawing.Point(83, 39);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(73, 27);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(158, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.ForeColor = System.Drawing.Color.Blue;
            this.btnSeven.Location = new System.Drawing.Point(2, 72);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(38, 27);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.ForeColor = System.Drawing.Color.Blue;
            this.btnEight.Location = new System.Drawing.Point(43, 72);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(36, 27);
            this.btnEight.TabIndex = 6;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.ForeColor = System.Drawing.Color.Blue;
            this.btnNine.Location = new System.Drawing.Point(81, 72);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(35, 27);
            this.btnNine.TabIndex = 7;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(119, 72);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(37, 27);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrt.Location = new System.Drawing.Point(158, 72);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(38, 27);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.ForeColor = System.Drawing.Color.Blue;
            this.btnPercentage.Location = new System.Drawing.Point(158, 103);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(38, 27);
            this.btnPercentage.TabIndex = 15;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(119, 103);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(37, 27);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSix
            // 
            this.btnSix.ForeColor = System.Drawing.Color.Blue;
            this.btnSix.Location = new System.Drawing.Point(81, 103);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(35, 27);
            this.btnSix.TabIndex = 13;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.ForeColor = System.Drawing.Color.Blue;
            this.btnFive.Location = new System.Drawing.Point(43, 103);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(36, 27);
            this.btnFive.TabIndex = 12;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.ForeColor = System.Drawing.Color.Blue;
            this.btnFour.Location = new System.Drawing.Point(2, 103);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(38, 27);
            this.btnFour.TabIndex = 11;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.ForeColor = System.Drawing.Color.Blue;
            this.btnInverse.Location = new System.Drawing.Point(158, 135);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(38, 27);
            this.btnInverse.TabIndex = 21;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(119, 135);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(37, 27);
            this.btnSubtract.TabIndex = 20;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnThree
            // 
            this.btnThree.ForeColor = System.Drawing.Color.Blue;
            this.btnThree.Location = new System.Drawing.Point(81, 135);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(35, 27);
            this.btnThree.TabIndex = 19;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.ForeColor = System.Drawing.Color.Blue;
            this.btnTwo.Location = new System.Drawing.Point(43, 135);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(36, 27);
            this.btnTwo.TabIndex = 18;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.ForeColor = System.Drawing.Color.Blue;
            this.btnOne.Location = new System.Drawing.Point(2, 135);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(38, 27);
            this.btnOne.TabIndex = 17;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.ForeColor = System.Drawing.Color.Red;
            this.btnEqual.Location = new System.Drawing.Point(158, 167);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(85, 27);
            this.btnEqual.TabIndex = 27;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(119, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 27);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.ForeColor = System.Drawing.Color.Blue;
            this.btnPoint.Location = new System.Drawing.Point(81, 167);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(35, 27);
            this.btnPoint.TabIndex = 25;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.ForeColor = System.Drawing.Color.Blue;
            this.btnNegate.Location = new System.Drawing.Point(43, 167);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(36, 27);
            this.btnNegate.TabIndex = 24;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btnZero
            // 
            this.btnZero.ForeColor = System.Drawing.Color.Blue;
            this.btnZero.Location = new System.Drawing.Point(2, 167);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(38, 27);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnCube
            // 
            this.btnCube.ForeColor = System.Drawing.Color.Blue;
            this.btnCube.Location = new System.Drawing.Point(198, 134);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(45, 27);
            this.btnCube.TabIndex = 30;
            this.btnCube.Text = "x^3";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.ForeColor = System.Drawing.Color.Blue;
            this.btnSquare.Location = new System.Drawing.Point(198, 102);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(45, 27);
            this.btnSquare.TabIndex = 29;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCubeRoot
            // 
            this.btnCubeRoot.ForeColor = System.Drawing.Color.Blue;
            this.btnCubeRoot.Location = new System.Drawing.Point(198, 71);
            this.btnCubeRoot.Name = "btnCubeRoot";
            this.btnCubeRoot.Size = new System.Drawing.Size(45, 27);
            this.btnCubeRoot.TabIndex = 28;
            this.btnCubeRoot.Text = "cubert";
            this.btnCubeRoot.UseVisualStyleBackColor = true;
            this.btnCubeRoot.Click += new System.EventHandler(this.btnCubeRoot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 197);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnCubeRoot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.txtResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultBox;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCubeRoot;
    }
}

