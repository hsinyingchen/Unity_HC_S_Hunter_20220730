
using UnityEngine;
namespace Chen
{
    /// <summary>
    /// 學習非靜態API
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        //靜態:static 存在記憶體內,跟遊戲物件沒有關係
        //Time,Random

        //非靜態:預設不存在記憶體內,跟遊戲物件有關係
        //Transform

        //1.非靜態屬性 Properties

        //1-1 取得 Get
        //語法:
        //步驟一:定義欄位儲存遊戲資料
        //欄位名稱:非靜態屬性

        //步驟二:確定該物件有此元件
        //例如:燈光 Light

        public Transform traA;
        public Light lightA;

        public Transform traPlayer;
        public Camera camMain;

        public Transform traGhost;

        private void Awake()
        {
            print("座標:" + traA.position);

            print("燈光顏色" + lightA.color);
            //唯獨屬性不能設定
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
            print("立方體碰撞器的尺寸:" + cube.size);
            print("音源的音量:" + aud.volume);
            print("畫布的渲染模式" + canvas.renderMode);

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

