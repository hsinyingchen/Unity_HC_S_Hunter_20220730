
using UnityEngine;

namespace Chen
{
    public class LearnMethod : MonoBehaviour
    {
        //��k�y�k:
        //�׹��� �Ǧ^������� ��k�g�� (�Ѽ�) {�����϶� ���z�� �t��k}

        //�ۭq��k:���|���� �ݭn�I�s
        //VS 2019
        //��k�W�٨S���Q�I�s�ɷ|�H����
        //��k�W�٦��Q�I�s�ɷ|�G����
        //�Lvoid
        private void Test()
        {
            print("�ڬO���դ�k");
 
            }
		private void Awake()
		{
            //�I�s��k�y�k:
            //��k�W��():
            Test();
            Test();
            //�I�s���Ѽƪ���k�ݭn��J�������޼�
            NumberTest(10);
            NumberTest(999);

            ShootMarble(10, "�@��");
            ShootMarble(50, "���K");

            //���w�]�Ȫ��Ѽƥi�H���ο� �|�H�w�]��
            ShootMarble(7);

            //3, ���K, ���y
            ShootMarble(3, "���K", "���y");

            //9, �@��, �{�q
            ShootMarble(9, "�{�q");             //���~���浲�G: 9,�{�q,���I     
            ShootMarble(9, effect: "�{�q");

		}
        //�Ѽƻy�k:
        //���� �Ѽ� 1 �W�� ���� �T�� 2 �W��... (�S���W��)
        private void NumberTest(int number1) 
        {
            //= ���w�B��l
            //��������w�B��l�k�� �b���w���G������
            number1 = number1 + 10;
          print("�Ʀr�[10�����G:" + number1);
        }

        //�Ѽƹw�]��
        //���� �ѼƦW�� ���w �w�]��
        private void ShootMarble(int count, string type = "�@��", string effect = "���I") 
        {
            print("�u�]�ƶq:" + count);
            print("�u�]�ݩ�:" + type);
            print("�u�]�S��:" + effect);

            //���w�]�Ȫ��Ѽƥ����g�b�᭱

        }


	}


}

