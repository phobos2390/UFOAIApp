using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFOAIApp
{
    public partial class SoldierDataEntry : Form
    {
        private SoldierContainer container;
        private SoldierContainerBuilder builder;

        public SoldierDataEntry()
            :this(new SoldierContainer())
        {
        }

        private SoldierDataEntry(SoldierContainer container)
        {
            InitializeComponent();
            this.container = container;
            this.builder = new SoldierContainerBuilder();
            
            this.strengthEntry.Maximum = Decimal.MaxValue;
            this.speedEntry.Maximum = Decimal.MaxValue;
            this.accuracyEntry.Maximum = Decimal.MaxValue;
            this.mindEntry.Maximum = Decimal.MaxValue;

            this.closeCombatEntry.Maximum = Decimal.MaxValue;
            this.heavyWeaponsEntry.Maximum = Decimal.MaxValue;
            this.assaultWeaponsEntry.Maximum = Decimal.MaxValue;
            this.sniperRiflesEntry.Maximum = Decimal.MaxValue;
            this.highExplosivesEntry.Maximum = Decimal.MaxValue;

            this.hpEntry.Maximum = Decimal.MaxValue;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Soldier newSoldierToAdd = new Soldier();
            newSoldierToAdd.Name = this.nameTextBox.Text;
            newSoldierToAdd.Strength = (int) this.strengthEntry.Value;
            newSoldierToAdd.Speed = (int)this.speedEntry.Value;
            newSoldierToAdd.Accuracy = (int)this.accuracyEntry.Value;
            newSoldierToAdd.Mind = (int)this.mindEntry.Value;
            newSoldierToAdd.CloseCombat = (int)this.closeCombatEntry.Value;
            newSoldierToAdd.HeavyWeapons = (int)this.heavyWeaponsEntry.Value;
            newSoldierToAdd.AssaultWeapons = (int)this.assaultWeaponsEntry.Value;
            newSoldierToAdd.SniperRifles = (int)this.sniperRiflesEntry.Value;
            newSoldierToAdd.HighExplosives = (int)this.highExplosivesEntry.Value;
            newSoldierToAdd.Hp = (int)this.hpEntry.Value;
            this.container.AddSoldier(newSoldierToAdd);
            this.listOfSoldiers.Text = this.container.ToString();
        }

        private void ListOfSoldiers_TextChanged(object sender, EventArgs e)
        {
            this.container = this.builder.ParseInput(this.listOfSoldiers.Text);
        }

        private void SortStats_Click(object sender, EventArgs e)
        {
            SortedSoldierTeamDataForm form = new SortedSoldierTeamDataForm(this.container);
            form.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.container = this.builder.ParseInput(this.listOfSoldiers.Text);
        }
    }
}
