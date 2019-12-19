using UnityEngine;
using System.Collections;

public class Camarasigue : MonoBehaviour {

    public GameObject objetivo;

    public Vector3 desfase;

	
    // Use this for initialization
	void Start () {
        desfase = this.transform.position - objetivo.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = objetivo.transform.position + desfase;
	}
}
