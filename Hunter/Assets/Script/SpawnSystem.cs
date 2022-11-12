
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Chen
{

    /// <summary>
    /// �ͦ��t��
    /// </summary>


    public class SpawnSystem : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("�Ǫ��w�m��")]
        private GameObject[] prefabEnemys;
        [SerializeField, Header("�Ǫ��ͦ��ĤG��")]
        private Transform[] traSpawnPoints;
        [Header("�ͦ��ƶq : �̤p�P�̤j��")]
        [SerializeField]
        private int minEnemy = 2;
        [SerializeField]
        private int maxEnemy = 5;
        [SerializeField, Header("�ĤG�ƪ���l�M��")]
        private List<Transform> listSpawnPoints = new List<Transform>();
        [SerializeField, Header("�u�]��l")]
        private GameObject prefabMarble;

        #endregion

        #region �ƥ�
        private void Awake()
        {
            SpawnEnemy();
        }
        #endregion

        #region ��k
        ///<summary>
        ///�ͦ��ĤH
        ///</summary>
        private void SpawnEnemy()
        {
            int randomCount = Random.Range(minEnemy, maxEnemy + 1);
            print("<color=#3366aa>�ĤH�H���ƶq:" + randomCount + "</color>");

            int countToDelete = traSpawnPoints.Length - randomCount;
            print("<color=red>�n�R�����ƶq:" + countToDelete + "</color>");

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
    
