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
	
	// Update is called once per frame
	void Update () {
		
	}
    //procesamiento de funcionalidad con el procesador
    private void FixedUpdate()
    {
        
        if (Input.GetKeyUp(KeyCode.LeftArrow) )
        {
            player_engine.instance.moverIzquierda();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            player_engine.instance.moverDerecha();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            player_bala.instance.disparar();
        }
    }
}
