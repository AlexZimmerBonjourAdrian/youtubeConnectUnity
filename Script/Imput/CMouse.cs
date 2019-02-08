using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMouse 
{
    static private bool mInitialized = false;

    public CMouse()
    {
        throw new UnityException("Error in CMouse(). you´re not supposed to instantiate this class");
    }
     public static void init()
    {
        if(mInitialized)
        {
            return;
        }
        mInitialized = false;
    }
    // Start is called before the first frame update
    public static void destroy()
    {
        if(mInitialized)
        {
            mInitialized = false;
        }
    }
    public static bool firstPress()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static Vector3 getPos()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos *= -1;
        pos.z = 0;
        return pos;
    }
}
