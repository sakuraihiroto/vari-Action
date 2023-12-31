using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour
{

    //ジャンプの速度を設定
    private const float _velocity = 6.0f;

    private Rigidbody _rigidbody;
    //着地状態を管理
    private bool _isGrounded;

    void Start()
    {
        //Rigidbodyコンポーネントを取得
        _rigidbody = GetComponent<Rigidbody>();
        //最初は着地していない状態
        _isGrounded = false;
    }

    void Update()
    {
        //着地しているかを判定
        if (_isGrounded == true)
        {
            //スペースキーが押されているかを判定
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                //ジャンプの方向を上向きのベクトルに設定
                Vector3 jump_vector = Vector3.up;
                //ジャンプの速度を計算
                Vector3 jump_velocity = jump_vector * _velocity;

                //上向きの速度を設定
                _rigidbody.velocity = jump_velocity;
                //地面から離れるので着地状態を書き換え
                _isGrounded = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //着地を検出したので着地状態を書き換え
        _isGrounded = true;
    }
}

