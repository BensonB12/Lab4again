using NUnit.Framework;
using lib;

namespace lib.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestCharacter()
    {
        var characterOne = new Character();
        Assert.AreEqual("unknown", characterOne.CharacterName);
    }

    [Test]
    public void TestPalidin()
    {
        var characterOne = new Paladin(1, "Benson", "elf");
        Assert.AreEqual("Benson", characterOne.CharacterName);
        Assert.AreEqual(1, characterOne.CharacterLevel);
    }

    [Test]
    public void TestBarbian()
    {
        var characterOne = new Barbian(1, "Benson", "half-ling");
        Assert.AreEqual(1, characterOne.CharacterLevel);
        Assert.AreEqual("Rage", characterOne.SpecialMagicMove());
    }

    [Test]
    public void TestWarlock()
    {
        var characterOne = new Warlock(3, "Benson", "half-ling");
        Assert.AreEqual("half-ling", characterOne.CharacterRace);
        Assert.AreEqual("Making a potion of hurting", characterOne.SpecialMagicMove());
    }

    [Test]
    public void TestDarkMagic()
    {
        var characterOne = new DarkMagic(7, "Benson", "half-ling");
        Assert.AreEqual(7, characterOne.CharacterLevel);
        Assert.AreEqual("Eldritch blast", characterOne.SpecialMagicMove());
    }

    [Test]
    public void TestingGenie()
    {
        var characterOne = new Genie(7, "Benson", "half-ling");
        Assert.AreEqual("Warlock", characterOne.CharacterClass);
        Assert.AreEqual("Grant an opponents wish with a twist of your own", characterOne.SpecialMagicMove());
    }
}