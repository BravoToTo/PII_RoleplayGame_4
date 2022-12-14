using RoleplayGame.Scenarios;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenario = new ConsoleScenario();
            scenario.Setup();
            scenario.Run();
        }
    }
}
