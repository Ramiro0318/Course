using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.OrganizacionProyecto
{
    [CreateAssetMenu(fileName ="New Data", menuName = "ScriptableObjects/Data", order =2)]
    public class DataSO : ScriptableObject
    {

        [Header("Visual")]
        public string title;
        public Sprite sprite;

        [Header("Stats")]
        public float health = 100f;
        public int damage = 15;

        public string GetPrintStats() {
            return $" Stats; Health( {health}) Damage( {damage})";
        }
    }
}
