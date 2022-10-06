using System.ComponentModel;

namespace Game.Core
{
    /// <summary>
    /// それぞれのInGame部分でコアになるゲームオブジェクトの名前を定義
    /// </summary>
    public enum CoreGameObject
    {
        InGameStageManager,
        InGameLoadingManager,
    }

    /// <summary>
    /// それぞれのステージに付与するIDを指定する
    /// </summary>
    public enum StageGroupes
    {
        //A1.GetName()を利用することでstring型の"A-1"を取得できそう？
        [Description("A-1")]
        A1,
        A2,
        A3,
        B1,
        B2,
        B3,
    }
}