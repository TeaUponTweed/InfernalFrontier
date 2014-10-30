using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Wakka : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public class Board{

		public class Coord{
			public int row;
			public int col;
			
			public Coord(int row,int col){
				this.row = row;
				this.col = col;
				
			}
			public int x(){
				return col;
			}
			public int y(){
				return row;
			}
		}
		Coord indexToRowCol(int index){
			return new Coord(index/sideSize,index%sideSize);
		}
		public class Cell{
			Coord coordinates;
			public Cell(Coord coordinates){
				this.coordinates = coordinates;
			}
		}
		int sideSize;
		List<Cell> cells = new List<Cell>();
		Board(int sideSize){
			this.sideSize = sideSize;
			for(int i=0;i< sideSize*sideSize;++i){
				cells.Add(new Cell(indexToRowCol(i)));
			}
		}

		int rowColToIndex(int row,int col){
			return row*sideSize+col%sideSize;
		}
		int rowColToIndex(Coord coord){
			return rowColToIndex (coord.row,coord.col);
		}

		bool inBounds(int row, int col){return row >= 0 && row < sideSize && col < sideSize && col >= 0;}
		int[] getAdjacentsDirection(int cellIndex){
			int[] adjacents = new int[4];
			if (cellIndex/sideSize == 0){
				adjacents[0] = -1;
			}else{
				adjacents[0] = cellIndex-sideSize;
			}
			if (cellIndex/sideSize == sideSize-1){
				adjacents[2] = -1;
			}else{
				adjacents[2] = cellIndex+sideSize;
			}
			
			if (cellIndex%sideSize == 0){
				adjacents[3] = -1;
			}else{
				adjacents[3] = cellIndex-1;
			}
			if (cellIndex%sideSize == sideSize-1){
				adjacents[1] = -1;
			}else{
				adjacents[1] = cellIndex+1;
			}
			return adjacents;
		}
		List<int> getAllAdjecents(int cellIndex){
			int[] adj = getAdjacentsDirection (cellIndex);
			List<int> adjacent = new List<int> ();
			for (int i = 0; i < 4; i++) {
				if(adj[i] >=0){
					adjacent.Add(adj[i]);
				}
			}
			return adjacent;
		}
	}
	public void displayBoard(ref Board b){

	}
	enum Directions{N,E,S,W};
}
