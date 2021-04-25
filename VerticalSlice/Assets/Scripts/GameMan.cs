using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMan : MonoBehaviour
{
    [Header("Towers")]
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;
    public GameObject tower4;
    
    [Header("Enemy Group 1")]
    public Transform enemy1G1;
    public GameObject enemy2G1;
    public GameObject enemy3G1;

    public GameObject target1G1;
    public GameObject target2G1;
    public GameObject target3G1;

    public float speedG1 = 3f;
    
    [Header("Enemy Group 2")]
    public GameObject enemy1G2;
    public GameObject enemy2G2;
    public GameObject enemy3G2;
    public GameObject enemy4G2;

    public GameObject target1G2;
    public GameObject target2G2;
    public GameObject target3G2;
    public GameObject target4G2;
    public GameObject target5G2;
    public GameObject target6G2;

    public float speedG2 = 3f;
    
    [Header("Enemy Group 3")]
    public GameObject enemy1G3;
    public GameObject enemy2G3;
    public GameObject enemy3G3;
    public GameObject enemy4G3;

    public GameObject target1G3;
    public GameObject target2G3;
    public GameObject target3G3;
    public GameObject target4G3;

    public float speedG3 = 3f;

    //[Header("Groups")]
    //public Transform group1;
    //public Transform group2;
    //public Transform group3;

    //public float speed = 3f;

    [Header("Targets/Triggers")]
    public Transform target1;
    public Transform target2;
    public bool transition1;
    public bool transition2;

    [Header("UI text/img")]
    public Text nextWaveText;
    public Image nextWaveBG;

    public Text spellRdyText;
    public Image spellBG;

    private void Awake()
    {
        nextWaveBG.enabled = false;
        nextWaveText.enabled = false;

        spellRdyText.enabled = false;
        spellBG.enabled = false;


    }

    private void Update()
    {
        if (!transition1)
        {
            enemy1G1.position = Vector2.MoveTowards(new Vector2(enemy1G1.position.x, enemy1G1.position.y), target1.position, speedG1 * Time.deltaTime);

            
        }
        if (!transition2)
        {
            enemy1G1.position = Vector2.MoveTowards(new Vector2(enemy1G1.position.x, enemy1G1.position.y), target2.position, speedG1 * Time.deltaTime);
        }



    }

    private void FixedUpdate()
    {
        
    }

    IEnumerator FakeGame()
    {
        StartCoroutine(GroupOneMove());
        yield return new WaitForSecondsRealtime(7);
        StartCoroutine(GroupOneDeath());

        // next wave inc

        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(GroupTwoMove());
        yield return new WaitForSecondsRealtime(4);
        StartCoroutine(GroupTwoDeath());
        //StartCoroutine(GroupThreeMove());

    }

    IEnumerator GroupOneMove()
    {
        yield return new WaitForSecondsRealtime(0);

        Vector2 enemy1G1Pos = new Vector2(enemy1G1.transform.position.x, enemy1G1.transform.position.y);
        Vector2 enemy2G1Pos = new Vector2(enemy2G1.transform.position.x, enemy2G1.transform.position.y);
        Vector2 enemy3G1Pos = new Vector2(enemy3G1.transform.position.x, enemy3G1.transform.position.y);

        enemy1G1.transform.position = Vector2.MoveTowards(enemy1G1Pos, target1G1.transform.position, speedG1 * Time.deltaTime);
        enemy2G1.transform.position = Vector2.MoveTowards(enemy2G1Pos, target2G1.transform.position, speedG1 * Time.deltaTime);
        enemy3G1.transform.position = Vector2.MoveTowards(enemy3G1Pos, target3G1.transform.position, speedG1 * Time.deltaTime);
    }

    IEnumerator GroupTwoMove()
    {
        
        Vector2 enemy1G2Pos = new Vector2(enemy1G2.transform.position.x, enemy1G2.transform.position.y);
        Vector2 enemy2G2Pos = new Vector2(enemy2G2.transform.position.x, enemy2G2.transform.position.y);
        Vector2 enemy3G2Pos = new Vector2(enemy3G2.transform.position.x, enemy3G2.transform.position.y);
        Vector2 enemy4G2Pos = new Vector2(enemy4G2.transform.position.x, enemy4G2.transform.position.y);

        enemy1G2.transform.position = Vector2.MoveTowards(enemy1G2Pos, target1G2.transform.position, speedG2 * Time.deltaTime);
        enemy2G2.transform.position = Vector2.MoveTowards(enemy2G2Pos, target2G2.transform.position, speedG2 * Time.deltaTime);
        enemy3G2.transform.position = Vector2.MoveTowards(enemy3G2Pos, target3G2.transform.position, speedG2 * Time.deltaTime);
        enemy4G2.transform.position = Vector2.MoveTowards(enemy4G2Pos, target4G2.transform.position, speedG2 * Time.deltaTime);

        yield return new WaitForSecondsRealtime(10);
        enemy1G2.transform.position = Vector2.MoveTowards(enemy1G2Pos, target5G2.transform.position, speedG2 * Time.deltaTime);
        enemy3G2.transform.position = Vector2.MoveTowards(enemy3G2Pos, target6G2.transform.position, speedG2 * Time.deltaTime);

    }

    IEnumerator GroupThreeMove()
    {
        yield return new WaitForSecondsRealtime(0);
        Vector2 enemy1G3Pos = new Vector2(enemy1G3.transform.position.x, enemy1G3.transform.position.y);
        Vector2 enemy2G3Pos = new Vector2(enemy2G3.transform.position.x, enemy2G3.transform.position.y);
        Vector2 enemy3G3Pos = new Vector2(enemy3G3.transform.position.x, enemy3G3.transform.position.y);
        Vector2 enemy4G3Pos = new Vector2(enemy4G3.transform.position.x, enemy4G3.transform.position.y);

        enemy1G3.transform.position = Vector2.MoveTowards(enemy1G3Pos, target1G3.transform.position, speedG3 * Time.deltaTime);
        enemy2G3.transform.position = Vector2.MoveTowards(enemy2G3Pos, target2G3.transform.position, speedG3 * Time.deltaTime);
        enemy3G3.transform.position = Vector2.MoveTowards(enemy3G3Pos, target3G3.transform.position, speedG3 * Time.deltaTime);
        enemy4G3.transform.position = Vector2.MoveTowards(enemy4G3Pos, target4G3.transform.position, speedG3 * Time.deltaTime);
    }

    IEnumerator GroupOneDeath()
    {
        //enemy1G1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        enemy2G1.SetActive(false);
        yield return new WaitForSecondsRealtime(0.5f);
        enemy3G1.SetActive(false);
    }

    IEnumerator GroupTwoDeath()
    {
        enemy2G1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        enemy4G2.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        tower2.SetActive(false);
    }


    IEnumerator ActivateTextWave()
    {
        nextWaveBG.enabled = true;
        nextWaveText.enabled = true;
        yield return new WaitForSecondsRealtime(1);
        nextWaveBG.enabled = false;
        nextWaveText.enabled = false;

    }
    private void DeactivateTextWave()
    {
        

    }
    public void SetTransition1(bool state)
    {
        transition1 = state;
    }
    public void SetTransition2(bool state)
    {
        transition2 = state;
    }

}
