using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour {
        public float Speed=0.5f;
    	float lastFall;
      public float TimeStop = 1f;
      public Vector2 Velocity;      // Use this for initialization
      void Start () {

      }

      // Update is called once per frame
	void Update() {
		
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			
			transform.position += new Vector3(-1, 0, 0);

			if (isValidGridPos())
				
				updateGrid();
			else
				
				transform.position += new Vector3(1, 0, 0);
		}


		else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			
			transform.position += new Vector3(1, 0, 0);


			if (isValidGridPos())
				updateGrid();
			else
				transform.position += new Vector3(-1, 0, 0);
		}


		else if (Input.GetKeyDown(KeyCode.Space)) 
		{
			transform.Rotate(0, 0, -90);


			if (isValidGridPos())
				
				updateGrid();
			else
				
				transform.Rotate(0, 0, 90);
		}


		else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - lastFall >= 1) 
		{
			
			transform.position += new Vector3(0, -1, 0);


			if (isValidGridPos()) {
				
				updateGrid();
			} else {
				
				transform.position += new Vector3(0, 1, 0);


				Grid.deleteFullRows();

			
				FindObjectOfType<PiecesSpawner>().Create();


				enabled = false;
			}

			lastFall = Time.time;
		}
	}

	bool isValidGridPos()
	{        
		foreach (Transform child in transform)
		{
			Vector2 v = Grid.roundVec2(child.position);
			if (!Grid.insideBorder(v))
				return false;
			if (Grid.grid[(int)v.x, (int)v.y] != null 
				&& Grid.grid[(int)v.x, (int)v.y].parent != transform)
				return false;
		}
		return true;
	}
	void updateGrid() 
	{
		for (int y = 0; y < Grid.rows; ++y) 
		{
			for (int x = 0; x < Grid.col; ++x) 
			{
				if (Grid.grid [x, y] != null)
				if (Grid.grid [x, y].parent == transform)
					Grid.grid [x, y] = null;
			}
		}
		foreach (Transform child in transform) 
		{
			Vector2 v = Grid.roundVec2(child.position);
			Grid.grid[(int)v.x, (int)v.y] = child;
		}        
	}

}
