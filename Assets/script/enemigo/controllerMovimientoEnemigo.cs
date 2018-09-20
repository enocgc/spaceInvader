using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMovimientoEnemigo : MonoBehaviour {
    public int direccion = 1;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (direccion == 1)
        {
            transform.Translate(Vector3.right * 1 * Time.deltaTime);
        }
        if (direccion == 2)
        {
            transform.Translate(Vector3.left * 1 * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "paredDerecha")
        {
          
            direccion = 2;
        }
        if (collision.gameObject.tag == "paredIzquierda")
        {
            direccion = 1;
        }
    }
}
