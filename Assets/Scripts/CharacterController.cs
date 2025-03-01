using UnityEngine;



public class CharacterController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public audioScript audios;
    public bool birdIsAlive = true;
    public float yOffScreen = -14;
    public GameObject startScreen;
    public AudioSource flapSrc;
    public AudioClip flapSound;
    public AudioSource hitPipeSrc;
    public AudioClip hitPipeSound;
    public WingAnimation wings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody.gravityScale = 0;
        wings.wingBody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startScreen.activeInHierarchy) {
            myRigidbody.gravityScale = 3;
            wings.wingBody.gravityScale = 3;
            //wings.flap();
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true && !startScreen.activeInHierarchy) {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            wings.wingBody.linearVelocity = Vector2.up * flapStrength;
            flapSrc.clip = flapSound;
            flapSrc.Play();
            //wings.flap();
        }

        if(transform.position.y < yOffScreen) {
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitPipeSrc.clip = hitPipeSound;
        hitPipeSrc.Play();
        logic.gameOver();
        birdIsAlive = false;
    }
}
