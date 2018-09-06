using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bala : MonoBehaviour {

    public GameObject player;
    public GameObject disparo;
    public static player_bala instance;
	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        if (instance== null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void disparar()
    {
        GameObject bala = Instantiate(disparo, player.transform.position, player.transform.rotation);
        bala.GetComponent<Rigidbody>().AddRelativeForce(new Vector2(0, 3), ForceMode.VelocityChange);//fuerza mas impulso
        Destroy(bala, 3f);
    }
}
