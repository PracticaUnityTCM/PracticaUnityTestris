using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PieceMove : MonoBehaviour {
    public float Speed=0f;
   float lastFall;
   public float TimeStop = 1f;
    private Color[] color = new Color[8];
    public bool isOnViewMode;
    public Vector2 Velocity;
    private int i;
    private int numLastFall=0;
    private float posUltimaPeca;
    // Use this for initialization
      void Start () {
        color[0] = Color.red;
        color[1] = Color.blue;
        color[2] = Color.green;
        color[3] = Color.yellow;
        color[4] = Color.white;
        color[5] = Color.magenta;
        color[6] = Color.grey;
        color[7] = Color.black;
        
        var ii = Random.Range(0, 3);
        if (ii == 0)
        {
            SetColor(7);
        }
        else
        { i = Random.Range(0,6);
            SetColor(i);
        }
        
       
    }
  
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
				transform.position += new Vector3(-Speed , 0, 0);
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
            
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {

            if (!isOnViewMode && GameManager.Instance.IsHardDificulty)
            {
                if (!gameObject.GetComponent<SpriteRenderer>().color.Equals(Color.black))
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
          
        }
        else if (  Time.time - lastFall >= GameManager.Instance.SpeedPices)
        {
            if (!isOnViewMode)
            {
          
                transform.position += new Vector3(0, -Speed, 0);


                if (isValidGridPos())
                {
                    
                    updateGrid();
                                

                }
                else
                {
                  
                    float yMesAlta = 0;
                    foreach (Transform child in transform)
                    {

                        if (child.transform.position.y > yMesAlta)
                            yMesAlta = child.transform.position.y;
                    }
                    if (yMesAlta >= 20)
                    {
                       GameManager.Instance.currentState = Menu.State.End;
                      }
                   
                    if (!GameManager.Instance.IsHardDificulty)
                    {
                        Grid.deleteFullRows();
                        FindObjectOfType<PiecesSpawner>().MoveToStartMoving();
                        FindObjectOfType<PiecesSpawner>().CreateToView();
                    }
                    else
                    {
                        Grid.CheckColorRowsGrid(gameObject.GetComponent<SpriteRenderer>().color);
                        FindObjectOfType<PiecesSpawner>().Create();
                    }
                     
                    
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
        GetComponent<SpriteRenderer>().color = color[ii];
   
        foreach (SpriteRenderer a in GetComponentsInChildren<SpriteRenderer>())
        {
            a.material.color = color[ii];
        }
    }
    
}
