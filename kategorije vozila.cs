using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Vozila> vozila = new List<Vozila>();
        private int motocikli;
        private int automobili;
        private int kamioni;
        

     

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Vozila vozilo = new Vozila(txtModel.Text, int.Parse(txtGodinaProizvodnje.Text), int.Parse(txtBrojKotaca.Text));
                vozila.Add(vozilo);
                UpdateCounts(vozilo.Kategorija);

                textBox4.AppendText($"Model: {vozilo.Model}, Godina proizvodnje: {vozilo.GodinaProizvodnje}, Broj kotača: {vozilo.BrojKotaca}, Kategorija: {vozilo.Kategorija}\r\n");

                txtModel.Clear();
                txtGodinaProizvodnje.Clear();
                txtBrojKotaca.Clear();
            }
        }

        private bool ValidateInput()
        {
            if (!int.TryParse(txtGodinaProizvodnje.Text, out _) || !int.TryParse(txtBrojKotaca.Text, out _))
            {
                MessageBox.Show("Unos teksta u polje za unos broja kotača i godine proizvodnje nije dozvoljen.");
                return false;
            }
            if (int.Parse(txtBrojKotaca.Text) % 2 != 0)
            {
                MessageBox.Show("Unos neparnog broja kotača nije dozvoljen.");
                return false;
            }
            return true;
        }

        private void UpdateCounts(string kategorija)
        {
            switch (kategorija)
            {
                case "Motocikl":
                    motocikli++;
                    break;
                case "Automobil":
                    automobili++;
                    break;
                case "Kamion":
                    kamioni++;
                    break;
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            if (vozila.Count > 0)
            {
                textBox4.Clear();
                foreach (Vozila vozilo in vozila)
                {
                    textBox4.AppendText($"Model: {vozilo.Model}, Godina proizvodnje: {vozilo.GodinaProizvodnje}, Broj kotača: {vozilo.BrojKotaca}, Kategorija: {vozilo.Kategorija}\r\n");
                }
                textBox4.AppendText($"Ukupno:\r\nMotocikli: {motocikli}\r\nAutomobili: {automobili}\r\nKamioni: {kamioni}\r\n");
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }


    
    }


