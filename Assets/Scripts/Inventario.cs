using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public GameObject panel;
  
    //Ocultar inventario, si el estado 0 se oculta y si el estado es 1 el panel es visible
    public int estado = 0;
    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && estado == 0)
        {
            panel.gameObject.SetActive(true);
            
            Cursor.lockState = CursorLockMode.Locked;
            estado = 0;

        }
        else if (Input.GetKeyDown(KeyCode.I) && estado == 1)
        {
            panel.gameObject.SetActive(false);
           
            Cursor.lockState = CursorLockMode.Locked;
            estado = 0;
        }
    }
}