using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class HankTalking : MonoBehaviour
{
    bool cantalk = false;
    public DialogueRunner runner;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.F) && cantalk)
        { runner.Stop();
          runner.StartDialogue("Hank");
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        cantalk = false;
    }
    private void OnTriggerEnter2D(Collider2D othercollider)
    {
        if (othercollider.gameObject.name == ("Jeremy"))
        { cantalk = true;
        }
        else
        {  cantalk = false;
        }
    }
    


}
