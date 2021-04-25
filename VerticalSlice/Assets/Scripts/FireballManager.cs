using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballManager : MonoBehaviour
{
    public GameObject fireball;
    public FollowPath moveScript;

    private void Start()
    {
        moveScript.enabled = false;
        StartCoroutine(FakeGameplay());
    }

    

    IEnumerator FakeGameplay()
    {
        yield return new WaitForSecondsRealtime(87);
        moveScript.enabled = true;
        yield return new WaitForSecondsRealtime(4);
        gameObject.SetActive(false);
    }
}
