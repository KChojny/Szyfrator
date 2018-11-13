using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class Szyfr : Form
    {

        // Znaki
        Znak A = new Znak('A', 0);
        Znak Ą = new Znak('Ą', 1);
        Znak B = new Znak('B', 2);
        Znak C = new Znak('C', 3);
        Znak Ć = new Znak('Ć', 4);
        Znak D = new Znak('D', 5);
        Znak E = new Znak('E', 6);
        Znak Ę = new Znak('Ę', 7);
        Znak F = new Znak('F', 8);
        Znak G = new Znak('G', 9);
        Znak H = new Znak('H', 10);
        Znak I = new Znak('I', 11);
        Znak J = new Znak('J', 12);
        Znak K = new Znak('K', 13);
        Znak L = new Znak('L', 14);
        Znak Ł = new Znak('Ł', 15);
        Znak M = new Znak('M', 16);
        Znak N = new Znak('N', 17);
        Znak Ń = new Znak('Ń', 18);
        Znak O = new Znak('O', 19);
        Znak Ó = new Znak('Ó', 20);
        Znak P = new Znak('P', 21);
        Znak R = new Znak('R', 22);
        Znak S = new Znak('S', 23);
        Znak Ś = new Znak('Ś', 24);
        Znak T = new Znak('T', 25);
        Znak U = new Znak('U', 26);
        Znak W = new Znak('W', 27);
        Znak Y = new Znak('Y', 28);
        Znak Z = new Znak('Z', 29);
        Znak Ź = new Znak('Ź', 30);
        Znak Ż = new Znak('Ż', 31);
        Znak spacja = new Znak(' ', 32);

        // Macierz szyfru
        int[,] szyfr = {
             { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 },
             { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0 },
             { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1 },
             { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2 },
             { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3 },
             { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4 },
             { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5 },
             { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6 },
             { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7 },
             { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8 },
             { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
             { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
             { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
             { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
             { 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
             { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
             { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
             { 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
             { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
             { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 },
             { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 },
             { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
             { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 },
             { 23, 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 },
             { 24, 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 },
             { 25, 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 },
             { 26, 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 },
             { 27, 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 },
             { 28, 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 },
             { 29, 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 },
             { 30, 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 },
             { 31, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            };

        public Szyfr()
        {
            InitializeComponent();
        }

        //Szyfrowanie strona 1
        private void button1_Click(object sender, EventArgs e)
        {
            string TextBox1 = (textBox1.Text).ToUpper();
            string TextBox2 = (textBox2.Text).ToUpper();
            textBox3.Text = "";

            //Sprawdzanie długości
            if (TextBox1.Length == TextBox2.Length)
            {
                for (int i = 0; i < TextBox1.Length; i++)
                {
                    //Sprawdzanie znaków
                    bool spr1, spr2;
                    switch (TextBox1[i])
                    {
                        case 'V':
                        case 'Q':
                        case 'X':
                        case 'v':
                        case 'q':
                        case 'x':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                        case '!':
                        case '@':
                        case '#':
                        case '$':
                        case '%':
                        case '^':
                        case '&':
                        case '*':
                        case '(':
                        case ')':
                        case '`':
                        case '~':
                        case '-':
                        case '_':
                        case '=':
                        case '+':
                        case ',':
                        case '<':
                        case '.':
                        case '>':
                        case '/':
                        case '?':
                        case ';':
                        case ':':
                        case '[':
                        case ']':
                        case '{':
                        case '}':
                        case '|':
                        case '\'':
                        case '\\':
                        case '\"':
                            spr1 = false;
                            break;
                        default:
                            spr1 = true;
                            break;


                    }

                    switch (TextBox2[i])
                    {
                        case 'V':
                        case 'Q':
                        case 'X':
                        case 'v':
                        case 'q':
                        case 'x':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                        case '!':
                        case '@':
                        case '#':
                        case '$':
                        case '%':
                        case '^':
                        case '&':
                        case '*':
                        case '(':
                        case ')':
                        case '`':
                        case '~':
                        case '-':
                        case '_':
                        case '=':
                        case '+':
                        case ',':
                        case '<':
                        case '.':
                        case '>':
                        case '/':
                        case '?':
                        case ';':
                        case ':':
                        case '[':
                        case ']':
                        case '{':
                        case '}':
                        case '|':
                        case '\'':
                        case '\\':
                        case '\"':
                            spr2 = false;
                            break;
                        default:
                            spr2 = true;
                            break;

                    }

                    if ((spr1 == true) && (spr2 == true))
                    {
                        //Odstępy
                        if ((TextBox1[i] == ' ' && TextBox2[i] != ' ') || (TextBox2[i] == ' ' && TextBox1[i] != ' '))
                        {
                            textBox3.Text = "Odstępy nie w tych samycz miejscach";
                            break;
                        }

                        //Szyfrowanie
                        else
                        {
                            if (TextBox1[i] == ' ' && TextBox2[i] == ' ')
                            {
                                textBox3.Text = textBox3.Text + ' ';
                            }

                            else
                            {
                                char znak, znak1 = TextBox1[i], znak2 = TextBox2[i];
                                int id, id1, id2;
                                id1 = A.znak_liczba(znak1);
                                id2 = A.znak_liczba(znak2);
                                id = szyfr[id1, id2];
                                znak = A.liczba_znak(id);
                                textBox3.Text = textBox3.Text + znak;
                            }
                        }
                    }
                    else
                    {
                        if ((spr1 == false) && (spr2 == false))
                        {
                            textBox3.Text = "W tekscie i w kluczu są litery obce, eznaki lub cyfry";
                            break;
                        }
                        else
                        {
                            if (spr1 == false) {textBox3.Text = "W tekscie są litery obce, znaki lub cyfry"; break;}
                            if (spr2 == false) { textBox3.Text = "W kluczu są litery obce, znaki lub cyfry"; break; }
                        }
                    }
                }
            }
            else textBox3.Text = "Klucz i tekst nie mają takiej samej długości";
        }

        //Czyszczenie pól 1 strona
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //Ustawienie paska
        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, -vScrollBar1.Value);
        }

        //Właściwości paska
        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = 0;
            vScrollBar1.Maximum = 700;
            vScrollBar1.Minimum = 0;

        }

        //Punkt startowy paska
        private void Szyfr_Load(object sender, EventArgs e)
        {
            panel1.AutoScrollPosition = new Point(0, 0);
        }

        //Szyfrowanie strona 2
        private void button4_Click(object sender, EventArgs e)
        {

            string TextBox4 = (textBox4.Text).ToUpper();

            //Puste pola
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox52.Text = "";
            textBox54.Text = "";
            textBox56.Text = "";
            textBox58.Text = "";
            textBox60.Text = "";
            textBox61.Text = "";
            textBox62.Text = "";
            textBox63.Text = "";
            textBox64.Text = "";
            textBox65.Text = "";
            textBox66.Text = "";
            textBox67.Text = "";
            textBox68.Text = "";

            for (int i = 0; i < TextBox4.Length; i++)
            {
                //Sprawdzanie znaków
                bool spr;
                switch (TextBox4[i])
                {
                    case 'V':
                    case 'Q':
                    case 'X':
                    case 'v':
                    case 'q':
                    case 'x':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                    case '!':
                    case '@':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '*':
                    case '(':
                    case ')':
                    case '`':
                    case '~':
                    case '-':
                    case '_':
                    case '=':
                    case '+':
                    case ',':
                    case '<':
                    case '.':
                    case '>':
                    case '/':
                    case '?':
                    case ';':
                    case ':':
                    case '[':
                    case ']':
                    case '{':
                    case '}':
                    case '|':
                    case '\'':
                    case '\\':
                    case '\"':
                        spr = false;
                        break;
                    default:
                        spr = true;
                        break;
                }

                if (spr == true)
                {
                    if (TextBox4[i] != ' ')
                    {
                        //Przypisanie litery do kluczu
                        textBox6.Text = textBox6.Text + "A";
                        textBox8.Text = textBox8.Text + "Ą";
                        textBox10.Text = textBox10.Text + "B";
                        textBox12.Text = textBox12.Text + "C";
                        textBox14.Text = textBox14.Text + "Ć";
                        textBox16.Text = textBox16.Text + "D";
                        textBox18.Text = textBox18.Text + "E";
                        textBox20.Text = textBox20.Text + "Ę";
                        textBox22.Text = textBox22.Text + "F";
                        textBox24.Text = textBox24.Text + "G";
                        textBox26.Text = textBox26.Text + "H";
                        textBox28.Text = textBox28.Text + "I";
                        textBox30.Text = textBox30.Text + "J";
                        textBox32.Text = textBox32.Text + "K";
                        textBox34.Text = textBox34.Text + "L";
                        textBox36.Text = textBox36.Text + "Ł";
                        textBox38.Text = textBox38.Text + "M";
                        textBox40.Text = textBox40.Text + "N";
                        textBox42.Text = textBox42.Text + "Ń";
                        textBox44.Text = textBox44.Text + "O";
                        textBox46.Text = textBox46.Text + "Ó";
                        textBox48.Text = textBox48.Text + "P";
                        textBox50.Text = textBox50.Text + "R";
                        textBox52.Text = textBox52.Text + "S";
                        textBox54.Text = textBox54.Text + "Ś";
                        textBox56.Text = textBox56.Text + "T";
                        textBox58.Text = textBox58.Text + "U";
                        textBox60.Text = textBox60.Text + "W";
                        textBox62.Text = textBox62.Text + "Y";
                        textBox64.Text = textBox64.Text + "Z";
                        textBox66.Text = textBox66.Text + "Ź";
                        textBox68.Text = textBox68.Text + "Ż";

                        //Przypisanie litery do szyfru
                        char znak = TextBox4[i];

                        int znak_a = A.znak_liczba(znak);
                        int znak_ą = Ą.znak_liczba(znak);
                        int znak_b = B.znak_liczba(znak);
                        int znak_c = C.znak_liczba(znak);
                        int znak_ć = Ć.znak_liczba(znak);
                        int znak_d = D.znak_liczba(znak);
                        int znak_e = E.znak_liczba(znak);
                        int znak_ę = Ę.znak_liczba(znak);
                        int znak_f = F.znak_liczba(znak);
                        int znak_g = G.znak_liczba(znak);
                        int znak_h = H.znak_liczba(znak);
                        int znak_i = I.znak_liczba(znak);
                        int znak_j = J.znak_liczba(znak);
                        int znak_k = K.znak_liczba(znak);
                        int znak_l = L.znak_liczba(znak);
                        int znak_ł = Ł.znak_liczba(znak);
                        int znak_m = M.znak_liczba(znak);
                        int znak_n = N.znak_liczba(znak);
                        int znak_ń = Ń.znak_liczba(znak);
                        int znak_o = O.znak_liczba(znak);
                        int znak_ó = Ó.znak_liczba(znak);
                        int znak_p = P.znak_liczba(znak);
                        int znak_r = R.znak_liczba(znak);
                        int znak_s = S.znak_liczba(znak);
                        int znak_ś = Ś.znak_liczba(znak);
                        int znak_t = T.znak_liczba(znak);
                        int znak_u = U.znak_liczba(znak);
                        int znak_w = W.znak_liczba(znak);
                        int znak_y = Y.znak_liczba(znak);
                        int znak_z = Z.znak_liczba(znak);
                        int znak_ź = Ź.znak_liczba(znak);
                        int znak_ż = Ż.znak_liczba(znak);

                        int ID_A = szyfr[0, znak_a];
                        int ID_Ą = szyfr[1, znak_ą];
                        int ID_B = szyfr[2, znak_b];
                        int ID_C = szyfr[3, znak_c];
                        int ID_Ć = szyfr[4, znak_ć];
                        int ID_D = szyfr[5, znak_d];
                        int ID_E = szyfr[6, znak_e];
                        int ID_Ę = szyfr[7, znak_ę];
                        int ID_F = szyfr[8, znak_f];
                        int ID_G = szyfr[9, znak_g];
                        int ID_H = szyfr[10, znak_h];
                        int ID_I = szyfr[11, znak_i];
                        int ID_J = szyfr[12, znak_j];
                        int ID_K = szyfr[13, znak_k];
                        int ID_L = szyfr[14, znak_l];
                        int ID_Ł = szyfr[15, znak_ł];
                        int ID_M = szyfr[16, znak_m];
                        int ID_N = szyfr[17, znak_n];
                        int ID_Ń = szyfr[18, znak_ń];
                        int ID_O = szyfr[19, znak_o];
                        int ID_Ó = szyfr[20, znak_ó];
                        int ID_P = szyfr[21, znak_p];
                        int ID_R = szyfr[22, znak_r];
                        int ID_S = szyfr[23, znak_s];
                        int ID_Ś = szyfr[24, znak_ś];
                        int ID_T = szyfr[25, znak_t];
                        int ID_U = szyfr[26, znak_u];
                        int ID_W = szyfr[27, znak_w];
                        int ID_Y = szyfr[28, znak_y];
                        int ID_Z = szyfr[29, znak_z];
                        int ID_Ź = szyfr[30, znak_ź];
                        int ID_Ż = szyfr[31, znak_ż];

                        char ZNAK_A = A.liczba_znak(ID_A);
                        char ZNAK_Ą = Ą.liczba_znak(ID_Ą);
                        char ZNAK_B = B.liczba_znak(ID_B);
                        char ZNAK_C = C.liczba_znak(ID_C);
                        char ZNAK_Ć = Ć.liczba_znak(ID_Ć);
                        char ZNAK_D = D.liczba_znak(ID_D);
                        char ZNAK_E = E.liczba_znak(ID_E);
                        char ZNAK_Ę = Ę.liczba_znak(ID_Ę);
                        char ZNAK_F = F.liczba_znak(ID_F);
                        char ZNAK_G = G.liczba_znak(ID_G);
                        char ZNAK_H = H.liczba_znak(ID_H);
                        char ZNAK_I = I.liczba_znak(ID_I);
                        char ZNAK_J = J.liczba_znak(ID_J);
                        char ZNAK_K = K.liczba_znak(ID_K);
                        char ZNAK_L = L.liczba_znak(ID_L);
                        char ZNAK_Ł = Ł.liczba_znak(ID_Ł);
                        char ZNAK_M = M.liczba_znak(ID_M);
                        char ZNAK_N = N.liczba_znak(ID_N);
                        char ZNAK_Ń = Ń.liczba_znak(ID_Ń);
                        char ZNAK_O = O.liczba_znak(ID_O);
                        char ZNAK_Ó = Ó.liczba_znak(ID_Ó);
                        char ZNAK_P = P.liczba_znak(ID_P);
                        char ZNAK_R = R.liczba_znak(ID_R);
                        char ZNAK_S = S.liczba_znak(ID_S);
                        char ZNAK_Ś = Ś.liczba_znak(ID_Ś);
                        char ZNAK_T = T.liczba_znak(ID_T);
                        char ZNAK_U = U.liczba_znak(ID_U);
                        char ZNAK_W = W.liczba_znak(ID_W);
                        char ZNAK_Y = Y.liczba_znak(ID_Y);
                        char ZNAK_Z = Z.liczba_znak(ID_Z);
                        char ZNAK_Ź = Ź.liczba_znak(ID_Ź);
                        char ZNAK_Ż = Ż.liczba_znak(ID_Ż);

                        textBox5.Text = textBox5.Text + ZNAK_A;
                        textBox7.Text = textBox7.Text + ZNAK_Ą;
                        textBox9.Text = textBox9.Text + ZNAK_B;
                        textBox11.Text = textBox11.Text + ZNAK_C;
                        textBox13.Text = textBox13.Text + ZNAK_Ć;
                        textBox15.Text = textBox15.Text + ZNAK_D;
                        textBox17.Text = textBox17.Text + ZNAK_E;
                        textBox19.Text = textBox19.Text + ZNAK_Ę;
                        textBox21.Text = textBox21.Text + ZNAK_F;
                        textBox23.Text = textBox23.Text + ZNAK_G;
                        textBox25.Text = textBox25.Text + ZNAK_H;
                        textBox27.Text = textBox27.Text + ZNAK_I;
                        textBox29.Text = textBox29.Text + ZNAK_J;
                        textBox31.Text = textBox31.Text + ZNAK_K;
                        textBox33.Text = textBox33.Text + ZNAK_L;
                        textBox35.Text = textBox35.Text + ZNAK_Ł;
                        textBox37.Text = textBox37.Text + ZNAK_M;
                        textBox39.Text = textBox39.Text + ZNAK_N;
                        textBox41.Text = textBox41.Text + ZNAK_Ń;
                        textBox43.Text = textBox43.Text + ZNAK_O;
                        textBox45.Text = textBox45.Text + ZNAK_Ó;
                        textBox47.Text = textBox47.Text + ZNAK_P;
                        textBox49.Text = textBox49.Text + ZNAK_R;
                        textBox51.Text = textBox51.Text + ZNAK_S;
                        textBox53.Text = textBox53.Text + ZNAK_Ś;
                        textBox55.Text = textBox55.Text + ZNAK_T;
                        textBox57.Text = textBox57.Text + ZNAK_U;
                        textBox59.Text = textBox59.Text + ZNAK_W;
                        textBox61.Text = textBox61.Text + ZNAK_Y;
                        textBox63.Text = textBox63.Text + ZNAK_Z;
                        textBox65.Text = textBox65.Text + ZNAK_Ź;
                        textBox67.Text = textBox67.Text + ZNAK_Ż;
                    }

                    else
                    {
                        //Danie odstępu
                        textBox5.Text = textBox5.Text + " ";
                        textBox6.Text = textBox6.Text + " ";
                        textBox7.Text = textBox7.Text + " ";
                        textBox8.Text = textBox8.Text + " ";
                        textBox9.Text = textBox9.Text + " ";
                        textBox10.Text = textBox10.Text + " ";
                        textBox11.Text = textBox11.Text + " ";
                        textBox12.Text = textBox12.Text + " ";
                        textBox13.Text = textBox13.Text + " ";
                        textBox14.Text = textBox14.Text + " ";
                        textBox15.Text = textBox15.Text + " ";
                        textBox16.Text = textBox16.Text + " ";
                        textBox17.Text = textBox17.Text + " ";
                        textBox18.Text = textBox18.Text + " ";
                        textBox19.Text = textBox19.Text + " ";
                        textBox20.Text = textBox20.Text + " ";
                        textBox21.Text = textBox21.Text + " ";
                        textBox22.Text = textBox22.Text + " ";
                        textBox23.Text = textBox23.Text + " ";
                        textBox24.Text = textBox24.Text + " ";
                        textBox25.Text = textBox25.Text + " ";
                        textBox26.Text = textBox26.Text + " ";
                        textBox27.Text = textBox27.Text + " ";
                        textBox28.Text = textBox28.Text + " ";
                        textBox29.Text = textBox29.Text + " ";
                        textBox30.Text = textBox30.Text + " ";
                        textBox31.Text = textBox31.Text + " ";
                        textBox32.Text = textBox32.Text + " ";
                        textBox33.Text = textBox33.Text + " ";
                        textBox34.Text = textBox34.Text + " ";
                        textBox35.Text = textBox35.Text + " ";
                        textBox36.Text = textBox36.Text + " ";
                        textBox37.Text = textBox37.Text + " ";
                        textBox38.Text = textBox38.Text + " ";
                        textBox39.Text = textBox39.Text + " ";
                        textBox40.Text = textBox40.Text + " ";
                        textBox41.Text = textBox41.Text + " ";
                        textBox42.Text = textBox42.Text + " ";
                        textBox43.Text = textBox43.Text + " ";
                        textBox44.Text = textBox44.Text + " ";
                        textBox45.Text = textBox45.Text + " ";
                        textBox46.Text = textBox46.Text + " ";
                        textBox47.Text = textBox47.Text + " ";
                        textBox48.Text = textBox48.Text + " ";
                        textBox49.Text = textBox49.Text + " ";
                        textBox50.Text = textBox50.Text + " ";
                        textBox51.Text = textBox51.Text + " ";
                        textBox52.Text = textBox52.Text + " ";
                        textBox53.Text = textBox53.Text + " ";
                        textBox54.Text = textBox54.Text + " ";
                        textBox55.Text = textBox55.Text + " ";
                        textBox56.Text = textBox56.Text + " ";
                        textBox57.Text = textBox57.Text + " ";
                        textBox58.Text = textBox58.Text + " ";
                        textBox59.Text = textBox59.Text + " ";
                        textBox60.Text = textBox60.Text + " ";
                        textBox61.Text = textBox61.Text + " ";
                        textBox62.Text = textBox62.Text + " ";
                        textBox63.Text = textBox63.Text + " ";
                        textBox64.Text = textBox64.Text + " ";
                        textBox65.Text = textBox65.Text + " ";
                        textBox66.Text = textBox66.Text + " ";
                        textBox67.Text = textBox67.Text + " ";
                        textBox68.Text = textBox68.Text + " ";
                    }
                }
                else textBox4.Text = "Są litery obce, znaki lub cyfry w polu";
            }
        }

        //Czyszczenie pól 2 storna
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = ""; textBox6.Text = ""; textBox5.Text = ""; textBox8.Text = ""; textBox7.Text = ""; textBox10.Text = "";
            textBox9.Text = ""; textBox12.Text = ""; textBox11.Text = ""; textBox14.Text = ""; textBox13.Text = "";
            textBox16.Text = ""; textBox15.Text = ""; textBox18.Text = ""; textBox17.Text = ""; textBox20.Text = "";
            textBox19.Text = ""; textBox22.Text = ""; textBox21.Text = ""; textBox24.Text = ""; textBox23.Text = "";
            textBox26.Text = ""; textBox25.Text = ""; textBox28.Text = ""; textBox27.Text = ""; textBox30.Text = "";
            textBox29.Text = ""; textBox32.Text = ""; textBox31.Text = ""; textBox34.Text = ""; textBox33.Text = "";
            textBox36.Text = ""; textBox35.Text = ""; textBox38.Text = ""; textBox37.Text = ""; textBox40.Text = "";
            textBox39.Text = ""; textBox42.Text = ""; textBox41.Text = ""; textBox44.Text = ""; textBox43.Text = "";
            textBox46.Text = ""; textBox45.Text = ""; textBox48.Text = ""; textBox47.Text = ""; textBox50.Text = "";
            textBox49.Text = ""; textBox52.Text = ""; textBox51.Text = ""; textBox54.Text = ""; textBox53.Text = "";
            textBox56.Text = ""; textBox55.Text = ""; textBox58.Text = ""; textBox57.Text = ""; textBox60.Text = "";
            textBox59.Text = ""; textBox62.Text = ""; textBox61.Text = ""; textBox64.Text = ""; textBox63.Text = "";
            textBox66.Text = ""; textBox65.Text = ""; textBox68.Text = ""; textBox67.Text = "";
        }

        //Rozszyfrowanie
        private void button5_Click(object sender, EventArgs e)
        {
            string TextBox1 = (textBox69.Text).ToUpper();
            string TextBox2 = (textBox70.Text).ToUpper();
            textBox71.Text = "";


            //Sprawdzanie długości
            if (TextBox1.Length == TextBox2.Length)
            {
                for (int i = 0; i < TextBox1.Length; i++)
                {
                    //Sprawdzanie znaków
                    bool spr1, spr2;
                    switch (TextBox1[i])
                    {
                        case 'V':
                        case 'Q':
                        case 'X':
                        case 'v':
                        case 'q':
                        case 'x':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                        case '!':
                        case '@':
                        case '#':
                        case '$':
                        case '%':
                        case '^':
                        case '&':
                        case '*':
                        case '(':
                        case ')':
                        case '`':
                        case '~':
                        case '-':
                        case '_':
                        case '=':
                        case '+':
                        case ',':
                        case '<':
                        case '.':
                        case '>':
                        case '/':
                        case '?':
                        case ';':
                        case ':':
                        case '[':
                        case ']':
                        case '{':
                        case '}':
                        case '|':
                        case '\'':
                        case '\\':
                        case '\"':
                            spr1 = false;
                            break;
                        default:
                            spr1 = true;
                            break;


                    }

                    switch (TextBox2[i])
                    {
                        case 'V':
                        case 'Q':
                        case 'X':
                        case 'v':
                        case 'q':
                        case 'x':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                        case '!':
                        case '@':
                        case '#':
                        case '$':
                        case '%':
                        case '^':
                        case '&':
                        case '*':
                        case '(':
                        case ')':
                        case '`':
                        case '~':
                        case '-':
                        case '_':
                        case '=':
                        case '+':
                        case ',':
                        case '<':
                        case '.':
                        case '>':
                        case '/':
                        case '?':
                        case ';':
                        case ':':
                        case '[':
                        case ']':
                        case '{':
                        case '}':
                        case '|':
                        case '\'':
                        case '\\':
                        case '\"':
                            spr2 = false;
                            break;
                        default:
                            spr2 = true;
                            break;

                    }

                    if ((spr1 == true) && (spr2 == true))
                    {
                        //Odstępy
                        if ((TextBox1[i] == ' ' && TextBox2[i] != ' ') || (TextBox2[i] == ' ' && TextBox1[i] != ' '))
                        {
                            textBox71.Text = "Odstępy nie w tych samycz miejscach";
                            break;
                        }

                        //Rozszyfrowanie
                        else
                        {
                            if (TextBox1[i] == ' ' && TextBox2[i] == ' ')
                            {
                                textBox71.Text = textBox71.Text + ' ';
                            }

                            else
                            {
                                int klucz = A.znak_liczba(TextBox2[i]);
                                int tekst_sz = A.znak_liczba(TextBox1[i]);

                                for (int j = 0; j < 32; j++)
                                {
                                    int spr = szyfr[klucz,j];
                                    if(tekst_sz == spr)
                                    {
                                        char z = A.liczba_znak(j);
                                        textBox71.Text = textBox71.Text + z;
                                        break;
                                    }
                                }
                                
                            }
                        }
                    }
                    else
                    {
                        if ((spr1 == false) && (spr2 == false))
                        {
                            textBox71.Text = "W szyfrze i w kluczu są litery obce, znaki lub cyfry";
                            break;
                        }
                        else
                        {
                            if (spr1 == false) { textBox71.Text = "W szyfrze są litery obce, znaki lub cyfry"; break; }
                            if (spr2 == false) { textBox71.Text = "W kluczu są litery obce, znaki lub cyfry"; break; }
                        }
                    }
                }
            }
            else textBox71.Text = "Klucz i szyfr nie mają takiej samej długości";
        }

        //Czyszczenie pól 3 strona
        private void button6_Click(object sender, EventArgs e)
        {
            textBox69.Text = "";
            textBox71.Text = "";
            textBox70.Text = "";
        }

        //Pętla do góry Tekst 1 storna
        private void button7_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox1.Text).ToUpper();
            string Tekst_gora = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba++;
                if (liczba == 32) liczba = 0;
                char znak = A.liczba_znak(liczba);
                Tekst_gora = Tekst_gora + znak;
            }
            textBox1.Text = Tekst_gora;
            
        }

        //Pętla do dołu Tekst 1 storna
        private void button8_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox1.Text).ToUpper();
            string Tekst_dol = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba--;
                if (liczba == -1) liczba = 31;
                char znak = A.liczba_znak(liczba);
                Tekst_dol = Tekst_dol + znak;
            }
            textBox1.Text = Tekst_dol;
        }

        //Pętla do góry Klucz 1 storna
        private void button9_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox2.Text).ToUpper();
            string Tekst_gora = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba++;
                if (liczba == 32) liczba = 0;
                char znak = A.liczba_znak(liczba);
                Tekst_gora = Tekst_gora + znak;
            }
            textBox2.Text = Tekst_gora;
        }

        //Pętla do dołu Klucz 1 storna
        private void button10_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox2.Text).ToUpper();
            string Tekst_dol = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba--;
                if (liczba == -1) liczba = 31;
                char znak = A.liczba_znak(liczba);
                Tekst_dol = Tekst_dol + znak;
            }
            textBox2.Text = Tekst_dol;
        }

        //Pętla do góry Szyfr 3 storna
        private void button11_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox69.Text).ToUpper();
            string Tekst_gora = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba++;
                if (liczba == 32) liczba = 0;
                char znak = A.liczba_znak(liczba);
                Tekst_gora = Tekst_gora + znak;
            }
            textBox69.Text = Tekst_gora;
        }

        //Pętla do dolu Szyfr 3 storna
        private void button12_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox69.Text).ToUpper();
            string Tekst_dol = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba--;
                if (liczba == -1) liczba = 31;
                char znak = A.liczba_znak(liczba);
                Tekst_dol = Tekst_dol + znak;
            }
            textBox69.Text = Tekst_dol;
        }

        //Pętla do góry Klucz 3 storna
        private void button13_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox70.Text).ToUpper();
            string Tekst_gora = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba++;
                if (liczba == 32) liczba = 0;
                char znak = A.liczba_znak(liczba);
                Tekst_gora = Tekst_gora + znak;
            }
            textBox70.Text = Tekst_gora;
        }

        //Pętla do dolu Klucz 3 storna
        private void button14_Click(object sender, EventArgs e)
        {
            string Tekst = (textBox70.Text).ToUpper();
            string Tekst_dol = "";
            for (int i = 0; i < Tekst.Length; i++)
            {
                int liczba = A.znak_liczba(Tekst[i]);
                liczba--;
                if (liczba == -1) liczba = 31;
                char znak = A.liczba_znak(liczba);
                Tekst_dol = Tekst_dol + znak;
            }
            textBox70.Text = Tekst_dol;
        }
        
    }
}
