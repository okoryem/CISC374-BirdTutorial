using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject cloud;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 6;
    public GameObject startScreen;
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud() {
        if (!startScreen.activeInHierarchy) {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
    }
}
