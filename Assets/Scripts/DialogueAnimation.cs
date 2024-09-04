using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimation : MonoBehaviour
{
    public Animator animator;

    private GameObject dialogueTwo;
    private GameObject dialogueThree;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogueTwo = GameObject.Find("Dialogue 2");
        dialogueThree = GameObject.Find("Dialogue 3");
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueTwo.activeInHierarchy)
        {
            animator.SetBool("isSmiling", true);
        }
        if (dialogueThree.activeInHierarchy)
        {
            animator.SetBool("isSmiling", false);
            animator.SetBool("isFrowning", true);
        }
    }
}
