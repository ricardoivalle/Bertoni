public class init
{
    private double _myValue;
    public init(double initialValue)
    {
        //Constructor with a value
        _myValue = initialValue;

    }
    public init()
    {
        //Blank constructor
        _myValue = 1 + 3;
    }
    public void initialize()
    {
        throw new System.Exception("I had to crash");
    }
}
