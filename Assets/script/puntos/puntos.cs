using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puntos : MonoBehaviour {
    public Text puntostexto;
    public static puntos instance;
    public int cantidadEnemigos;
    int puntosvalor = 0;
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
        puntostexto.text = "Puntos :" + puntosvalor;
	}
	
	public void subirPuntos(int valor)
    {
        //Debug.Log(valor);
        puntosvalor = puntosvalor + valor;
        puntostexto.text = "Puntos :" + puntosvalor;
        cantidadEnemigos--;
        Debug.Log(cantidadEnemigos);
        if (cantidadEnemigos == 0)
        {
            GameControl.instance.bloque = 1;
            controlDelay.instance.startGame();
        }
    }// fin de subir puntos
}
