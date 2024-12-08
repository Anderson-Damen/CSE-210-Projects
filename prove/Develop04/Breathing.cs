public class Breathing : Activity
{
   public void RunBreathing()
   {
      SetStartMessage("Welcome to the Breathing Activity");
      Console.WriteLine(GetStartMessage());
      Console.WriteLine("");
      SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
      Console.WriteLine(GetDescription());
      Console.WriteLine("");
      Console.Write("How long, in seconds, would you like for your session? ");
      SetDuration(int.Parse(Console.ReadLine()));
      int duration = GetDuration();
      Console.WriteLine("Get Ready...");
      Animation();
                
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(duration);

      while (DateTime.Now < futureTime)
      {
         Console.Write("Breath in...");
         CountDown();
         Console.WriteLine("");
         Console.Write("Breath out...");
         CountDown();
         Console.WriteLine("");
      }
      SetEndMessage("Well done!! \n \n You have completed another" + duration + "seconds of the Breathing ACtivity.");
   }
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