using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.OrganizacionProyecto
{
    public class Documentación : MonoBehaviour
    {
        private void Start()
        { int myValue;
            myValue = GetID("Mariano");
        } 
        /// <summary>
        /// Descripcion corta
        /// <remarks> Descripcion detallada de la funcion </remarks>
        /// </summary>
        /// <param name="CharacterName"></param> Descripcion de la variable
        /// <returns></returns> Descripcion del tipo de valor que devuelve
        

        private int GetID(string CharacterName) {

            return 1; 
        }

    }
}
