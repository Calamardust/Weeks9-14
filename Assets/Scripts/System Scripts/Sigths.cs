using UnityEngine;
using UnityEngine.InputSystem;

public class Sigths : MonoBehaviour
{
    private float speed = 10;
    public Vector2 movement;
    //public AudioSource SFX;
    public SpriteRenderer SpriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;

    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("attack" + context.phase);
        if (context.started == true)
        {
          SpriteRenderer.color = Color.blue;
            //corutine or timer
        }
        
    }
}
