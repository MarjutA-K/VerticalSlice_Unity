using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager4 : MonoBehaviour
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
        yield return new WaitForSecondsRealtime(74);
        movementScripts[0].enabled = true;

        // fireball kill
        yield return new WaitForSecondsRealtime(14);
        for (int i = 0; i < enemies.Length; i++)
        {
            SetDead(enemies[i]);
        }
    }

    private void SetDead(GameObject deadObject)
    {
        deadObject.SetActive(false);
    }
}
