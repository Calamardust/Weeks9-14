using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knigth : MonoBehaviour
{
    public AudioSource SFX;
    public ParticleSystem ParticleSystem;

    public float speed = 5;
    public Vector2 movement;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        animator.SetFloat("Speed", movement.magnitude);
        if(movement.x < 0)
        {
            spriteRenderer.flipX = true;
            ParticleSystem.transform.rotation = Quaternion.identity;
            
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void Footstep()
    {
        //Debug.Log("step");
        SFX.Play();
        ParticleSystem.Play();
        
    }
}
