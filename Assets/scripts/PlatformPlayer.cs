using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayer : MonoBehaviour
{
    public LayerMask mascaraSuelo;
    public float rayDistance = 1.5f;
    private Rigidbody2D rb;
    private Animator animator;
    SpriteRenderer rend;
    public float fuerzasalto = 200;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("runanimation");
            rend.flipX = true;
            rb.velocity = new Vector3(-10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("runanimation");
            rend.flipX = false;
            rb.velocity = new Vector3(10, 0, 0);
        }
        else
        {
            animator.Play("idleAnimation");
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector2(0, fuerzasalto));
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D resultado = Physics2D.Raycast(transform.position, 
            Vector2.down, rayDistance, mascaraSuelo.value);

        if (resultado)
        {
            Debug.Log(resultado.collider.gameObject.name);
            //if (resultado.collider.gameObject.CompareTag("suelo"))
           // {
                return true;
            //}
        }

        return false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }
} 
