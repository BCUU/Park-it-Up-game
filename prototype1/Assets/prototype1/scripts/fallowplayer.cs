using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fallowplayer : MonoBehaviour
{
    public GameObject player;
    private  Vector3 offset1=new Vector3(0f,7f,-6f);
    private  Vector3 offset2=new Vector3(0f,7f,-16f);
    private  Vector3 offset3=new Vector3(0f,3.3f,-5.73f);
    private  Vector3 offset4=new Vector3(0f,2f,1);

    public Vector3 selected;
    public float rotationSpeed;
    public bool isfnish = false;
    public int cameraoffsetbool =1;

    private void Start()
    {
        selected = offset1;
        transform.eulerAngles = new Vector3(10, 0, 0);
    }
    private void Update()
    {
        if (isfnish==false)
            level_start();

        else
            level_fnish();

        if (Input.GetKeyUp(KeyCode.V))
        {
            if (cameraoffsetbool <= 3)
            {
                cameraoffsetbool++;
                Debug.Log(cameraoffsetbool);
            }
            else
                cameraoffsetbool = 1;
        }


        switch (cameraoffsetbool)
        {
            case 1:selected = offset1;break;
            case 2:selected = offset2;break;
            case 3:selected = offset3;break;
            case 4:selected = offset4;break;
            
        }
            
        
    }
    public void level_start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        transform.position = player.transform.position + selected;
       
    }

    public void level_fnish()
    {

        transform.Rotate(Vector3.up, 1 * rotationSpeed * Time.deltaTime);

        transform.position = player.transform.position;
    }
    

}
