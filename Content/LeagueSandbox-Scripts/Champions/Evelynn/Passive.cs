using LeagueSandbox.GameServer.API;
using GameServerCore.Domain.GameObjects;
using GameServerCore.Domain;
using LeagueSandbox.GameServer.Scripting.CSharp;
using System;

namespace Spells
{
    public class EvelynnPassive : IGameScript
    {
        public void OnActivate(IChampion owner)
        {
            ApiEventManager.Subscribe(this);
        }

        [Listener]
        public void SelfWasDamaged(OnUnitDamageTaken evt)
        {
            Console.WriteLine( $"took {evt.Damage} dmg as {evt.Unit.Model}" );
        }

        public void OnDeactivate(IChampion owner)
        {
            //Listeners are automatically removed when GameScripts deactivate
        }

        public void OnStartCasting(IChampion owner, ISpell spell, IAttackableUnit target)
        {
        }

        public void OnFinishCasting(IChampion owner, ISpell spell, IAttackableUnit target)
        {
        }

        public void ApplyEffects(IChampion owner, IAttackableUnit target, ISpell spell, IProjectile projectile)
        {
        }

        public void OnUpdate(double diff)
        {
        }
    }
}

