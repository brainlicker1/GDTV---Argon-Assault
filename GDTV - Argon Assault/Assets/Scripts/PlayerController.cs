using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float xRange = 5f;
    
    [SerializeField] float controlSpeed = 30f;
    [SerializeField] float pitchFactor = -2f;
    [SerializeField] float controlPitchFactor = -15f;
    [SerializeField] float positionYawFactor = -2f;
    [SerializeField] float controlRollFactor = -3;

    [SerializeField] GameObject[] lazers;
    float yThrow;
    float xThrow;
     
    void OnEnable() {
        movement.Enable();
    }
    
     void OnDisable() {
        movement.Disable();
    }
    
        
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UserInput();
        ProcessRotation();
        ProcessFiring();
    }

    void ProcessRotation(){
        float pitch = transform.localPosition.y * pitchFactor +
         yThrow * controlPitchFactor;
        float yaw = transform.localPosition.x * positionYawFactor;
        float  roll = xThrow * controlRollFactor;

        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);

    }
    void UserInput(){


          xThrow = Input.GetAxis("Horizontal");
           yThrow = Input.GetAxis("Vertical");
            float rawXPos = xThrow * Time.deltaTime * controlSpeed;
            float rawYPos = yThrow * Time.deltaTime * controlSpeed;

            float clampedXpos = Mathf.Clamp(rawXPos,-xRange,xRange);
            float clampedYPos = Mathf.Clamp(rawYPos, -xRange, xRange);

            transform.localPosition = new Vector3(clampedXpos,
            clampedYPos,transform.localPosition.z);

    }

    void ProcessFiring()   {

        if(Input.GetButton("Fire1")) {
            ActivateLazers();
        } else {
             DeactivateLazers();}

    }
    void ActivateLazers(){

        foreach (GameObject lazer in lazers)
        {
            lazer.SetActive(true);
        }

    }
    void DeactivateLazers(){

        foreach (GameObject lazer in lazers)
        {
            lazer.SetActive(false);
        }
    }
}
