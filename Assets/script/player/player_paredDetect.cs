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
            player_inputs.instance.moverPlayer(0);
            Debug.Log("choco la derecha");
        }
        if (collision.gameObject.tag == "paredIzquierda")
        {
            player_inputs.instance.moverPlayer(-0);
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
