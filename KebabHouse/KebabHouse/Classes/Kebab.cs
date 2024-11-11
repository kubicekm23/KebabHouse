namespace KebabHouse.Classes;

public class Kebab
{
    private string _typ;  // chleba / tortila
    private string _omacka; // cesnek, bylinky, chilli
    private int _cena;  // odvodit od místního kebabu   (120kč basic tortilla, 110kč basic chleba +10, +20 za dodatky)

    private Dictionary<string, int> _ingredience;
    
    public Kebab(string typ, string omacka, bool masoOnly)
    {
        _typ = typ;
        _omacka = omacka;
        
        InitIngredience();
        
        switch (_typ)
        {
            case "chleba":
                _cena = 110;
                _ingredience["chleba"] = 1;
                break;
            case "tortila":
                _cena = 120;
                _ingredience["tortila"] = 1;
                break;
        }

        switch (_omacka)
        {
            case "omackaCesnek":
                _ingredience["omackaCesnek"] = 1;
                break;
            case "omackaBylynka":
                _ingredience["omackaBylynka"] = 1;
                break;
            case "omackaChilli":
                _ingredience["omackaChilli"] = 1;
                break;
        }

        if (masoOnly)
        {
            _ingredience["maso"] = 3;
            _cena += 20;
        }
        else
        {
            _ingredience["maso"] = 2;
            _ingredience["mrkev"] = 1;
            _ingredience["cibule"] = 1;
            _ingredience["zeli"] = 1;
        }
        
        
    }

    private void InitIngredience()
    {
        _ingredience = new Dictionary<string, int>();
        
        _ingredience.Add("chleba", 0);
        _ingredience.Add("tortila", 0);
        
        _ingredience.Add("omackaCesnek", 0);
        _ingredience.Add("omackaBylinka", 0);
        _ingredience.Add("omackaChilli", 0);
        
        _ingredience.Add("maso", 0);
        
        _ingredience.Add("mrkev", 0);
        _ingredience.Add("cibule", 0);
        _ingredience.Add("zeli", 0);
    }

    public void printKebabInfo()
    {
        Console.WriteLine($"Kebab typ: {_typ}");
        Console.WriteLine($"Kebab omacka: {_omacka}");
        Console.WriteLine($"Kebab cena: {_cena}");

        Console.WriteLine();
        
        Console.WriteLine($"Chleba: {_ingredience["chleba"]}");
        Console.WriteLine($"Tortila: {_ingredience["tortila"]}");
        Console.WriteLine($"Maso: {_ingredience["maso"]}");
        Console.WriteLine($"Česneková omáčka: {_ingredience["omackaCesnek"]}");
        Console.WriteLine($"Bylinková omáčka: {_ingredience["omackaBylinka"]}");
        Console.WriteLine($"Chilli omáčka: {_ingredience["omackaChilli"]}");
        
        Console.WriteLine($"Mrkev: {_ingredience["mrkev"]}");
        Console.WriteLine($"Cibule: {_ingredience["cibule"]}");
        Console.WriteLine($"Zeli: {_ingredience["zeli"]}");
    }
    
    public Dictionary<string, int> getIngredience() { return _ingredience; }

    public string getOmackaString()
    {
        switch (_omacka)
        {
            case "omackaCesnek":
                return "česnekovou";
            case "omackaBylinka":
                return "bylinkovou";
            case "omackaChilli":
                return "chilli";
        }

        return "žádnou omáčkou";
    }
    
    public int GetCena(){ return _cena; }
}