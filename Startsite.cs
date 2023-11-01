namespace Bankaccount;

public class Startsite
{
    private double guthaben = 100.00;
    private double schulden = 78.21;
    private double spenden;

    public double GetGuthaben()
    {
        return Math.Round(guthaben,2);
    }

    public double GetSchulden()
    {
        return Math.Round(schulden,2);
    }

    public double GetSpenden()
    {
        return Math.Round(spenden, 2);
    }

    public void WahlAussuchen(string wahl)
    {
        switch (wahl)
        {
            case "1": 
                GuthabenAfterSpenden(Convert.ToDouble(Console.ReadLine()));
                break;
            case "2": 
                SchuldenZahlen();
                break;
            case "3": 
                Console.Clear();
                Console.WriteLine("Have a good day");
                Exit();
                break;
        }
    }

    private double GuthabenAfterSpenden(double value)
    {
        {
            if (guthaben >= value)
            {
                guthaben -= value;
                spenden += value;
            }
            
            return Math.Round(guthaben,2);
        }
    }
    private void SchuldenZahlen()
    {
        if (schulden != 0.00)
        {
            if (guthaben > schulden || guthaben == schulden)
            {
                guthaben -= schulden;
                schulden = 0.00;
            }
            else
            {
                schulden -= guthaben;
                guthaben = 0.00;
            }
        }
        
    }

    private void Exit()
    {
        System.Environment.Exit(1);
    }
}

