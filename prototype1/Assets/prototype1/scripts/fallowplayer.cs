using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallowplayer : MonoBehaviour
{
    public GameObject player;
    private  Vector3 offset=new Vector3(0,7,-6);
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    
    
}
