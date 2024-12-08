public class Dice
{
    private int _diceSize;

    public void SetDiceSize(int diceSize)
    {
        _diceSize = diceSize;
    }
    public int GetDiceSize()
    {
        return _diceSize;
    }

    public int RollDice(int diceSize)
    {
        Random rnd = new Random();
        int diceNum = rnd.Next(0, diceSize + 1);
        return diceNum;
    }

}