using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction direction;
    public CharacterController controller;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction.Enable();
    }

    private void OnDisable()
    {
        direction.Disable();
    }

    private void Update()
    {
        Vector2 inputVector = direction.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();
        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        controller.Move(finalVector * Time.deltaTime * 3.14f);
        if (finalVector != Vector3.zero)
        {
            gameObject.transform.forward = finalVector;
        }
    }
}
