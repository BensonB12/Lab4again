using System;
using System.Collections.Generic;

namespace lib
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Character
    {
        static private int numberOfCharters = 0;
        public string CharacterName = "unknown";
        public int CharacterLevel;
        public string CharacterRace = "unknown";
        public string CharacterClass = "unknown";
        public Character()
        {
            numberOfCharters++;
        }
        public virtual void LevelUp(int addedLevel)
        {

        }
        public virtual string SpecialMagicMove()
        {
            return "Not";
        }
    }

    public class Paladin : Character
    {
        public override string SpecialMagicMove()
        {
            return "The holy sword";
        }

        public Paladin(int InCLevel, string InCName, string InCRace)
        {
            CharacterLevel = InCLevel;
            CharacterName = InCName;
            CharacterRace = InCRace;
            CharacterClass = "Paladin";
        }

        public override void LevelUp(int addedLevel)
        {
            CharacterLevel += addedLevel;
        }
    }
    public class Warlock : Character
    {
        public override string SpecialMagicMove()
        {
            return "Making a potion of hurting";
        }
        public Warlock(int InCLevel, string InCName, string InCRace)
        {
            CharacterLevel = InCLevel;
            CharacterName = InCName;
            CharacterRace = InCRace;
            CharacterClass = "Warlock";
        }


        public override void LevelUp(int addedLevel)
        {
            CharacterLevel += addedLevel;
        }
    }

    public class Barbian : Character
    {
        public Barbian(int InCLevel, string InCName, string InCRace)
        {
            CharacterLevel = InCLevel;
            CharacterName = InCName;
            CharacterRace = InCRace;
            CharacterClass = "Barbian";
        }

        public override string SpecialMagicMove()
        {
            return "Rage";
        }


        public override void LevelUp(int addedLevel)
        {
            CharacterLevel += addedLevel;
        }
    }

    public class DarkMagic : Warlock
    {
        public DarkMagic(int InCLevel, string InCName, string InCRace) : base(InCLevel, InCName, InCRace)
        {
        }
        public override string SpecialMagicMove()
        {
            return "Eldritch blast";

        }
    }

    public class Genie : Warlock
    {
        public Genie(int InCLevel, string InCName, string InCRace) : base(InCLevel, InCName, InCRace)
        {
        }
        public override string SpecialMagicMove()
        {
            return "Grant an opponents wish with a twist of your own";
        }
    }
}