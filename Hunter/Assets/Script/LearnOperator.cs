
using UnityEngine;

namespace Chen 
{
    /// <summary>
    /// �ǲ߹B��l
    /// 1.�ƾ�
    /// 2.���
    /// 3.�޿�
    /// 4.�T��
    /// </summary>
    public class LearnOperator : MonoBehaviour
    {
        private void Awake()
        {
            //OperatorMath();
            //OperatorComparison();
            //OperatorLogic();
        }

        private float a = 10, b = 3;

        ///<summary>
        ///�ƾǹB��l
        ///<summary>
        private void OperatorMath() 
        { 
        //�[,��,��,��,�l,
        
            print("�[�k" + (a + b));   //13
            print("��k" + (a - b));   //7
            print("���k" + (a * b));   //30
            print("���k" + (a / b));   //3.333
            print("�l��" + (a % b));   //1

        }
        ///<summary>
        ///����B��l
        ///<summary>
        private void OperatorComparison() 
        { 
        //�j��,�p��, �j�󵥩�, �p�󵥩�, ����, ������
        //����B��l�����G�����L��, ��truw, false
        print ("�j��" + (a > b));        //t
        print ("�p��" + (a < b));        //f
        print ("�j�󵥩�" + (a >= b));        //t
        print ("�p�󵥩�" + (a <= b));        //f
        print ("����" + (a == b));        //f
        print ("������" + (a != b));        //t
                        
        }
        private void OperatorLogic() 
        {
            //�åB, �Ϊ�, �A��
            //�åB: �����ӥ��L��
            //�u�n�䤤�@�ӥ��L�ȵ���f, �h���G��f
            print(true && true);          //t
            print(true && false);          //f
            print(false && true);          //f
            print(false && false);          //f

            //�Ϊ�:�����ӥ��L��
            //�u�n�䤤�@�ӥ��L�ȵ���t, �h���G��t
            print(true || true);          //t
            print(true || false);          //t
            print(false || true);          //t
            print(false || false);          //f

            //�A��
            //�N���L�ȥ洫
            print(!true);          //f
            print(!false);          //t
            print(!(a > b));          //f


        }


    }

}

