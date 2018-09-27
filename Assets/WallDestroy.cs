using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "BalaPlayer")
        {
            //puntos.instance.subirPuntos(10);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "BalaEnemigo")
        {
            //puntos.instance.subirPuntos(10);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
