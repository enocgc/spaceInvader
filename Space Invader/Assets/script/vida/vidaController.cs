using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vidaController : MonoBehaviour {
    public Text vidastexto;
    int vida = 3;
    public static vidaController instance;
    public GameObject[] vidas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
        vidastexto.text = ""+vida;
    }

    //bajar vida
    public void bajarVida(int valor)
    {
        Debug.Log(valor);
        vida = vida - valor;
        vidastexto.text = "" + vida;
        quitarVida(vida);
    }// fin de subir puntos

    //quitar vida
    void quitarVida(int numeroVida) {
        vidas[numeroVida].SetActive(false);
    }//fin quitar vida

}
