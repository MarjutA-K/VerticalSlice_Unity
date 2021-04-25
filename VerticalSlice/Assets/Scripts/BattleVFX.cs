using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleVFX : MonoBehaviour
{
    public GameObject[] vfx;

    private void Start()
    {
        for (int i = 0; i < vfx.Length; i++)
        {
            vfx[i].SetActive(false);
        }
        StartCoroutine(VFXBattle(0, 22.5f, 31));
        StartCoroutine(VFXBattle(1, 34.5f, 19));
        StartCoroutine(VFXBattle(2, 38f, 17.5f));
        StartCoroutine(VFXBattle(3, 56.5f, 6));
        StartCoroutine(VFXBattle(4, 56, 6f));
        StartCoroutine(VFXBattle(5, 68.5f, 19f));
        StartCoroutine(VFXBattle(6, 69f, 18.5f));
        StartCoroutine(VFXBattle(7, 77.5f, 10.5f));
        StartCoroutine(VFXBattle(8, 87, 22));
        StartCoroutine(VFXBattle(9, 88.5f, 25.5f));
    }

    IEnumerator VFXBattle(int i, float startTime, float finishTime)
    {
        yield return new WaitForSecondsRealtime(startTime);
        vfx[i].SetActive(true);

        yield return new WaitForSecondsRealtime(finishTime);
        vfx[i].SetActive(false);
    }

}
