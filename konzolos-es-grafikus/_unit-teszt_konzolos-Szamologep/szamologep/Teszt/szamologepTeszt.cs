using szamologep;
using NUnit.Framework;
using static szamologep.Program;
using System;

[TestFixture]

public class szamologepTeszt
{

    //Szamologep sz;
    /*
    [SetUp]

    public void Setup()
    {
        sz = new Szamologep();
    }*/


    [TestCase]
    public void osszeadasTeszt()
    {
        Szamologep szamolo = new Szamologep();

        int osszeg = szamolo.osszeadas(10, 10);

        Assert.AreEqual(10, osszeg);
    }

    [TestCase]
    public void kivonasTeszt()
    {
        Szamologep szamolo = new Szamologep();

        int osszeg = szamolo.kivonas(20, 10);

        Assert.AreEqual(10, osszeg);
    }

    [TestCase]
    public void szorzasTeszt()
    {
        Szamologep szamolo = new Szamologep();

        int osszeg = szamolo.szorzas(2, 2);

        Assert.AreEqual(4, osszeg);
    }

    [TestCase]
    public void osztasTeszt()
    {
        Szamologep szamolo = new Szamologep();

        int osszeg = szamolo.osztas(9, 3);

        Assert.AreEqual(3, osszeg);
    }



    /*
    [TestCase]
    public void TesztSikertelenUTalas()
    {
        //Bank b = new Bank();
        b.Ujszamla("Tesztnev", "1234");
        b.Ujszamla("Tesztnev2", "5678");
        var sikeres = b.Utal("1234", "5678", 10000);

        Assert.AreEqual(0, b.Egyenleg("1234"));
        Assert.AreEqual(0, b.Egyenleg("5678"));
        Assert.False(sikeres);
    }

    [TestCase]

    public void UtalasNemLEtezoSzamlara()
    {
        //3wBank b = new Bank();
        b.Ujszamla("Tesztnev", "1234");
        b.EgyenlegFeltolt("1234", 15000);
        b.Ujszamla("Tesztnev2", "5678");

        Assert.Throws<HibasSzamlaszamException> () =>
        {
            b.Utal("1234", "9999", 10000)
        }
        );
        Assert.AreEqual(15000, b.Egyenleg("1234"));
        Assert.AreEqual
    }*/

}