using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager6 : MonoBehaviour
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
        // move to position one
        yield return new WaitForSecondsRealtime(75);
        movementScripts[0].enabled = true;

        // first kill
        yield return new WaitForSecondsRealtime(22);
        SetDead(enemies[1]);

        // second kill
        yield return new WaitForSecondsRealtime(8);
        SetDead(enemies[3]);

        // third kill
        yield return new WaitForSecondsRealtime(3);
        SetDead(enemies[2]);

        // fourth kill
        yield return new WaitForSecondsRealtime(4);
        SetDead(enemies[0]);

        // fifth kill
        yield return new WaitForSecondsRealtime(2);
        SetDead(enemies[4]);
    }

    private void SetDead(GameObject deadObject)
    {
        deadObject.SetActive(false);
    }
}
