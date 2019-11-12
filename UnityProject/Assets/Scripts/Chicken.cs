
using UnityEngine;

public class Chicken : MonoBehaviour
{

    [Header("移動速度"),Range(0,9999f)]
	public float   speed = 1f  ;

	[Header("跳要高度"),Range(0,9999)]
	public int   Jump = 1  ;

	[Header("對話內容")]
	 public  string  Talk  ;


	 [Header("是否取的雞蛋")]
	 public  bool  Egg  ;

    void Start()
    {
        print("遊戲開始");
    }

    // Update is called once per frame
    void Update()
    {
       print(Talk);
        
    }
}
