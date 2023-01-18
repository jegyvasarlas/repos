using System;

namespace gyorsrendezes
{
    class MyArray {
        private int[] array;
        public MyArray(int length) {  array = new int[length]; }
        public int this[int idx] {
            get { return array[idx]; }
            set { array[idx] = value; } }
        public int Length {  get { return array.Length; }  }
        public void Sort() {   QuickSort(0, array.Length - 1); }
        private void QuickSort(int left, int right) { 
            int pivot = array[left]; 
            int lhold = left; 
            int rhold = right;

            while (left < right) {
                while (array[right] >= pivot && left < right) 	--right;
 
                if (left != right) {
                    array[left] = array[right];
                    ++left;}
	
                while (array[left] <= pivot && left < right)	++left;
	
                if (left != right) {
                    array[right] = array[left];
                    --right; }
            }
            array[left] = pivot;
            pivot = left;
            left = lhold;
            right = rhold;

            if (left < pivot) {
                QuickSort(left, pivot - 1);}
            if (right > pivot) {
                QuickSort(pivot + 1, right); }
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            MyArray a = new MyArray(100000000);
            Random r = new Random();
            for (int i = 0; i < a.Length; ++i) {
                a[i] = r.Next(Int32.MinValue, Int32.MaxValue); }
            Console.WriteLine("Rendezés...");
            DateTime start = DateTime.Now;
            a.Sort();
            DateTime end = DateTime.Now;
            Console.WriteLine("Time: {0}", end - start);
        }
    }
}