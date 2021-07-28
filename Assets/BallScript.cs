using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool isDown = false;
    private bool shouldHitBall = false;
    private Rigidbody2D ball;
    private Vector3 startPos, endPos;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
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
           
            if (ball.GetPointVelocity(ball.position) == new Vector2(0, 0))
            {
                shouldHitBall = true;
            }

            endPos = Input.mousePosition;
        }
    }

    void FixedUpdate()
    {
        if (shouldHitBall)
        {
            Vector3 vector = endPos - startPos;

            ball.AddForce(vector * 5);

            shouldHitBall = false;
        }
    }
}
