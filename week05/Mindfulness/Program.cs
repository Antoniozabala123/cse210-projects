using System;
using EternalQuest; // Asegúrate de tener esta línea

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aquí es donde creas el objeto
            GoalManager manager = new GoalManager();
            manager.Start();
        }
    }
}