
using UnityEngine;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public GameObject LevelSelection;

    private void Awake()
    {
        playButton.onClick.AddListener(playGame);
        quitButton.onClick.AddListener(OnApplicationQuit);
    }

    private void playGame()
    {
        LevelSelection.SetActive(true);
        
    }

    private void OnApplicationQuit()
    {
        Application.Quit();
    }
}


