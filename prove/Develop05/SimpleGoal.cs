using System.ComponentModel;

public class SimpleGoal
{
    private bool _completion;
    public SimpleGoal(name, description, points) : base(name, description, points){}
    public bool GetCompletion()
    {
        return _completion;
    }
    public void SetCompletion(bool completion)
    {
        _completion = completion;
    }
}