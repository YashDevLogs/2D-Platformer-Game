using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject Gamewonpanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.GetComponent<PlayerController>()!=null)
        {

            Gamewonpanel.SetActive(true);
            LevelManager.Instance.MarkCurrentLevelComplete();


/*            NextLevel();*/

        }
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
            Debug.Log("Next Level Loaded");
        }
    }
}
