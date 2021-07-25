using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool isDown = false;
    private Vector3 startPos, endPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If left click is pressed down
        if (Input.GetMouseButtonDown(0))
        {
            isDown = true;
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && isDown)
        {
            isDown = false;
            endPos = Input.mousePosition;

            Vector3 vector = endPos - startPos;

            GetComponent<Rigidbody2D>().AddForce(vector * 5);
        }
    }
}
