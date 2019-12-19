using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "Inventary/ Item", order = 1)]

public class Invetary01 : ScriptableObject
{



    [System.Serializable]
    public struct item
    {

        public string nombre;
        public Sprite sprite;
        public string caracteristicas;
        public Uso uso;
        public string funcion;
    }

    public enum Uso
    {
        consumible,
        llave
    }
    public item[] db;
        }
        
        
