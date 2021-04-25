using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager3 : MonoBehaviour
{
    public GameObject towerObj;
    public SpriteRenderer tower;
    public Slider slider;
    public Canvas canvas;

    private void Start()
    {
        tower.enabled = false;
        canvas.enabled = false;
        StartCoroutine(HealthBar());
    }

    private void FixedUpdate()
    {
        StartCoroutine(FakeGameplay());
        StartCoroutine(Dead());
    }

    IEnumerator FakeGameplay()
    {
        yield return new WaitForSecondsRealtime(9);
        tower.enabled = true;
    }
    IEnumerator Dead()
    {
        yield return new WaitForSecondsRealtime(62);
        towerObj.SetActive(false);
    }

    IEnumerator HealthBar()
    {
        yield return new WaitForSecondsRealtime(9);
        canvas.enabled = true;
        yield return new WaitForSecondsRealtime(32);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(4);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
    }
}
