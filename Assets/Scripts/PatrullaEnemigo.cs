using UnityEngine;
using System.Collections;

public class PatrullaEnemigo : MonoBehaviour {
    // Puntos de patrulla
    public GameObject p1;
    public GameObject p2;
   
    public int destActual;
    public UnityEngine.AI.NavMeshAgent miAgente;
    public float margen = 1;
    //Referencia del jugador
    public GameObject Jugador;
    public float rango = 4;

    // Use this for initialization
    void Start()
    {
        miAgente = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        //Detectar al Player
        DetectarAlPlayer();

        Patrulla();




    }
    void DetectarAlPlayer()
    {
        //Detectar el player
        Vector3 distPlayer = Jugador.transform.position - transform.position; // Vector de jugador a la IA

        if (distPlayer.magnitude < rango)
        {                                     //Comparar tamaño del vector con rango de deteccion
                                              // mirar la linea de vision, lanzando un rayo desde el enemigo al jugador
            RaycastHit resultadoRay;
            if (Physics.Raycast(this.transform.position, distPlayer, out resultadoRay, 20)) // Aqui ya lanzamos el rayo
            {
                //Rayo colisiona con algo 
                if (resultadoRay.transform.tag == "Player") // Tenemos linea de vision y puedo seguir al jugador
                {
                    miAgente.SetDestination(Jugador.transform.position);
                }
            }

        }
    }

    void Patrulla()
    {
        // Detectar la distancia que falta al destino 
        // Distancia al destino
        //Patrulla
        Vector3 dist = this.transform.position - miAgente.destination;
        if (dist.magnitude < margen)
        {
            //Llegamos al destino
            if (destActual == 1)
            {
                //Actualizar el destino
                destActual = 2;
                //Mandar al punto 2
                miAgente.SetDestination(p2.transform.position);

            }
            else
            {
                destActual = 1;
                //Mandar al punto 1
                miAgente.SetDestination(p1.transform.position);
            }
        }
    }
}
