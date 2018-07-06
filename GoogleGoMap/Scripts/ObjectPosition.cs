using UnityEngine;
using System.Collections;

public class ObjectPosition : MonoBehaviour {
	public GoogleStaticMap mainMap;

    public bool local=false;
	public float lat_d = 0.0f, lon_d = 0.0f;

	private GeoPoint pos;


	void Awake (){
		pos = new GeoPoint ();
		pos.setLatLon_deg (lat_d, lon_d);
	}
    public void Update()
    {
       
      
    }
    public void setPositionOnMap () {
		Vector2 tempPosition = GameManager.Instance.getMainMapMap ().getPositionOnMap (this.pos);
     
            transform.position = new Vector3 (120.42f,935, 0);
    
       }

	public void setPositionOnMap (GeoPoint pos) {
		this.pos = pos;
		setPositionOnMap ();
	}

}
