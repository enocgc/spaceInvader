using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour {
    public Text timetexto;
    public static tiempo instance;
    int segundos = 0;
    int minutos = 0;
    int horas = 0;
    private void Awake()
    {
        if (instance ==null)
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
        timetexto.text = "Tiempo :" + horas + ":" + minutos + ":" + segundos;

        StartCoroutine(Reloj());
    }

     IEnumerator Reloj()
    {
       // Debug.Log("curutina");
        yield return new WaitForSeconds(1f);
        segundos = segundos + 1;

        if (segundos == 60)
        {
            segundos = 0;
            minutos = minutos + 1;
        }
        if(minutos == 60)
        {
            minutos = 0;
            horas = horas + 1;
        }
        timetexto.text = "Tiempo :" +horas+":"+minutos + ":" + segundos;
        if (segundos<10)
        {
            timetexto.text = "Tiempo :" + horas + ":" + minutos + ":0" + segundos;
        }
       
       
        StartCoroutine(Reloj());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
