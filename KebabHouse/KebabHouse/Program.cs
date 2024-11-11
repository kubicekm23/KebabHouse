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
        Kebab order;
        bool objednavam = true;
        Sklad sklad = new Sklad();
        sklad.DoplnitSklad();
        Cheff cheff = new Cheff();

        int pocetObjednavek = 0;
        
        // loop se šéf kuchařem
        while (objednavam)
        {
            pocetObjednavek++;
            if (pocetObjednavek == 10)
            { sklad.DoplnitSklad(); pocetObjednavek = 0; }
            
            objednavam = cheff.ChceSiObjednat();
            if (objednavam)
            {
                order = cheff.Objednat();
                if (sklad.KontrolaIngredienci(order))
                {
                    sklad.OdebratZeSkladu(order);
                    cheff.PredaniKebabu(order);
                }
                else
                {
                    Console.WriteLine("Omlouvám se, ale došli nám ingredience, zkuste přijít později.");
                }
            }
        }
    }


}