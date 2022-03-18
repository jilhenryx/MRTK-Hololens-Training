using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    //Declaring Variables
    public GameObject Ball;
    GameObject cloneBall;
    public Rigidbody rb;
    public Transform dropPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            //Instantiate clones an object and gives us ref to it
            //Quaternion is used to handle rotation. It is a maths concept
            cloneBall= Instantiate(Ball, dropPoint.position,Quaternion.identity);
            rb = cloneBall.GetComponent<Rigidbody>();

        }
    }
}
