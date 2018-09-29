using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_paredDetect : MonoBehaviour {
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "paredDerecha")
        {
            //float mover = Input.GetAxis("Horizontal");
            //Debug.Log(mover);
            // desabilidarDerecha();
            float mover = 01;
            Debug.Log("choco la derecha");
        }
        if (collision.gameObject.tag == "paredIzquierda")
        {

            // desabilidarIzquierda();
            Debug.Log("choco la izquierda");
        }
    }
    public void desabilidarDerecha()
    {

    }
    public void desabilidarIzquierda()
    {

    }
}
