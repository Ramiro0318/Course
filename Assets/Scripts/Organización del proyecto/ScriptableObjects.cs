using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.OrganizacionProyecto
{
    public class ScriptableObjects : MonoBehaviour
    {
        public DataSO data;

        private void Start()
        {
            data.GetPrintStats();
        }
    }
}
