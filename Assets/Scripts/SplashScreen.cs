using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    static bool hasBeenShown = false;

    Animator animator;

    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject title;
    [SerializeField]
    GameObject slogan;
    [SerializeField]
    GameObject concept;

    // Start is called before the first frame update
    private void Awake()
    {
        if (hasBeenShown) {
            gameObject.SetActive(false);
        }

        hasBeenShown = true;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Splash());
    }
    
    IEnumerator Splash()
    {
        animator.Play("TitleAnim");
        yield return new WaitForSeconds(3f);
        title.SetActive(false);
        animator.Play("SloganAnim");
        yield return new WaitForSeconds(3f);
        slogan.SetActive(false);
        animator.Play("ConceptAnim");
        yield return new WaitForSeconds(3f);
        concept.SetActive(false);
        animator.Play("SplashBackgroundAnim");
        yield return new WaitForSeconds(3f);
        background.SetActive(false);
        yield return new WaitForSeconds(16f);
        this.gameObject.SetActive(false);

    }
}
