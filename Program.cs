namespace PVA_projekt;

class Program
{
    static void Main(string[] args)
    {
        int characterIndex = 0;
        string command = "";
        bool exit = false;
        Console.WriteLine("Welcome to DnD character tracker V0.1 \nto list all available commands type '?'");
        while(exit == false)
        {
            command = Console.ReadLine();
            switch (command)
            {
                case "exit":
                Console.WriteLine("Bye and hope to see you soon :)");
                exit = true;
                break; 

                case "":
                break;

                case "?":
                Console.WriteLine(@"Commands: 
    exit: closes the program 
    create character: begins the character creation process
    add item: add an item of your choice to the characters inventory
    show inventory: lists all items in your inventory along with equipped armor, weapons and atuned items
    add XP: adds an amount of XP of your choice and levels up your character when necesarry
    take damage: deals damage to your character taking into account resistances and vulnerabilites
    change character: lists all saved characters and allows you to switch between them
    heal: adds an amount of HP of your choice
    use spell: lists all prepared spells, available spellslots and allows you to cast them
    attack: used to make attacks with non magical weapons
    change money: used to add and subtract money with exchange rates taken into account, shown in gp
    short/long rest: restores abilities and allows the use of hit dice
    ability check: used to roll ability check taking into account the characters bonuses
    saving throw: used to roll saving throws taking into account the characters bonuses
    change equipment: used to change armor and weapons
    list feats: writes out all feats the character possesses along with their description
    list proficiencies:writes out all the characters skill, tool, armor and weapon proficiencies
    list character: writes out all the basic info about the character not covered by other functions f.e. name, class, etc.
    list spells: writes out all spells available to your character separated by level along with their description(optional)
    prepared spells: writes out the spells the character has prepared, along with their description(optional)");
                break;

                case "create character":
                Character character1 = new Character();
                //characterslist.addnew = new character();
                break;

                case "add item":
                break;

                case "show inventory":
                break;

                case "add XP":
                break;

                case "take damage":
                break;

                case "change character":
                break;

                case "heal":
                break;

                case "use spell":
                break;

                case "attack":
                break;

                case "change money":
                break;

                case "short rest":
                break;

                case "long rest":
                break;

                case "ability check":
                break;

                case "saving throw":
                break;

                case "change equipment":
                break;

                case "list feats":
                break;

                case "list proficiencies":
                break;

                case "list character":
                break;

                case "class spells":
                break;

                case "prepared spells":
                break;

                case "debugName":
                break;

                default:
                Console.WriteLine("invalid input");
                break;
            }
        }
    }
}

class Character
{
    bool loop = false;
    string name;
    string size;
    string race;
    string alignment;
    int armorClass;
    int speed;
    string background;
    string mainClass;
    string multiClass;
    //array all classes together in characterClass[]
    string subClass;
    int proficencyBonus;
    bool inspiration;
    //0=str,1=dex,2=con,3=int,4=wis,5=chr
    int[] abilityScores = new int[6];
    int healhPoints;
    //0=cantrips,1-9=1-9lvl spellslots
    int[] spellSlots = new int[10];
    int level;
    int experiencePoints;
    /* string list<> inventory;
    string list<> skills;
    string list<> toolProficencies;
    string list<> weaponArmorProficiencies;
    string list<> languages;
    string list<> feats;
 */    int weight;
    float money;
    public Character()
    {
    Console.WriteLine("input the character's full name:");
    name = Console.ReadLine();
        Console.WriteLine("input the character's stats in order(str, dex, con,int, wis, chr):");
        for (int i = 0; i < 6; i++)
        {

                try
                {
                    abilityScores[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please input a whole number");
                    i--;
                }
            
        }
        Console.WriteLine("input the character's race:");
    race = Console.ReadLine();

        Console.WriteLine("input the character's alignment(shortened f.e. neutral good = NG):");
    alignment = Console.ReadLine();

        Console.WriteLine("input the character's background:");
    background = Console.ReadLine();

            Console.WriteLine("input the character's level:");
            loop = true;
            while (loop == true)
            {

                try
                {
                    level = int.Parse(Console.ReadLine());
                    loop = false;
                }
                catch 
                {
                    Console.WriteLine("please enter a whole number");
                }
            }

        Console.WriteLine("input the character's class:");
    mainClass = Console.ReadLine();    
    }
    public void ListCharacter()
    {
        Console.WriteLine("name: " + name + "\nrace: " + race + "\nalignmet: " + alignment + "\n level: " + level);
    }
}
