namespace Parcels.Objects
{
  public class Parcel
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;

    public Parcel(int length, int width, int height, int weight)
    {
      _length = length;
      _width = width;
      _height = height;
      _weight = weight;
    }

    public int CalcQuote(int distance = 1)
    {
      return (_length * _width * _height) * _weight * distance;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }
  }
}
