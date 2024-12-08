using System.ComponentModel;

public class EternalGoal : Goal
{
    private int _completionNumber;

    public EternalGoal(name, description, points) : base(name, description, points){}
    public int GetCompletionNumber()
    {
        return _completionNumber;
    }
    public void SetCompletionNumber(int completionNumber)
    {
        _completionNumber = completionNumber;
    }
}