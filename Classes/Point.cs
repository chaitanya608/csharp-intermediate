namespace Classes;

class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        // this.X = newLocation.X;
        // this.Y = newLocation.Y;
        // commented the above lines to make sure that there's only 1 method that sets the new point location and it's re-used.

        if (newLocation == null)
        {
            throw new ArgumentNullException(nameof(newLocation));
        }
        Move(newLocation.X, newLocation.Y);
    }
}
