namespace KebabHouse.Classes;

public class Sklad
{
    private int _chleba;
    private int _tortila;
    private int _omackaCesnek;
    private int _omackaBylinka;
    private int _omackaChilli;
    private int _maso;
    private int _mrkev;
    private int _cibule;
    private int _zeli;
    public Sklad()
    {
        _chleba = 0;
        _tortila = 0;
        
        _omackaCesnek = 0;
        _omackaBylinka = 0;
        _omackaChilli = 0;
        
        _mrkev = 0;
        _cibule = 0;
        _zeli = 0;

        _maso = 0;

    }

    public bool kontrolaIngredienci(Kebab objednavka)
    {
        // TODO: dodělat kontrolu ingrediencí
        return true;
    }
    
    public void odebratZeSkladu(Kebab objednavka)
    {
        Dictionary<string, int> ingredience = objednavka.getIngredience();
        _chleba -= ingredience["chleba"];
        _tortila -= ingredience["tortila"];
        _omackaBylinka -= ingredience["omackaBylinka"];
        _omackaChilli -= ingredience["omackaChilli"];
        _omackaCesnek -= ingredience["omackaCesnek"];
        _maso -= ingredience["maso"];
        _zeli -= ingredience["zeli"];
        _cibule -= ingredience["cibule"];
        _mrkev -= ingredience["mrkev"];
    }
}