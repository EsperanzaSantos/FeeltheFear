using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInventario : MonoBehaviour {
    public GameObject panel;
   
    // estado = 0 si el panel esta oculto  y estado=1 si el panel esta visible.
    public int estado = 0;
	// Use this for initialization
	void Start () {
        panel.gameObject.SetActive(false);
      

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I) && estado == 0)
        {
            panel.gameObject.SetActive(true);
            
            Cursor.lockState = CursorLockMode.None;
            estado = 1;
        } else if (Input.GetKeyDown(KeyCode.I) && estado == 1)
        {
            panel.gameObject.SetActive(false);
            
            Cursor.lockState = CursorLockMode.Locked;
            estado = 0;
        }
	}
}
