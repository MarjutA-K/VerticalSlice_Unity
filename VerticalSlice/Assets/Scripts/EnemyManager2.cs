using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager2 : MonoBehaviour
{
    public FollowPath[] movementScripts;
    public GameObject[] enemies;
    public Slider soulMeter;

    private void Awake()
    {
        for (int i = 0; i < movementScripts.Length; i++)
        {
            movementScripts[i].enabled = false;
        }
    }
    private void Update()
    {
        StartCoroutine(FakeGameplay());
    }

    IEnumerator FakeGameplay()
    {
        // Move to pos1
        yield return new WaitForSecondsRealtime(32);
        movementScripts[0].enabled = true;

        // first death
        yield return new WaitForSecondsRealtime(11);
        SetDead(enemies[0]);

        // second death
        yield return new WaitForSecondsRealtime(4);
        SetDead(enemies[3]);

        // third death
        yield return new WaitForSecondsRealtime(3);
        SetDead(enemies[1]);

        // fourth death
        yield return new WaitForSecondsRealtime(3);
        SetDead(enemies[4]);

        // fifth death
        yield return new WaitForSecondsRealtime(2);
        SetDead(enemies[2]);
    }

    private void SetDead(GameObject deadObject)
    {
        deadObject.SetActive(false);
    }
}
