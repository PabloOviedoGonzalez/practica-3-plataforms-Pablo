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
    private SpriteRenderer rend;
    public float fuerzasalto = 200;
    public string boolWalk = "boolWalk";
    public float slide = 0f;
    float dir = 1;

    //doblesalto
    private int numSaltos = 2;  //cantidad de saltos extra q tenemos en una variable
    private int numSaltosV;     //variable para guardar la cantidad de saltos de la anterior variable para
                                // poder modificarlo constantemente pero pudiendo volver a la original con la anterior variable

    public AudioClip jumpSound;
    [Range(0, 1)]
    public float jumpVolume;


    public AudioClip lavaSound;
    [Range(0, 1)]
    public float lavaVolume;
    //private void OnDestroy() //declaramos metedo para cuando se destruya hacer algo
    //{
    //    SceneManager.LoadScene("GameOver"); //resetear la escena
    //}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Lava>())
        {
            GetComponent<PlatformPlayer>().animator.Play("burn");
            AudioManager.instance.PlayAudio(lavaSound, lavaVolume);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        numSaltosV = numSaltos; // guardamos el valor de la prmera variable en la variable aux
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

        if (IsGrounded())  // aquí le decimos q cada vez q player toque el suelo la varable aux se vuelva a igualar
                           // a la primera variable para q se reinicie el doble salto y se pueda volver a realizar.
        {
            numSaltosV = numSaltos;
        }

        if (Input.GetKeyDown(KeyCode.Space) && numSaltosV > 0)//con numSaltosV decimos q si es mayor a 0 salta y si no no salta      //IsGrounded()) 
        {
            animator.Play("jumpanimation");
            rb.AddForce(transform.up * fuerzasalto * rb.gravityScale);

            AudioManager.instance.PlayAudio(jumpSound, jumpVolume);

             numSaltosV--; // disminuimosen uno el valor cada vez q de un salto para q solo pueda dar dos
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

    void ChangeScene(string name)
    {
        GameManager.instance.ChangeScene("GameOver");
    }


    //public void ChangeColor()
    //{
    //    Destroy.GameObject;
    //    rend.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    //}
}
