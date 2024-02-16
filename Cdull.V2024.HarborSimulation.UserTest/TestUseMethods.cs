using Cdull.V2024.HarborSimulation.SimulationFramework;
using Cdull.V2024.HarborSimulation.TestClient;
using static Cdull.V2024.HarborSimulation.SimulationFramework.Enums;


namespace Cdull.V2024.HarborSimulation.UserTest
{
    public class TestUseMethods
    {
        static void Main(string[] args)
        {
            Harbor harbor = new("Habor1", new CargoStorage("Cargostorage", 1000));


            // Lag en liste med docks-objeckter ved hjelp av harbor-metoden InitializeDocks(): 

            List<Dock> docks = harbor.InitializeDocks(5, Model.ContainerShip, Size.Large, 2);
            docks.AddRange(harbor.InitializeDocks(5, Model.RoRo, Size.Medium, 1));
            docks.AddRange(harbor.InitializeDocks(5, Model.Bulker, Size.Large, 2));


            // Lag en liste med Ships-objekter ved hjelp av harbor-metoden InitializeShips(): 

            List<Ship> ships = harbor.InitializeShips(5, Model.ContainerShip, Size.Large, 10);
            ships.AddRange(harbor.InitializeShips(5, Model.RoRo, Size.Medium, 50));
            ships.AddRange(harbor.InitializeShips(5, Model.Bulker, Size.Large, 50));
            ships.AddRange(harbor.InitializeShips(5, Model.LNGCarrier, Size.Large, 50));

            // Instans av simulering-klassen: 
            IHarborSimulation driver = new Simulation();

            // Starttid og sluttid for simuleringen 
            DateTime startTime = new DateTime(2024, 1, 1);
            DateTime endTime = new DateTime(2024, 1, 5);

            // Starttid for seiling for alle ship: 
            DateTime startSailingTime = new DateTime(2024, 1, 1);


            // Kjør simuleringen ved å bruke metoden run på driver-instansen som er definert
            // ovenfor: 
            driver.Run(harbor, startTime, endTime, ships, docks, startSailingTime, 1, true, Enums.RecurringType.Daily);


            // Hent Historikk for alle dager fra starttid til slutttid for harbor,
            // ved hjelp av GetHarborHistory()-metoden på harbor objektet: 
            //Skriv ut historikken til terminalen:           

            Console.WriteLine(harbor.GetHarborHistory(new DateTime(2024, 1, 1)));

            Console.WriteLine(harbor.GetHarborHistory(new DateTime(2024, 1, 2)));

            Console.WriteLine(harbor.GetHarborHistory(new DateTime(2024, 1, 3)));

            Console.WriteLine(harbor.GetHarborHistory(new DateTime(2024, 1, 4)));
        }

    }
}
