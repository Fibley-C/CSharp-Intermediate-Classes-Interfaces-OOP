namespace Workflow
{
    public interface IActivity
    {
        void Execute();
    }

    public class WakeUp : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Waking up!");
        }
    }

    public class GoWork : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Going to work -.-");
        }
    }

    public class Sleep : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Going to sleep... Zzz...");
        }
    }
}