using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CKeyboard : MonoBehaviour
{
    static private bool mInizialisate = false;
    public const KeyCode D = KeyCode.D;
    public const KeyCode W = KeyCode.W;
    public const KeyCode A = KeyCode.A;
    public const KeyCode S = KeyCode.S;
    public const KeyCode Space = KeyCode.Space;
    public const KeyCode ESC = KeyCode.Escape;
    public const KeyCode Enter = KeyCode.KeypadEnter;
    public const KeyCode F = KeyCode.F;
    public const KeyCode F2 = KeyCode.F2;
    
    public CKeyboard()
    {
        throw new UnityException("Error in CKeyboar().you're notification ti instanciate this class");

    }
    public static void init()
    {
        if (mInizialisate)
        {
            return;
        }
        mInizialisate = true;
    }
 
    public static void destroy()
    {
        if(mInizialisate)
        {
            mInizialisate = false;
        }
    } 
    public static bool pressed(KeyCode aKey)
    {
        return Input.GetKey(aKey);
    }
    public static bool FirsPress(KeyCode aKey)
    {
        return Input.GetKeyDown(aKey);
    }
    public static bool relesed(KeyCode aKey)
    {
        return Input.GetKeyUp(aKey);
    }
}
