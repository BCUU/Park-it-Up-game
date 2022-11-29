using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolller : MonoBehaviour
{
    //public float speed = 5f;
    public float Turnspeed = 2f;
    public float horizontalInput;
    public float verticalnput;

    private Rigidbody playerRB;
    [SerializeField] private float horsepower = 0;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalnput = Input.GetAxis("Vertical");


        playerRB.AddRelativeForce(Vector3.forward * verticalnput * horsepower);
        transform.Rotate(Vector3.up, Time.deltaTime * Turnspeed * horizontalInput);
    }

    // Update is called once per frame
    /*void Update()
    {
        

        //we'll move the vachicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed* verticalnput);  
        
        
    }*/
}
