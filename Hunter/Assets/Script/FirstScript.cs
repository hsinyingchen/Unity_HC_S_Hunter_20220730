//������
using UnityEngine;//�ޥ�Unity�C���R�W�Ŷ�;�ܮw��θ�ƥ\��
//�}��=���O
/*�h�����
 * 
 * 
 */
namespace Chen
{
    /// <summary>
    /// �K�n:���U�����÷|�X�{�b�sĶ���W
    /// First script �Ĥ@�Ӹ}���ǲ� C#��¦�PUnity
    /// </summary>

    public class FirstScript : MonoBehaviour
    {
        #region ��ưϰ�
        //
        //
        //
        #endregion

        #region �ƥ�ϰ�:Unity �J�f
        /// <summary>
        /// ����ƥ�:�C���}�l�æbStart�e ����@��
        /// </summary>
        private void Awake()
        {
            print("���O, �A�n~");
        }
        /// <summary>
        /// �}�l�ƥ�:�C���}�l�æbAwake�� ����@��
        /// </summary>
        private void Start()
        {
            print("�}�l�ƥ�!");
            //rich text
            print("<color=yellow>�����r</color>");
            print("<color=#006699>�ź��</color>");

            
        }

        #endregion

    }
}

