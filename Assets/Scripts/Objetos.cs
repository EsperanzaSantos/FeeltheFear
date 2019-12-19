using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    InventaryManager manager;
    bool entroTrigger = false;
    public Collider col1;
    // Use this for initialization
    void Start()
    {
        manager = GetComponent<InventaryManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (entroTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            if (col1.GetComponent<ItemsPickup>() != null)
            {
                ItemsPickup i = col1.GetComponent<ItemsPickup>();
                manager.AgregarItemAlInventario(i.id, i.cantidad);
                // Debug.Log("entro en trigger");
                Destroy(col1.transform.parent.gameObject);
                entroTrigger = false;
            }

        }
    }

    void OnTriggerEnter(Collider col)
    {
        col1 = col;
        entroTrigger = true;
    }
}
        
    

