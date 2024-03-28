using UnityEngine;

public class PlayerContloal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            
        }
    }
}
