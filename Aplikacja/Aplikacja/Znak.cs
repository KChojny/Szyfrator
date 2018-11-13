using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Znak
    {

        private char _znak;
        private int _id;

        public char znak
        {
            get { return _znak; }
            set { _znak = value; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public char liczba_znak(int id)
        {
            switch (id)
            {
                case 0: znak = 'A'; return znak;
                case 1: znak = 'Ą'; return znak;
                case 2: znak = 'B'; return znak;
                case 3: znak = 'C'; return znak;
                case 4: znak = 'Ć'; return znak;
                case 5: znak = 'D'; return znak;
                case 6: znak = 'E'; return znak;
                case 7: znak = 'Ę'; return znak;
                case 8: znak = 'F'; return znak;
                case 9: znak = 'G'; return znak;
                case 10: znak = 'H'; return znak;
                case 11: znak = 'I'; return znak;
                case 12: znak = 'J'; return znak;
                case 13: znak = 'K'; return znak;
                case 14: znak = 'L'; return znak;
                case 15: znak = 'Ł'; return znak;
                case 16: znak = 'M'; return znak;
                case 17: znak = 'N'; return znak;
                case 18: znak = 'Ń'; return znak;
                case 19: znak = 'O'; return znak;
                case 20: znak = 'Ó'; return znak;
                case 21: znak = 'P'; return znak;
                case 22: znak = 'R'; return znak;
                case 23: znak = 'S'; return znak;
                case 24: znak = 'Ś'; return znak;
                case 25: znak = 'T'; return znak;
                case 26: znak = 'U'; return znak;
                case 27: znak = 'W'; return znak;
                case 28: znak = 'Y'; return znak;
                case 29: znak = 'Z'; return znak;
                case 30: znak = 'Ź'; return znak;
                case 31: znak = 'Ż'; return znak;
                case 32: znak = ' '; return znak;
                default: return 'X';
            }
        }

        public int znak_liczba(char znak)
        {
            switch (znak)
            {
                case 'A': id = 0; return id;
                case 'Ą': id = 1; return id;
                case 'B': id = 2; return id;
                case 'C': id = 3; return id;
                case 'Ć': id = 4; return id;
                case 'D': id = 5; return id;
                case 'E': id = 6; return id;
                case 'Ę': id = 7; return id;
                case 'F': id = 8; return id;
                case 'G': id = 9; return id;
                case 'H': id = 10; return id;
                case 'I': id = 11; return id;
                case 'J': id = 12; return id;
                case 'K': id = 13; return id;
                case 'L': id = 14; return id;
                case 'Ł': id = 15; return id;
                case 'M': id = 16; return id;
                case 'N': id = 17; return id;
                case 'Ń': id = 18; return id;
                case 'O': id = 19; return id;
                case 'Ó': id = 20; return id;
                case 'P': id = 21; return id;
                case 'R': id = 22; return id;
                case 'S': id = 23; return id;
                case 'Ś': id = 24; return id;
                case 'T': id = 25; return id;
                case 'U': id = 26; return id;
                case 'W': id = 27; return id;
                case 'Y': id = 28; return id;
                case 'Z': id = 29; return id;
                case 'Ź': id = 30; return id;
                case 'Ż': id = 31; return id;
                case ' ': id = 32; return id;
                default: return 0;
            }
        }

        public string tekst(string wyraz)
        {
            wyraz = wyraz + znak;
            return wyraz;

        }

        public Znak() { }

        public Znak(char znak, int id)
        {
            this.znak = znak;
            this.id = id;
        }

    }
}
