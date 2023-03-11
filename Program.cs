using System;

class Program 
{

    static public void Main(String[] args)
    {

        Console.Clear();

        GameCharacter newChar = new GameCharacter(1, 1, "#");


    }

class GameCharacter {

public int maxWidth; //Can be accessed outside of this class
public int maxHeight;
//Character
int posx;
int posy;
string charac;

    public GameCharacter(int iniposx, int iniposy, string character) //constructor
    {
        maxWidth = 6; // inititalizes these variables
        maxHeight = 6;
        posx = iniposx - 1;
        posy = iniposy - 1;
        charac = character;
    }

    static void Move()
    {
        
    }

    private Boolean Draw(int x, int y, string chara)
    {
        Boolean Bflag = false;
        for(int i = 0; i < maxHeight; i++)
        {
            for(int ii = 0; ii < maxWidth; ii++)
            {
                if(i == y && ii == x)
                {
                    Console.Write(charac);
                    Bflag = true;
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        return Bflag;

    }

    private void ToString()
    {


        Console.WriteLine(charac + posx + ", " + posy); //NEED TO ADD THE TYPE OF OBJECT**
    }
    }
}

class HorizontalMover 
{


    private Boolean MoveRight;


    int posx;
    int posy;
    int maxX;
    int maxY;

    public HorizontalMover(int x, int y, string charac) //constructor
    {

    }

    private void Move()
    {

        if(MoveRight == true) //&& posx != WIDTH)
        {
            posx++;
        } 
        else if (MoveRight != true) //&& posx != 0)
        {
            posx--;
        }
    }
    

}

class VerticalMover
{

    public VerticalMover() //constructor
    {

    }

}

