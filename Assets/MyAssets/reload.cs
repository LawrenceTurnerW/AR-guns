using UnityEngine;

public class Reload : MonoBehaviour
{
    // ここで指定したオブジェクトの位置や角度を基準にする
    [SerializeField] private GameObject gunPoint;

    // 入力ボタンフィールをを作成できる
    [SerializeField] private OVRInput.RawButton inputBtn;

    private void Update()
    {
        Vector3 gunPointPos = gunPoint.transform.position;
        float dis = Vector3.Distance(gunPointPos, this.transform.position);
        // 指定したボタンが押されたら
        if (OVRInput.GetDown(inputBtn) && dis > 0.4)
        {
            Gun gun; //呼ぶスクリプトにあだなつける
            GameObject obj = GameObject.Find("OVRRuntimeControllerPrefabR");
            gun = obj.GetComponent<Gun>(); //付いているスクリプトを取得
            gun.magazine = 10;
        }
    }
}