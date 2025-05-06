using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MiniGameTrigger
{
    private void Start()
    {
        loadSceneName = "StackScene";
    }

    protected override void HandlerTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("스택");
        }
    }

    protected override void HandlerTriggerExit(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("스택 나감");
        }
    }
}
