namespace RectanglesForm
{
    partial class RectanglesForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rectanglesTextBox = new System.Windows.Forms.TextBox();
            this.rectangleGeneratorBtn = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Rectangles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Rectangles:";
            // 
            // rectanglesTextBox
            // 
            this.rectanglesTextBox.Location = new System.Drawing.Point(235, 13);
            this.rectanglesTextBox.Name = "rectanglesTextBox";
            this.rectanglesTextBox.Size = new System.Drawing.Size(183, 20);
            this.rectanglesTextBox.TabIndex = 2;
            // 
            // rectangleGeneratorBtn
            // 
            this.rectangleGeneratorBtn.Location = new System.Drawing.Point(483, 13);
            this.rectangleGeneratorBtn.Name = "rectangleGeneratorBtn";
            this.rectangleGeneratorBtn.Size = new System.Drawing.Size(116, 23);
            this.rectangleGeneratorBtn.TabIndex = 3;
            this.rectangleGeneratorBtn.Text = "Generate";
            this.rectangleGeneratorBtn.UseVisualStyleBackColor = true;
            this.rectangleGeneratorBtn.Click += new System.EventHandler(this.OnGenerateClick);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(232, 46);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 4;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(643, 13);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(113, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetDrawing);
            // 
            // RectanglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 668);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.rectangleGeneratorBtn);
            this.Controls.Add(this.rectanglesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RectanglesForm";
            this.Text = "RectanglesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rectanglesTextBox;
        private System.Windows.Forms.Button rectangleGeneratorBtn;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button resetBtn;
    }
}

