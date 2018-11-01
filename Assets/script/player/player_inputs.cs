using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_inputs : MonoBehaviour {

    public static player_inputs instance;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	public float moverPlayer(float movimiento)
    {
        Debug.Log(movimiento);
        return movimiento;
    }
    //procesamiento de funcionalidad con el procesador
    void Update()
    {//movimiento del player
        float mover = moverPlayer(Input.GetAxis("Horizontal"));
        if (mover >0)
        {//mover derecha
            player_engine.instance.moverDerecha();
        }
        if (mover < 0)
        {//mover izquierda
            player_engine.instance.moverIzquierda();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            player_bala.instance.disparar();
        }
    }
}
