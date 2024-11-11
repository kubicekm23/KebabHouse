namespace KebabHouse.Classes;

public class Cheff
{
    public Cheff()
    {
               
    }

    public bool ChceSiObjednat()
    {
        Console.Write("Přáli by jste si objednat? ");
        string input = Console.ReadLine();

        bool objednavam = true;
        
        switch (input)
        {
            case "ne":
                objednavam = false;
                break;
            case "Ne":
                objednavam = false;
                break;
            case "Ne.":
                objednavam = false;
                break;
        }

        return objednavam;
    }

    public void PredaniKebabu(Kebab kebab)
    {
        Console.WriteLine($"Tady je váš kebab s {kebab.getOmackaString()} omáčkou. Dobrou chuť.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}