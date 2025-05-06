using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MiniGameTrigger : MonoBehaviour
{
    public TextMeshProUGUI triggerText;

    protected bool isPlayerInRange = false;
    protected bool isPlayerExit = false;
    protected bool canPressF = false;
    protected bool canPressX = false;

    protected string loadSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandlerTriggerEnter(collision);
    }

    protected virtual void HandlerTriggerEnter(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("인식");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        HandlerTriggerExit(collision);
    }

    protected virtual void HandlerTriggerExit(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Debug.Log("나감");
        }
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(loadSceneName);
        }

        if (isPlayerExit && Input.GetKeyDown(KeyCode.X))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
        }
    }
}