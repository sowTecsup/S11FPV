using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float amplitude = 1f;
    public float speed = 2f;
    private float initialY;

    public Transform target;

    void Start()
    {
        initialY = transform.position.y;      
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GetTarget();
        float newY = initialY + Mathf.Sin(speed * Time.time) * amplitude;

        transform.position =  new Vector3(transform.position.x, newY, transform.position.z);
    }

    public Transform GetTarget()
    {

        return GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
}
