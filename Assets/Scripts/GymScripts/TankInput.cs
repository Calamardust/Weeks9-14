using UnityEngine;
using UnityEngine.InputSystem;

public class TankInput : MonoBehaviour
{

    public float MovementSpeed = 5;
    public Vector2 movement;
    public float RotationSpeed = 1;
    public Vector3 rotation;
    public Transform barrel;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * MovementSpeed * Time.deltaTime;


        Vector3 newRotation = barrel.eulerAngles;
        newRotation.z += rotation.y * 50 * Time.deltaTime;
        barrel.eulerAngles = newRotation;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        rotation = context.ReadValue<Vector2>();
    }
}
