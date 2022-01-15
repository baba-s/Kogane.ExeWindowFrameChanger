# Kogane Exe Window Frame Changer

Windows 向けにビルドした .exe のウィンドウのフレームをボーダーレスに変更できる機能

![](https://user-images.githubusercontent.com/6134875/149616716-eb0ecbb9-b543-45fe-8c85-1892feaa7c44.gif)

## 使用例

```cs
#if UNITY_EDITOR || UNITY_STANDALONE_WIN

using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Z ) )
        {
            ExeWindowFrameChanger.ChangeToBorderless();
        }
        else if ( Input.GetKeyDown( KeyCode.X ) )
        {
            ExeWindowFrameChanger.ChangeToDefault();
        }
    }
}

#endif
```