namespace _7Vererbung
{
    public class Motor
    {
        public int Hubraum { get; private set; }
        public int Leistung { get; private set; }

        public Motor(int hubraum, int leistung)
        {
            Hubraum = hubraum;
            Leistung = leistung;
        }
    }
}