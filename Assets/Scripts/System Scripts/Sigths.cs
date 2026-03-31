using UnityEngine;
using UnityEngine.InputSystem;

public class Sigths : MonoBehaviour
{
    public float cooldownTime;

    public bool cooldown;

    private float speed = 10;

    public Vector2 movement;

    //public AudioSource SFX;

    public SpriteRenderer SpriteRenderer;

    public ParticleSystem ParticleSystem;

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
    public void OnJump(InputAction.CallbackContext context)
    {
        
        
        if (context.performed && !cooldown)
        {
            cooldown = true;
            //StartCoroutine()
            SpriteRenderer.color = Color.red;
            ParticleSystem.Play();
            
        }
        else
        {
            SpriteRenderer.color = Color.green;
        }
    }
}
