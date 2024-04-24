using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    //スコアを加算する関数
    ///<summary>
    ///製品完成時にDebug処理は無効化してください(パフォーマンスに影響します)
    ///</summary>
    public void AddScore(int amount) //数式なのでinteger型の略でint型
    {
        Score += amount;
        Debug.Log("Score: " + Score);
    }
}
