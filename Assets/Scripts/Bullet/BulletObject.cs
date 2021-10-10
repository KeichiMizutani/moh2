using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using UniRx.Triggers;

public class BulletObject : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] private float lifeTime = 1.0f;
    [SerializeField] bool isRightDiagonal = false;
    [SerializeField] public bool isLeftDiagonal = false;

    private Rigidbody _rigidbody;
    private readonly Subject<Unit> _finishedSubject = new Subject<Unit>();

    // オブジェクトを使い終わったことを通知する
    public IObservable<Unit> OnFinishedAsync => _finishedSubject.Take(1);
    
    // オブジェクトに速度を与えて一定時間後に

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
        // 何かにぶつかったときの処理
        this.OnCollisionEnterAsObservable().Subscribe(_ => OnHit());
        
        if (isRightDiagonal && !isLeftDiagonal)
        {
            _rigidbody.AddForce(speed, 0, speed,ForceMode.Impulse);
        }
        else if (!isRightDiagonal && isLeftDiagonal)
        {
            _rigidbody.AddForce(-speed, 0, speed,ForceMode.Impulse);
        }
        else if (!isRightDiagonal && !isLeftDiagonal)
        {
            _rigidbody.AddForce(0,0,speed,ForceMode.Impulse);
        }
        else
        {
            _rigidbody.AddForce(0,0,speed,ForceMode.Impulse);
        }
    }

    private void OnHit()
    {
        Finish();
    }

    private void Finish()
    {
        _rigidbody.velocity = Vector3.zero;
        
        //使い終わったイベントを発行
        _finishedSubject.OnNext(Unit.Default);
    }

    private void OnDestroy()
    {
        _finishedSubject.Dispose();
    }
}