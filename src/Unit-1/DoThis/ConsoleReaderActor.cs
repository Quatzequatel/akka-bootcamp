using System;
using Akka.Actor;

namespace WinTail
{
    /// <summary>
    /// Actor responsible for reading FROM the console. 
    /// Also responsible for calling <see cref="ActorSystem.Terminate"/>.
    /// </summary>
    public class ConsoleReaderActor : UntypedActor
    {
        public const string StartCommand = "start";
        public const string ExitCommand = "exit";

        public ConsoleReaderActor()
        {
            
        }

        protected override void OnReceive(object message)
        {
            if (message.Equals(StartCommand))
            {
                DoPrintInstructions();
            }
            GetAndValidateInput();
        }

        #region Internal Methods
        private void DoPrintInstructions()
        {
            Console.WriteLine("Please provide the URI of a log file on disk.\n");
        }

        private void GetAndValidateInput()
        {
            var message = Console.ReadLine();
            if (!string.IsNullOrEmpty(message) && String.Equals(message, ExitCommand, StringComparison.OrdinalIgnoreCase))
            {
                Context.System.Terminate();
                return;
            }

            Context.ActorSelection("akka://MyActorSystem/user/validationActor").Tell(message);
        }

        private static bool IsValid(string message)
        {
            return message.Length % 2 == 0;
        }
        #endregion
    }
}