using System.Text;

namespace MoneyToTurkishLira
{
    public static class Extension
    {
        static string[] birler = { "", "Bir ", "İki ", "Üç ", "Dört ", "Beş ", "Altı ", "Yedi ", "Sekiz ", "Dokuz " };
        static string[] onlar = { "", "On ", "Yirmi ", "Otuz ", "Kırk ", "Elli ", "Altmış ", "Yetmiş ", "Seksen ", "Doksan " };
        static string[] binler = { "Trilyon, ", "Milyar, ", "Milyon, ", "Bin, ", "TL ", "Kuruş" };

        public static string ToCurrencyText(this decimal tutar)
        {
            decimal kalan = tutar;
            decimal bolen = 1000000000000;
            int grup = 0;
            StringBuilder yazi = new StringBuilder();
            while (true)
            {
                int bolum = (int)(kalan / bolen);
                kalan = kalan % bolen;
                yazi.Append(BasamakCozumle(bolum, grup));
                if (kalan > 0)
                    grup++;

                bolen = bolen / 1000;
                if (kalan < 1 || kalan == 0)
                {
                    yazi.Append(BasamakCozumle((int)(kalan * 100), grup));
                    break;
                }
            }
            return yazi.ToString();
        }

        static string BasamakCozumle(int basamak, int grup)
        {
            if (basamak == 0)
                return string.Empty;

            int yuz = basamak / 100;
            int on = (basamak % 100) / 10;
            int bir = (basamak % 100 % 10);
            return $"{ (yuz > 1 ? birler[yuz] + " Yüz" : (yuz == 1 ? "Yüz" : ""))}  {onlar[on]} {birler[bir]} {binler[grup]}";
        }
    }
}
