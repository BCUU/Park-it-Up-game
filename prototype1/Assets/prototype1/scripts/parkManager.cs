using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkManager : MonoBehaviour
{
    public levelManager levelman;


    GameObject car;
    Rigidbody playerRB;
    bool front = false;
    bool back = false;
    private void Start()
    {
        addrb();
    }
    public void addrb()
    {
        car = GameObject.FindGameObjectWithTag("Player");
        playerRB = car.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("front"))
        {
            front = true;
        }
        if (other.CompareTag("backend"))
        {
            back = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("front"))
        {
            front = false;
        }
        if (other.CompareTag("backend"))
        {
            back = false;
        }
    }
    private void Update()
    {
        if (playerRB==null)
        {
            addrb();
        }

        if (front == true && back == true && playerRB.velocity.z < 1f)
        {
            Debug.Log("player here");
            //CoinCalculator(100);
            
            front = false;
            back = false;
            levelman.adc = true;
            
        }
    }
    public void CoinCalculator(int money)
    {
        if (PlayerPrefs.HasKey("moneyy"))
        {
            int oldscore = PlayerPrefs.GetInt("moneyy");
            PlayerPrefs.SetInt("moneyy", oldscore + money);
        }
        else
            PlayerPrefs.SetInt("moneyy", 5000);
    }
}
