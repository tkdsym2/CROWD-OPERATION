# Dummy Cursor Algorithm

ダミーカーソの動きアルゴリズムについてのdocument．

## ダミーカーソルのアルゴリズム

[相澤ら](https://www.dropbox.com/s/p9m7rllimc8fnvs/HCI184_zawa.pdf?dl=0) の回転アルゴリズムを現在では採用．他人のカーソル軌跡再生は実装予定なし．

## アルゴリズム記述箇所

`/Assets/Scripts/Public/MoveFunction.cs` の95行目 `CalcDirection()` 内

```csharp
(前略)
private static Vector3 CalcDirection(float _angle, Vector3 _direction)
{
    float _drangle = _angle;
    float moveRad = (float)(System.Math.PI * _drangle / 180.0);
    float rad = (float)(System.Math.Atan2(_direction.y, _direction.x) + moveRad);
    float moveDist = _direction.magnitude;
    float relativeX = (float)(moveDist * System.Math.Cos(rad));
    float relativeY = (float)(moveDist * System.Math.Sin(rad));
    Vector3 addDirection = new Vector3(relativeX, relativeY, 0);
    return addDirection;
}
(後略)
```

### 引数

- `_angle` ... `/Assets/Scripts/DemoScene/DummyCursor/DummyCreator.cs` や `/Assets/Scripts/Expetiments/DummyCursor/ExDummyCreator.cs` 内で実行している `GenerateDummyCursor()` で生成した角度
- `_direction` ... ユーザの動かしているマウスの移動量
