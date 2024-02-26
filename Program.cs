/*
 * -----------------------------------------------------------------------
#

##  Using the Dungeon and Dragons style game program that you developed previously, add/altering the following functionality:

Add a sub/child class called Fighter. The fighter inherits the base class called character and adds these inputs:
Deity
Divine Spell -1 (a text entry)
Divine Spell -2 (a text entry)
Type of Healing (Spell, Hands-on, Item)
Add a sub/child class called Wizard. The wizard inherits the base class called character and adds these inputs:
Source of Power (Magic, Nature, Demonic)
Arcane Spell -1 (a text entry)
Arcane Spell 2 (a text entry)
Then create a program that will allow a user to add information into this class and then the program puts the information out. Just to demonstrate the functionality.


-------------------------------------------------------------Your program must have the following:


## 
##Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Proper mathematical calculations
Proper output
You must use subclasses that use the superclass.
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs
## ---------------------------
*/



using System;



class Characters 
{ 
    private string CharGen; 
    private string CharRac; 
    private string CharClass; 
    private string NameC; 
    private int AgeC; 
    private string playerNameC; 
    private int LevelChar; 

    
    
    public void Character() 
    { 
        NameC = ""; 
        AgeC = 0; 
        playerNameC = ""; 
        LevelChar = 0; 
        CharGen = "";
        CharRac = ""; 
        CharClass = "";

        
    } 
    
    

    
    public int getLevelChar()
    {
        return LevelChar;
    }
    
    public string getCharGen()
    {
        return CharGen;
    }
    

     
    public void setNameC(string NameC) 
    { 
        this.NameC = NameC; 
    } 

    public void setAgeC(int AgeC) 
    {
        this.AgeC = AgeC;
    }
    
    
    public string getCharRac()
    {
        return CharRac;
    }
    

    public void setLevelChar(int LevelChar) 
    {
        this.LevelChar = LevelChar;
    } 
    
    
    public void setCharGen(string CharGen)
    
    {
        this.CharGen = CharGen;
    }
    
    public void setCharRac(string CharRac)
    
    {
        this.CharRac = CharRac; 
    }

    public void setPlayerNameC(string playerNameC)
    
    {
        this.playerNameC = playerNameC; 
    }
    
    
    
    public void setCharClass(string CharClass)
    {
        this.CharClass = CharClass;
    }
    
    
    public string getNameC()
    {
        return NameC; 
    } 
    
    
    
    public int getAgeC() 
    { 
        return AgeC;
    } 
    
    public string getPlayerNameC()
    { 
        return playerNameC;
    }


    
    public string getCharClass()
    {
        return CharClass;
    }
    
    public void Output()
    {
        Console.WriteLine("Character details: ");
        Console.WriteLine("Character Name: " + NameC);
        Console.WriteLine("Age: " + AgeC);
        Console.WriteLine("Player Name: " + playerNameC);
        Console.WriteLine("Level of Character: " + LevelChar);
        Console.WriteLine("CharGen: " + CharGen);
        Console.WriteLine("Race of Character: " + CharRac);
        Console.WriteLine("Character Class: " + CharClass);
    }
}

class Fighter : Characters
{
    private string Deity = "";
    public string DivineSpell1 = "";
    public string DivineSpell2 = "";
    public string HealType = "";

    public Fighter()
    {

    }

}

class Wizard : Characters
{
    //he fighter inherits the base class called character and adds these inputs:
   // Deity
      //  Divine Spell -1 (a text entry)
   // Divine Spell -2 (a text entry)
  //  Type of Healing (Spell, Hands-on, Item)

  private string SourcePower = "";
  private string ArcaneSpell1 = "";
  private string ArcaneSpell2 = "";

}



class Mainn
{ 
    
    static void  Main()
    {
        string NameC,
            playerNameC,CharGen,CharRac, CharClass;
        int AgeC, LevelChar;

        Console.WriteLine("Character Menu: ");
        Console.Write("Player NameC: ");
        playerNameC = Console.ReadLine();
        Console.Write("Enter AgeC: ");
        AgeC = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Character NameC: ");
        NameC = Console.ReadLine();
        Console.Write("Enter CharGen: ");
        CharGen = Console.ReadLine();
        Console.Write("Enter LevelChar: ");
        LevelChar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter CharRac: ");
        CharRac = Console.ReadLine();
        Console.Write("Enter character class: ");
        CharClass = Console.ReadLine();
        Characters character = new Characters();
        character.setNameC(NameC);
        character.setPlayerNameC(playerNameC);
        character.setAgeC(AgeC);
        character.setCharGen(CharGen);
        character.setCharRac(CharRac);
        character.setLevelChar(LevelChar);
        character.setCharClass(CharClass);
        character.Output();
    }
}