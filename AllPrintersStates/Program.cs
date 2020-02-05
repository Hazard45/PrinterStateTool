using System;
using PrinterState;

namespace AllPrintersStates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var queues = PrinterInfo.GetAllQueues();
            foreach (var queue in queues)
            {
                Console.WriteLine("---" + queue.FullName.ToUpper() + "---");
                Console.WriteLine("Name: " + queue.Name);
                Console.WriteLine("Is Offline: " + queue.IsOffline);
                Console.WriteLine("Is Paper Jammed: " + queue.IsPaperJammed);
                Console.WriteLine("Need User Intervention: " + queue.NeedUserIntervention);
                Console.WriteLine("Has Paper Problem: " + queue.HasPaperProblem);
                Console.WriteLine("Is Busy: " + queue.IsBusy);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}