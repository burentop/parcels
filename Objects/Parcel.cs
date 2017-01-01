namespace Parcels.Objects
{
  public class Parcel
  {
    private double _length;
    private double _width;
    private double _height;
    private double _weight;
    private double _distance;

    public Parcel(double length, double width, double height, double weight, double distance)
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
      _distance = distance;
    }

    public double Volume()
    {
      return _length * _width * _height;
    }

    public double CostToShip()
    {
      return (_length * _width * _height) * _weight * _distance;
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

    public double GetDistance()
    {
      return _distance;
    }

    public void SetDistance(double newDistance)
    {
      _distance = newDistance;
    }
  }
}
