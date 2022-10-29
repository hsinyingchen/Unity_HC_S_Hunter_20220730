
using System.Collections;
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
        private int countShootMarble = 10;
        [SerializeField, Range(0, 50000)]
        private int speedMarble = 1500;
        [SerializeField, Range(0, 3)]
        private float intervalShoot = 0.5f;
        [SerializeField, Header("彈珠預置物")]
        private GameObject prefabMarble;
        [SerializeField, Header("彈珠生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("箭頭")]
        private GameObject goArrow;

        private string parAttack = "觸發攻擊";
        private Animator ani;
        #endregion
        private void Awake()
        {
            ani = GetComponent<Animator>();

            StartCoroutine(SpawnMarble(countShootMarble));
        }

        private void Update()
        {
            ShootMarble();
        }

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
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                goArrow.SetActive(true);
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                goArrow.SetActive(false);
            }
        }

        


        /// <summary>
        /// 生成彈珠
        /// </summary>
        /// <param name="countToSpawn">要生成的彈珠數量</param>
        private IEnumerator SpawnMarble(int countToSpawn)
        {
            //Object.Instantiate(); //第一種寫法,Static
            //Instantiate(); //第二種寫法,繼承類別
            for (int i = 0; i < countToSpawn; i++)
            {

                Instantiate(prefabMarble, pointSpawn.position, pointSpawn.rotation);
                ani.SetTrigger(parAttack);
                yield return new WaitForSeconds(intervalShoot);



            }
            

        }
        #endregion
    }
}

