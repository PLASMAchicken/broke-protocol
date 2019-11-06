﻿using BrokeProtocol.Entities;
using BrokeProtocol.ExportScripts.Required;
using UnityEngine;

namespace BrokeProtocol.GameSource.Types
{
    public class SvDestroyable : SvEntity
    {
        [Target(typeof(API.Events.Destroyable), (int)API.Events.Destroyable.OnDamage)]
        protected void OnDamage(ShDestroyable destroyable, DamageIndex damageIndex, float amount, ShPlayer attacker, Collider collider)
        {
            if (destroyable.IsDead())
            {
                return;
            }

            destroyable.health -= amount;

            if (destroyable.health <= 0f)
            {
                destroyable.ShDie();
            }
        }

        [Target(typeof(API.Events.Destroyable), (int)API.Events.Destroyable.OnDeath)]
        protected void OnDeath(ShDestroyable destroyable)
        {
        }
    }
}
