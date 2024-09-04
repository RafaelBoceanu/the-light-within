using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    [SerializeField]
    Canvas gameWinCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.visible = true;
            gameWinCanvas.gameObject.SetActive(true);
            StartCoroutine(Replay());
        }
    }

    IEnumerator Replay()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(0);
        Cursor.visible = false;
    }
}
