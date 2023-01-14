using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class Player : MonoBehaviour, ICharacter
    {
        public string playerName;
        public int health = 100;
        public float speedMovement = 15f;
        [Space]
        public Item currentItem;
        [Space]
        public TextMeshProUGUI healthTxt;

        private ICharacter otherCharacter;

        private void Start()
        {
            healthTxt.text = "Health: " + health.ToString();
        }

        private void Update()
        {
            //Movement
            float inputHorizontal = Input.GetAxis("Horizontal");

            Vector3 direction = new Vector3(inputHorizontal, 0, 0);

            transform.Translate(direction * speedMovement * Time.deltaTime);


            //Interaccion
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (otherCharacter != null)
                {
                    otherCharacter.Interact();
                }

            }


            //ConsumeItem
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (currentItem != null)
                {
                    if (currentItem is ItemWeapon)
                    {
                        Debug.Log($"{currentItem.itemName}: Shoot");
                    }

                    else if (currentItem is ItemPotion)
                    {
                        Debug.Log($"{currentItem.itemName}: Drink to get the power");
                    }
                }

            }
        }

        public void Damage(int value)
        {
            health = Mathf.Clamp(health - value, 0, 100);

            if (health <= 0) {
                Debug.Log("Player dead");
            }
            healthTxt.text = "Health: " + health.ToString();
        }

        public void Heal(int value)
        {
            health = Mathf.Clamp(health + value, 0, 100);

            healthTxt.text = "Health: " + health.ToString();
        }

        public void Interact() 
        { 
            //None
        }

        private void OnTriggerEnter(Collider other)
        {
            otherCharacter = other.GetComponent<ICharacter>();
        }

        private void OnTriggerExit(Collider other)
        {
            otherCharacter = null;
        }
    }
}
