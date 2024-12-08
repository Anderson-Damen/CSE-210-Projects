public abstract class SmartDevice
{
    private string _name;
    private bool _isOn;
    private TimeSpan _runtime;

    public void GetName(string name)
    {
        _name = name;
    }
}