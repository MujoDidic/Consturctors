using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erzeuge eine neue LibelleEltern-Instanz mit den Initialwerten
            // laenge=10, gewicht=3, fluegelLaenge=5, kinderzahl=2, stress=2
            LibelleEltern libelleEltern = new LibelleEltern(10, 3, 5, 2, 2);

            // Rufe die Methoden der Instanz auf
            libelleEltern.Essen();
            libelleEltern.StressErhoehen(1);
            libelleEltern.KindHinzufuegen();

            // Gib die Werte von Gewicht, Größe, Kinderzahl und Stress aus
            Console.WriteLine("Gewicht: {0} Gramm", libelleEltern.Gewicht);
            Console.WriteLine("Größe: {0} cm", libelleEltern.Laenge);
            Console.WriteLine("Kinderzahl: {0}", libelleEltern.Kinderzahl);
            Console.WriteLine("Stress: {0}", libelleEltern.Stress);
        }
    }

    class Insekt
    {
        protected int laenge;
        protected int gewicht;

        public Insekt(int laenge, int gewicht)
        {
            this.laenge = laenge;
            this.gewicht = gewicht;
        }

        public virtual void Essen()
        {
            laenge++;
            gewicht++;
        }

        public virtual void Ausgabe()
        {
            Console.WriteLine("Das Insekt ist {0} cm lang und wiegt {1} Gramm.", laenge, gewicht);
        }
    }

    class Libelle : Insekt
    {
        protected int fluegelLaenge;

        public Libelle(int laenge, int gewicht, int fluegelLaenge) : base(laenge, gewicht)
        {
            this.fluegelLaenge = fluegelLaenge;
        }

        public override void Essen()
        {
            base.Essen();
            fluegelLaenge++;
        }

        public override void Ausgabe()
        {
            base.Ausgabe();
            Console.WriteLine("Die Flügellänge beträgt {0} cm.", fluegelLaenge);
        }
    }

    class LibelleEltern : Libelle
    {
        protected int kinderzahl;
        protected int stress;

        public int Gewicht { get; set; }
        public int Laenge { get; set; }

        public LibelleEltern(int laenge, int gewicht, int fluegelLaenge, int kinderzahl, int stress) : base(laenge, gewicht, fluegelLaenge)
        {
            this.kinderzahl = kinderzahl;
            this.stress = stress;
        }

        public void KindHinzufuegen()
        {
            kinderzahl++;
            stress += kinderzahl;
        }

        public void StressErhoehen(int kindNummer)
        {
            stress += kindNummer;
        }

        public int Kinderzahl
        {
            get { return kinderzahl; }
            set { kinderzahl = value; }
        }

        public int Stress
        {
            get { return stress; }
            set { stress = value; }
        }
    }
}

