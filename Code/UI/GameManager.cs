using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Animator anim;

    public GameObject scoreUI, lastScoreUI, highScoreUI;
    public AudioSource audioObject;

    private float yourScore;
    private int bitParts = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        HighScore();
    }
    public void Addscore()
    {
        yourScore += 0.5f;
        scoreUI.GetComponent<Text>().text = "" + Mathf.FloorToInt(yourScore);
        lastScoreUI.GetComponent<Text>().text = scoreUI.GetComponent<Text>().text;

        bitParts++;

        if (bitParts == 2)
        {
            audioObject.Play();
            bitParts = 0;
        }

        if (yourScore % 10 == 0)
        {
            anim.Play("Score");
        }
    }
    void HighScore()
    {
        if (yourScore > PlayerPrefs.GetFloat("highscore"))
        {
            PlayerPrefs.SetFloat("highscore", yourScore);
        }

        highScoreUI.GetComponent<Text>().text = "" + Mathf.FloorToInt(PlayerPrefs.GetFloat("highscore"));
    }

}
