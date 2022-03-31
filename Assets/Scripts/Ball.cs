using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialSpeed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float currentSpeed;

    // Start is called before the first frame update
    void Start(){
        Launch();
    }

    public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch(){
        currentSpeed = initialSpeed;
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(currentSpeed * x,currentSpeed * y);
    }

}
