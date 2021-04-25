using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject spellsMenu;
    public GameObject newWave;
    public GameObject soulMeter;
    public GameObject spellReady;
    public GameObject towerMenu;
    public GameObject victory;
    public GameObject setDef;
    public Image tower1;
    public Image tower2;
    public Image tower3;
    public Image tower4;

    private bool alreadyActive;

    private void Awake()
    {
        setDef.SetActive(true);
        newWave.SetActive(false);
        spellReady.SetActive(false);
        towerMenu.SetActive(true);
        victory.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (!alreadyActive)
        {
            StartCoroutine(TowerMenu());
            StartCoroutine(Wave1());
            StartCoroutine(Wave2());
            StartCoroutine(Wave3());
            StartCoroutine(SpellReady());
            StartCoroutine(Victory());
            alreadyActive = true;
        }
    }

    IEnumerator TowerMenu()
    {
        yield return new WaitForSecondsRealtime(3);
        setDef.SetActive(false);
        tower1.enabled = false;

        yield return new WaitForSecondsRealtime(3);
        tower2.enabled = false;

        yield return new WaitForSecondsRealtime(3);
        tower3.enabled = false;

        yield return new WaitForSecondsRealtime(3);
        tower4.enabled = false;

        yield return new WaitForSecondsRealtime(1);
        towerMenu.SetActive(false);
    }

    IEnumerator Wave1()
    {
        yield return new WaitForSecondsRealtime(15);
        newWave.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        newWave.SetActive(false);
    }
    IEnumerator Wave2()
    {
        yield return new WaitForSecondsRealtime(29);
        newWave.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        newWave.SetActive(false);
    }

    IEnumerator Wave3()
    {
        yield return new WaitForSecondsRealtime(71);
        newWave.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        newWave.SetActive(false);
    }

    IEnumerator SpellReady()
    {
        yield return new WaitForSecondsRealtime(43);
        spellReady.SetActive(true);
        yield return new WaitForSecondsRealtime(45);
        spellReady.SetActive(false);
        yield return new WaitForSecondsRealtime(11);
        spellReady.SetActive(true);
    }

    IEnumerator Victory()
    {
        yield return new WaitForSecondsRealtime(114);
        victory.SetActive(true);
        
    }
}
