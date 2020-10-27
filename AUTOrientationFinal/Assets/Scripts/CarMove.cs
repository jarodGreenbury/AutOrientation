using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentBreakForce;
    private bool isBreaking;

    public float motorForce;
    public float breakForce;
    public float maxSteerAngle;

    public WheelCollider FrontLeftWCollider;
    public WheelCollider FrontRightWCollider;
    public WheelCollider rearLeftWCollider;
    public WheelCollider rearRightWCollider;

    public Transform FrontLeftWheel;
    public Transform FrontRightWheel;
    public Transform rearLeftWheel;
    public Transform rearRightWheel;

    public void Update()
    {
        if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    public void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isBreaking = Input.GetKey(KeyCode.Space);

    }

    private void HandleMotor()
    {
        FrontLeftWCollider.motorTorque = (verticalInput * 5) * motorForce;
        FrontRightWCollider.motorTorque = (verticalInput * 5) * motorForce;
        currentBreakForce = isBreaking ? breakForce : 0f;
       
        FrontLeftWCollider.brakeTorque = currentBreakForce;
        FrontRightWCollider.brakeTorque = currentBreakForce;
        rearLeftWCollider.brakeTorque = currentBreakForce;
        rearRightWCollider.brakeTorque = currentBreakForce;

    }
    private void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        FrontLeftWCollider.steerAngle = currentSteerAngle;
        FrontRightWCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(FrontLeftWCollider, FrontLeftWheel);
        UpdateSingleWheel(FrontRightWCollider, FrontRightWheel);
        UpdateSingleWheel(rearLeftWCollider, rearLeftWheel);
        UpdateSingleWheel(rearRightWCollider, rearRightWheel);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }


}
