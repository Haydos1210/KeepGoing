using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject UICanvas;

    [Header("Vars")]
    private bool gameIsOver;

    public static GameController Instance;

    private void Awake() => Instance = this;

    private void Start()
    {
        Time.timeScale = 1.0f;
        gameIsOver = false;
        gameOverCanvas.SetActive(false);
    }

    // other scripts should call this when game should end()
    public void EndGame()
    {
        Time.timeScale = 0f;
        UICanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        gameIsOver = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1.0f;
        UICanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        gameIsOver = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1.0f;
    }

    public bool GameOver()
    {
        return gameIsOver;
    }
}
