using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawnerScript : MonoBehaviour
{
    public GameObject goodApple;
    public GameObject badApple;
    public float heightOffset = 8;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnGoodApple", 0f, 0.8f);
        InvokeRepeating("spawnBadApple", 0f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnGoodApple()   
    {
        float leftMax = transform.position.x - heightOffset;
        float rightMax = transform.position.x + heightOffset;
        
        Instantiate(goodApple, new Vector3(Random.Range(leftMax, rightMax), transform.position.y + 5, 0), transform.rotation);
        
    }
    void spawnBadApple()
    {
        float leftMax = transform.position.x - heightOffset;
        float rightMax = transform.position.x + heightOffset;

        Instantiate(badApple, new Vector3(Random.Range(leftMax, rightMax), transform.position.y + 5, 0), transform.rotation);
    }
}
