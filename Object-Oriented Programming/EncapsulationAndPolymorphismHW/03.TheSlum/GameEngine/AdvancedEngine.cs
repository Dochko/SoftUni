namespace TheSlum.GameEngine
{
    public class AdvancedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddintItemToCharacter(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string type = inputParams[1];
            string name = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            string team = inputParams[5];

            switch (type)
            {
                case "mage":
                    Mage mage = new Mage(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    characterList.Add(mage);
                    break;

                case "warrior":
                    Warrior warrior = new Warrior(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    characterList.Add(warrior);
                    break;

                case "healer":
                    Healer healer = new Healer(name, x, y, team == "Blue" ? Team.Blue : Team.Red);
                    characterList.Add(healer);
                    break;
            }
        }

        protected void AddintItemToCharacter(string[] inputParams)
        {
            string owner = inputParams[1];
            string type = inputParams[2];
            string id = inputParams[3];
            int index = characterList.FindIndex(x => x.Id == owner);

            switch (type)
            {
                case "injection":
                    characterList[index].AddToInventory(new Injection(id));
                    break;
                case "pill":
                    characterList[index].AddToInventory(new Pill(id));
                    break;
                case "axe":
                    characterList[index].AddToInventory(new Axe(id));
                    break;
                case "shield":
                    characterList[index].AddToInventory(new Shield(id));
                    break;
            }
        }
    }
}