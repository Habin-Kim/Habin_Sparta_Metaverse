using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
            if (triggerText != null && !isPlayerInRange)
            {
                triggerText.gameObject.SetActive(true);
                triggerText.text = "Press \"F\" To Stack Start";
            }
            isPlayerInRange = true;
        }
    }

    protected override void HandlerTriggerExit(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (triggerText != null)
            {
                triggerText.gameObject.SetActive(false);
            }

            isPlayerInRange = false;
            Debug.Log("스택 나감");
        }
    }
}
