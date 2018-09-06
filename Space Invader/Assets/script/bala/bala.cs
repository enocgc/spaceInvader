using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="enemigo1")
        {
            puntos.instance.subirPuntos(10);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "enemigo2")
        {
            puntos.instance.subirPuntos(20);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "enemigo3")
        {
            puntos.instance.subirPuntos(50);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "enemigo4")
        {
            puntos.instance.subirPuntos(300);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }

}
