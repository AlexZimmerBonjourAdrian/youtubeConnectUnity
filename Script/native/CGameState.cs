using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameState
{
    private int mState = 0;
    private float mTimeState = 0.0f;


    // Update is called once per frame
    virtual void Update()
    {
        mTimeState = mTimeState + Time.deltaTime;
    }
    virtual public void setState(int aState)
    {
        mState = aState;
        mTimeState = 0.0f;
    }
    public int getState()
    {
        return mState;
    }
    public void setTimeState(float aTimeState)
    {
        mTimeState = aTimeState;
    }
    public float getTimeState()
    {
        return mTimeState;
    }
}
