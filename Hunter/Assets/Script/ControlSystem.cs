
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

        [SerializeField, Header("地板圖層")]
        private LayerMask layerGround;
        [SerializeField, Header("射擊碰撞點的物件")]
        private Transform traTarget;


        private string parAttack = "觸發攻擊";
        private Animator ani;
        private bool isShooted;
        #endregion
        private void Awake()
        {
            ani = GetComponent<Animator>();

           
        }

        private void Update()
        {
            ShootMarble();
            TurnCharacter();
        }

        #region 方法
        /// <summary>
        /// 旋轉角色
        /// </summary>
        private void TurnCharacter()
        {
            if (isShooted) return;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Vector3 posMouse = Input.mousePosition;

                Ray ray = Camera.main.ScreenPointToRay(posMouse);

                RaycastHit hit;


               if (Physics.Raycast(ray, out hit, 100, layerGround));
                {
                    print("射擊碰到的物件座標:" + hit.point);
                    traTarget.position = hit.point;
                    transform.LookAt(traTarget);
                
                }
             
            }

        }

        /// <summary>
        /// 發射彈珠
        /// </summary>
        private void ShootMarble() 
        {
            if (isShooted) return;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                goArrow.SetActive(true);
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                goArrow.SetActive(false);
                isShooted = true;
                StartCoroutine(SpawnMarble(countShootMarble));
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
                //生成的彈珠 = 生成(物件, 座標, 角度)
                GameObject tempMarble = Instantiate(prefabMarble, pointSpawn.position, pointSpawn.rotation);
                //生成的彈珠.取得元件<鋼體>() . 添加推力(三維向量)

                //依照世界座標的Z軸發射
                //tempMarble.GetComponent<Rigibody>(). AddForce(new Vector3(0, 0, speedMarble));



                //依照腳色的Z軸發射
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);                
                ani.SetTrigger(parAttack);
                yield return new WaitForSeconds(intervalShoot);



            }
            

        }
        #endregion
    }
}

