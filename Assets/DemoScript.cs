using UnityEngine;
using UnityEngine.XR.WSA;
using UnityEngine.XR.WSA.Input;

public class DemoScript : MonoBehaviour {
    public string hololensIP;
    public GameObject cube;

    private bool _blueCube;
    private bool _connected;
    private GestureRecognizer _gestureRecognizer;

    private void Start() { HolographicRemoting.Connect(hololensIP); }

    private void Update() {
        if (HolographicRemoting.ConnectionState
            == HolographicStreamerConnectionState.Connected
            && !_connected) {
            _connected = true; // run a single time upon connection established
            
            _gestureRecognizer = new GestureRecognizer();
            _gestureRecognizer.Tapped += args => {
                _blueCube = !_blueCube;
                cube.GetComponent<MeshRenderer>().material.color = _blueCube ? Color.blue : Color.magenta;
            };
        
            _gestureRecognizer.StartCapturingGestures();
            _gestureRecognizer.SetRecognizableGestures(GestureSettings.Tap);
        }
    }
}