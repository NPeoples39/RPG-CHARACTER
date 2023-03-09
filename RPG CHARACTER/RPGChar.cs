using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_CHARACTER
{
    internal class RPGChar
    {
        // Fields
        private CharacterClasses _characterClass;
        private int _strength;
        private int _maxStrength = 20;
        private int _wisdom;
        private int _maxWisdom = 20;
        private int _charisma;
        private int _maxCharisma = 20;
        private int _intelligence;
        private int _maxIntelligence = 20;
        private int _luck;
        private int _maxLuck = 20;
        private string _name = "";
        private int _dexterity;
        private int _maxDexterity = 20;
        private Random _rng = new Random();

        // Properties
        #region Properties
        public CharacterClasses CharacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Level { get; set; }
        public int Strength { get { return _strength; } }
        public int Wisdom { get { return _wisdom; } }
        public int Charisma { get { return _charisma; } }
        public int Intelligence { get { return _intelligence; } }
        public int Luck { get { return _luck; } }
        public int Dexterity { get { return _dexterity; } }
        #endregion 

        public RPGChar()
        {
            Roll();
        }
        public void Roll()
        {
            _charisma = _rng.Next(1, _maxCharisma+ 1);
            _intelligence = _rng.Next(1, _maxIntelligence+ 1);
            _strength = _rng.Next(1, _maxStrength + 1);
            _wisdom = _rng.Next(1, _maxWisdom + 1);
            _luck = _rng.Next(1, _maxLuck + 1);
            _dexterity = _rng.Next(1, _maxDexterity + 1);
        }
    }
    public enum CharacterClasses
    {
        None = 0,
        Cleric,
        Rogue,
        Barbarian,
        Wizard
    }
}
