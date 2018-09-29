using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_engine : MonoBehaviour {
    public float velocidadMovimiento = 3f;
    public GameObject player;
    public static player_engine instance;
    private void Awake()
    {
        if (instance==null) {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

   

    public void moverDerecha()
    {
        //Debug.Log("run:");
        player.transform.Translate( Vector3.right*velocidadMovimiento* Time.deltaTime);
    }
    public void moverIzquierda()
    {
        player.transform.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);
    }

}
