using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class controlNarrativa : MonoBehaviour {

    public Flowchart flchar;
    // Use this for initialization
    void Start()
    {
        flchar.SetIntegerVariable("bloque", GameControl.instance.bloque);
        flchar.ExecuteBlock("Main");
    }
}
