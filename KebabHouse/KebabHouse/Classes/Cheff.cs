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
        if (kebab.getIngredience()["maso"] == 3)
            Console.WriteLine($"Tady je váš kebab bez zeleniny a s {kebab.getOmackaString()} omáčkou. Dobrou chuť.");
        else    
            Console.WriteLine($"Tady je váš kebab s {kebab.getOmackaString()} omáčkou. Dobrou chuť.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public Kebab Objednat()
    {
        Console.WriteLine("Přáli by jste si ve chlebu nebo v tortile?");
        string typ = Console.ReadLine();
        Console.WriteLine("Jakou si přejete omáčku? Máme česnekovou, bylinkovou a chilli. ");
        string omacka = Console.ReadLine();

        switch (typ)
        {
            case "chléb":
                typ = "chleba";
                break;
            case "chleba":
                break;
            case "s chlebem":
                typ = "s chlebem";
                break;
            default:
                typ = "tortila";
                break;
        }
        
        switch (omacka)
        {
            case "česnekovou":
                omacka = "omackaCesnek";
                break;
            case "česnek":
                omacka = "omackaCesnek";
                break;
            case "cesnek":
                omacka = "omackaCesnek";
                break;
            case "cesnekovou":
                omacka = "omackaCesnek";
                break;
            
            case "bylinkovou":
                omacka = "omackaBylinka";
                break;
            case "Bylinkovou":
                omacka = "omackaBylinka";
                break;
            
            case "chilli":
                omacka = "omackaChilli";
                break;
            case "Chilli":
                omacka = "omackaChilli";
                break;
        }
        
        Console.WriteLine("Chcete se zeleninou nebo jenom s masem? ");
        string masoOption = Console.ReadLine();

        bool masoOnly;

        switch (masoOption)
        {
            case "maso":
                masoOnly = true;
                break;
            case "s masem":
                masoOnly = true;
                break;
            case "Maso":
                masoOnly = true;
                break;
            case "S masem":
                masoOnly = true;
                break;
            case "masem":
                masoOnly = true;
                break;
            case "Masem":
                masoOnly = true;
                break;
            default:
                masoOnly = false;
                break;
        }
        
        Kebab objednavka = new Kebab(typ, omacka, masoOnly);
        Console.WriteLine($"Poprosil bych o {objednavka.GetCena()} Kč.");
        Console.WriteLine("(Enter pro pokračování)");
        Console.ReadLine();
        //objednavka.printKebabInfo();
        
        return objednavka;
    }
}