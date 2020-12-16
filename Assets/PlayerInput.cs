using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Player player;

    //Hide cursor at start, lock it to game
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //WASD movement
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        
        player.movementDirection = new Vector2(xInput, yInput);
        
        //Turning
        float mouseXInput = Input.GetAxis("Mouse X");
        player.amountToRotate = mouseXInput;
        
        //Run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        player.isRunning = isRunning;
        
    }
}
