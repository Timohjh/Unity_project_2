using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    float timer;
    public bool started = false;
    public TextMeshProUGUI timerText;
    public GameObject restartButton;
    public GameObject menuButton;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            StartTimer();
            timerText.text = "Timer: " + timer.ToString("F2");
        }
    }

    //DATA PERSISTANCE with a singleton
    public void SetPlayer()
    {
        if (MainManager.Instance.ballSize == "Big")
        {
            player.AddComponent<BigBall>();
        }
        else {
            player.AddComponent<SmallBall>();
        }
    }

    public void StartTimer()
    {
        timer += Time.deltaTime;
    }

    public void EndTimer()
    {
        started = false;
        restartButton.SetActive(true);
        menuButton.SetActive(true);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
