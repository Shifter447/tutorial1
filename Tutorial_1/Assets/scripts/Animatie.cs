using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
         animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            animator.SetTrigger("start_dance");
        }
    }
}
