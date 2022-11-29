using SojaExiles;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOther : MonoBehaviour
{
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeNow()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("01MainScene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            ResumeNow();
        }
    }
}
