#include <iostream>
#include <vector>
using namespace std;
class Cell{
public:
	Cell();
};
Cell::Cell(){

}
class Board{
public:
	int sideSize;
	Board(int sideSize);
	vector<Cell> cells;
	int* getAdjacents(int cellIndex);
	int rowColToIndex(int row,int col){return row*sideSize+col%sideSize;}
//	int* indexToRowCol(int index){int temp[]={index/sideSize,index%sideSize};return temp;}
	bool inBounds(int row, int col){return row >= 0 && row < sideSize && col < sideSize && col >= 0;}

};
Board::Board(int sideSize){
	this->sideSize = sideSize;
	//cells = new vector<Cell>(sideSize*sideSize);
	for(int i=0;i< sideSize*sideSize;++i){
		cells.push_back(Cell());
	}
}
int* Board::getAdjacents(int cellIndex){
	int adjacents[4];
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
	/*
	int* tempRowCol = indexToRowCol(cellIndex);
	if(inBounds(tempRowCol[0]+1,tempRowCol[1])){

	}else{

	}

	if(inBounds(tempRowCol[0],tempRowCol[1]+1)){

	}else{
		
	}
	if(inBounds(tempRowCol[0]-1,tempRowCol[1])){

	}else{
		
	}
	if(inBounds(tempRowCol[0],tempRowCol[1]-1)){

	}else{
		
	}
	*/
}
enum Directions{N,E,S,W};
int main(){		
	cout<<"wakka\n";
	Board board = Board(5);
	//for(int k = 0; k < 4; k++){
	//	cout<<board.getAdjacents(24)[k]<<endl;
	//}
	return 0;
}