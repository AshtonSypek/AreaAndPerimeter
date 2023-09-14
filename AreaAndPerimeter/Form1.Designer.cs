namespace AreaAndPerimeter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(79, 141);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(185, 141);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 54);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Width:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 83);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Area:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 112);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Perimeter:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(160, 25);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 6;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(160, 54);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 7;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(160, 83);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 8;
            txtArea.TabStop = false;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(160, 112);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(100, 23);
            txtPerimeter.TabIndex = 9;
            txtPerimeter.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(384, 211);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "AreaAndPerimeter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtArea;
        private TextBox txtPerimeter;
    }
}