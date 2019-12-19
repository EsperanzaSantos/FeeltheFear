using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autotype : MonoBehaviour
{
    //Creamos una variable Gameobject para el titulo del texto y otra tipo float
    public float letterPause = 0.2f;
    public GameObject titulodeljuego;
    public string[] texto;

    public int contador = 0;

    UnityEngine.Coroutine co;

    public string message;




    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (Time.timeScale != 0)
            {
                Debug.Log("Pausa");
                Time.timeScale = 0;
            }
            else
            {
                Debug.Log("Reanudar");
                Time.timeScale = 1;
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (contador != 0 && co != null)
            {
                StopCoroutine(co);
            }
            titulodeljuego.GetComponent<Text>().text = "";
            message = texto[contador];
            co = StartCoroutine(TypeText()); //Dos corrutinas diferentes

            contador++;
            if (contador >= texto.Length)
            {
                contador = 0;
                Debug.LogError("Tamaño de tabla superado");
            }


        }
    }
    //Funcion que muestra el texto
    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            titulodeljuego.GetComponent<Text>().text += letter;
            yield return new WaitForSeconds(letterPause);
        }
        message = "";
        //Invoke ("Automatico", 1f);

    }
    IEnumerator Typetext2()
    {
        string messageAux = "";
        foreach (char letter in message.ToCharArray())
        {
            if (string.Compare(letter.ToString(), " ") == 0)
            {
                messageAux += letter;
                titulodeljuego.GetComponent<Text>().text += messageAux;
                messageAux = "";
            }
            else
            {
                //Para la ultima palabra
                if (string.Compare(letter.ToString(), "\n") == 0)
                {

                }
                else
                {
                    messageAux += letter;
                }
            }
            yield return new WaitForSeconds(letterPause);
        }
        message = "";
        Invoke ("Automatico2", 1f);
    }
    void Automatico()
    {
        titulodeljuego.GetComponent<Text>().text = "";
        message = texto[contador];
        co = StartCoroutine(Typetext2());
        contador++;
        if (contador >= texto.Length)
        {
            contador = 0;
            Debug.LogError("Tamaño de tabla superado");
        }
    }
}

             



