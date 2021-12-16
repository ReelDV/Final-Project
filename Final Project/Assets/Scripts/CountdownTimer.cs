using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField]
    public int countdownTime = 600;
    [SerializeField]
    public TMPro.TextMeshProUGUI countdownDisplay;
    bool takingAway = false;

    public void TimerPlay()
    {
        StartCoroutine(CountdownToStart());


    }

    IEnumerator CountdownToStart()
    {
        takingAway = true;
        while (countdownTime > 0)
        {
            float minutes = Mathf.FloorToInt(countdownTime / 60);
            float seconds = Mathf.FloorToInt(countdownTime % 60);

            countdownDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            //countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1);

            countdownTime--;
        }
    }

}
