using UnityEngine;
using System.Collections;
using Vuforia;

public class HeadObjectController : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	private string whoAmI;
	private GameObject theChild;
	public GameObject HeadPiece;


	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			whoAmI = gameObject.name;

			if (whoAmI == "Arrival")
			{
				theChild = HeadPiece.transform.Find("Arrive").gameObject;
				theChild.SetActive(true);
		
			} 

			else if (whoAmI == "Attraction")
			{
				theChild = HeadPiece.transform.Find("Attract").gameObject;
				theChild.SetActive(true);
		
			}
			else if (whoAmI == "Intimacy")
			{
				theChild = HeadPiece.transform.Find("Intimate").gameObject;
				theChild.SetActive(true);

			}
			else if (whoAmI == "Departure")
			{
				theChild = HeadPiece.transform.Find("Depart").gameObject;
				theChild.SetActive(true);

			}
		}
		else
		{
			//foreach (Transform child in transform)

			//foreach (Transform child in HeadPiece.transform) 
			
			//{ HeadPiece.SetActive(false); }

			theChild = HeadPiece.transform.Find("Arrive").gameObject;
			theChild.SetActive(false);
			theChild = HeadPiece.transform.Find("Attract").gameObject;
			theChild.SetActive(false);
			theChild = HeadPiece.transform.Find("Intimate").gameObject;
			theChild.SetActive(false);
			theChild = HeadPiece.transform.Find("Depart").gameObject;
			theChild.SetActive(false);
		}
	}
		
}

	

	



	