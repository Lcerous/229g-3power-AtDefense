using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void BtnRetry() // click and load new scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    public void BtnToMain() // click and load new scene
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1.0f;
    }
}