using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoad : MonoBehaviour
{
        public int score = 0; // تحديد متغير score

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            Application.LoadLevel("Level2");
        }
        
    
    if (score == 3)
        {
            // إذا كانت قيمة score تساوي 3، قم بتحميل المستوى القادم هنا
            LoadNextLevel();
        }
    }

    // دالة لتحميل المستوى القادم
    void LoadNextLevel()
    {
        // يمكنك هنا تحديد اسم المستوى القادم للانتقال إليه بعد الحصول على النقاط اللازمة
        string nextLevelName = "Level2"; // افترضنا أن اسم المستوى القادم هو "Level3"
        Application.LoadLevel(nextLevelName); // قم بتحميل المستوى القادم
    }
}
