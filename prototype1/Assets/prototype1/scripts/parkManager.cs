using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class parkManager : MonoBehaviour
{
    GameObject car;
    Rigidbody playerRB;
    bool front = false;
    bool back = false;
    public int levelcontroller = 0;
    private void Start()
    {
       // levelcontroller = PlayerPrefs.GetInt(nameof(levelcontroller));
        PlayerPrefs.SetInt(nameof(levelcontroller), 0);
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
            PlayerPrefs.SetInt(nameof(levelcontroller), 1);
            

        }
    }
}
