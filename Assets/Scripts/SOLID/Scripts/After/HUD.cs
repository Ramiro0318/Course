using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Course.SOLID.After
{
    public class HUD : MonoBehaviour
    {    
        public TextMeshProUGUI healthTxt;

        public  void UpdateHealth(int value) 
        { 
            healthTxt.text = $"Health: {value}";
        }
    }
}
