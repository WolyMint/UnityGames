using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {
	public float maxSpeed = 10f;
	public float jumpForce = 700f;
	bool facingRight = true;
	bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float score;
	public float move;
	public float spawnX, spawnY;

	private GameObject star;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {


		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);

		move = Input.GetAxis ("Horizontal");

	}

	void Update(){
		if (grounded && (Input.GetKeyDown (KeyCode.W)||Input.GetKeyDown (KeyCode.UpArrow))) {

			GetComponent<Rigidbody2D>().AddForce (new Vector2(0f,jumpForce));
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();



		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}

		if (Input.GetKey(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}


	}
	
	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

     void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.name == "die" || col.gameObject.name == "border")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "die1" || col.gameObject.name == "border1")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "die2" || col.gameObject.name == "border2")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "die3" || col.gameObject.name == "border3")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "die4" || col.gameObject.name == "border4")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "die5" || col.gameObject.name == "border5")
			Application.LoadLevel(Application.loadedLevel);
		//transform.position = new Vector3 (spawnX, spawnY, transform.position.z);

		if (col.gameObject.name == "exit" && score == 3) {
			score = 0;
			Application.LoadLevel ("Level1");
		}
		
		if (col.gameObject.name == "exit1" && score == 3) {
			score = 0;
			Application.LoadLevel ("Level2");
		}

		if (col.gameObject.name == "exit2" && score == 3) {
			score = 0;
			Application.LoadLevel ("Level3");
		}

		if (col.gameObject.name == "exit3" && score == 3) {
			score = 0;
			Application.LoadLevel ("Level4");
		}

		if (col.gameObject.name == "exit4" && score == 5) {
			score = 0;
			Application.LoadLevel ("Level5");
		}
	}
		void OnTriggerEnter2D (Collider2D col){
			if (col.gameObject.name == "money") {
				Destroy (col.gameObject);
				score++;

			}
		}

		void OnGUI (){
			GUI.Box (new Rect (0,0,100,30), "money:" + score);
	}
}