using System;

internal class Rectangle
{
    private double width = 0;
    private double height = 0;

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    private static Rectangle GetRotatedSize(Rectangle rect, double rotation)
    {
        double sinValue = Math.Abs(Math.Sin(rotation));
        double cosValue = Math.Abs(Math.Cos(rotation));
        double rotatedWidth = cosValue * rect.width + sinValue * rect.height;
        double rotatedHeigth = cosValue * rect.width + sinValue * rect.height;

        Rectangle rotatedFigure = new Rectangle(rotatedWidth, rotatedHeigth);

        return rotatedFigure;
    }
}
