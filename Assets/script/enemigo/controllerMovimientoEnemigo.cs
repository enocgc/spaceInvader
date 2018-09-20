using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMovimientoEnemigo : MonoBehaviour {
    public int direccion = 1;
    public int velocidad = 1;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (direccion == 1)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        if (direccion == 2)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "paredDerecha")
        {
            bajarenemigos();
            direccion = 2;
        }
        if (collision.gameObject.tag == "paredIzquierda")
        {
            bajarenemigos();
            direccion = 1;
        }
    }
    //se encarga de bajar los enemigos
    public void bajarenemigos()
    {
        transform.Translate(Vector3.down * (velocidad+3) * Time.deltaTime);
    }
}
