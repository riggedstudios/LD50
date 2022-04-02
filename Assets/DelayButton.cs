using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayButton : MonoBehaviour
{
	public GameObject mStopWatchObject;
	StopWatch mStopWatch;
    // Start is called before the first frame update
    void Start()
    {
		mStopWatch = mStopWatchObject.GetComponent<StopWatch>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseDown()
	{
		mStopWatch.IncreaseStopWatchTimer(1);
	}
}
