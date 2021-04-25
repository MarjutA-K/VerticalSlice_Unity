using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager1 : MonoBehaviour
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
        yield return new WaitForSecondsRealtime(3);
        tower.enabled = true;
        slider.enabled = true;
    }
    IEnumerator Dead()
    {
        yield return new WaitForSecondsRealtime(53);
        towerObj.SetActive(false);
    }

    IEnumerator HealthBar()
    {
        yield return new WaitForSecondsRealtime(3);
        canvas.enabled = true;
        yield return new WaitForSecondsRealtime(28f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3f);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2f);
        slider.value -= 10;
    }
}
