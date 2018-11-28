using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlHigscores : MonoBehaviour {
    public Text puntostexto1;
    public Text puntostexto2;
    public Text higscores;
    // Use this for initialization
    public static controlHigscores instance;
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

    void Start()
    {
        Debug.Log(leerPuntaje2().ToString());
        Debug.Log(leerPuntaje1().ToString());
        Debug.Log(leerPuntaje().ToString());
        puntostexto1.text = leerPuntaje1().ToString();
        puntostexto2.text = leerPuntaje2().ToString();
        higscores.text = leerPuntaje().ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}

   

    //leer puntaje
    public int leerPuntaje()
    {
        return PlayerPrefs.GetInt("mejorpuntuacion", 000);
    }// fin de leerpuntaje

    public int leerPuntaje1()
    {
        return PlayerPrefs.GetInt("mejorpuntuacion2", 000);
    }// fin de leerpuntaje

    public int leerPuntaje2()
    {
        return PlayerPrefs.GetInt("mejorpuntuacion3", 000);
    }// fin de leerpuntaje
}
