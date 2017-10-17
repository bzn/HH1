using UnityEngine;

public class Scroller : MonoBehaviour
{
    private float count = 3;
    private float speed = 100;
    private float wrapPoint = 400;
    public float position;

    void Start()
    {
        position = Vector3.Dot(transform.position, transform.forward);
    }

    void Update()
    {
        position += Time.deltaTime * speed;

        if (position > wrapPoint) position -= wrapPoint * count;

        transform.position = transform.forward * position;
    }
}
