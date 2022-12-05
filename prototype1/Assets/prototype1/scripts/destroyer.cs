using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacles"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(0, 10, 0);
            other.transform.rotation = new Quaternion(0, 0, 0, 0);
            playerRB.isKinematic = true;
            playerRB.isKinematic = false;

        }


    }
    public Rigidbody playerRB;
    GameObject car;
    bool carnull = true;
 
    private void Update()
    {
        if (carnull)
        {
            car = GameObject.FindGameObjectWithTag("Player");
            playerRB = car.GetComponent<Rigidbody>();
            carnull = false;
        }
       
    }
}
