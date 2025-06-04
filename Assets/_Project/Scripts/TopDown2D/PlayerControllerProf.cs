using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerProf : MonoBehaviour
{
    private TopDownMover2D _mover;
    private Animator _anim;

    void Start()
    {
        _mover = GetComponent<TopDownMover2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        _mover.UpdateDirection(dir);

        if (_anim != null && (h != 0 || v != 0) )
        {
            _anim.SetFloat("hDir", h);
            _anim.SetFloat("vDir", v);
        }
    }
}
