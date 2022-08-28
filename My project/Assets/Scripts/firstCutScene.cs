using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstCutScene : MonoBehaviour
{
    public Animator camAnim;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            camAnim.SetBool("cutScene1", true);
            Invoke(nameof(StopCutScene), 3f);
           
            
        }

    }

    void StopCutScene()
    {
        
        camAnim.SetBool("cutScene1", false);

    }
}
