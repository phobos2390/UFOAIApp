using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFOAIApp
{
    public class Soldier
    {
        private string name;

        private int strength;
        private int speed;
        private int accuracy;
        private int mind;

        private int closeCombat;
        private int heavyWeapons;
        private int assaultWeapons;
        private int sniperRifles;
        private int highExplosives;

        private int hp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }

        public int Mind
        {
            get { return mind; }
            set { mind = value; }
        }

        public int CloseCombat
        {
            get { return closeCombat; }
            set { closeCombat = value; }
        }

        public int HeavyWeapons
        {
            get { return heavyWeapons; }
            set { heavyWeapons = value; }
        }

        public int AssaultWeapons
        {
            get { return assaultWeapons; }
            set { assaultWeapons = value; }
        }

        public int SniperRifles
        {
            get { return sniperRifles; }
            set { sniperRifles = value; }
        }

        public int HighExplosives
        {
            get { return highExplosives; }
            set { highExplosives = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public bool compareCloseCombat(Soldier other)
        {
            return this.CloseCombat < other.CloseCombat;
        }

        public bool compareHeavyWeapons(Soldier other)
        {
            return this.HeavyWeapons < other.HeavyWeapons;
        }

        public bool compareAssaultWeapons(Soldier other)
        {
            return this.AssaultWeapons < other.AssaultWeapons;
        }

        public bool compareSniperRifles(Soldier other)
        {
            return this.SniperRifles < other.SniperRifles;
        }

        public bool compareHighExplosives(Soldier other)
        {
            return this.HighExplosives < other.HighExplosives;
        }

        public bool compareHP(Soldier other)
        {
            return this.Hp < other.Hp;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Name).Append(": ");
            builder.Append(Strength).Append(" ");
            builder.Append(Speed).Append(" ");
            builder.Append(Accuracy).Append(" ");
            builder.Append(Mind).Append(" | ");
            builder.Append(CloseCombat).Append(" ");
            builder.Append(HeavyWeapons).Append(" ");
            builder.Append(AssaultWeapons).Append(" ");
            builder.Append(SniperRifles).Append(" ");
            builder.Append(HighExplosives).Append(" | ");
            builder.Append(Hp);
            return builder.ToString();
        }
    }
}
