using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    [Header("Main Menu Panels")]
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject difficultyPanel;

    [Header("Main Menu Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    [Header("Difficulty Buttons")]
    [SerializeField] private Button easyButton;
    [SerializeField] private Button normalButton;
    [SerializeField] private Button hardButton;
    [SerializeField] private Button impossibleButton;
    [SerializeField] private Button backButton;

    private void Start()
    {
        ShowMainMenu();

        playButton.onClick.AddListener(ShowDifficultyMenu);
        quitButton.onClick.AddListener(QuitGame);

        // easyButton.onClick.AddListener(() => StartGame(GameManager.Difficulty.Easy));
        // normalButton.onClick.AddListener(() => StartGame(GameManager.Difficulty.Normal));
        // hardButton.onClick.AddListener(() => StartGame(GameManager.Difficulty.Hard));
        // impossibleButton.onClick.AddListener(() => StartGame(GameManager.Difficulty.Impossible));
        backButton.onClick.AddListener(ShowMainMenu);
    }

    private void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        difficultyPanel.SetActive(false);
    }

    private void ShowDifficultyMenu()
    {
        mainMenuPanel.SetActive(false);
        difficultyPanel.SetActive(true);
    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    private void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}