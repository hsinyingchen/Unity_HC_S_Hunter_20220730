
using UnityEngine;

namespace Chen 
{
    /// <summary>
    /// 學習運算子
    /// 1.數學
    /// 2.比較
    /// 3.邏輯
    /// 4.三元
    /// </summary>
    public class LearnOperator : MonoBehaviour
    {
        private void Awake()
        {
            //OperatorMath();
            //OperatorComparison();
            //OperatorLogic();
            //OperatorTernary();

        }

        private float a = 10, b = 3;

        ///<summary>
        ///數學運算子
        ///<summary>
        private void OperatorMath() 
        { 
        //加,減,乘,除,餘,
        
            print("加法" + (a + b));   //13
            print("減法" + (a - b));   //7
            print("乘法" + (a * b));   //30
            print("除法" + (a / b));   //3.333
            print("餘數" + (a % b));   //1

        }
        ///<summary>
        ///比較運算子
        ///<summary>
        private void OperatorComparison() 
        { 
        //大於,小於, 大於等於, 小於等於, 等於, 不等於
        //比較運算子的結果為布林值, 為truw, false
        print ("大於" + (a > b));        //t
        print ("小於" + (a < b));        //f
        print ("大於等於" + (a >= b));        //t
        print ("小於等於" + (a <= b));        //f
        print ("等於" + (a == b));        //f
        print ("不等於" + (a != b));        //t
                        
        }
        private void OperatorLogic() 
        {
            //並且, 或者, 顛倒
            //並且: 比較兩個布林值
            //只要其中一個布林值等於f, 則結果為f
            print(true && true);          //t
            print(true && false);          //f
            print(false && true);          //f
            print(false && false);          //f

            //或者:比較兩個布林值
            //只要其中一個布林值等於t, 則結果為t
            print(true || true);          //t
            print(true || false);          //t
            print(false || true);          //t
            print(false || false);          //f

            //顛倒
            //將布林值交換
            print(!true);          //f
            print(!false);          //t
            print(!(a > b));          //f


        }

        private void OperatorTernary() 
        {
            //語法
            //布林值 ? 運算式一:運算式二:
            //當布林值為true時執行運算式一
            //當布林值為false時執行運算式二
            print(true ? "我是運算式一" : "我是運算式二");
            print((a < b) ? "a 小於 b" : "a 大於 b");

        }
            

    }

}

