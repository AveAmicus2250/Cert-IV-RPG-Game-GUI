﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

    [Header("MOVEMENT VARIABLES")]
    [Space(100)]
    [Header("Mini Header")]
    [Range(0f, 10f)]
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float maxForwardSpeed;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    private void Start()
    {
        controller = this.GetComponent<CharacterController>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

     



    }
}
