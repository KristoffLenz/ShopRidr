using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandler : MonoBehaviour {

    // all possible move directions
    enum Direction { UP, DOWN, LEFT, RIGHT, NONE }
    // The move's direction
    Direction moveDirection;

    private bool disabled = false;
    //                                               UP     DOWN   LEFT   RIGHT
    private bool[] disabledDirections = new bool[4] {false, false, false, false};

    // Update is called once per frame
    void Update(){

        // Get the move direction
        if (Input.GetKeyDown (KeyCode.UpArrow)) {
            moveDirection = Direction.UP;
        } else if (Input.GetKeyDown (KeyCode.DownArrow)) {
            moveDirection = Direction.DOWN;
        } else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            moveDirection = Direction.LEFT;
        } else if (Input.GetKeyDown (KeyCode.RightArrow)) {
            moveDirection = Direction.RIGHT;
        }

        // make a move if a button was pressed and the direction is enabled
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
