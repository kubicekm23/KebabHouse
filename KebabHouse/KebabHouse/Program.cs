using System.ComponentModel.Design;
using System.Diagnostics;
using KebabHouse.Classes;

namespace KebabHouse;

class Program
{
    static void Main(string[] args)
    {
        Kebab testKebab = new Kebab("chleba", "omackaCesnek", true);
        //testKebab.printKebabInfo();

        // Vytvoření všeho potřebného
        Kebab _order;
        bool objednavam = true;
        Sklad _sklad = new Sklad();
        
        // loop se šéf kuchařem
        while (objednavam)
        {
            Console.Write("Přáli by jste si objednat? ");
            string input = Console.ReadLine();

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
                default:
                    _order = Objednat();

                    _sklad.odebratZeSkladu(_order);
                    break;
            }
        }
    }

    static Kebab Objednat()
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
            default:
                masoOnly = false;
                break;
        }
        
        Kebab objednavka = new Kebab(typ, omacka, masoOnly);
        
        objednavka.printKebabInfo();
        
        return objednavka;
    }
}