using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    const string ANIM_WALK = "Walk";
    const string ANIM_UP = "Up";
    const string ANIM_DOWN = "Down";
    const string ANIM_SIDE = "Side";
    const string ANIM_DEAD = "Dead";
    const string ANIM_ITEM = "Item";
    const string ANIM_ATTACK = "Attack";
    [SerializeField] private Animator _anim;
    [SerializeField] private SpriteRenderer _sr;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerInput.Instance.InputVector != Vector2.zero)
        {
            if(PlayerInput.Instance.InputVector.y > 0)
            {
                _anim.SetBool(ANIM_DOWN, false);
                _anim.SetBool(ANIM_UP, true);
            }
            else if (PlayerInput.Instance.InputVector.y < 0)
            {
                _anim.SetBool(ANIM_DOWN, true);
                _anim.SetBool(ANIM_UP, false);
            }
            else
            {
                _anim.SetBool(ANIM_DOWN, false);
                _anim.SetBool(ANIM_UP, false);
            }

            if(PlayerInput.Instance.InputVector.x != 0)
            {
                _anim.SetBool(ANIM_SIDE, true);
                if(PlayerInput.Instance.InputVector.x < 0)
                {
                    _sr.flipX = true;
                }
                else
                {
                    _sr.flipX = false;
                }
            }
            else
            {
                _anim.SetBool(ANIM_SIDE, false);
            }

            _anim.SetBool(ANIM_WALK, true);
        }        
        else
        {
            _anim.SetBool(ANIM_WALK, false);
        }
    }
}
