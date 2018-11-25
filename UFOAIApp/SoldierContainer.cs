using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFOAIApp
{
    public class SoldierContainer
    {
        private IList<Soldier> soldiers;

        public SoldierContainer()
        {
            this.soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier toAdd)
        {
            this.soldiers.Add(toAdd);
        }

        public void SortCloseCombat()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareCloseCombat(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public void SortHeavyWeapons()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareHeavyWeapons(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public void SortAssaultWeapons()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareAssaultWeapons(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public void SortSniperRifles()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareSniperRifles(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public void SortHighExplosives()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareHighExplosives(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public void SortHP()
        {
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                for (int j = i + 1; j < this.soldiers.Count; j++)
                {
                    if (this.soldiers[i].compareHP(this.soldiers[j]))
                    {
                        Soldier temp = this.soldiers[i];
                        this.soldiers[i] = this.soldiers[j];
                        this.soldiers[j] = temp;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder returnBuilder = new StringBuilder();
            for (int i = 0; i < this.soldiers.Count; i++)
            {
                returnBuilder.Append(this.soldiers[i].ToString()).Append("\n");
            }
            return returnBuilder.ToString();
        }
    }
}
