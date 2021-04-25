using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public Text text;

    private void Start()
    {
        StartCoroutine(FillBar());
    }

    IEnumerator FillBar()
    {
        // death 1
        yield return new WaitForSecondsRealtime(31);
        slider.value += 10;
        text.text = "10/100";

        // death 2
        yield return new WaitForSecondsRealtime(6);
        slider.value += 10;
        text.text = "20/100";

        // death 3
        yield return new WaitForSecondsRealtime(6);
        slider.value += 10;
        text.text = "30/100";

        // death 4
        yield return new WaitForSecondsRealtime(3);
        slider.value += 10;
        text.text = "40/100";

        // death 5
        yield return new WaitForSecondsRealtime(1);
        slider.value += 10;
        text.text = "50/100";

        // death 6
        yield return new WaitForSecondsRealtime(3);
        slider.value += 10;
        text.text = "60/100";

        // death 7
        yield return new WaitForSecondsRealtime(2);
        slider.value += 10;
        text.text = "70/100";

        // death 8
        yield return new WaitForSecondsRealtime(1);
        slider.value += 10;
        text.text = "80/100";

        // death 9
        yield return new WaitForSecondsRealtime(2);
        slider.value += 10;
        text.text = "90/100";

        // death 10
        yield return new WaitForSecondsRealtime(6);
        slider.value += 10;
        text.text = "100/100";

        // fireball reset
        yield return new WaitForSecondsRealtime(27);
        slider.value = 0;
        text.text = "0/100";

        // death 11
        yield return new WaitForSecondsRealtime(5);
        slider.value += 10;
        text.text = "10/100";

        // death 12
        yield return new WaitForSecondsRealtime(4);
        slider.value += 10;
        text.text = "20/100";

        // death 13
        yield return new WaitForSecondsRealtime(2);
        slider.value += 10;
        text.text = "30/100";

        // death 14
        yield return new WaitForSecondsRealtime(3);
        slider.value += 10;
        text.text = "40/100";

        // death 15
        yield return new WaitForSecondsRealtime(3);
        slider.value += 20;
        text.text = "60/100";

        // death 16
        yield return new WaitForSecondsRealtime(3);
        slider.value += 10;
        text.text = "70/100";

        // death 17
        yield return new WaitForSecondsRealtime(1);
        slider.value += 10;
        text.text = "80/100";

        // death 18
        yield return new WaitForSecondsRealtime(3);
        slider.value += 10;
        text.text = "90/100";

        // death 19
        yield return new WaitForSecondsRealtime(2);
        slider.value += 10;
        text.text = "100/100";
    }

}
