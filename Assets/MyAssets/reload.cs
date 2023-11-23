using UnityEngine;

public class Reload : MonoBehaviour
{
    // 入力ボタンフィールをを作成できる
    [SerializeField] private OVRInput.RawButton inputBtn;

    private void Update()
    {
        // 指定したボタンが押されたら
        if (OVRInput.GetDown(inputBtn))
        {
            Gun gun; //呼ぶスクリプトにあだなつける
            GameObject obj = GameObject.Find("OVRRuntimeControllerPrefabR");
            gun = obj.GetComponent<Gun>(); //付いているスクリプトを取得
            gun.magazine = 10;
        }
    }
}