namespace BlaisePascal.EnemyOrPlayer.Domain
{
    public class Player
    {
        private int _level;
        private int _experience;
        private int _health;
        public string Name { get; set; }
        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                {
                    _level = 1;
                }
                else
                {
                    _level = value;
                }
            }
        }
        public int Experience
        {
            get { return _experience; }
            private set
            {
                if (value < 0)
                {
                    _experience = 0;
                }
                else if (value > 100)
                {
                    _experience = 100;

                }
                {
                    _experience = value;
                }
            }
        }
        public int Health
        {
            get { return _health; }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int MaxHealth { get; private set; }
        public bool IsAlive { get; private set; }
        public int Gold { get; private set; }
        public Player(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }
        public void GainExperience(int amount)
        {
            if (amount > 0)
            {
                Experience += amount;
                if (Experience >= 100)
                {
                    Level += 1;
                    Experience = 0;
                }
            }
        }
        public void ResetExperience()
        {
            Experience = 0;
        }
        public void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                Health -= amount;
                if (Health <= 0)
                {
                    IsAlive = false;
                }
            }
        }
        public void Heal(int amount)
        {
            if (amount > 0 && amount <= MaxHealth - Health)
            {
                Health += amount;
            }

        }
        public void AddGold(int amount)
        {
            if (amount > 0)
            {
                Gold += amount;
            }
        }
        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }
    }


    }
