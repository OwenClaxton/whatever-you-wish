using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text;  
using System.Threading.Tasks;
using Sandbox.ModAPI;
using Sandbox.Common;

/*   
  Welcome to Modding API. This is one of two sample scripts that you can modify for your needs, 
  in this case simple script is prepared that will show Hello world message in chat. 
  You need to run this script manually from chat to see it. To run it you first need to enable this in game 
  (press new World, than Custom World and Mods , you should see Script1 at the top), when world with mod loads, 
  please press F11 to see if there was any loading error during loading of the mod. When there is no mod loading errors  
  you can activate mod by opening chat window (by pressing Enter key). Than you need to call Main method of script class. 
   
  To do that you need to write this command : //call Script1_ResponseTriggerHelloWorld TestScript.Script ShowHelloWorld
  //call means that you want to call script
  Script1_TestScript is name of directory (if you have more script directories e.g. Script1, Script2 ... you need to change Script1 to your actual directory)
  TestScript.Script is name of tthe class with namespace , if you define new class you need to use new name e.g. when you create class Test in TestScript namespace
  you need to write : TestScript.Test 
  ShowHelloWorld is name of method, you can call only public static methods from chat window. 
   
   You can define your own namespaces / classes / methods to call 
 */ 
 
namespace ResponseTriggerHelloWorld 
{
  public class CommandHello : ChatCommand
  {
    public CommandHello()
    : base(ChatCommandSecurity.User, "hello", new[] { "/hello"})
  {
  }
  
  public override void Help(ulong steamId bool brief)
}



    public class CommandHelloWorld : ChatCommand
    {
        public CommandHelloWorld()
            : base(ChatCommandSecurity.User, "hello", new[] { "/hello" })
        {
        }

        public override void Help(ulong steamId, bool brief)
        {
            MyAPIGateway.Utilities.ShowMessage("/hello", "A simple Hello World test.");
        }

        public override bool Invoke(ulong steamId, long playerId, string messageText)
        {
            if (messageText.Equals("/hello", StringComparison.InvariantCultureIgnoreCase))
            {
                MyAPIGateway.Utilities.ShowNotification("Hello back to you", 1000, MyFontEnum.Red); // display on your screen.
                MyAPIGateway.Utilities.ShowMessage("Computer", "Hello back to you");  // echo back to yourself.
                MyAPIGateway.Utilities.SendMessage("This player thinks it cool to say hello"); // broadcast to everyone like a standard chat message, but from YOU.
                return true;
            }
            return false;
        }
    }
}
