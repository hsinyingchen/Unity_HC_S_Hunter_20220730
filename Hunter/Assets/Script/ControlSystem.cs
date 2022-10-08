
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

        private string parAttack = "觸發攻擊";
        #endregion




        


    }
}

