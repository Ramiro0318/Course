using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.POO
{
    public class EnemyOrc : Enemy
    {
        public override void Attack()
        {
            damage = 99;

            base.Attack();

            Debug.Log("Im an Orc");
        }

        public override void Defense()
        {
            Debug.Log($"Enemy '{title}' Attack. Damage: '{health}'");
        }
    }
}
