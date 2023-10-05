using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // Add this line

public class SceneFreeze : MonoBehaviour
{
    public float freezeDuration = 3f;

    private void Start()
    {
        StartCoroutine(UnfreezeAfterDelay());
    }

    private IEnumerator UnfreezeAfterDelay()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(freezeDuration);
        Time.timeScale = 1f;
    }
}
