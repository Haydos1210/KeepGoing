using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("CarSelection");
    }

    public void QuitGame()
    {
        Debug.Log("quitting app");
        Application.Quit();
    }
}
