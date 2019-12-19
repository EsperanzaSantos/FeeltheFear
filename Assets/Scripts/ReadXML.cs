using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class ReadXML : MonoBehaviour
{
    //Usamos un archivo XmL para la lectura de datos
    public const string path = "textosxml.xml";
    public string idiomaSeleccion;
    public GameObject IdiomasPanel;
    public GameObject MainPanel;
    
    public Text JugarBoton;
    public Text SalirBoton;
    public Text OpcionesBoton;

    // Start is called before the first frame update
    void Start()
    {
        IdiomasPanel.SetActive(true);
        MainPanel.SetActive(false);
      
    }

    public void Seleccion(string idioma)
    {
        idiomaSeleccion = idioma;
        //Leer XML
        LeerXML(idiomaSeleccion);

        IdiomasPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void Volver()
    {
        IdiomasPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    void LeerXML(string seleccion)
    {
        Languages ic = Languages.Load(path); //Cargamos el XML
        if (ic != null)
        {
            foreach (Idioma it in ic.Idiomas)
            {
                //Segun el idioma selecionado cambiamos el texto de los dos botones
                if (string.Compare(it.name, seleccion) == 0)
                {
                    JugarBoton.text = it.Jugar;
                    SalirBoton.text = it.Salir;
                    OpcionesBoton.text = it.Opciones;
                }
            }
        }
        else
        {
            {
                Debug.LogError("Imposible cagar el fichero");
            }
        }
    }
}




