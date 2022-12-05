using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
using System;

public class menucontroller : MonoBehaviour
{
    


    public GameObject start_button;
    public GameObject exit_button;
    public GameObject deising_button;
    public GameObject panel;
    public GameObject back_menu;

    public void deising_buttonn()
    {
        start_button.SetActive(false);
        exit_button.SetActive(false);
        deising_button.SetActive(false);
        panel.SetActive(true);

    }
    public void backtomenu()
    {
        start_button.SetActive(true);
        exit_button.SetActive(true);
        deising_button.SetActive(true);
        panel.SetActive(false);
    }
    public void startscreen()
    {

        SceneManager.LoadScene(1);
    }
    public void exitbutton()
    {
        
    }


    public Button red_car_button;
    public Button blue_car_button;
    public Button van_button;
    public Button bus_button;
    public Button armor_button;
    public int cars_number=0;
    public void Check_car1()
    {
        red_car_button.image.color = Color.green;
        blue_car_button.image.color = Color.red;
        van_button.image.color = Color.red;
        bus_button.image.color = Color.red;
        armor_button.image.color = Color.red;
        cars_number = 0;
    }
    public void Check_car2()
    {
        red_car_button.image.color = Color.red;
        blue_car_button.image.color = Color.green;
        van_button.image.color = Color.red;
        bus_button.image.color = Color.red;
        armor_button.image.color = Color.red;
        cars_number = 1;
    }
    public void Check_car3()
    {
        red_car_button.image.color = Color.red;
        blue_car_button.image.color = Color.red;
        van_button.image.color = Color.green;
        bus_button.image.color = Color.red;
        armor_button.image.color = Color.red;
        cars_number = 2;
    }
    public void Check_car4()
    {
        red_car_button.image.color = Color.red;
        blue_car_button.image.color = Color.red;
        van_button.image.color = Color.red;
        bus_button.image.color = Color.green;
        armor_button.image.color = Color.red;
        cars_number = 3;
    }
    public void Check_car5()
    {
        red_car_button.image.color = Color.red;
        blue_car_button.image.color = Color.red;
        van_button.image.color = Color.red;
        bus_button.image.color = Color.red;
        armor_button.image.color = Color.green;
        cars_number = 4;
    }

    private void Start()
    {
       
        cars_number = 4 ;

        //mainManager.asf=false;
    }
   

    public GameObject[] cars;
    public MainManager mainManager;
    private void Update()
    {

        Debug.Log(mainManager.ars_number);
        mainManager.ars_number= cars_number ;
        select_car();

    }
    public void select_car()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars_number == i)
            {
                for (int z = 0; z < cars.Length; z++)
                {
                    if (i != z)
                    {
                        cars[z].gameObject.SetActive(false);
                    }
                }
                cars[i].gameObject.SetActive(true);
                //mainManager.ars_number = i;


            }
        }
    }

    /*public void save_number()
    {
        SaveData data = new SaveData();
        data.cars_number = cars_number;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void load_number()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            cars_number = data.cars_number;
        }
    }*/


    /*[System.Serializable]
    class SaveData
    {
        public int cars_number;
    }*/
}
