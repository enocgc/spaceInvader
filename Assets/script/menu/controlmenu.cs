using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlmenu : MonoBehaviour {
    public static controlmenu instance;
    public GameObject panelGameOver;
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

    public void activarGameOver()
    {
        panelGameOver.SetActive(true);
    }

    public void recargarScena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
