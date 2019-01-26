using System;

namespace MEV_Paint_Vjezba.GrafickiOblici
{
    class KreatorOblika
    {
        public static GrafickiOblik KreirajOblik(VrstaOblika vrsta)
        {
            if (vrsta == VrstaOblika.Linija) return new Linija();
            else if (vrsta == VrstaOblika.Pravokutnik) return new Pravokutnik();
            else if (vrsta == VrstaOblika.Elipsa) return new Elipsa();
            else if (vrsta == VrstaOblika.Krug) return new Krug();
            else //throw new Exception("Ne postoji trazeni oblik");
            throw new ArgumentException("Ne postoji trazeni oblik: {0}", vrsta.ToString());
        }
    }
}
