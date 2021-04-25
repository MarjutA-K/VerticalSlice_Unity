using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager3 : MonoBehaviour
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
        // move to position 1
        yield return new WaitForSecondsRealtime(31);
        movementScripts[0].enabled = true;

        // first death
        yield return new WaitForSecondsRealtime(15);
        SetDead(enemies[3]);
        
        // second death
        yield return new WaitForSecondsRealtime(6);
        SetDead(enemies[1]);

        // move to position 2
        yield return new WaitForSecondsRealtime(1);
        movementScripts[0].enabled = false;
        movementScripts[1].enabled = true;

        // third death
        yield return new WaitForSecondsRealtime(8);
        SetDead(enemies[2]);

        // move to position 3
        yield return new WaitForSecondsRealtime(2);
        movementScripts[1].enabled = false;
        movementScripts[2].enabled = true;

        // fireball death
        yield return new WaitForSecondsRealtime(25);
        SetDead(enemies[0]);
        SetDead(enemies[4]);
    }

    private void SetDead(GameObject deadObject)
    {
        deadObject.SetActive(false);
    }
}
