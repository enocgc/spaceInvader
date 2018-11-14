using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlDelay : MonoBehaviour {
    public GameObject countDown;

    public static controlDelay instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void counterDisplay()
    {
        StartCoroutine(StartDeley());
    }

    IEnumerator StartDeley()
    {
        countDown.SetActive(true);
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        countDown.SetActive(false);
        startGame();
        Time.timeScale = 1;

    }

    public void startGame()
    {
        SceneManager.LoadScene("story");
    }
}
