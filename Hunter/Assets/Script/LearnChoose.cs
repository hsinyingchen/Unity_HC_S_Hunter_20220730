﻿
using UnityEngine;

namespace Chen 
{
    /// <summary>
    /// 選取語句
    /// 1.if
    /// 2.switch
    /// </summary>
    public class LearnChoose : MonoBehaviour
    {
        [SerializeField]
        private int keyCount;

        private void Awake()
        {
            Chooseif();
        }

        private void Update()
        {
            UpdateChooseif();
        }

        /// <summary>
        /// if
        /// </summary>
        private void Chooseif() 
        {
            //if (布林值) {當布林值等於true時執行}
            if (true)
            {
                print("truw 我是判斷式 if");
            }
            if (false) 
            {
                print("false 我是判斷式 if");
            }

        }

        private void UpdateChooseif()
        {
            //如果 if 鑰匙 大於等於 5 就過關, 否則 else 就不過關
            if (keyCount >= 5)
            {
                //布林值 true 執行
                print("過關");
            }
            else 
            {
                //布林值 false 執行
                print("不過關");
            }
        }


    }



}

