using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerpared : MonoBehaviour {

    // Use this for initialization
    public GameObject paredIzquierda;
    public GameObject paredDerecha;

    public float limiteHorizontal;
    public float limiteVertical;
    void Start()
    {//obtiene el tamano de lo que se ve en la camara
        limiteHorizontal = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, transform.position.z - Camera.main.transform.position.z)).x;
        //limiteVertical = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, transform.position.z - Camera.main.transform.position.z)).y;
       // Debug.Log(limiteHorizontal);
        ubicarParedes();
    }
    public void ubicarParedes()
    {
        paredIzquierda.transform.position = new Vector3(-limiteHorizontal, paredIzquierda.transform.position.y, 0);
        paredDerecha.transform.position = new Vector3(limiteHorizontal, paredDerecha.transform.position.y, 0);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
