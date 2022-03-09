using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownText : MonoBehaviour
{
    public TextMeshProUGUI countDownText;

    void Start()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        countDownText.text = "3";
        yield return new WaitForSeconds(1f);
        countDownText.text = "2";
        yield return new WaitForSeconds(1f);
        countDownText.text = "1";
        yield return new WaitForSeconds(1f);
        countDownText.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        countDownText.gameObject.SetActive(false);

        GameObject.Find("Player").GetComponent<CarDrive>().enabled = true;
    }
}
