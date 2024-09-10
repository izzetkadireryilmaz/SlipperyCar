using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject player;
    public GameObject DeadScene;
    public GameObject aButton;
    public bool award;

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void AwardButton()
    {
        if (award == false)
        {
            player.SetActive(true);
            award = true;
            DeadScene.SetActive(false);
            aButton.SetActive(false);

            GameObject[] objects = GameObject.FindGameObjectsWithTag("Obstancle");
            foreach (GameObject obj in objects)
            {
                Destroy(obj);
            }
        }
        
    }
    public void TryAgainButton()
    {
        StartCoroutine(ReklamDelay());
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    
    IEnumerator ReklamDelay()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(1);
    }
}
