using Empire.Core;
using Empire.Core.Factories;
using Empire.IO;

namespace Empire
{
    class EmpireMain
    {
        static void Main()
        {
            var buildingFactory = new BuildingFactory();
            var resourceFactory = new ResourceFactory();
            var unitsFactory = new UnitFactory();
            var data = new EmpiresData();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new Engine(
                buildingFactory, 
                resourceFactory, 
                unitsFactory, 
                data, 
                reader, 
                writer);

            engine.Run();
        }
    }
}
