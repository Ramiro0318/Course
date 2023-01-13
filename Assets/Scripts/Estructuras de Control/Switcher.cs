using UnityEngine;

namespace Course.EstructurasDeControl
{
    public enum EPlatform
    {
        None,
        PC,
        Xbox,
        Playstation,
        Switch, dsdasdadsa
    }

    public class Switcher : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public EPlatform currentPlatform;

        private void Start()
        {
            switch (currentPlatform)
            {
                case EPlatform.None:
                case EPlatform.PC:    
                case EPlatform.Xbox:
                case EPlatform.Playstation:
                case EPlatform.Switch:
                case EPlatform.dsdasdadsa:
                   
                default:
                    break;
            }
        }

    }
}
