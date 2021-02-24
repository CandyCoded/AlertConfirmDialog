# AlertConfirmDialog

> ⚠️ Display simple alert and confirm dialogs on both iOS and Android.

[![npm](https://img.shields.io/npm/v/xyz.candycoded.alertconfirmdialog)](https://www.npmjs.com/package/xyz.candycoded.alertconfirmdialog)

## Installation

### Unity Package Manager

<https://docs.unity3d.com/Packages/com.unity.package-manager-ui@2.0/manual/index.html>

#### Git

```json
{
  "dependencies": {
    "xyz.candycoded.alertconfirmdialog": "https://github.com/CandyCoded/alertconfirmdialog.git#v1.0.0",
    ...
  }
}
```

#### Scoped UPM Registry

```json
{
  "dependencies": {
    "xyz.candycoded.alertconfirmdialog": "1.0.0",
    ...
  },
  "scopedRegistries": [
    {
      "name": "candycoded",
      "url": "https://registry.npmjs.com",
      "scopes": ["xyz.candycoded"]
    }
  ]
}
```

# Usage

First include the package.

```csharp
using CandyCoded.AlertConfirmDialog;
```

### Alert

```csharp
AlertConfirmDialog.Alert("Title", "Message");
```

```csharp
AlertConfirmDialog.Alert("Title", "Message", () =>
{

    Debug.Log("Ok");

});
```

### Confirm

```csharp
AlertConfirmDialog.Confirm("Title", "Message");
```

```csharp
AlertConfirmDialog.Confirm("Title", "Message", () =>
{

    Debug.Log("Ok");

});
```

```csharp
AlertConfirmDialog.Confirm("Title", "Message", () =>
{

    Debug.Log("Ok");

}, () =>
{

    Debug.Log("Cancel");

});
```
