namespace SIR_Modell
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoIt();
        }

        const double N = 83000000;  // Bevölkerungszahl
        const double R0 = 2.4;      // Ausbreitungsrate
        const double T = 5.2;       // Regenerationszeit

        // Die beiden Faktoren für die Differenzialgleichungen
        double alpha = Math.Log(R0) / N / T;
        double beta = 1.0 / 21.0;   // kombinierte Gesundungs- / Todesrate

        void DoIt()
        {
            double Laufzeit = 300;      // Wir betrachten 300 Tage der Entwicklung
            double Unterteilung = 100;  // Wir lösen in 1/100 Tage auf.

            // Hier simulieren wir eine Letalitätsrate von 0,4%
            // Aus der Gruppe R entsteht durch Multiplikation mit lambda die Gruppe D
            // Entsprechend verbleiben 99,6% in der Gruppe R, das sind die Gesundeten,
            // wobei R für Recovered steht.
            double lambda = 0.4 / 100;   // 0,4%
            CellArray ca = new CellArray();

            // Startwerte
            double I = 1;
            double S = N - I;
            double R = 0;
            double D = 0;

            // Überschriften
            ca[0, 0] = "Tag";
            ca[0, 1] = "S";
            ca[0, 2] = "I";
            ca[0, 3] = "D";
            ca[0, 4] = "R";

            // Eintragen der Startwerte
            ca[1, 0] = 0;
            ca[1, 1] = S;
            ca[1, 2] = I;
            ca[1, 3] = D;
            ca[1, 4] = R;

            var delta_t = 1 / Unterteilung;
            var row = 2; // Die Zeilen 0 und 1 haben wir gerade beschrieben

            for (int i = 0; i < Laufzeit; i++)  // Schleife über die Laufzeit in Tagen
            {
                for (int j = 0; j < Unterteilung; j++)  // Schleife über 100 Teile á 1/100 Tag
                {
                    var dS = delta_t * (-alpha * S * I);

                    var dI = delta_t * (alpha * S * I - beta * I);

                    var dD = delta_t * lambda * beta * I;

                    var dR = delta_t * (1 - lambda) * beta * I;

                    S += dS;
                    I += dI;
                    R += dR;
                    D += dD;
                }

                ca[row, 0] = i + 1;
                ca[row, 1] = S;
                ca[row, 2] = I;
                ca[row, 3] = D;
                ca[row, 4] = R;
                row++;
            }

            File.Delete("SIR-Modell.csv");
            using (FileStream fs = File.OpenWrite("SIR-Modell.csv"))
            using (StreamWriter sw = new StreamWriter(fs))
                ca.ToStreamWriter(sw);
        }
    }
}