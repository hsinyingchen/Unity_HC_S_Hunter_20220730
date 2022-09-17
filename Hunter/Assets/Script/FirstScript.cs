//單行註解
using UnityEngine;//引用Unity遊戲命名空間;倉庫實用資料功能
//腳本=類別
/*多行註解
 * 
 * 
 */
namespace Chen
{
    /// <summary>
    /// 摘要:輔助說明並會出現在編譯器上
    /// First script 第一個腳本學習 C#基礎與Unity
    /// </summary>

    public class FirstScript : MonoBehaviour
    {
        #region 資料區域
        //
        //
        //
        #endregion

        #region 事件區域:Unity 入口
        /// <summary>
        /// 喚醒事件:遊戲開始並在Start前 執行一次
        /// </summary>
        private void Awake()
        {
            print("哈摟, 你好~");
        }
        /// <summary>
        /// 開始事件:遊戲開始並在Awake後 執行一次
        /// </summary>
        private void Start()
        {
            print("開始事件!");
            //rich text
            print("<color=yellow>黃色文字</color>");
            print("<color=#006699>藍綠色</color>");

            
        }

        #endregion

    }
}

