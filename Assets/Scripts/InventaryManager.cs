using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaryManager : MonoBehaviour {

    private GameObject Energia;
    public void Start()
    {
        Energia = GameObject.Find("Energia");
        ActualizarInventario();

    }



    [System.Serializable]
    public struct ObjetoInventarioId
    {
        public int id;
        public int cantidad;

        public ObjetoInventarioId(int id, int cantidad)
        {
            this.id = id;
            this.cantidad = cantidad;
        }
    }

    public Invetary01 baseDatos;
    public List<ObjetoInventarioId> inventario;

    public void AgregarItemAlInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[i].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad + cantidad);
                ActualizarInventario();
                return;
            }

        }

        inventario.Add(new ObjetoInventarioId(id, cantidad));
        ActualizarInventario();

    }


    public void EliminarItemDelInventario(int id, int cantidad)
    {
        for (int i = 0; i < inventario.Count; i++)
        {
            if (inventario[id].id == id)
            {
                inventario[i] = new ObjetoInventarioId(inventario[i].id, inventario[i].cantidad - cantidad);
                if (inventario[i].cantidad <= 0)
                    inventario.Remove(inventario[i]);
                ActualizarInventario();
                return;
            }

        }

        Debug.LogError("No existe el item a eliminar");

    }


    public InventaryObjectInterface prefab;
    public Transform inventarioUI;
    List<InventaryObjectInterface> pool = new List<InventaryObjectInterface>();



    public void ActualizarInventario()
    {
        for (int i = 0; i < pool.Count; i++)
        {

            if (i < inventario.Count)
            {
                ObjetoInventarioId o = inventario[i];
                pool[i].sprite.sprite = baseDatos.db[o.id].sprite;
                pool[i].cantidad.text = o.cantidad.ToString();
                pool[i].id = i;
                pool[i].boton.onClick.RemoveAllListeners();
                pool[i].boton.onClick.AddListener(() => gameObject.SendMessage(baseDatos.db[o.id].funcion));
                pool[i].gameObject.SetActive(true);
            }
            else
            {
                pool[i].gameObject.SetActive(false);
            }

        }

        if (inventario.Count > pool.Count)
        {
            for (int i = pool.Count; i < inventario.Count; i++)
            {

                InventaryObjectInterface oi = Instantiate(prefab, inventarioUI);
                pool.Add(oi);

                oi.transform.position = Vector3.zero;
                oi.transform.localScale = Vector3.one;

                ObjetoInventarioId o = inventario[i];
                pool[i].sprite.sprite = baseDatos.db[o.id].sprite;
                pool[i].cantidad.text = o.cantidad.ToString();
                pool[i].id = i;
                pool[i].boton.onClick.RemoveAllListeners();
                pool[i].boton.onClick.AddListener(() => gameObject.SendMessage(baseDatos.db[o.id].funcion));
                pool[i].gameObject.SetActive(true);


            }
        }


    }
}

 
