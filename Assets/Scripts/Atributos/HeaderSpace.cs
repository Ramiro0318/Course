using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Atributos
{
    public class HeaderSpace : MonoBehaviour
    {
        [Header("Stats")]
        public string displayname;
        [Space]
        public int mana;
        public int health;
        [Space(50)]
        public bool IsAlive;

        [Header("References")]
        public CapsuleCollider capsuleCollider;
    }
}
