using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public float deadZone = -45;
    public float speedOffset = 10;
    void Start()
    {
        float scaler = Random.Range(1, 4);
        moveSpeed = Random.Range(8, 14);
        transform.localScale = new Vector3(scaler, scaler, scaler);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left *  moveSpeed) * Time.deltaTime;
        Debug.Log("Pipe Deleted");
        if (transform.position.x < deadZone) Destroy(gameObject);
    }
}
