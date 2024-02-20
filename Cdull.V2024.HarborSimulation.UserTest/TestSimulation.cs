using Cdull.V2024.HarborSimulation.SimulationFramework;
using Cdull.V2024.HarborSimulation.TestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cdull.V2024.HarborSimulation.SimulationFramework.Enums;

namespace Cdull.V2024.HarborSimulation.UserTest
{
    class TestSimulation
    {
        static void Main(string[] args)
        {
            //Her har du en harbor
            Harbor harbor = new Harbor("Test Harbor", new CargoStorage("CargoStorage", 1000));

            //Her har du en liste med kaier
            List<Dock> docks = harbor.InitializeDocks(5, Model.ContainerShip, Size.Large, 2);
            docks.AddRange(harbor.InitializeDocks(5, Model.RoRo, Size.Medium, 1));
            docks.AddRange(harbor.InitializeDocks(5, Model.Bulker, Size.Large, 2));

            //Her har du en liste med skip
            List<Ship> ships = harbor.InitializeShips(5, Model.ContainerShip, Size.Large, 10);
            ships.AddRange(harbor.InitializeShips(5, Model.RoRo, Size.Medium, 50));
            ships.AddRange(harbor.InitializeShips(5, Model.Bulker, Size.Large, 50));
            ships.AddRange(harbor.InitializeShips(5, Model.LNGCarrier, Size.Large, 50));



            //sett opp en simulering: 

            // Kjør simuleringen: 
            // 1: Seilingen skal skje daglig:


            // Kjør simuleringen: 
            // 2: Seilingen skal skal skje ukentlig:

            // Kjør simuleringen: 
            // 3: Seilingen skal skje 3/25/2024 eller på en dato du selv spesifiserer:



        }
    }
}
