using Cdull.V2024.HarborSimulation.SimulationFramework;
using Cdull.V2024.HarborSimulation.TestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdull.V2024.HarborSimulation.UserTest
{
    class TestFindMethods
    {
        static void Main(string[] args)
        {   
            // Opprettet en instans av havne-klassen
            Harbor harbor = new("Habor1", new CargoStorage("Cargostorage", 1000));

            // Prøv å lag en liste med skip så enkelt så mulig ved å bruke harbor klassen:


            // Prøv å lag en liste med kaiplasser så enkelt så mulig ved å bruke harbor klassen:


            // Laget en instans av simuleringen vår - klassen som implementerer IHarborSimulation interface:  
            IHarborSimulation driver = new Simulation();

            // Lagde en starttid og en slutttid for simuleringen: 
            DateTime startTime = new DateTime(2024, 1, 1);
            DateTime endTime = new DateTime(2024, 1, 5);

            // Lagde en starttid for når seilingen til alle skipene skal starte: 
            DateTime startSailingTime = new DateTime(2024, 1, 2);


            // Prøv å kjør en simulering: 

            
            // Prøv å hente ut historikken for simuleringen du nettopp kjørte:


           
            


        }
    }
}
