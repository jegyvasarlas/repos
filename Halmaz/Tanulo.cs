using System;

namespace StackFeladat
{
    class Tanulo
    {
        string nev;
        string szuletesiHely;
        DateTime szuletesiDatum;
        long diakIgazolvanySzam;

        public Tanulo(string nev, string szuletesiHely, DateTime szuletesiDatum, long diakIgazolvanySzam)
        {
            this.nev = nev;
            this.szuletesiDatum = szuletesiDatum;
            this.szuletesiHely = szuletesiHely;
            this.diakIgazolvanySzam = diakIgazolvanySzam;
        }

        public override string ToString()
        {
            return "\n"+nev + "\nSzuletesi hely, ido: " + szuletesiHely + ", " + szuletesiDatum.Year + ". " + szuletesiDatum.Month + ". " + szuletesiDatum.Day + ".\nDiakigazolvany szama: " + diakIgazolvanySzam + "\n";
        }
    }
}
