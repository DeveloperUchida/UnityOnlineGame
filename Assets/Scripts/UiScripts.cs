using UnityEngine;
public class UIScripts : MonoBehaviour
{
    public string targetTag = "Enamy"; // 敵のタグでEnamyを作成
    public int scoreValue = 5; //Enamyと衝突判定が発生した時のスコア増加率
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreManagerオブジェクトを検索して取得
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //スコア加点処理
        scoreManager.AddScore(scoreValue);
        //衝突したオブジェクトを削除
        Destroy(other.gameObject);
    }
}
