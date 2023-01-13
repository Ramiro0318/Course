using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace Course
{
    public class Example : MonoBehaviour
    {
        
        public string myString;

        private void Start()
        {
            myString = "Mariano";
            myString = "Mariano" + " " + "Sosa";

            int age = 27;
            myString = "Mariano`s Birthday: " + age.ToString();

            myString = string.Format("{0}`s Birthday :  {1}, Mariano, age");
            myString = $"Mariano`s Birthday: {age}";

            myString = "27_Mariano_Rifle";
            string[] characterInfo = myString.Split('_');
            
        }

    }
}
