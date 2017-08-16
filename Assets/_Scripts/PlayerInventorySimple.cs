using UnityEngine;
using UnityEngine.UI;

public class PlayerInventorySimple : MonoBehaviour
{
	// reference to a UI Text object
	// public - so we have to assign via the Inspector
	public Text starText;

	// flag to indicate if player is carrying a star or not
	private bool carryingStar = false;

	//------------------------
	// ensure UI display matches this initial state
	// of whether we are carrying a star or not
	void Start()
	{
		UpdateStarText();
	}

	//--------------------------
	// when we hit a star, update carrying flag
	// and update the display
	// (and remove the star GameObject)
	void OnTriggerEnter2D(Collider2D hit)
	{
		if (hit.CompareTag("Star"))
		{
			carryingStar = true;
			UpdateStarText();
			Destroy(hit.gameObject);
		}
	}

	//------------------------------
	// update the text message on screen
	// to indicate if we are carrying the star or not
	private void UpdateStarText()
	{
		string starMessage = "no star :-(";
		if (carryingStar)
            starMessage = "Carrying star :-)";
		starText.text = starMessage;
	}
}