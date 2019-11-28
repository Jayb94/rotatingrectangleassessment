using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglesForm.Helpers
{
    public class RectanglesBuilder : IRectanglesBuilder
    {
        public List<Rectangle> GenerateInputRectangles(int yCoordinates, int noOfRectangles)
        {
            var rectangles = new List<Rectangle>();
            var random = new Random();

            if(noOfRectangles <= 2 || noOfRectangles > 30)
            {
                throw new Exception("Please enter No Of Rectangles between 3 and 30");
            }

            for (int x = 0; x < noOfRectangles; x++)
            {
                if (x == 0)
                {
                    Rectangle rectangle = new Rectangle(10, yCoordinates, random.Next(15, 50), random.Next(60, 200));
                    rectangles.Add(rectangle);
                }
                else
                {
                    Rectangle rectangle = new Rectangle(rectangles[x - 1].X + rectangles[x - 1].Width, yCoordinates, random.Next(15, 50), random.Next(60, 200));
                    rectangles.Add(rectangle);
                }

            }

            return rectangles;
        }

        public List<Rectangle> GenerateOutputRectangles(List<Rectangle> rectangles, int yCoordinates)
        {
            var rectanglesOutputList = new List<Rectangle>();
            var orderedByHeightRectangles = rectangles.OrderBy(x => x.Height).ToArray();

            for (int x = 0; x < orderedByHeightRectangles.Length; x++)
            {
                if (x == 0)
                {
                    Rectangle rectangle = new Rectangle(10, yCoordinates, orderedByHeightRectangles.Select(z => z.Width).Sum(), orderedByHeightRectangles[x].Height);
                    rectanglesOutputList.Add(rectangle);
                }
                //else
                //{
                //    var interS = CheckIfRectanglesIntersect(orderedByHeightRectangles[x], orderedByHeightRectangles.ToList());

                //    if (interS.Count != 0)
                //    {
                //        for (int q = 0; q < interS.Count; q++)
                //        {
                //            Rectangle newRectangle = new Rectangle(interS[q].X - orderedByHeightRectangles[x].X, interS[q].Height + yCoordinates, orderedByHeightRectangles[x].Width + interS[q].Width, interS[q].Height - orderedByHeightRectangles[x].Height - orderedByHeightRectangles[0].Height);
                //            rectanglesOutput.Add(newRectangle);
                //        }
                //    }
                //    else
                //    {
                //        Rectangle newRectangle = new Rectangle(orderedByHeightRectangles[x].X, orderedByHeightRectangles[0].Height + yCoordinates, orderedByHeightRectangles[x].Width, orderedByHeightRectangles[x].Height - orderedByHeightRectangles[0].Height);
                //        rectanglesOutput.Add(newRectangle);
                //    }

                //}
                else
                {
                    Rectangle rectangle = new Rectangle(orderedByHeightRectangles[x].X, orderedByHeightRectangles[0].Height + yCoordinates, orderedByHeightRectangles[x].Width, orderedByHeightRectangles[x].Height - orderedByHeightRectangles[0].Height);
                    rectanglesOutputList.Add(rectangle);
                }
            }

            return rectanglesOutputList;
        }

        public void DrawRectanglesShapes(Graphics graphics, Pen pen, List<Rectangle> rectangles)
        {
            graphics.DrawRectangles(pen, rectangles.ToArray());
        }

        public List<Rectangle> CheckIfRectanglesIntersect(Rectangle rt1, List<Rectangle> rtList)
        {
            var intersectRectanglesList = new List<Rectangle>();

            for (int x = 0; x < rtList.Count; x++)
            {
                if (Rectangle.Intersect(rt1, rtList[x]) != Rectangle.Empty)
                {
                    if (rtList[x].Height > rt1.Height)
                    {
                        intersectRectanglesList.Add(rtList[x]);
                    }
                }
            }

            return intersectRectanglesList;
        }
    }
}
