using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
    public static GameControl instance;
    private int _bloque=0;
   
    public int _puntosActuales;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //set y get del bloque
    public int bloque
    {
        set { _bloque = value; }
        get { return _bloque; }
        
    }
    public int puntosActuales
    {
        set { _puntosActuales = value; }
        get { return _puntosActuales; }

    }

    //guardar puntaje
    public void guardarPuntos()
    {
        Debug.Log(GameControl.instance.puntosActuales);
        if (PlayerPrefs.GetInt("mejorpuntuacion", 000) < GameControl.instance.puntosActuales)
        {
            PlayerPrefs.SetInt("mejorpuntuacion", GameControl.instance.puntosActuales);
        }
        else if (PlayerPrefs.GetInt("mejorpuntuacion2", 000) < GameControl.instance.puntosActuales)
        {
            PlayerPrefs.SetInt("mejorpuntuacion2", GameControl.instance.puntosActuales);
        }
        else if (PlayerPrefs.GetInt("mejorpuntuacion3", 000) < GameControl.instance.puntosActuales)
        {
            PlayerPrefs.SetInt("mejorpuntuacion3", GameControl.instance.puntosActuales);
        }
    }
}
