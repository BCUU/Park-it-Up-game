using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int ars_number;
    public bool controlbool=true;
    public bool asf=true;
    public GameObject[] cars;

    public void Awake()
    {
        dontdestroy();
    }

    
    private void Update()
    {
        setcar();

        
    }
    public void setcar()
    {
        if (controlbool == true && SceneManager.GetActiveScene().buildIndex == 1)
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
