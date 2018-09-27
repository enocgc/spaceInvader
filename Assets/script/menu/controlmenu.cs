using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlmenu : MonoBehaviour {
    public void cambiarScen()
    {
        SceneManager.LoadScene("scene-1");
    }
}
