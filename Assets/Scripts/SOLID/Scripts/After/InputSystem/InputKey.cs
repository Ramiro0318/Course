using Course.SOLID.After;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.After
{
    public class InputKey : InputHandler
    {
        public KeyCode KeyLeft  = KeyCode.LeftArrow;
        public KeyCode KeyRight = KeyCode.RightArrow;
        public override float GetAxisHorizontal()
        {
            if (Input.GetKey(KeyLeft)) 
            {
                return -1;
            }

            if (Input.GetKey(KeyRight))
            {
                return 1;
            }
            return 0; 
        }
    }
}
