using System;
using System.Collections;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public event Action<Enemy> Died;
    public abstract void Accept(IEnemyVisitor visitor);
    public void MoveTo(Vector3 pos) 
        => transform.position = pos;

    public void Kill()
    {
        Died?.Invoke(this);
        Destroy(gameObject);
    }
}