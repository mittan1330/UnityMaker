using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePresenter : MonoBehaviour
{
    [SerializeField]
    private InGameModel _inGameModel;
    [SerializeField]
    private InGameView _inGameView;

    public void AddCoin(int coin)
    {
        _inGameModel.gameCoin += coin;
    }
}
