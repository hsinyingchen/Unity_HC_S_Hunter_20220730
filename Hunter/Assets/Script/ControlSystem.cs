
using UnityEngine;

namespace Chen
{
    public class ControlSystem : MonoBehaviour
    {
        #region ���
        [Header("�򥻸��")]
        [SerializeField]
        private float speed = 10.5f;
        [SerializeField]
        private int countshootMarble = 10;
        [SerializeField, Range(0, 50000)]
        private int speedMarble = 1500;
        [SerializeField, Range(0, 3)]
        private float intervalShoot = 0.5f;
        [SerializeField, Header("�u�]�w�m��")]
        private GameObject prefabMarble;

        private string parAttack = "Ĳ�o����";
        #endregion




        


    }
}

