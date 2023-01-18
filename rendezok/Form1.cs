using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rendezok
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        private int[] buborek;
        private int[] gyors;
        public Form1()
        {
            InitializeComponent();
        }

        //Feltoltes
        private void button1_Click(object sender, EventArgs e)
        {
            int elemeszam = Convert.ToInt32(numericUpDown1.Text);
            buborek = new int[elemeszam];
            gyors = new int[elemeszam];
            for (int i = 0; i < elemeszam; i++)
            {
                buborek[i] = gyors[i] = r.Next(int.MinValue, int.MinValue);
            }
            MessageBox.Show("Feltoltve");
        }
        
        //GyorsRendezes
        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start(); 
            Sort();
            sw.Stop();
            label1.Text = sw.Elapsed.ToString();
        }
        
        public void Sort() {   QuickSort(0, gyors.Length - 1); }

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
        
        //BuborekRendezes

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start(); 
            BuborekRendez();
            sw.Stop();
            label2.Text = sw.Elapsed.ToString();
        }
        
        private void BuborekRendez()
        {
            for (int i = 0; i < buborek.Length-1; i++)
            {
                for (int j=i+1; j < buborek.Length; j++)
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
    }
}