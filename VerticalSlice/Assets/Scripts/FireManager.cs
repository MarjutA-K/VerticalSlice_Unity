using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public GameObject fire1T1;
    public GameObject fire2T1;

    public GameObject fire1T2;
    public GameObject fire2T2;

    public GameObject fire1T3;
    public GameObject groundFire1;
    public GameObject groundFire2;
    public GameObject groundFire3;

    public GameObject fire1T4;
    public GameObject fire2T4;

    public GameObject movingTower;

    private void Start()
    {
        fire1T1.SetActive(false);
        fire2T1.SetActive(false);
        fire1T2.SetActive(false);
        fire2T2.SetActive(false);
        fire1T3.SetActive(false);
        fire1T4.SetActive(false);
        fire2T4.SetActive(false);
        groundFire1.SetActive(false);
        groundFire2.SetActive(false);
        groundFire3.SetActive(false);
        StartCoroutine(FakeGameplay());
    }

    private void Update()
    {
        fire1T3.transform.position = movingTower.transform.position;
    }

    IEnumerator FakeGameplay()
    {
        yield return new WaitForSecondsRealtime(37);
        fire1T1.SetActive(true);

        yield return new WaitForSecondsRealtime(8);
        fire2T1.SetActive(true);

        yield return new WaitForSecondsRealtime(3);
        fire1T2.SetActive(true);

        yield return new WaitForSecondsRealtime(5);
        fire1T1.SetActive(false);
        fire2T1.SetActive(false);

        yield return new WaitForSecondsRealtime(5);
        fire2T2.SetActive(true);

        yield return new WaitForSecondsRealtime(4);
        fire1T2.SetActive(false);
        fire2T2.SetActive(false);

        yield return new WaitForSecondsRealtime(27);
        fire1T3.SetActive(true);
        groundFire1.SetActive(true);
        groundFire2.SetActive(true);
        groundFire3.SetActive(true);

        yield return new WaitForSecondsRealtime(5);
        fire1T4.SetActive(true);

        yield return new WaitForSecondsRealtime(5);
        groundFire1.SetActive(false);
        groundFire2.SetActive(false);
        groundFire3.SetActive(false);

        yield return new WaitForSecondsRealtime(4);
        fire2T4.SetActive(true);

        yield return new WaitForSecondsRealtime(4);
        fire1T3.SetActive(false);
    }
}
