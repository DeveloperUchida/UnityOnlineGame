using System;
using UnityEngine;
using Mirror;

public class CustomNetworkManager : NetworkManager
{
    // ホスト、クライアント、サーバーの開始/停止イベント
    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log("ホスト開始");
    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("クライアント開始");
    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("サーバー開始");
    }

    public override void OnStopHost()
    {
        base.OnStopHost();
        Debug.Log("ホスト停止");
    }

    public override void OnStopClient()
    {
        base.OnStopClient();
        Debug.Log("クライアント停止");
    }

    public override void OnStopServer()
    {
        base.OnStopServer();
        Debug.Log("サーバー停止");
    }

    // クライアントイベント
    public override void NetworkConnectionToClient(NetworkConnectionToClient conn)
    {
        Debug.Log("クライアント接続 : " + conn.connectionId);
    }

    public override void OnClientDisconnect(NetworkConnectionToClient conn)
    {
        Debug.Log("クライアント切断 : " + conn.connectionId);
    }

    public override void OnClientError(NetworkConnection conn, Exception exception)
    {
        Debug.LogError("クライアントエラー : " + exception);
    }

    public override void OnClientNotReady(NetworkConnection conn)
    {
        Debug.Log("クライアント準備未完了 : " + conn.connectionId);
    }

    public override void OnClientChangeScene(NetworkConnectionToClient conn, string newSceneName, SceneOperation sceneOperation, bool customHandling)
    {
        base.OnClientChangeScene(conn, newSceneName, sceneOperation, customHandling);
        Debug.Log("クライアントシーン変更 : " + newSceneName);
    }

    // サーバーイベント
    public override void OnServerConnect(NetworkConnectionToClient conn)
    {
        Debug.Log("サーバー接続 : " + conn.connectionId);
    }

    public override void OnServerDisconnect(NetworkConnectionToClient conn)
    {
        Debug.Log("サーバー切断 : " + conn.connectionId);
    }

    public override void OnServerError(NetworkConnection conn, Exception exception)
    {
        Debug.LogError("サーバーエラー : " + exception);
    }

    public override void OnServerReady(NetworkConnectionToClient conn)
    {
        Debug.Log("サーバー準備完了 : " + conn.connectionId);
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        Debug.Log("サーバープレイヤー追加 : " + conn.connectionId);
    }

    public override void OnServerChangeScene(string newSceneName)
    {
        base.OnServerChangeScene(newSceneName);
        Debug.Log("サーバーシーン変更 : " + newSceneName);
    }
}
