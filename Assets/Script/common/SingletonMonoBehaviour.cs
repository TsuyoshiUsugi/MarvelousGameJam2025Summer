using System;
using UnityEngine;

/// <summary>抽象クラス</summary>
/// <typeparam name="T">MonoBehaviourを継承している型のみ指定</typeparam>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = (T)FindAnyObjectByType(typeof(T));
                if (_instance == null)
                {
                    Debug.LogError("シーン上にないよ");
                }
            }

            return _instance;
        }
    }

    protected void Awake()
    {
        CheckInstance();
    }
    
    protected bool CheckInstance()
    {
        if (_instance == null)
        {
            _instance = this as T;
            return true;
        }
        else if (Instance == this)
        {
            return true;
        }

        Destroy(this);
        return false;
    }
}