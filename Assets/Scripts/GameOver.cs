using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject gameOverCanvas;

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    IEnumerator Replay()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(0);
        Cursor.visible = false;
    }
}
