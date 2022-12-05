using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject finishscreen;
    public GameObject image;
    public Text skor_text;
    public GameObject skor_text_obje;
    public GameObject next_level_button;
    public int lcontroller;
    public int score;
    bool asd = false;
    int car_bonus_score = 1;

    //public GameObject[] cars;

    private void Start()
    {
        Time.timeScale = 1f;
        asd = false;
        score = PlayerPrefs.GetInt(nameof(score));
        ScoreWriter();

       // Instantiate()

    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("levelcontroller")==1 && asd==false)
        {
            fnishscreen();
            asd = true;
        }
    }
    public void fnishscreen()
    {
        ScoreCalculator();
        ScoreWriter();
        StartCoroutine("finishlaunch");

    }
    public IEnumerator finishlaunch()
    {
        Time.timeScale = 0.3f;
        finishscreen.SetActive(true);
        yield return new WaitForSecondsRealtime(0.8f);
        image.SetActive(true);
        yield return new WaitForSecondsRealtime(1.2f);
        skor_text_obje.SetActive(true);
        yield return new WaitForSecondsRealtime(0.4f);
        next_level_button.SetActive(true);
    }
    public void ScoreWriter()
    {
        skor_text.text = "+ " + score;
        

    }
    public void ScoreCalculator()
    {
        score += car_bonus_score * 100;
        PlayerPrefs.SetInt(nameof(score), score);
    }

    public void next_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
