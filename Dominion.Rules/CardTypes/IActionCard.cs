﻿namespace Dominion.Rules.CardTypes
{
    public interface IActionCard : ICard
    {
        void Play(TurnContext context);
    }

    public interface IReactionCard : ICard
    {
        void React(AttackEffect attackEffect, Player player, IGameLog log);
    }

    public interface IAttackCard : ICard
    {
        
    }
}