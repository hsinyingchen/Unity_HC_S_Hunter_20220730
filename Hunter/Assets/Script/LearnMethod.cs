
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
            //呼叫有參數的方法需要填入對應的引數
            NumberTest(10);
            NumberTest(999);

            ShootMarble(10, "一般");
            ShootMarble(50, "火焰");

            //有預設值的參數可以不用選 會以預設值
            ShootMarble(7);

            //3, 火焰, 火球
            ShootMarble(3, "火焰", "火球");

            //9, 一般, 閃電
            ShootMarble(9, "閃電");             //錯誤執行結果: 9,閃電,光點     
            ShootMarble(9, effect: "閃電");

            //在方法或事件內這格稱為區域變數 欄位有限制性 僅在此結構內使用
            int ten = ReturnTen();
            print("傳回的數字:" + ten);


		}
        //參數語法:
        //類型 參數 1 名稱 類型 三數 2 名稱... (沒有上限)
        private void NumberTest(int number1) 
        {
            //= 指定運算子
            //先執行指定運算子右邊 在指定結果給左邊
            number1 = number1 + 10;
          print("數字加10的結果:" + number1);
        }

        //參數預設值
        //類型 參數名稱 指定 預設值
        private void ShootMarble(int count, string type = "一般", string effect = "光點") 
        {
            print("彈珠數量:" + count);
            print("彈珠屬性:" + type);
            print("彈珠特效:" + effect);

            //有預設值的參數必須寫在後面
      
        }
        
        private int ReturnTen() 
        {
           return 10;
        }

        private void Start()
        {
            float bmiChen = BMI(1.75f, 120);
            print("Chen BMI" + bmiChen);

            print("pei BMI" + BMI(1.55f, 45));

        }
        //計算BMI
        //提供身高(公尺) 體重並算出BMI值 體重 / 身高平方
        /// <summary>
        /// 計算BMI方法
        /// </summary>
        /// <param name="height">請輸入身高, 公尺</param>
        /// <param name="weight">請輸入體重</param>
        /// <returns>BMI 結果</returns>
        private float BMI(float height, float weight) 
        {
            float result = weight / (height * height);
            return result;
        }
	}


}

