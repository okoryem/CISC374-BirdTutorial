using UnityEngine;

public class WingAnimation : MonoBehaviour
{
    public Sprite wingUp;
    public Sprite wingDown;
    public SpriteRenderer spriteRenderer;
    public float interval;
    private float timer = 0f;
    public Rigidbody2D wingBody;
    public GameObject startScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interval = 0.3f;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = wingUp;

        wingBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!startScreen.activeInHierarchy) {
            if (timer < interval) {
                timer += Time.deltaTime;
            } else {
                spriteRenderer.sprite = (spriteRenderer.sprite == wingUp) ? wingDown : wingUp;
                timer = 0;
            }
        }
    }
}
