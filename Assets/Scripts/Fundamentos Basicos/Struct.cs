using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Struct : MonoBehaviour
    {
        public string playerName;
        public byte playerHealth;
        public bool playerIsDead;

        [System.Serializable]

        public struct PlayerData {

        public string name;
        public byte health;
        public bool isDead;

        }

        public PlayerData playerData;

        private void Start()
        {
            playerData.name = "Mariano";
            playerData.health = 25;
            playerData.isDead = false;
        }
    }
}
