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

    public bool KontrolaIngredienci(Kebab objednavka)
    {
        Dictionary<string, int> ingredience = objednavka.getIngredience();
        if (_chleba - ingredience["chleba"] < 0) { return false; }
        else if (_tortila - ingredience["tortila"] < 0) { return false; }
        else if (_omackaCesnek - ingredience["omackaCesnek"] < 0){ return false; }
        else if (_omackaBylinka - ingredience["omackaBylinka"] < 0) { return false; }
        else if (_omackaChilli - ingredience["omackaChilli"] < 0) { return false; }
        else if (_mrkev - ingredience["mrkev"] < 0) { return false; }
        else if (_cibule - ingredience["cibule"] < 0) { return false; }
        else if (_zeli - ingredience["zeli"] < 0 ) { return false; }
        else if (_maso - ingredience["maso"] < 0 ) { return false; }
        
        return true;
    }
    
    public void OdebratZeSkladu(Kebab objednavka)
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

    public void DoplnitSklad()
    {
        _maso += 30;

        _chleba += 5;
        _tortila += 10;

        _omackaBylinka += 15;
        _omackaCesnek += 15;
        _omackaChilli += 15;

        _cibule += 20;
        _mrkev += 20;
        _zeli += 20;
    }
}