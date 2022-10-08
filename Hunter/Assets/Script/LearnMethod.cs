
using UnityEngine;

namespace Chen
{
    public class LearnMethod : MonoBehaviour
    {
        //方法語法:
        //修飾詞 傳回資料類型 方法迷稱 (參數) {城市區塊 陳述式 演算法}

        //自訂方法:部會執行 需要呼叫
        //VS 2019
        //方法名稱沒有被呼叫時會淡黃色
        //方法名稱有被呼叫時會亮黃色
        //無void
        private void Test()
        {
            print("我是測試方法");
 
            }
		private void Awake()
		{
            //呼叫方法語法:
            //方法名稱():
            Test();
            Test();




		}



	}


}

