using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript2 : MonoBehaviour
{
    public GameObject ball;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 15.0f;
            Vector3 wMousePos = mainCamera.ScreenToWorldPoint(mousePosition);

            Instantiate(ball,wMousePos,Quaternion.identity);

            Debug.Log("World Mouse Position: " + wMousePos);

        }
    }
}
