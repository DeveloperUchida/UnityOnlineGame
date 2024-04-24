using UnityEngine;
using UnityEngine.UI;
public class UIScripts : MonoBehaviour
{
    public string targetTag = "Enamy"; // 敵のタグでEnamyを作成
    public int scoreValue = 5; //Enamyと衝突判定が発生した時の
    private ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreManagerオブジェクトを検索して取得
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
