using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class TriggerVsCollision : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision Enter");
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            Debug.Log("Collision Stay");
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            Debug.Log("Collision Exit");
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Trigger Enter");
        }

        private void OnTriggerStay2D(Collider2D other )
        {
            Debug.Log("Trigger Stay");
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            Debug.Log("Trigger Exit");
        }
    }
}
