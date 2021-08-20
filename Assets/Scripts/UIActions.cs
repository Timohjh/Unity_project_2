using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }
    // Setting ballSize to the one from menu button
    public void SetBall(string size)
    {
        MainManager.Instance.ballSize = size;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
