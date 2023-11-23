using UnityEngine;
using UnityEngine.UI;
public class Gun : MonoBehaviour
{
    // ここで指定したオブジェクトの位置や角度を基準にする
    [SerializeField] private GameObject controlPoint;

    // 入力ボタンフィールをを作成できる
    [SerializeField] private OVRInput.RawButton inputBtn;

    // 生成するオブジェクト
    [SerializeField] private GameObject ball;

    // マガジンの座標
    [SerializeField] private GameObject magazinePoint;


    public int magazine = 5;
    public Text TextFrame;


    bool flag = true;
    private void Update()
    {
        Vector3 magazinePointPos = magazinePoint.transform.position;
        float dis = Vector3.Distance(magazinePointPos, this.transform.position);
        // 指定したボタンが押されたら
        if (OVRInput.GetDown(inputBtn) && magazine > 0 && dis < 0.3)
        {
            magazine = magazine - 1;
            // ballをcontrolPointの位置と角度に合わせて生成する
            GameObject newBall = Instantiate(ball, controlPoint.transform.position, controlPoint.transform.rotation);

            Transform myTransform = newBall.transform;

            // ローカル座標を基準に、回転を取得して調整
            Vector3 localAngle = myTransform.localEulerAngles;
            localAngle.x = localAngle.x + 10f; // 調整
            localAngle.y = localAngle.y - 10f; // 調整
            localAngle.z = localAngle.z;
            myTransform.localEulerAngles = localAngle; // 回転角度を設定

            Rigidbody rb = newBall.GetComponent<Rigidbody>();  // rigidbodyを取得
            float power = 40.0f;
            rb.AddForce(newBall.transform.forward * power, ForceMode.Impulse);  // 力を加える
        }
        TextFrame.text = string.Format(magazine + "");
    }
}