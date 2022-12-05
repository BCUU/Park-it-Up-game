using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public parkManager pkmanager;


    // public MainManager mainManager;
    public GameObject finishscreen;
    public GameObject image;
    public Text skor_text;
    public GameObject skor_text_obje;
    public GameObject next_level_button;
    public bool adc =false;

    private void Update()
    {
        if (adc)
        {
            finishscreenn();
        }
    }


    public void backtomenu()
    {
        finishscreenn();
        //SceneManager.LoadScene(0);
    }

    public void CoinTextuptade()
    {
        skor_text.text = PlayerPrefs.GetInt("moneyy").ToString();
    }


    public void finishscreenn()
    {
        Debug.Log("a");
        StartCoroutine("finishlaunch");
    }
    public IEnumerator finishlaunch()
    {
        Time.timeScale = 0.3f;
       // radialshine = true;
        finishscreen.SetActive(true);
        yield return new WaitForSecondsRealtime(0.8f);
        image.SetActive(true);
        yield return new WaitForSecondsRealtime(1.2f);
        skor_text_obje.SetActive(true);
        yield return new WaitForSecondsRealtime(0.4f);
        next_level_button.SetActive(true);
    }
}
