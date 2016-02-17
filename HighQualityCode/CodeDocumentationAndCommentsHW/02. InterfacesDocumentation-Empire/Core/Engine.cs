using System;
using System.Linq;
using System.Text;
using Empire.Contracts;

namespace Empire.Core
{
    public class Engine : IRunnable
    {
        private readonly IBuildingFactory buildingFactory;
        private readonly IResourceFactory resourceFactory;
        private readonly IUnitFactory unitFactory;
        private readonly IEmpiresData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(
            IBuildingFactory buildingFactory, 
            IResourceFactory resourceFactory, 
            IUnitFactory unitFactory, 
            IEmpiresData data, 
            IInputReader reader, 
            IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadCommand().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.data.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resources[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, unitFactory, resourceFactory);

            this.data.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            this.AppendTreasuryInfo(output);

            this.AppendBuildingInfo(output);

            this.AppendUnitsInfo(output);

            this.writer.Print(output.ToString().Trim());
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.data.Resources)
            {
                output.AppendFormat("--{0}: {1}{2}", resource.Key, resource.Value, Environment.NewLine);
            }
        }

        private void AppendBuildingInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (var building in this.data.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.AppendFormat("--{0}: {1}{2}", unit.Key, unit.Value, Environment.NewLine);
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }
    }
}