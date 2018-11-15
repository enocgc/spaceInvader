using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puntos : MonoBehaviour {
    public Text puntostexto;
    public static puntos instance;
    public int cantidadEnemigos;
    public int scena;
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
        cantidadEnemigos=(cantidadEnemigos-1);
        Debug.Log(cantidadEnemigos);
        if (cantidadEnemigos == 0)
        {
            GameControl.instance.bloque = scena;
            controlDelay.instance.startGame();
        }
    }// fin de subir puntos
}
