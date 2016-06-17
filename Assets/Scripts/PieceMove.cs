using UnityEngine;
using System.Collections;

public class PieceMove : MonoBehaviour {
        public float Speed=0f;
    	float lastFall;
      public float TimeStop = 1f;
    private Color[] color = new Color[7];
    public bool isOnViewMode;
    public Vector2 Velocity;
    private int i;
    // Use this for initialization
      void Start () {
        color[0] = Color.red;
        color[1] = Color.blue;
        color[2] = Color.green;
        color[3] = Color.yellow;
        color[4] = Color.white;
        color[5] = Color.magenta;
        color[6] = Color.grey;
     
    }
   // 
      // Update is called once per frame
      public void StartMove()
    {
        Speed = 1;
        isOnViewMode = false;
    }
   
	void Update() {
		
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			
			transform.position += new Vector3(-Speed, 0, 0);

			if (isValidGridPos())
				
				updateGrid();
			else
				
				transform.position += new Vector3(Speed, 0, 0);
		}


		else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			
			transform.position += new Vector3(Speed, 0, 0);


			if (isValidGridPos())
				updateGrid();
			else
				transform.position += new Vector3(-Speed, 0, 0);
		}


		else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isOnViewMode)
            {
                transform.Rotate(0, 0, -90);


                if (isValidGridPos())

                    updateGrid();
                else

                    transform.Rotate(0, 0, 90);
            }
		}        
		else if (Input.GetKeyDown(KeyCode.DownArrow)) 
		{
            // es q el codi que vam copiar no permetia lo del spawn a fora del grid
            // ho he canviat i ara 

            //  si fas baixar la peca amb el

            if(!isOnViewMode)
            transform.position += new Vector3(0, -1, 0);

        // si fem q amb down arrow pugui baixaer peta tot 
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {

            if (!isOnViewMode)
            {
                if (i == 6)
                {
                    i = 0;
                    SetColor(i);
                }
                else
                {
                    i++;
                    SetColor(i);
                }
            }

        }
        else if (  Time.time - lastFall >= GameManager.Instance.SpeedPices)
        {
            if (!isOnViewMode)
            {
                transform.position += new Vector3(0, -Speed, 0);


                if (isValidGridPos())
                {
                   // Debug.Log("VALID POS");
                    updateGrid();
                }
                else
                {

                 

                  //  Debug.Log("gg");
                    Grid.deleteFullRows();
                    FindObjectOfType<PiecesSpawner>().MoveToStartMoving();
                    FindObjectOfType<PiecesSpawner>().CreateToView();
                    
                

                    enabled = false;
                }
                lastFall = Time.time;
            }

            
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
    public void SetColor(int ii)
    {
        i = ii;
        GetComponent<SpriteRenderer>().color = color[i];

        foreach (SpriteRenderer a in GetComponentsInChildren<SpriteRenderer>())
        {
            a.material.color = GetComponent<SpriteRenderer>().color;

        }
    }

}
