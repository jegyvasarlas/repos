using System;

namespace String_Cucc
{
    class MyString
    {
        char[] chars;
        int lenght;

        public MyString(char[] chars)
        {
            this.chars = chars;
        }

        public MyString(string[] sor)
        {
            this.lenght = sor.Length;
        }

        public MyString(MyString other) // masolo konstruktor
        {
            this.chars = other.chars;
            this.lenght = other.lenght;
        }
    }
}
