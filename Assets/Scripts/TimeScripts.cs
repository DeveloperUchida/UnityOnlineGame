using System.Net.Mail;
using UnityEngine;
using UnityEngine.UI;

public class TimeScripts : MonoBehaviour
{
    public int Minute;
    private float Second;
    //前のUpdateの時の秒数
    private float oldSeconds;
    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        Minute = 0;
        Second = 0;
        oldSeconds = 0;
        timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Second += Time.deltaTime;
        if(Second >=60)
        {
            Minute++;
            Second = Second -60;
        }
        //値が変わった時だけTextを更新
        if((int)Second !=(int)oldSeconds)
        {
            timerText.text = Minute.ToString("00")+ ":"+((int) Second).ToString("00");
        }
        oldSeconds = Second;
    }
}
