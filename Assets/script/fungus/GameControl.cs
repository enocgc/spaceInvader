using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    public static GameControl instance;
    private int _bloque=0;
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
}
