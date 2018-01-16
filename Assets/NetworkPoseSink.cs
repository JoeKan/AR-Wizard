using UnityEngine;
using System.Collections;

using System;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.IO;

/*public class RegisterHostMessage : MessageBase
{
    public string dataString;
}*/

//Vorher NetworkPoseSink jetzt auf UnityPerspektive geändert
/*public class NetworkPoseSink : MonoBehaviour
{
    private int port = 41845;
    private string id = "holoPose";
    static readonly DateTime StartOfEpoch = new DateTime(1970, 1, 1);
    NetworkClient myClient;
    // RegisterHostMessage msg = new RegisterHostMessage();
    //public const short RegisterHostMsgId = 888;
    string dataString;
    float rotX, rotY, posZ;
    //Camera m_MainCamera;
    private GameObject cam;
    private const short sendMsgID = 123;

    private IEnumerator coroutine;

    // Use this for initialization
    void Start()
    {
        //m_MainCamera = Camera.main;
        cam = GameObject.FindWithTag("MainCamera");
        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myClient.RegisterHandler(MsgType.Disconnect, OnDisconnected);
       // InvokeRepeating("SetupClient", 2.0f, 5.0f);
        SetupClient();
    }

  
    void OnEnable()
    {
        //Establish a Connection

    }

    void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if (myClient.isConnected == false) return;

         if (!connected) return;

        /*rotX = -1.0f * cam.transform.rotation.x;
        rotY = -1.0f * cam.transform.rotation.y;
        posZ = -1.0f * cam.transform.position.z;

        dataString = "22 serialization::archive 13 8 " + id + " 0 0 " + (ulong)getUbitrackTimeStamp() + " 0 0 0 0 "
                 + rotX + " " + rotY + " " + cam.transform.rotation.z.ToString()
                 + " " + cam.transform.rotation.w.ToString() + " 0 0 " + cam.transform.position.x.ToString() + " " + cam.transform.position.y.ToString()
                 + " " + posZ + " " + ((ulong)getUbitrackTimeStamp() + 100000) + " 1";

        dataString = cam.transform.position.x.ToString() + " " + cam.transform.position.y.ToString() + " " + cam.transform.position.z.ToString()
            + " " + cam.transform.rotation.x.ToString() + " " + cam.transform.rotation.y.ToString() + " " 
            + cam.transform.rotation.z.ToString() + " " +cam.transform.rotation.w.ToString();

        byte[] data = Encoding.ASCII.GetBytes(dataString);

        try
        {
            myClient.Send(sendMsgID, new StringMessage(dataString));
            Debug.Log("numeber of bytes:" + data.Length);
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

    private ulong getUbitrackTimeStamp()
    {
        ulong millis = (ulong)(DateTime.UtcNow - StartOfEpoch).Ticks / TimeSpan.TicksPerMillisecond;
        return millis * 1000000;
    }

    bool connected = false;

    void SetupClient()
    {
        try
        {
            Debug.Log("start SetupClient");
            if(!connected)
                myClient.Connect("131.159.10.129", port);
           // return myClient.isConnected;
        }

        catch (Exception e)
        {
            Debug.Log(e.ToString());
           // return false;
        }
    }

    public void OnConnected(NetworkMessage netMsg) {
        Debug.Log("Connected to server ");
        connected = true;
    }

    public void OnDisconnected(NetworkMessage netMsg)
    {
        Debug.Log("Disconnected from server ");
        connected = false;
    }
}

    */

