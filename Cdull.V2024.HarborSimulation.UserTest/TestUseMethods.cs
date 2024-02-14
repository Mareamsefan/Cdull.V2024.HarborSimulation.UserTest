using Cdull.V2024.HarborSimulation.SimulationFramework;
using Cdull.V2024.HarborSimulation.TestClient;


namespace Cdull.V2024.HarborSimulation.UserTest
{
    public class TestUseMethods
    {
        static void Main(string[] args)
        {
            Harbor harbor = new("Habor1", new CargoStorage("Cargostorage", 1000));


            // Lag en liste med docks-objeckter ved hjelp av harbor-metoden InitializeDocks(): 





            // Lag en liste med Ships-objekter ved hjelp av harbor-metoden InitializeShips(): 


            // Instans av simulering-klassen: 
            IHarborSimulation driver = new Simulation();

            // Starttid og sluttid for simuleringen 
            DateTime startTime = new DateTime(2024, 1, 1);
            DateTime endTime = new DateTime(2024, 1, 5);

            // Starttid for seiling for alle ship: 
            DateTime startSailingTime = new DateTime(2024, 1, 1);


            // Kjør simuleringen ved å bruke metoden run på driver-instansen som er definert
            // ovenfor: 


            // Hent Historikk for alle dager fra starttid til slutttid for harbor,
            // ved hjelp av GetHarborHistory()-metoden på harbor objektet: 
            //Skriv ut historikken til terminalen: 


    
            

        }

    }
}
