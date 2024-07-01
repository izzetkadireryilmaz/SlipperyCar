using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public TMP_Text HighScoreText;
    public GameObject homeCanvas;
    public GameObject tutorialCanvas;

    public void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void TutorialButton()
    {
        homeCanvas.SetActive(false);
        tutorialCanvas.SetActive(true);
    }
}
