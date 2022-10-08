
using UnityEngine;

namespace Chen
{
    /// <summary>
    /// �ǲ����
    ///
    /// </summary>
 
    public class LearnField : MonoBehaviour
    {
        //���y�k:
        //�׹��� ������� ���W��;
        private int number;
        //�׹��� ������� ���W��;
        private int level = 1;
        //�p�H:�����O�i�H�s�� ���|��ܦb�ݩʭ��O
        private int scoreA = 60;
        //���}:�Ҧ����O�i�H�s�� �|��ܦb�ݩʭ��O
        //��� int
        public int scoreB = 90;
        //�B�I�� float
        public float speed = 3.5f;
        //�r�� string
        public string weapon = "���b��";
        //���L��
        public bool isDead = false;
        public bool isGrounded = true;

        #region Unity �`������
        //�V�q
        public Vector2 v2Position;
        public Vector2 v2One = Vector2.one;
        public Vector2 v2Custom = new Vector2(7.5f, 9.5f);
        public Vector2 v3Custom = new Vector3(1, 2, 3);
        public Vector2 v4Custom = new Vector4(9, 8, 7, 6);

        //�C��
        public Color colorDefult;
        public Color colorRed = Color.red;
        public Color colorCustom = new Color(1, 0, 1);
        public Color colorCustomRGBA = new Color(0, 1, 0, 0.5f);

        //�C�|��� ����
        public KeyCode keyA = KeyCode.A;
        public KeyCode keyJumo = KeyCode.Space;
        public KeyCode keyFire = KeyCode.Mouse0;

        //��������:������w�� �z�L API �Ϊ��ݩʭ��O�즲
        public AudioClip soundAttack;
        public Sprite picureWin;
        public Material materialDissolve;
        
        //�C������:���h���O�P�M�פ�������ιw�m��
        public GameObject goBlue;
        public GameObject prefabMarble;
       
        //����
        public ParticleSystem psLight;
        public Camera maimCamera;


        #endregion


        public void Awake()
        {
            // �� ���o��� Get
            // ���W��
            //�H Unity �ݩʭ��O���D
            print(level);
            print("�t��:" + speed);
            //�s �s���� Set
        }
    #region ����ݩ� Field Attribute
    [Header("���D")]
    public int testint = 10;
    [Tooltip("�ڬO����")]
    public float testfloat = 3.5f;
    [Range(10, 100)]
    public int numberTest = 99;
    [Range(2.5f, 7.5f)]
    public float numberFloatTest = 5.5f;
    //Range �u���b��ƤίB�I��W
    public bool booltest;
        [SerializeField]
        private string weaponName = "���u�M";



    #endregion

    }

}
