using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_PokeRace.PokeRaceClasses;
using WFA_PokeRace.PokeRaceEnums;

namespace WFA_PokeRace
{
    public partial class frmChooseRacer : Form
    {
        public frmChooseRacer()
        {
            InitializeComponent();
        }
        public Pokemon SelectedRacer; 
        private void frmChooseRacer_Load(object sender, EventArgs e)
        {
            cmbOwner.DataSource = Enum.GetValues(typeof(PokeOwnerTypes));
            cmbPoke.DataSource = Enum.GetValues(typeof(PokemonTypes));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PokeOwner owner = new PokeOwner((PokeOwnerTypes)cmbOwner.SelectedItem);
            SelectedRacer = new Pokemon((PokemonTypes)cmbPoke.SelectedItem, owner);


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
