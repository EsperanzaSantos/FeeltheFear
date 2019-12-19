using UnityEngine;
using System.Collections;

public class EnPatrullando : MonoBehaviour {

    //Puntos de patrulla
    public GameObject p3;
    public GameObject p4;
    public int destActual;
    public UnityEngine.AI.NavMeshAgent miAgente;
    public float margen = 1;

    // Use this for initialization
    void Start () {
        {
            miAgente = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

    }

    // Update is called once per frame
    void Update() {
        //Detectar la distancia del destino
        Vector3 dist = this.transform.position - miAgente.destination;
        if ( dist.magnitude <= margen )
        {
            //LLegamos a nuestro destino
            if (destActual == 1)
            {
                //Actualizar nuestro destino 
                destActual = 2;
            }
            else
            {
                destActual = 1;
            }
        }
      
        if (destActual == 1)
        {  //Mandar al punto 1
            miAgente.SetDestination(p3.transform.position);

        }
        else
        {   //Mandar al punto 2
            miAgente.SetDestination(p4.transform.position);
        }
	}
}
