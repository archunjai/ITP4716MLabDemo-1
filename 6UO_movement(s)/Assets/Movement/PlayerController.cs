using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private Vector2 movementInput;
    public Vector2 rotateInput;

    private void Update()
    {
        if (movementInput.x > 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            transform.Translate(new Vector3(movementInput.y, 0, movementInput.x) * speed * Time.deltaTime);
        }
        if (movementInput.x < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            transform.Translate(new Vector3(movementInput.y, 0, -movementInput.x) * speed * Time.deltaTime);
        }

        if (movementInput.y > 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.Translate(new Vector3(movementInput.x, 0, movementInput.y) * speed * Time.deltaTime);
        }
        if (movementInput.y < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            transform.Translate(new Vector3(movementInput.x, 0, -movementInput.y) * speed * Time.deltaTime);
        }
            
        
    }

        public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>();
}
