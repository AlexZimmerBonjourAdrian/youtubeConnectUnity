using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLevelManager : MonoBehaviour
{
    public static int STATE_PLAY = 0;
    public static int STATE_PAUSE = 1;

    private int _state;

    private CPlayer _player;


    // Start is called before the first frame update
    private void CreatePlayer()
    {
        GameObject asset = Resources.Load<GameObject>("player");
        GameObject obj = Instantiate(asset, Vector3.zero, Quaternion.identity) as GameObject;
        _player = obj.GetComponent<CPlayer>();

    }

    private void OnprevStateExit(int aState)
    {
        if(aState == STATE_PLAY)
        {
           
        }

        if(aState == STATE_PAUSE)
        {
            Time.timeScale = 1;
        }
    }

    public void SetState(int aState)
    {
        OnprevStateExit(_state);
        _state = aState;

        if(_state == STATE_PLAY)
        {

        }
        else if(_state == STATE_PAUSE)
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_state == STATE_PLAY)
        {
            if(CheckPause())
            {
                SetState(STATE_PAUSE);
            }
            else if(_state == STATE_PAUSE)
            {
                if(CheckPause())
                {
                    SetState(STATE_PLAY);
                }
            }
        }
    }
    private bool CheckPause()
    {
        return CKeyboard.FirsPress(CKeyboard.ESC);
    }
}
