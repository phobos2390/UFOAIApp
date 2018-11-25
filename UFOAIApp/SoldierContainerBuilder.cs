using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFOAIApp
{
    class SoldierContainerBuilder
    {
        private Soldier parseSoldier(string input)
        {
            string [] substrings = input.Split(':');
            string name = substrings[0];
            substrings = substrings[1].Split('|');
            string nonweaponskills = substrings[0].TrimStart().TrimEnd();
            string weaponskills = substrings[1].TrimStart().TrimEnd();
            string healthString = substrings[2].TrimStart().TrimEnd();
            substrings = nonweaponskills.Split(' ');
            string strengthString = substrings[0];
            string speedString = substrings[1];
            string accuracyString = substrings[2];
            string mindString = substrings[3];
            substrings = weaponskills.Split(' ');
            string closeCombatString = substrings[0];
            string heavyWeaponsString = substrings[1];
            string assaultWeaponsString = substrings[2];
            string sniperRiflesString = substrings[3];
            string highExplosivesString = substrings[4];
            Soldier returnSoldier = new Soldier();
            returnSoldier.Name = name;
            
            returnSoldier.Strength = Int32.Parse(strengthString);
            returnSoldier.Speed = Int32.Parse(speedString);
            returnSoldier.Accuracy = Int32.Parse(accuracyString);
            returnSoldier.Mind = Int32.Parse(mindString);

            returnSoldier.CloseCombat = Int32.Parse(closeCombatString);
            returnSoldier.HeavyWeapons = Int32.Parse(heavyWeaponsString);
            returnSoldier.AssaultWeapons = Int32.Parse(assaultWeaponsString);
            returnSoldier.SniperRifles = Int32.Parse(sniperRiflesString);
            returnSoldier.HighExplosives = Int32.Parse(highExplosivesString);

            returnSoldier.Hp = Int32.Parse(healthString);
            
            return returnSoldier;
        }

        public SoldierContainer ParseInput(string value)
        {
            SoldierContainer returnContainer = new SoldierContainer();
            string[] substrings = value.Split('\n');
            foreach (string s in substrings) 
            {
                try
                {
                    returnContainer.AddSoldier(parseSoldier(s));
                }
                catch
                {
                }
            }
            return returnContainer;
        }
    }
}
