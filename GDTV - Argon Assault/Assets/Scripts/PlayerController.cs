using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float xDistance;
    [SerializeField] float yDistance;
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
    }

    
    void UserInput(){


            float xThrow = movement.ReadValue<Vector2>().x;
            float yThrow = movement.ReadValue<Vector2>().y;

            float newXPos = transform.localPosition.x + xDistance;
            float newYPos = transform.localPosition.y + yDistance;

            transform.localPosition = new Vector3(newXPos,
            newYPos,transform.localPosition.z);

    }


}
