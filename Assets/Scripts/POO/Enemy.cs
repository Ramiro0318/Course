using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;

namespace Course.POO
{
    public abstract class Enemy : MonoBehaviour
    {
        [Header("Enemy")]
        [SerializeField] protected string title;
        [SerializeField] protected int damage;
        [SerializeField] protected float health;

        public string Title {
           // set { title = value; }
            get { return title; }
        }

        private void Start()
        {
            Attack();
        }

        public virtual void Attack() {
            
            Debug.Log($"Enemy '{title}' Attack. Damage: '{damage}'");
        }

        public abstract void Defense();

    }
}
