using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EfectoFadeEscenas : MonoBehaviour
{
    public Image Fude;
    public string[] escena;
    // Start is called before the first frame update
    void Start()
    {
       Fude.CrossFadeAlpha(0, 0.5f, false);
    }

    public void FadeOut(int s)
    {
       Fude.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(CambioEscena(escena[s]));
    }

    IEnumerator CambioEscena(string escena)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level1");
    
    }
}
       
