using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("01MainScene");
        Debug.Log("Load Scene 1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exitting...");
    }

    public void NextSceneMeme()
    {
        SceneManager.LoadScene("Scenes/00MainMenu01");
        Debug.Log("Load Meme");
    }
}