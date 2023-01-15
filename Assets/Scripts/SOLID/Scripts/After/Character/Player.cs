using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

namespace Course.SOLID.After
{
    public class Player : Character, IHeal, IDamage
    {
        public int health = 100;
        public Item currentItem;
        public UnityEvent<int> OnUpdateHealth;

        private IInteract otherCharacter;

        private void Start()
        {
            OnUpdateHealth.Invoke(health);
        }

        public void ActionInteraction() {
            if (otherCharacter != null)
            {
                otherCharacter.Interact();
            }
        }

        public void ActionConsumeItem() { 
            if (currentItem != null)
            {
                currentItem.ExecuteMessage();
            }

        }

        public void Damage(int value)
        {
            health = Mathf.Clamp(health - value, 0, 100);

            if (health <= 0) {
                Debug.Log("Player dead");
            }
            OnUpdateHealth.Invoke(health);
        }

        public void Heal(int value)
        {
            health = Mathf.Clamp(health + value, 0, 100);

            OnUpdateHealth.Invoke(health);
        }

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<IInteract>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }
    }
}
