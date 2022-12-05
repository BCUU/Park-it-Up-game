using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastsenemanager : MonoBehaviour
{
    public Text score_text;
    public int score;
    private void Start()
    {
        scoretextupdate();
    }
    public void scoretextupdate()
    {
        score_text.text = "Your Score :"+PlayerPrefs.GetInt(nameof(score));
    }
    public void restartgame()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt(nameof(score), 0);
        Application.LoadLevel(0);
    }
    public void exit()
    {
        Application.Quit();
    }
}
