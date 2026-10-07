using UnityEngine;

public class MoveWithTime : MonoBehaviour
{
    public float speed = 20f;

    void Start()
    {

    }

    void Update()
    {
        // Moves in the -Z direction (Local Space)
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}