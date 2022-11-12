
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Chen
{

    /// <summary>
    /// 生成系統
    /// </summary>


    public class SpawnSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("怪物預置物")]
        private GameObject[] prefabEnemys;
        [SerializeField, Header("怪物生成第二排")]
        private Transform[] traSpawnPoints;
        [Header("生成數量 : 最小與最大值")]
        [SerializeField]
        private int minEnemy = 2;
        [SerializeField]
        private int maxEnemy = 5;
        [SerializeField, Header("第二排的格子清單")]
        private List<Transform> listSpawnPoints = new List<Transform>();
        [SerializeField, Header("彈珠格子")]
        private GameObject prefabMarble;

        #endregion

        #region 事件
        private void Awake()
        {
            SpawnEnemy();
        }
        #endregion

        #region 方法
        ///<summary>
        ///生成敵人
        ///</summary>
        private void SpawnEnemy()
        {
            int randomCount = Random.Range(minEnemy, maxEnemy + 1);
            print("<color=#3366aa>敵人隨機數量:" + randomCount + "</color>");

            int countToDelete = traSpawnPoints.Length - randomCount;
            print("<color=red>要刪除的數量:" + countToDelete + "</color>");

            listSpawnPoints = traSpawnPoints.ToList();

            System.Random random = new System.Random();

            listSpawnPoints = listSpawnPoints.OrderBy(item => random.Next()).ToList();

            for (int i = 0; i < countToDelete; i++) listSpawnPoints.RemoveAt(0);

            for (int i = 0; i < randomCount; i++)
            {
                
                Vector3 pos = listSpawnPoints[i].position;
               

                if (i == 0)
                {
                    Instantiate(prefabMarble, pos, Quaternion.identity);

                }
                else 
                {
                    int randomEnemy = Random.Range(0, prefabEnemys.Length);
                    Instantiate(prefabEnemys[randomEnemy], pos, Quaternion.identity);
                
                }




            }

        }
        #endregion



    }




}
    
