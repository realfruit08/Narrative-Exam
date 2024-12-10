using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Jeremy : MonoBehaviour
{
    float moveSpeed = 4.0f;
    float sprint = 2f;
    float crouch = 0.5f;
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
void Update()
 {
     spriteRenderer = GetComponent<SpriteRenderer>();
   
        if (Input.GetKey(KeyCode.LeftShift))
        { moveSpeed = 4.0f * sprint;

        }
        else
        { moveSpeed = 5f;

        }
        if (Input.GetKey(KeyCode.LeftControl))
        { moveSpeed = 4.0f * crouch;

        }
     if (Input.GetKey(KeyCode.A))
         spriteRenderer.flipX = true;
     else if (Input.GetKey(KeyCode.D))
         spriteRenderer.flipX = false;
      if (Input.GetKey(KeyCode.W))
     { transform.position += Vector3.up * Time.deltaTime * moveSpeed;
     }
     if (Input.GetKey(KeyCode.A))
     { transform.position += Vector3.left * Time.deltaTime * moveSpeed;
     }
     if (Input.GetKey(KeyCode.S))
     { transform.position += Vector3.down * Time.deltaTime * moveSpeed;
     }
     if (Input.GetKey(KeyCode.D))
     { transform.position += Vector3.right * Time.deltaTime * moveSpeed;
     }
     
 }
}
