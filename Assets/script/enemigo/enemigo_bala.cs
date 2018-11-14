using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_bala : MonoBehaviour {

    public GameObject disparo;

    private void Start()
    {
        tiempoAleatorio();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void disparar()
    {
        if (player_inputs.instance.isGame)
        {
            GameObject bala = Instantiate(disparo, transform.position, transform.rotation);
            bala.GetComponent<Rigidbody>().AddRelativeForce(Vector3.down, ForceMode.VelocityChange);//fuerza mas impulso
            Destroy(bala, 5f);
            //Debug.Log("nueva vala");
        }
    }

    void tiempoAleatorio()
    {
        float tiempo = Random.Range(1,30);
        StartCoroutine(activarDisparo(tiempo));
    }// fin de tiempo aleatorio

    IEnumerator activarDisparo(float tiempo) {

        yield return new WaitForSeconds(tiempo);
        disparar();
        tiempoAleatorio();
    }

}
