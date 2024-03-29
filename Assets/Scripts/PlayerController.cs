using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    //Set up variables
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float speed;
    [SerializeField] float rpm;
    [SerializeField] private float horsePower = 20000;
    [SerializeField] private float turnSpeed = 32.0f;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody playerRb;
    
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (IsOnGround())
        {
            // Move the vehicle forward based on vertical input
            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            // Rotates the vehicle based on horizontal input
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

            speed = Mathf.Round(playerRb.velocity.magnitude * 3.6f); //2.237 for Mph
            speedometerText.SetText("Speed: " + speed + " km/h");

            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }

        bool IsOnGround()
        {
            wheelsOnGround = 0;

            foreach (WheelCollider wheel in allWheels)
            {
                if (wheel.isGrounded)
                {
                    wheelsOnGround++;
                }
            }

            if (wheelsOnGround == 4)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
