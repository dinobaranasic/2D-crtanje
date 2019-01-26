namespace MEV_Paint_Vjezba.GrafickiOblici
{
    class Krug : Elipsa
    {
        public override void Nacrtaj()
        {
            base.Nacrtaj();
            if (oblik.Width < oblik.Height) oblik.Width = oblik.Height;
            else oblik.Height = oblik.Width;
        }
    }
}
