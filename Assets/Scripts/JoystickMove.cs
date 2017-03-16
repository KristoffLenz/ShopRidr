using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class JoystickMove : MonoBehaviour {

    // all possible move directions
    enum Direction { UP, DOWN, LEFT, RIGHT, NONE }
    // The move's direction
    Direction moveDirection;
    //
    private bool disabled = false;
    //                                               UP     DOWN   LEFT   RIGHT
    private bool[] disabledDirections = new bool[4] {false, false, false, false};

    private int x = 0;

    // Update is called once per frame
    void Update()
    {
        if (x++ != 4)
        {
            return;
        }
        x = 0;

        float hAxis = CnInputManager.GetAxis("Horizontal");
        float vAxis = CnInputManager.GetAxis("Vertical");

        // Get the move direction
        if (vAxis == 1F) {
            moveDirection = Direction.UP;
        } else if (vAxis == -1F) {
            moveDirection = Direction.DOWN;
        } else if (hAxis == -1F)
        {
            moveDirection = Direction.LEFT;
        } else if (hAxis == 1F) {
            moveDirection = Direction.RIGHT;
        }

        // If the next update is reached
        if (moveDirection != Direction.NONE && !disabledDirections[(int) moveDirection])
            MakeMove();

    }

    // Move the player up, down, left or right by one field
    void MakeMove() {
        Debug.Log ("Moving " + moveDirection);
        switch (moveDirection) {
            case Direction.UP:
                transform.position += new Vector3 (0, 1, 0);
                break;
            case Direction.DOWN:
                transform.position -= new Vector3 (0, 1, 0);
                break;
            case Direction.LEFT:
                transform.position -= new Vector3 (1, 0, 0);
                break;
            case Direction.RIGHT:
                transform.position += new Vector3 (1, 0, 0);
                break;
        }
        moveDirection = Direction.NONE;
    }
    // When colliding
    void OnCollisionEnter2D(Collision2D coll) {
        Debug.Log("Touching Collider");
        const float safetyMargin = 0.2F;
        float playerX = gameObject.GetComponent<Transform>().position.x;
        float playerY = gameObject.GetComponent<Transform>().position.y;
        float collX = coll.gameObject.GetComponent<Transform>().position.x;
        float collY = coll.gameObject.GetComponent<Transform>().position.y;
        float xDistance = collX - playerX;
        float yDistance = collY - playerY;
        if (coll.gameObject.CompareTag("Regal"))
        {
            // if on the left side of Regal
            if(xDistance > safetyMargin && xDistance < 1F + safetyMargin && Math.Abs(collY - playerY) < safetyMargin)
                disabledDirections[(int) Direction.RIGHT] = true;
            // if on the right side of Regal
            if(xDistance < -safetyMargin && xDistance > -(1F + safetyMargin) && Math.Abs(collY - playerY) < safetyMargin)
                disabledDirections[(int) Direction.LEFT] = true;
            // if on top of Regal
            if (yDistance < -safetyMargin && yDistance > -(1F + safetyMargin) && Math.Abs(collX - playerX) < safetyMargin)
                disabledDirections[(int) Direction.DOWN] = true;
            // if below Regal
            if (yDistance > safetyMargin && yDistance < 1F + safetyMargin && Math.Abs(collX - playerX) < safetyMargin)
                disabledDirections[(int) Direction.UP] = true;
        }
    }
    void OnCollisionExit2D(Collision2D coll) {
        Debug.Log("Not touching Collider anymore");
        for (int i = 0; i < 4; i++)
            disabledDirections[i] = false;
    }

}
