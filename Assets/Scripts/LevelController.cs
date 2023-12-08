using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject Gamewonpanel;
    public ParticleSystem GameWonEffect;

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.GetComponent<PlayerController>()!=null)
        {

            Gamewonpanel.SetActive(true);
            SoundManager.Instance.playMusic(Sounds.NewLevel);
            LevelManager.Instance.MarkCurrentLevelComplete();
            GameWonEffect.Play();


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
