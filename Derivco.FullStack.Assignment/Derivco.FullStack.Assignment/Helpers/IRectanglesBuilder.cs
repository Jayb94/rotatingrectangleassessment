using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglesForm.Helpers
{
    public interface IRectanglesBuilder
    {
        List<Rectangle> GenerateInputRectangles(int yCoordinates, int noOfRectangles);
        List<Rectangle> GenerateOutputRectangles(List<Rectangle> rectangles, int yCoordinates);
        List<Rectangle> CheckIfRectanglesIntersect(Rectangle rt1, List<Rectangle> rtList);
        void DrawRectanglesShapes(Graphics graphics, Pen pen, List<Rectangle> rectangles);
    }
}
