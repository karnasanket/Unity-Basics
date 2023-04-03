using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

void Update()
{
    Vector3 pos = transform.position;

    // "w" can be replaced with any key
    // this section moves the character up
    if (Input.GetKey("w"))
    {
        pos.y += speed * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    // "s" can be replaced with any key
    // this section moves the character down
    if (Input.GetKey("s"))
    {
        pos.y -= speed * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // "d" can be replaced with any key
    // this section moves the character right
    if (Input.GetKey("d"))
    {
        pos.x += speed * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = Color.blue;
    }

    // "a" can be replaced with any key
    // this section moves the character left
    if (Input.GetKey("a"))
    {
        pos.x -= speed * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    transform.position = pos;
}
}
