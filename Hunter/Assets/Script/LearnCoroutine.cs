
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
            print("第一段程式");
            yield return new WaitForSeconds(2);
            print("兩秒後執行,第二段程式");
            yield return new WaitForSeconds(3);
            print("三秒後執行,第二段程式");


        }

    }



}
