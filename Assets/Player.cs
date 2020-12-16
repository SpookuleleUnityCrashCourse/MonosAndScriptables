using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform tform;
    public PlayerData playerData;
    
    public Vector2 movementDirection;
    public float amountToRotate;
    public bool isRunning;
    
    void Update()
    {
        //Rotate around Z axis by amount to rotate
        transform.Rotate(Vector3.up, amountToRotate * playerData.RotationSensitivity * Time.deltaTime);

        //Move forward by y input amount and right by x input amount
        Vector3 forward = tform.forward;
        Vector3 right = tform.right;

        //Walk speed or run speed?
        float speed = playerData.WalkSpeed;

        if (isRunning)
            speed = playerData.RunSpeed;
        
        tform.position +=
            speed * 
            Time.deltaTime *
            (movementDirection.y * forward +
             movementDirection.x * right);
        
        //Remember to multiply by delta time for smooth motion!
    }
}
