using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SistemadeVida : MonoBehaviour {
    public Image BarradeVida;
    public int maxVida = 5;
    public int vida = 5;

   
  void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            vida = vida - 1; // restar vida
        
            if (vida<= 0)
            {
              
                Debug.Log("Estas Muerto");
            }
        } 

        if (other.gameObject.tag == "Vida")
        {
            vida = vida + 1; // Sumamos la vida
            Destroy(other.gameObject); //Destruir el otro objeto que resulta ser un botiquin
       
        }
       


        ActualizarBarra();
    }

    void ActualizarBarra()
    {
        // Regla de tres 
        float vidaParaImagen = (float)vida / maxVida;
        Debug.Log(vidaParaImagen);
        //Resultado de la imagen
        BarradeVida.fillAmount = vidaParaImagen;
    }
}

