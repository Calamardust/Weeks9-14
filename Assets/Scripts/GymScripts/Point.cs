using Unity.Cinemachine;
using Unity.Mathematics;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;
public class Point : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource SFX;
    public ParticleSystem ParticleSystem;

    public float speed = 5;
    public Vector2 movement;
    public Vector2 mousePos;
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
            if (movement.x < 0)
            {
                spriteRenderer.flipX = true;
                ParticleSystem.transform.localScale = new Vector3(-1, 1, 1);

            }
            else
            {
                spriteRenderer.flipX = false;
                ParticleSystem.transform.localScale = new Vector3(1, 1, 1);
            }
        }
    

    public void Onpoint(InputAction.CallbackContext context)
    {
        mousePos = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
    public void OnClick(InputAction.CallbackContext contex)
    {
        if (contex.performed == true)

        {
            if (Vector2.Distance(transform.position, mousePos) > 0)
            {
                movement = mousePos;
            }
            else
            {
                movement = Vector2.zero;
            }
        }
       
        
    }

    public void Footstep()
    {
        
        SFX.Play();
        ParticleSystem.Play();

    }
}
// The player still moves in weird ways
