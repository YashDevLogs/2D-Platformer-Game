using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWonController : MonoBehaviour
{
    public Button RestartButton;
    public Button MenuButton;
    public Button NextLevel;
    private void Awake()
    {
        RestartButton.onClick.AddListener(restartLevel);
        MenuButton.onClick.AddListener(Menu);
        NextLevel.onClick.AddListener(nextLevel);
    }

/*    public void PlayerDied()
    {
        gameObject.SetActive(true);
    }*/
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Level Restarted");
        HealthManager.Health = 3;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void nextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
