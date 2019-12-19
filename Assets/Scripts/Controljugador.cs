using UnityEngine;
using System.Collections;

public class Controljugador : MonoBehaviour
{


    //Referencia  del componente que controla la animacion

    public Animator miAniPlayer;
    public float Andando;
    public float Rotar;
    public GameObject Player;
    public int vida = 5;
    public int Maxvida = 5;

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        // Control del player animado
        if (Input.GetKey(KeyCode.W))
        {
            miAniPlayer.SetBool("Andando", true);
            transform.Translate(0, 0, Andando * Time.deltaTime);

        }
        else
        {
            miAniPlayer.SetBool("Andando", false);
        }

        if (Input.GetKey(KeyCode.S))
        {

            miAniPlayer.SetBool("Andando", true);
            transform.Translate(0, 0, -Andando * Time.deltaTime);



        }
        else
        {
            miAniPlayer.SetBool("Andando", false);
        }


        {
            if (Input.GetKey(KeyCode.D))
            {
                //Aumentar el eje Y 
                this.transform.Rotate(0, Rotar, 0);
            }
            //Desplazamiento en el eje Y
            if (Input.GetKey(KeyCode.A))
            {
                //Disminuir el eje Y
                this.transform.Rotate(0, -Rotar, 0);

            }
        }
        //Hacer daño al zombie
        if (Input.GetKey(KeyCode.Mouse0))
        {
            miAniPlayer.SetTrigger("Golpear");
        }

    }
}
   

