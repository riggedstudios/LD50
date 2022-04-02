using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
	float mTimer = 1.0f;
	Time mTotalTime;
	GameObject mPointer;
	public Text mTimerText;
    // Start is called before the first frame update
    void Start()
    {
		mPointer = this.transform.GetChild(1).gameObject;
	}

    // Update is called once per frame
    void Update()
    {
		mPointer.transform.localEulerAngles = Vector3.Lerp(mPointer.transform.localEulerAngles, new Vector3(0, 0, mTimer * 6), Time.deltaTime);
		mTimer += Time.deltaTime;
		if (mTimer >= 60)
			mTimer = 60;
		mTimerText.text = mTimer.ToString();
	}

	public void IncreaseStopWatchTimer(float amount)
	{
		mTimer += amount;
		Debug.Log("Increasing Timer");
	}
}
