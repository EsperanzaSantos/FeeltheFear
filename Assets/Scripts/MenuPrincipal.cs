using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuPrincipal : MonoBehaviour {

    public RectTransform opcionesPanel;

    void Start()
    {
       
        opcionesPanel.gameObject.SetActive(false);
    }
   
    public void ShowOptiones()
    {
        opcionesPanel.gameObject.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Saliste del juego");
    }
    public void ExitOptions()
    {
        opcionesPanel.gameObject.SetActive(false);
    }

}
