
using System.Collections;
using UnityEngine;

namespace Chen
{



    public class LearnCoroutine : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(Test());

        }
        private IEnumerator Test()
        {
            print("�Ĥ@�q�{��");
            yield return new WaitForSeconds(2);
            print("�������,�ĤG�q�{��");
            yield return new WaitForSeconds(3);
            print("�T������,�ĤG�q�{��");


        }

    }



}
