using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Course.EstructurasDeControl
{

    public struct PlayerData {
        public int score;
        public bool isAlive;
    }


    public class JumpStatements : MonoBehaviour
    {
        
        public PlayerData[] playerData;


        private void ChechMaxScore()
        {
            for (int i = 0; i < playerData.Length; i++)
            {
                if (playerData[i].score >= 10) { 
                //Winer
                break;
                }
            }

        }

        private void CheckPlayerScore() {
            for (int i = 0; i < playerData.Length; i++) {

                if (!playerData[i].isAlive) {
                    continue;
                }
                // Other logic
            }
        }

        private void CheckPlayerScore(int index) {

            if (!playerData[index].isAlive) { 
            
                return; //EarlyExit
            }
            //Other logic
        }
        
    }

}
