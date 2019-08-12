using Akka.Actor;

namespace WinTail
{
    public class ValidationActor:UntypedActor
    {
        private readonly IActorRef _consoleWriterActor;

        public ValidationActor(IActorRef consoleWriterActor)
        {
            _consoleWriterActor = consoleWriterActor;
        }

        protected override void OnReceive(object message)
        {
            var msg = message as string;
            if(string.IsNullOrEmpty(msg))
            {
                _consoleWriterActor.Tell(new Messages.InputError("No input recieved."));
            }
            else
            {
                if(IsValid(msg))
                {
                    _consoleWriterActor.Tell(new Messages.InputSuccess("Valid message."));
                }
                else
                {
                    _consoleWriterActor.Tell(new Messages.InputError("Invalid input. Message had odd number of characters."));
                }
            }
            Sender.Tell(new Messages.ContinueProcessing());
        }

        private static bool IsValid(string msg)
        {
            return msg.Length % 2 == 0;
        }
    }
}
