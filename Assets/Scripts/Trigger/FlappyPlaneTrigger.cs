using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyPlaneTrigger : MiniGameTrigger
{
    private void Start()
    {
        loadSceneName = "FlappyPlaneScene";
    }

    protected override void HandlerTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("비행기");
        }
    }

    protected override void HandlerTriggerExit(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("비행기 나감");
        }
    }
}
