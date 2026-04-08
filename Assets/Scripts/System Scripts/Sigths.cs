using UnityEngine;
using UnityEngine.InputSystem;

public class Sigths : MonoBehaviour
{
    //cooldown between shots
    public float cooldownTime;
    public bool cooldown;

    // Speed for the sigths movement
    private float speed = 10;

    //Vector for sigths movement
    public Vector2 movement;

    //public AudioSource SFX;

    // reference for the sprite and particles
    public SpriteRenderer SpriteRenderer;
    public ParticleSystem ParticleSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // add movement
        transform.position += (Vector3)movement * speed * Time.deltaTime;

    }
    // Input system for movement (WASD or arrow keys)
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    // "Shoot" on presing space
    public void OnJump(InputAction.CallbackContext context)
    {
        
        //changes color and plays particles when pressed and the cooldown is false
        if (context.started && !cooldown)
        {
            cooldown = true;
            //StartCoroutine()
            SpriteRenderer.color = Color.red;
            ParticleSystem.Play();
            
        }
        // changes back to green
        else
        {
            SpriteRenderer.color = Color.green;
        }
    }
}
