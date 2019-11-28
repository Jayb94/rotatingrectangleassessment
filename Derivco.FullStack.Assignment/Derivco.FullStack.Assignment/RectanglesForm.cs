using RectanglesForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectanglesForm
{
    public partial class RectanglesForm : Form
    {
        private RectanglesBuilder _rectanglesBuilder;
        public RectanglesForm()
        {
            InitializeComponent();
            _rectanglesBuilder = new RectanglesBuilder();
        }

        private void OnGenerateClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rectanglesTextBox.Text))
            {
                if (int.Parse(rectanglesTextBox.Text) <= 2 || int.Parse(rectanglesTextBox.Text) > 30)
                {
                    Error.ForeColor = Color.Red;
                    Error.Text = "Please enter numnber of Rectangles between 3 and 30";
                    this.Invalidate();
                }
                else
                {
                    Error.Text = "";
                    
                    Graphics graphics = this.CreateGraphics();
                    Pen pen = new Pen(Color.Red, 1);
                    var inputYCoordinates = 350;
                    var outputYCoordinates = 80;

                    //Set (0,0) to the bottom of the screen
                    graphics.ScaleTransform(1.0f, -1.0f);
                    graphics.TranslateTransform(0, -this.ClientRectangle.Height);

                    //Generate Input Rectangles
                    var generatedInputRectangles = _rectanglesBuilder.GenerateInputRectangles(inputYCoordinates, int.Parse(rectanglesTextBox.Text));

                    _rectanglesBuilder.DrawRectanglesShapes(graphics, pen, generatedInputRectangles);

                    //Generate Output Rectangles
                    var generatedOutputRectangles = _rectanglesBuilder.GenerateOutputRectangles(generatedInputRectangles, outputYCoordinates);

                    _rectanglesBuilder.DrawRectanglesShapes(graphics, pen, generatedOutputRectangles);

                }
            }
        }

        private void ResetDrawing(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
