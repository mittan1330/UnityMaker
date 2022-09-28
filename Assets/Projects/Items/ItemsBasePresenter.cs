using UnityEngine;
using Game.Core;

public abstract class ItemsBasePresenter : MonoBehaviour
{
    /// <summary>
    /// アイテムに接触した時のAction
    /// </summary>
    //public Action<int> OnHitItem;

    /// <summary>
    /// コインに関しての種類を列挙するEnum
    /// </summary>
    public enum CoinType
    {
        BigCoin,
        BasicCoin,
    }

    /// <summary>
    /// アイテムに関しての種類を列挙するEnum
    /// </summary>
    public enum ItemType
    {
        Coin,
        AddRestartCount,
    }

    /// <summary>
    /// アイテムに関するサウンドを再生するAudioSource
    /// </summary>
    [SerializeField]
    private AudioSource _audioSource;
    public AudioSource audioSource => _audioSource;

    /// <summary>
    /// InGameを制御するPresenterと繋ぎこむ
    /// </summary>
    [SerializeField]
    private InGamePresenter _inGamePresenter;
    public InGamePresenter inGamePresenter => _inGamePresenter;

    /// <summary>
    /// アイテムを取得した時に流れるサウンド
    /// </summary>
    [SerializeField]
    AudioClip _getItemAudioClip;

    /// <summary>
    /// アイテムに関して完全に削除する関数
    /// </summary>
    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }

    /// <summary>
    /// アイテムを表示しているSpriteを非表示にする関数
    /// </summary>
    public abstract void OnDisableSprite();

    private void Start()
    {
        _inGamePresenter =
            GameObject.
            Find(CoreGameObject.InGameStageManager.ToString()).
            GetComponent<InGamePresenter>();
        Initalize();
    }

    /// <summary>
    /// 継承先クラスで初期化を行うための関数
    /// </summary>
    public abstract void Initalize();
}
