using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int ars_number;
    public bool controlbool=false;
    public bool asf=true;
    public GameObject[] cars;
    

    public void Awake()
    {
        dontdestroy();
    }

    int cortrol=1;
    private void Update()
    {
        setcar();
        if (SceneManager.GetActiveScene().buildIndex == cortrol && SceneManager.GetActiveScene().buildIndex !=0 )
        {

            cortrol++;
            controlbool = true;

        }

        
    }
    /*public void get_cars()
    {
        PlayerPrefs.SetInt(nameof(ars_number), ars_number);
    }*/
    public void setcar()
    {
        
        if (controlbool == true/* && SceneManager.GetActiveScene().buildIndex == 1||SceneManager.GetActiveScene().buildIndex==2*/)
        {
            Debug.Log("11");
            // spawnpoint.gameObject.GetComponent<Transform>().position = new Vector3();
            Instantiate(cars[ars_number], gameObject.transform.position, gameObject.transform.rotation);
            controlbool = false;

        }
    }
    public int get_car_number()
    {
        return ars_number;
    }

    public void dontdestroy()
    {
        if (Instance != null )
        {
            
            Destroy(gameObject);
            
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void ceck()
    {
        controlbool = true;
    }



}
