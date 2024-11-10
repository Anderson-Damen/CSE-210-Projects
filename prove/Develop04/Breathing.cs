public class Breathing : Activity
{
   public void CountDown()
   {
      Console.Write("5");

      Thread.Sleep(1000);
      Console.Write("\b \b");

      Console.Write("4");

      Thread.Sleep(1000);
      Console.Write("\b \b");

      Console.Write("3");

      Thread.Sleep(1000);
      Console.Write("\b \b");

      Console.Write("2");

      Thread.Sleep(1000);
      Console.Write("\b \b");

      Console.Write("1");
      Thread.Sleep(1000);
      Console.Write("\b \b");
   }
}