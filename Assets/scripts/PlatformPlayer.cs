using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformPlayer : MonoBehaviour
{
    public LayerMask mascaraSuelo;
    //

    public float rayDistance = 1.5f;
    private Rigidbody2D rb;
    private Animator animator;
    SpriteRenderer rend;
    public float fuerzasalto = 200;
    public string boolWalk = "boolWalk";
    public float slide = 0f;
    float dir = 1;

    public AudioClip jumpSound;
    [Range(0, 1)]
    public float jumpVolume;
    //private void OnDestroy() //declaramos metedo para cuando se destruya hacer algo
    //{
    //    SceneManager.LoadScene("GameOver"); //resetear la escena
    //}

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
            animator.SetBool(boolWalk, true);
            rend.flipX = true;
            rb.velocity = new Vector3(-10, rb.velocity.y, 0);
            dir = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool(boolWalk, true);
            rend.flipX = false;
            rb.velocity = new Vector3(10, rb.velocity.y, 0);
            dir = 1;
        }
        else
        {
            animator.SetBool(boolWalk, false);
            rb.velocity = new Vector3(slide * dir, rb.velocity.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            animator.Play("jumpanimation");
            rb.AddForce(transform.up * fuerzasalto * rb.gravityScale);

            AudioManager.instance.PlayAudio(jumpSound, jumpVolume);
        }

    }

    ////evento
    //void ChangeSpriteColor(int r)
    //{
    //    rend.color = Color.blue;
    //    Debug.Log(r);
    //}

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

    //void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    //}
}
