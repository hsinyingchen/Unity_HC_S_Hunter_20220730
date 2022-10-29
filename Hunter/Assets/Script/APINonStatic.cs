
using UnityEngine;
namespace Chen
{
    /// <summary>
    /// �ǲ߫D�R�AAPI
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        //�R�A:static �s�b�O���餺,��C������S�����Y
        //Time,Random

        //�D�R�A:�w�]���s�b�O���餺,��C���������Y
        //Transform

        //1.�D�R�A�ݩ� Properties

        //1-1 ���o Get
        //�y�k:
        //�B�J�@:�w�q����x�s�C�����
        //���W��:�D�R�A�ݩ�

        //�B�J�G:�T�w�Ӫ��󦳦�����
        //�Ҧp:�O�� Light

        public Transform traA;
        public Light lightA;

        public Transform traPlayer;
        public Camera camMain;

        public Transform traGhost;

        private void Awake()
        {
            print("�y��:" + traA.position);

            print("�O���C��" + lightA.color);
            //�߿W�ݩʤ���]�w
            //traPlayer.lossyScale = Vector3.one * 2;

            traPlayer.localScale = Vector3.one * 2;


        }
        
        
        public BoxCollider cube;
        public AudioSource aud;
        public Canvas canvas;

        public Rigidbody rigiSphere;

        public Transform traCube;
        public Transform traSphere;
        public Transform traCapsule;

        private void Start()
        {
            print("�ߤ���I�������ؤo:" + cube.size);
            print("���������q:" + aud.volume);
            print("�e������V�Ҧ�" + canvas.renderMode);

            cube.center = new Vector3(1, 3, 1);
            aud.volume = 0.5f;
            canvas.renderMode = RenderMode.WorldSpace;

            rigiSphere.AddForce(0, 1500, 0);
            
        }
        private void Update()
        {
            traGhost.Rotate(0, 30, 0);

            traCube.LookAt(traSphere);

            traCapsule.Translate(0, 0, 3);


        }

    }



}

