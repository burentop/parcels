namespace Parcels.Objects
{
  public class Parcel
  {
    private double _length;
    private double _width;
    private double _height;
    private double _weight;

    public Parcel(double length, double width, double height, double weight)
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
    }

    public double Volume()
    {
      return _length * _width * _height;
    }

    public double CostToShip(double distance = 1.0)
    {
      return (_length * _width * _height) * _weight * distance;
    }

    public double GetLength()
    {
      return _length;
    }

    public void SetLength(double newLength)
    {
      _length = newLength;
    }

    public double GetWidth()
    {
      return _width;
    }

    public void SetWidth(double newWidth)
    {
      _width = newWidth;
    }

    public double GetHeight()
    {
      return _height;
    }

    public void SetHeight(double newHeight)
    {
      _height = newHeight;
    }

    public double GetWeight()
    {
      return _weight;
    }

    public void SetWeight(double newWeight)
    {
      _weight = newWeight;
    }
  }
}
