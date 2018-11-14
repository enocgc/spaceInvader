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
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "paredDerecha")
        {
            player_inputs.instance.derecha = true;
        }
        if (other.gameObject.tag == "paredIzquierda")
        {
            player_inputs.instance.izquierda = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="paredDerecha")
        {
            player_inputs.instance.derecha = false;
        }
        if (other.gameObject.tag=="paredIzquierda")
        {
            player_inputs.instance.izquierda = false;
        }
    }
    public void desabilidarDerecha()
    {

    }
    public void desabilidarIzquierda()
    {

    }
}
