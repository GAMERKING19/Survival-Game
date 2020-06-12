using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public ParticleSystem dust;
    public float moveSpeed = 5f;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            CreateDust();
            float jumpVelocity = 6f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CreateDust();
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.RightArrow))
        {
            CreateDust();
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platform);
        
        return raycastHit2d.collider != null;
    }

    void CreateDust()
    {
        dust.Play();
    }
}