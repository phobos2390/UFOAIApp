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
    public partial class SortedSoldierTeamDataForm : Form
    {
        private SoldierContainer container;

        public SortedSoldierTeamDataForm(SoldierContainer container)
        {
            InitializeComponent();
            this.container = container;
        }

        private void SortedSoldierTeamDataForm_Load(object sender, EventArgs e)
        {
            this.container.SortCloseCombat();
            this.closeCombatText.Text = this.container.ToString();
            this.container.SortHeavyWeapons();
            this.heavyWeaponsText.Text = this.container.ToString();
            this.container.SortAssaultWeapons();
            this.assaultWeaponsText.Text = this.container.ToString();
            this.container.SortSniperRifles();
            this.sniperRiflesText.Text = this.container.ToString();
            this.container.SortHighExplosives();
            this.highExplosivesText.Text = this.container.ToString();
            this.container.SortHP();
            this.healthText.Text = this.container.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
