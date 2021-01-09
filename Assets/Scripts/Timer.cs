using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //config
    [SerializeField]
    Stat TimerStat;
    // Start is called before the first frame update
    void Start()
    {
        TimerStat.CurrentVal = 0;
        TimerStat.MaxVal = 20;
    }

    // Update is called once per frame
    void Update()
    {
        TimerStat.CurrentVal += Time.deltaTime;
    }
}
