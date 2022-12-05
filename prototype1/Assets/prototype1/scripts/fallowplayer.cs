using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fallowplayer : MonoBehaviour
{
    public GameObject player;
    private  Vector3 offset=new Vector3(0,7,-6);
    public float rotationSpeed;
   public bool isfnish = false;

    private void Update()
    {
        if (!isfnish)
            level_start();

        else
            level_fnish();

        
    }
    public void level_start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        transform.position = player.transform.position + offset;
    }

    public void level_fnish()
    {

        transform.Rotate(Vector3.up, 1 * rotationSpeed * Time.deltaTime);

        transform.position = player.transform.position;
    }
    

}
