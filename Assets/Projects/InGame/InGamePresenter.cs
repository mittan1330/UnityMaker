using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePresenter : MonoBehaviour
{
    /// <summary>
    /// InGameのModel
    /// </summary>
    private InGameModel _inGameModel;
    [SerializeField]
    private InGameView _inGameView;

    private void Start()
    {
        // modelを生成させる
        _inGameModel = new InGameModel();
    }
}
