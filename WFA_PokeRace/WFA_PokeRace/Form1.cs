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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PokeRace MyRace;
        private void Form1_Load(object sender, EventArgs e)
        {
            MyRace = new PokeRace();
            cmbArena.DataSource = Enum.GetValues(typeof(PokeArenaTypes));
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(MyRace.IsStarted && !MyRace.IsFinished)
            {
                MyRace.MovePokemons();
                pctPoke1.Left = MyRace.SortedRacers[MyRace.Racers[0]] - pctPoke1.Width;
                pctPoke2.Left = MyRace.SortedRacers[MyRace.Racers[1]] - pctPoke2.Width;
                pctPoke3.Left = MyRace.SortedRacers[MyRace.Racers[2]] - pctPoke3.Width;
                pctPoke4.Left = MyRace.SortedRacers[MyRace.Racers[3]] - pctPoke4.Width;
            }
            if(MyRace.IsFinished)
            {
                timer1.Stop();
                MessageBox.Show(String.Format("{0} has won the race..", MyRace.SortedRacers.ElementAt(0).Key.Name));
            }
        }

        private void pct_Click(object sender, EventArgs e)
        {
            PictureBox clickedPct = (PictureBox)sender;
            frmChooseRacer racer = new frmChooseRacer();
            if (racer.ShowDialog() == DialogResult.OK)
            {
                clickedPct.Tag = racer.SelectedRacer;
                clickedPct.Image = racer.SelectedRacer.Picture;
            }
        }

        private void cmbArena_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyRace.RaceArena = new PokeArena((PokeArenaTypes)cmbArena.SelectedItem);
            pctArena.Image = MyRace.RaceArena.ArenaImage;
            pctFloor.BackColor = MyRace.RaceArena.FloorColor;
            foreach(Control item in this.Controls)
            {
                if(item is PictureBox && item.Tag != null)
                {
                    item.BackColor = MyRace.RaceArena.FloorColor;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                MyRace.Racers.Clear();
                foreach (Control item in this.Controls)
                {
                    if(item is PictureBox && item.Tag!=null && item.Tag is Pokemon)
                    {
                        MyRace.Racers.Add((Pokemon)item.Tag);
                    }
                }
                MyRace.Start(pctPoke1.Right,pctFinishLine.Left);
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
