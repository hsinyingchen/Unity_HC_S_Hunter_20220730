
using UnityEngine;

namespace Chen
{
    public class ControlSystem : MonoBehaviour
    {
        #region 資料
        [Header("基本資料")]
        [SerializeField]
        private float speed = 10.5f;
        [SerializeField]
        private int countshootMarble = 10;
        [SerializeField, Range(0, 50000)]
        private int speedMarble = 1500;
        [SerializeField, Range(0, 3)]
        private float intervalShoot = 0.5f;
        [SerializeField, Header("彈珠預置物")]
        private GameObject prefabMarble;
        [SerializeField, Header("彈珠生成點")]
        private Transform pointSpawn;

        private string parAttack = "觸發攻擊";
        #endregion

        #region 方法
        /// <summary>
        /// 旋轉角色
        /// </summary>
        private void TurnCharacter() 
        { 
        
        }
        /// <summary>
        /// 發射彈珠
        /// </summary>
        private void ShootMarble() 
        { 
        
        }
        /// <summary>
        /// 生成彈珠
        /// </summary>
        /// <param name="countSpawn">要生成的彈珠數量</param>
        private void SpawnMarble(int countSpawn) 
        { 
        
        }
        #endregion
    }
}

