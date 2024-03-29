﻿using Captystacy.BattleOfHeroes.Entities.Interfaces;

namespace Captystacy.BattleOfHeroes.Entities.Skills.Base
{
    public abstract class TemporarySkill : BaseSkill
    {
        protected int StrokeCount;

        protected TemporarySkill(string name, int strokeCount) : base(name)
        {
            StrokeCount = strokeCount;
        }

        public override void Apply(IHero hero)
        {
            hero.AddTemporarySkill(this, StrokeCount);
        }
    }
}
