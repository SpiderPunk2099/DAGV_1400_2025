using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = 0f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    private void Start()

    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        //something here isnt working, in if statement
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {

            System.Console.WriteLine("is jumping");
            velocity.y += gravity * Time.deltaTime;
        }
    }

    private void ApplyGravity()

    {
        if (!controller.isGrounded)

        {
            velocity.y += gravity * Time.deltaTime;
            System.Console.WriteLine("is falling");
        }

        else
        {
            velocity.y = 0f;

        }

        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}