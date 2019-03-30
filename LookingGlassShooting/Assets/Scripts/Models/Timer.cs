using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public float CountTime = 60.0f;
    [SerializeField]
    public bool IsEnabled = false;

    void Start()
    {
    }

    void Update()
    {
        if (IsEnabled)
        {
            CountTime -= Time.deltaTime;
        }

        if (CountTime < 0)
        {
            TimerStop();
            CountTime = 0;
        }
    }

    public void TimerSet(int time)
    {
        CountTime = (float)time;
    }

    public void TimerStart()
    {
        IsEnabled = true;
    }

    public void TimerStop()
    {
        IsEnabled = false;
    }
}
