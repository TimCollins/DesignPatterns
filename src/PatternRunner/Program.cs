using System;
using BlackWasp.Singleton;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can't do var state = new ApplicationState(); because of the private constructor
            // Also can't do ApplicationState.UserId = 2; because there is no object instance yet
            var state = ApplicationState.GetApplicationState();

            state.IsConnected = true;
            state.UserId = 57;
            state.UserName = "Fred";

            Console.WriteLine("User {0} ({1}) " + (state.IsConnected ? "is " : "is not ") + "connected.", state.UserName, state.UserId);

            // Do stuff

            // There will still only be one state object supplied
            // The state2 variable is used but both state and state2 point at the same thing
            var state2 = ApplicationState.GetApplicationState();
            state2.IsConnected = !state2.IsConnected;

            Console.WriteLine("User {0} ({1}) " + (state2.IsConnected ? "is " : "is not ") + "connected.", state2.UserName, state2.UserId);

            ConsoleUtils.WaitForEscape();
        }        
    }
}