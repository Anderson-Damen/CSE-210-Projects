public class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    public string GetType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetReward()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    
    public string DisplayGoal()
    {
        return "" + _points + "";
    }
}