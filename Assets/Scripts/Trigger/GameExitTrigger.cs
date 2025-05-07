using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExitTrigger : MiniGameTrigger
{
    protected override void HandlerTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (triggerText != null)
            {
                triggerText.gameObject.SetActive(true);
                triggerText.text = "Press \"X\" To Game Exit";
            }
            isPlayerExit = true;
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

            isPlayerExit = false;
            Debug.Log("종료 나감");
        }
    }
}
