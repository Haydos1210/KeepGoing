using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject activeGamePanel;
    [SerializeField] private GameObject pauseGamePanel;
    public void Pause()
    {
        GameController.Instance.PauseGame();
        activeGamePanel.SetActive(false);
        pauseGamePanel.SetActive(true);
    }

    public void Play()
    {
        activeGamePanel.SetActive(true);
        pauseGamePanel.SetActive(false);
        GameController.Instance.ContinueGame();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void QuitGame()
    {
        Debug.Log("quitting app");
        Application.Quit();
    }
}
