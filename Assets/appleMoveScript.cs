using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class appleMoveScript : MonoBehaviour
{
    public float moveSpeed = 3;
    public double deadZone = -6.5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        
        if (transform.position.y < deadZone)
        {
            Debug.Log("Apple Deleted");
            Destroy(gameObject);
        }
    }
}
