﻿using BattleOfHeroes.Entities.Interfaces;

namespace BattleOfHeroes.Entities.Skills.Base
{
    public abstract class BaseSkill : ISkill
    {
        public string Name { get; }

        public IHero Hero { get; set; } = null!;

        protected BaseSkill(string name)
        {
            Name = name;
        }

        public abstract void Apply(IHero hero);
    }
}
