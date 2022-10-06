using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinPresenter : ItemsBasePresenter
{

    /// <summary>
    /// コインに接触した時のAction
    /// </summary>
    public Action<int> OnHitCoin;

    [SerializeField]
    private int _coinScore;

    public override void Initalize()
    {
        
    }

    public override void OnDisableSprite()
    {
        
    }

    public override void SetEvents()
    {
        OnHitCoin += inGamePresenter.AddCoin;
    }

    public void AddScore()
    {
        OnHitCoin?.Invoke(_coinScore);
        OnDestroy();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AddScore();
        }
    }
}
