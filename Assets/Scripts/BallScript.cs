using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Declaring Variables
    public GameObject yellowBall;
    public Rigidbody rb;
    public Transform cameraTransform, courtTransform;
    GameObject cloneBall;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        float a = Mathf.Abs(cameraTransform.position[2] - courtTransform.position[2]);
        Debug.Log("Camera Pos (:" + cameraTransform.position[2] + ")-Court Pos(" + courtTransform.position[2] + ")=" + a);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            Vector3 originalMousePos = Input.mousePosition;
            float a = Mathf.Abs(cameraTransform.position[2] - courtTransform.position[2]);
            Debug.Log("Camera Pos (:" + cameraTransform.position[2] + ")-Court Pos(" + courtTransform.position[2] + ")=" + a);

            originalMousePos.z = a;

            Vector3 worldViewMousePosition = mainCamera.ScreenToWorldPoint(originalMousePos);
            //Debug.Log("Mouse Pos: " + worldViewMousePosition);
            cloneBall = Instantiate(yellowBall, worldViewMousePosition, Quaternion.identity);
            Debug.Log("Ball Pos: " + cloneBall.GetComponent<Transform>().position);
            rb = cloneBall.GetComponent<Rigidbody>();

            //Debug.Log("Manager Pos: " + startPoint.position);
            //Debug.Log("Mouse Pos: " +  mousePos);

        }

    }




}
