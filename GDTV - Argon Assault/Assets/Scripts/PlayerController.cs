using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UserInput();
    }

    void OnEnable() {
        movement.Enable();
    }
     void OnDisable() {
        movement.Disable();
    }
    void UserInput(){


            float horizontalThrow = movement.ReadValue<Vector2>().x;
            float verticalThrow = movement.ReadValue<Vector2>().y;

    }


}
