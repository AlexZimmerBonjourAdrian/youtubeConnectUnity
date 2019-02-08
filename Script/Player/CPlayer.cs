using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer :MonoBehaviour
{

    public float speed = 6.0f;
    public float gravity = 20.0f;
    private float _force = 10f;
   private  Vector3 _moveDir =Vector3.zero;
    public static int STATE_IDLE = 0;
    public static int STATE_MOVE = 1;
    private int _state;
    public Rigidbody _rigidbody;
    private CharacterController _character;

    


    // Start is called before the first frame update

    private void Awake()
    {
        _character = GetComponent<CharacterController>();

        _rigidbody= GetComponent<Rigidbody>();        
    }
    void Start()
    {
        
        SetState(STATE_IDLE);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
    

    private void SetState(int aState)
    {
        _state = aState;
        if (_state == STATE_IDLE)
        {
            if (speed > 0)
            {
                speed -= 1;
            }
        }
        else if (_state == STATE_MOVE)
        {
            _moveDir = new Vector3(Input.GetAxis("Horizotal"), 0, Input.GetAxis("Vertical"));
            
            if (CKeyboard.pressed(CKeyboard.W))
            {
               _rigidbody.MovePosition( transform.position += _moveDir *  speed * Time.deltaTime);

            }
            else if(CKeyboard.pressed(CKeyboard.S))
            {
               _rigidbody.MovePosition(transform.position += _moveDir * -speed * Time.deltaTime);
            }


            else if(CKeyboard.pressed(CKeyboard.D))
            {

            }

            else if(CKeyboard.pressed(CKeyboard.A))
            {

            }

            else
            {
                SetState(STATE_IDLE);
            }
        }
       }
        
    private void MovementController()
    {
        

        if(CKeyboard.pressed(CKeyboard.W))
        {
            SetState(STATE_MOVE);
        }

        
    }
    
}
