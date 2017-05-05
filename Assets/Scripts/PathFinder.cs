using System.Collections.Generic;

public static class PathFinder
{
	public static List<Grid.Position> FindPath( Tile[,] tiles, Grid.Position fromPosition, Grid.Position toPosition)
	{
		var path = new List<Grid.Position>();
		path.Add( fromPosition );
        Grid.Position posi = fromPosition;

        while(posi.x != toPosition.x || posi.y != toPosition.y)
        {
            if(posi.x < toPosition.x)
            { posi.x++; }
            else if (posi.x>toPosition.x) { posi.x--; }

            if (posi.y < toPosition.y)
            { posi.y++; }
            else if (posi.y> toPosition.y) { posi.y--; }
           
            path.Add(posi);
        }
        
        path.Add(toPosition);
        return path;
	}
}