using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager2 : MonoBehaviour
{
    public GameObject tower1;
    public SpriteRenderer tower;
    public FollowPath movementScripts;
    public Slider slider;
    public Canvas canvas;

    private void Start()
    {
        tower.enabled = false;
        movementScripts.enabled = false;
        canvas.enabled = false;
        StartCoroutine(HealthBar());
    }

    private void FixedUpdate()
    {
        StartCoroutine(FakeGameplay());
        StartCoroutine(Reposition());
        StartCoroutine(TowerDestroy());
    }

    IEnumerator FakeGameplay()
    {
        yield return new WaitForSecondsRealtime(12);
        tower.enabled = true;
    }
    IEnumerator Reposition()
    {
        yield return new WaitForSecondsRealtime(93);
        movementScripts.enabled = true;
    }

    IEnumerator TowerDestroy()
    {
        yield return new WaitForSecondsRealtime(107);
        tower1.SetActive(false);
    }

    IEnumerator HealthBar()
    {
        yield return new WaitForSecondsRealtime(12);
        canvas.enabled = true;
        yield return new WaitForSecondsRealtime(60);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(5);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 5;
        yield return new WaitForSecondsRealtime(4);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
    }
}
