using UnityEngine;
using UnityEngine.UI;
public class UIScripts : MonoBehaviour
{
    private Text ScoreText;
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponentInChildren<Text>();
        ScoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }
}
