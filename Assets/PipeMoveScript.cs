using System;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -45;
    public float timer = 0f;
    public float interval = 0.05f;
    private bool pipeDirect = true;
    public float directionTimer = 0f;
    public float directionInterval = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        
        if (transform.position.x < deadZone) Destroy(gameObject);

        if (timer < interval) {
            timer += Time.deltaTime;
        } else {
            if (pipeDirect) {
                transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
                timer = 0;
            } else {
                transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
                timer = 0;
            }
        }

        if (directionTimer < directionInterval) {
            directionTimer += Time.deltaTime;
        } else {
            pipeDirect = !pipeDirect;
            directionTimer = 0;
        }
    }
}
