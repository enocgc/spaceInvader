using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigocomportamiento : MonoBehaviour {
    // Use this for initialization
    void OnTriggerEnter(Collider collision)//deteccion de colicion con el player
    {
       
        if (collision.gameObject.tag == "Player")
        {
            vidaController.instance.bajarVida(1);
             Destroy(collision.gameObject);

            //reiniciar juego

           // Destroy(this.gameObject);
        }//fin condicion verifica choque con enemigos1

    }

}
