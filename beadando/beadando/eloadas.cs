using System;

namespace beadando
{
    public class Eloadas
    {
        bool[,] foglalasok = new bool[0, 0];

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            this.foglalasok = foglalasok;
            if (sorokSzama < 1 || helyekSzama < 1)
            {
                throw new ArgumentException("A szamoknak pozitivnak kell lenniuk");
            }
            else
            {
                for (int i = 0; i < sorokSzama; i++)
                {
                    for (int j = 0; j < helyekSzama; j++)
                    {
                        foglalasok[i, j] = false;
                    }
                }
            }
        }

            public bool Lefoglal()
            {

                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        if (foglalasok[i, j] == false)
                        {
                            foglalasok[i, j] = true;
                        return true;
                        }
                    }
                }
                return false;
            }

        public int SzabadHelyek()
        {
            int szabadHelyekSzama = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        szabadHelyekSzama++;
                    }
                }
            }
            return szabadHelyekSzama;
        }

        public bool teli()
        {
            if (SzabadHelyek() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Foglalt(int sorszam, int helyszam)
        {
            if (sorszam < 1 || helyszam < 1)
            {
                throw new ArgumentException("a szamoknak pozitivnak kell nelliuk");
            }
            else if (foglalasok[sorszam, helyszam] == true)
            {
                return false;
            }
            return true;
        }


    }
    }
}

