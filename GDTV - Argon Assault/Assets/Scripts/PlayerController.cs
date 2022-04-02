using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float xRange = 5f;
    
    [SerializeField] float controlSpeed = 30f;
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
    }

    void ProcessRotation(){


        transform.localRotation = Quaternion.Euler(-30f,30f,0f);

    }
    void UserInput(){


            float xThrow = Input.GetAxis("Horizontal");
            float yThrow = Input.GetAxis("Vertical");
            float rawXPos = xThrow * Time.deltaTime * controlSpeed;
            float rawYPos = yThrow * Time.deltaTime * controlSpeed;

            float clampedXpos = Mathf.Clamp(rawXPos,-xRange,xRange);
            float clampedYPos = Mathf.Clamp(rawYPos, -xRange, xRange);

            transform.localPosition = new Vector3(clampedXpos,
            clampedYPos,transform.localPosition.z);

    }


}
