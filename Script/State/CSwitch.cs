using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public static 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CKeyboard.FirsPress(KeyCode.Alpha1))
        {
            CGameManger.Inst.LoadSceneAsync("scene1");
        }
        else if(CKeyboard.FirsPress(KeyCode.Alpha2))
       {

       }
        else if(CKeyboard.FirsPress(KeyCode.Alpha3))
        {

        }
    }
    public void SwitchScene(string name)
    {
        CGameManger.Inst.LoadSceneAsync(name);
    }
    public void Test(Vector3 vector)
    {

    }

}
