﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzF13_RendezesekWinForm
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        int[] buborek;
        int[] gyors;
        int[] lada;

        public Form1()
        {
            InitializeComponent();
        }

        // Feltölt Btn
        private void button1_Click(object sender, EventArgs e)
        {
            int elemszam = Convert.ToInt32(numericUpDown1.Value);
            int intervallum = Convert.ToInt32(Tartomany.Value);

            int min = int.MinValue;
            int max = int.MaxValue;
            if(intervallum != -1)
            {
                min = 0;
                max = intervallum;
            }

            buborek = new int[elemszam];
            gyors= new int[elemszam];
            lada = new int[elemszam];

            for (int i = 0; i < elemszam; i++)
                buborek[i] = gyors[i] = lada[i] = r.Next(min, max);
            
        }

        // GyorsRendezés
        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();

            sw.Start();
            Sort();
            sw.Stop();

            GyorsIdo.Text = sw.Elapsed.ToString();
        }

        private void Sort() { QuickSort(0, gyors.Length - 1); }

        private void QuickSort(int left, int right)
        {
            int pivot = gyors[left];
            int lhold = left;
            int rhold = right;

            while (left < right)
            {
                while (gyors[right] >= pivot && left < right) --right;

                if (left != right)
                {
                    gyors[left] = gyors[right];
                    ++left;
                }

                while (gyors[left] <= pivot && left < right) ++left;

                if (left != right)
                {
                    gyors[right] = gyors[left];
                    --right;
                }
            }
            gyors[left] = pivot;
            pivot = left;
            left = lhold;
            right = rhold;

            if (left < pivot)
            {
                QuickSort(left, pivot - 1);
            }
            if (right > pivot)
            {
                QuickSort(pivot + 1, right);
            }
        }

        // BuborékRendezés
        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();

            sw.Start();
            BuborekRendez();
            sw.Stop();

            BuborekIdo.Text = sw.Elapsed.ToString();
        }

        private void BuborekRendez()
        {
            for(int i=0; i<buborek.Length-1; i++)
            {
                for(int j=i+1; j<buborek.Length; j++)
                {
                    if(buborek[j] < buborek[i])
                    {
                        int tmp = buborek[i];
                        buborek[i] = buborek[j];
                        buborek[j] = tmp;
                    }
                }
            }
        }

        // LádaRenezés
        private void button4_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();

            sw.Start();
            LadaRendez();
            sw.Stop();

            LadaIdo.Text = sw.Elapsed.ToString();
        }

        private void LadaRendez()
        {
            int[] seged = new int[Convert.ToInt32(Tartomany.Value) + 1];

            for(int i=0; i<lada.Length; i++)
            {
                seged[lada[i]]++;
            }

            int k = 0;
            for(int i=0; i<seged.Length; i++)
            {
                for(int j = 0; j<seged[i]; j++)
                {
                    lada[k] = i;
                    k++;
                }
            }
        }
    }
}
