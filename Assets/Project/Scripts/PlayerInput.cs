using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NOOD;

public class PlayerInput : MonoBehaviorInstance<PlayerInput>
{
    private Vector2 _input;
    public Vector2 InputVector => _input;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement;
        // Get input from the player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize the movement vector to ensure consistent movement speed in all directions
        movement.Normalize();
        _input = movement;
    }
}
