using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
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
        yield return new WaitForSecondsRealtime(18);
        movementScripts[0].enabled = true;

        // first death
        yield return new WaitForSecondsRealtime(13);
        SetDead(enemies[0]);
        
        // second death
        yield return new WaitForSecondsRealtime(6);
        SetDead(enemies[1]);

        // move to pos 2
        yield return new WaitForSecondsRealtime(16);
        movementScripts[0].enabled = false;
        movementScripts[1].enabled = true;

        // move to pos3
        yield return new WaitForSecondsRealtime(10);
        movementScripts[1].enabled = false;
        movementScripts[2].enabled = true;

        // fireball kill
        yield return new WaitForSecondsRealtime(25);
        SetDead(enemies[2]);
        SetDead(enemies[3]);
        SetDead(enemies[4]);

    }

    private void SetDead(GameObject deadObject)
    {
        deadObject.SetActive(false);
    }
}
