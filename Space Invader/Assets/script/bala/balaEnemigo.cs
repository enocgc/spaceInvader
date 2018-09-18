using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaEnemigo : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log(collision.gameObject.tag+" choco");
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.transform.position
            vidaController.instance.bajarVida(1);
           // Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        //choque de balas
        if (collision.gameObject.tag == "BalaPlayer")
        {
            vidaController.instance.bajarVida(1);
             Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        //condicion de escudos sigue

    }
}
