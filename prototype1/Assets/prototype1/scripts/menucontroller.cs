using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
    public int cars_number;
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
        cars_number = 0;
    }

    public GameObject[] cars;
    private void Update()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars_number==i)
            {
                for (int z = 0; z < cars.Length; z++)
                {
                    if (i!=z)
                    {
                        cars[z].gameObject.SetActive(false);
                    }
                }
                cars[i].gameObject.SetActive(true);
            }
        }
    }
}
