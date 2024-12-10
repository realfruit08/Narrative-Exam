using UnityEngine;

public class Opal : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        float moveSpeed = 5.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            spriteRenderer.flipX = false;
        else if (Input.GetKey(KeyCode.RightArrow))
            spriteRenderer.flipX = true;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }

    }
}

