﻿namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;

    public class Engine
    {
        protected readonly List<Character> characterList = new List<Character>();

        protected List<Bonus> timeoutItems;

        private const int GameTurns = 4;

        public void InitializeTimeoutItems()
        {
            this.timeoutItems =
                this.characterList.SelectMany(c => c.Inventory).Where(i => i is Bonus).Cast<Bonus>().ToList();
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (var i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = this.GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public virtual void Run()
        {
            this.ReadUserInput();
            this.InitializeTimeoutItems();

            for (var i = 0; i < GameTurns; i++)
            {
                foreach (var character in this.characterList)
                {
                    if (character.IsAlive)
                    {
                        this.ProcessTargetSearch(character);
                    }
                }

                this.ProcessItemTimeout(this.timeoutItems);
            }

            this.PrintGameOutcome();
        }

        protected void AddItem(string[] inputParams)
        {
            throw new NotImplementedException();
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            throw new NotImplementedException();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
            }
        }

        protected Character GetCharacterById(string characterId)
        {
            return this.characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return this.characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
            var distance =
                Math.Sqrt((attackerX - targetX) * (attackerX - targetX) + (attackerY - targetY) * (attackerY - targetY));

            return distance <= range;
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = this.characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);

            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                var winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = this.characterList.Where(c => c.IsAlive);
            this.PrintCharactersStatus(aliveCharacters);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets =
                this.characterList.Where(
                    t => this.IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                    .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            this.ProcessInteraction(currentCharacter, target);
        }

        private void ReadUserInput()
        {
            var inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                var parameters = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }
    }
}