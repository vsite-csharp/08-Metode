﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.Metode
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private const int BrojPonavljanja = 10;
        private const int Interval = 1000;

        // 130 Pogledati što se izvršava na pritisak prve tipke. Pokrenuti program i provjeriti njegov odziv.
        private void buttonSinkroni_Click(object sender, EventArgs e)
        {
            NekaDugotrajnaOperacija();
        }

        private void NekaDugotrajnaOperacija()
        {
            // simulacija neke spore operacije koja povremeno ispisuje vrijeme
            for (int i = 1; i < BrojPonavljanja; ++i)
            {
                textBoxSinkronoVrijeme.Text = DateTime.Now.ToLongTimeString();
                // 131 Otkomentirati donju naredbu i ponovno pokrenuti program.
                 textBoxSinkronoVrijeme.Update();
                Thread.Sleep(Interval);
            }
        }
        // 132 Pogledati što se izvršava na pritisak druge tipke. Pokrenuti program i provjeriti njegov odziv.
        private async void buttonAsinkroni_Click(object sender, EventArgs e)
        {
            await NekaDrugaDugotrajnaOperacija();
        }

        async Task NekaDrugaDugotrajnaOperacija()
        {
            // simulacija neke spore operacije koja povremeno ispisuje vrijeme
            for (int i = 1; i < BrojPonavljanja; ++i)
            {
                textBoxAsinkronoVrijeme.Text = DateTime.Now.ToLongTimeString();
                await Task.Delay(Interval);
            }
        }

        // 133 Pogledati što se izvršava na pritisak treće tipke. Pokrenuti program i provjeriti njegov odziv.
        private async void buttonAsinkroni2_ClickAsync(object sender, EventArgs e)
        {
            textBoxAsinkroni2.Text = "Čekam da završi...";

            Task<string> rezultat = NekaTrećaOperacijaKojaVRaćaRezultat();

            // 134 Otkomentirati donju naredbu, pokrenuti program te pritisnuti treću tipku.
            await NekaDrugaDugotrajnaOperacija();

            // 135 Staviti točke prekida (breakpoints) na zadnje četiri naredbe u ovoj metodi (uključujući i praznu naredbu) i naredbu iza TODO:135a.
            // 136 Pokrenuti program i pogledati redoslijed izvođenja naredbi.

            textBoxAsinkroni2.Text = await rezultat;

            ;
        }

        async Task<string> NekaTrećaOperacijaKojaVRaćaRezultat()
        {
            // simulacija neke spore operacije koja ažurira traku napretka (progress bar)
            progressBar.Maximum = BrojPonavljanja;
            for (int i = 1; i < BrojPonavljanja; ++i)
            {
                // TODO:135a Staviti točku prekida na donju naredbu.
                progressBar.Value = i;
                await Task.Delay(Interval);
            }
            progressBar.Value = 0;

            return "Gotovo";
        }
    }
}
