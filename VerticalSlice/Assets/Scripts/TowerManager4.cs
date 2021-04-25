using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager4 : MonoBehaviour
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
    }

    IEnumerator FakeGameplay()
    {
        yield return new WaitForSecondsRealtime(6);
        tower.enabled = true;
    }

    IEnumerator HealthBar()
    {
        yield return new WaitForSecondsRealtime(6);
        canvas.enabled = true;
        yield return new WaitForSecondsRealtime(84);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(2);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(1);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(4);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(4);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;
        yield return new WaitForSecondsRealtime(3);
        slider.value -= 10;   
    }

}
