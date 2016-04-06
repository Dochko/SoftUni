namespace TheSlum.GameEngine
{
    public class AdvancedEngine : Engine
    {
        protected void AddintItemToCharacter(string[] inputParams)
        {
            var owner = inputParams[1];
            var type = inputParams[2];
            var id = inputParams[3];
            var index = this.characterList.FindIndex(x => x.Id == owner);

            switch (type)
            {
                case "injection":
                    this.characterList[index].AddToInventory(new Injection(id));
                    break;
                case "pill":
                    this.characterList[index].AddToInventory(new Pill(id));
                    break;
                case "axe":
                    this.characterList[index].AddToInventory(new Axe(id));
                    break;
                case "shield":
                    this.characterList[index].AddToInventory(new Shield(id));
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            var type = inputParams[1];
            var name = inputParams[2];
            var x = int.Parse(inputParams[3]);
            var y = int.Parse(inputParams[4]);
            var team = inputParams[5];

            switch (type)
            {
                case "mage":
                    var mage = new Mage(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    this.characterList.Add(mage);
                    break;

                case "warrior":
                    var warrior = new Warrior(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    this.characterList.Add(warrior);
                    break;

                case "healer":
                    var healer = new Healer(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    this.characterList.Add(healer);
                    break;
            }
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddintItemToCharacter(inputParams);
                    break;
            }
        }
    }
}