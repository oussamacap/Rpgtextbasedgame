using System;
using System.Collections.Generic;
using System.Text;
using Maandag2.Commands;
using Maandag2.Model;

/// <summary>
/// Here in 
/// </summary>

namespace Maandag2
{
    static class Game
    {
        private static PlayerHandler playerhandler = PlayerHandler.Instance;
        
        public static void Start()
        {
            Console.WriteLine(@" __ __ __   ______   __       ______   ______   ___ __ __   ______       _________  ______       
/_//_//_/\ /_____/\ /_/\     /_____/\ /_____/\ /__//_//_/\ /_____/\     /________/\/_____/\      
\:\\:\\:\ \\::::_\/_\:\ \    \:::__\/ \:::_ \ \\::\| \| \ \\::::_\/_    \__.::.__\/\:::_ \ \     
 \:\\:\\:\ \\:\/___/\\:\ \    \:\ \  __\:\ \ \ \\:.      \ \\:\/___/\      \::\ \   \:\ \ \ \    
  \:\\:\\:\ \\::___\/_\:\ \____\:\ \/_/\\:\ \ \ \\:.\-/\  \ \\::___\/_      \::\ \   \:\ \ \ \   
   \:\\:\\:\ \\:\____/\\:\/___/\\:\_\ \ \\:\_\ \ \\. \  \  \ \\:\____/\      \::\ \   \:\_\ \ \  
 ___\_______\/_\_____\/ \_____\/ \_____\/_\_____\/_\__\/ \__\/ \_____\/______ \__\/    \_____\/  
/________/\/__/\ /__/\ /_____/\     /______/\  /_______/\ /__//_//_/\ /_____/\                   
\__.::.__\/\::\ \\  \ \\::::_\/_    \::::__\/__\::: _  \ \\::\| \| \ \\::::_\/_                  
   \::\ \   \::\/_\ .\ \\:\/___/\    \:\ /____/\\::(_)  \ \\:.      \ \\:\/___/\                 
    \::\ \   \:: ___::\ \\::___\/_    \:\\_  _\/ \:: __  \ \\:.\-/\  \ \\::___\/_                
     \::\ \   \: \ \\::\ \\:\____/\    \:\_\ \ \  \:.\ \  \ \\. \  \  \ \\:\____/\               
      \__\/    \__\/ \::\/ \_____\/     \_____\/   \__\/\__\/ \__\/ \__\/ \_____\/    ");


        }



        //Player aanmaken 
        public static void CreatePlayerStart()
        {
            //firtsname 
            Console.WriteLine("Enter your firstname: ");
            string inputFirstName = Console.ReadLine(); // userinput
            

            //lastname
            Console.WriteLine("Enter your lastname: ");
            string inputLastName = Console.ReadLine(); // userinput
            
            //player aangemaakt  
            playerhandler.CreatePlayer(inputFirstName, inputLastName);


            Console.WriteLine(@"                            ==(W{==========-      /===-                        
                              ||  (.--.)         /===-_---~~~~~~~~~------____  
                              | \_,|**|,__      |===-~___                _,-' `
                 -==\\        `\ ' `--'   ),    `//~\\   ~~~~`---.___.-~~      
             ______-==|        /`\_. .__/\ \    | |  \\           _-~`         
       __--~~~  ,-/-==\\      (   | .  |~~~~|   | |   `\        ,'             
    _-~       /'    |  \\     )__/==0==-\<>/   / /      \      /               
  .'        /       |   \\      /~\___/~~\/  /' /        \   /'                
 /  ____  /         |    \`\.__/-~~   \  |_/'  /          \/'                  
/-'~    ~~~~~---__  |     ~-/~         ( )   /'        _--~`                   
                  \_|      /        _) | ;  ),   __--~~                        
                    '~~--_/      _-~/- |/ \   '-~ \                            
                   {\__--_/}    / \\_>-|)<__\      \                           
                   /'   (_/  _-~  | |__>--<__|      |                          
                  |   _/) )-~     | |__>--<__|      |                          
                  / /~ ,_/       / /__>---<__/      |                          
                 o-o _//        /-~_>---<__-~      /                           
                 (^(~          /~_>---<__-      _-~                            
                ,/|           /__>--<__/     _-~                               
             ,//('(          |__>--<__|     /                  .----_          
            ( ( '))          |__>--<__|    |                 /' _---_~\        
         `-)) )) (           |__>--<__|    |               /'  /     ~\`\      
        ,/,'//( (             \__>--<__\    \            /'  //        ||      
      ,( ( ((, ))              ~-__>--<_~-_  ~--____---~' _/'/        /'       
    `~/  )` ) ,/|                 ~-_~>--<_/-__       __-~ _/                  
  ._-~//( )/ )) `                    ~~-'_/_/ /~~~~~~~__--~                    
   ;'( ')/ ,)(                              ~~~~~~~~~~                         
  ' ') '( (/                                                                   
    '   '  `");

            string personalStartSentece = string.Format("Soldier {0} you have the fight 4 life", playerhandler.GetPlayer.LastName);
            string personalWelcomeSentece = string.Format("Welcome {0} 2 the game you have {1} lifepoints", playerhandler.GetPlayer.FirstName, playerhandler.GetPlayer.LevelPoints);

            Console.WriteLine(personalWelcomeSentece);
            Console.WriteLine(personalStartSentece);  
            

        }

        //Monster aanmaken 
        public static Monster CreateMonster() {
            Monster monster = new Monster();
            monster.monsterName = "Crazy duck";
            monster.attackPoints = 5;
            monster.asciiartMonster = (@"        _____
     _-~~     ~~-_//
   /~             ~\
  |              _  |_
 |         _--~~~ )~~ )___
\|        /   ___   _-~   ~-_
\          _-~   ~-_         \
|         /         \         |
|        |           |     (O  |
 |      |             |        |
 |      |   O)        |       |
 /|      |           |       /
 / \ _--_ \         /-_   _-~)
   /~    \ ~-_   _-~   ~~~__/
  |   |\  ~-_ ~~~ _-~~---~  \
  |   | |    ~--~~  / \      ~-_
   |   \ |                      ~-_
    \   ~-|                        ~~--__ _-~~-,
     ~-_   |                             /     |
        ~~--|                                 /
          |  |                               /
          |   |              _            _-~
          |  /~~--_   __---~~          _-~
          |  \                   __--~~
          |  |~~--__     ___---~~
          |  |      ~~~~~
          |  |");


            Monster monster2 = new Monster();
            monster2.monsterName = "Gaint Monster";
            monster2.attackPoints = 10;
            monster2.asciiartMonster = (@"                     _
                     : \
                     ;\ \_                   _
                     ;@: ~:              _,-;@)
                     ;@: ;~:          _,' _,'@;
                     ;@;  ;~;      ,-'  _,@@@,'
                    |@(     ;      ) ,-'@@@-;
                    ;@;   |~~(   _/ /@@@@@@/
                    \@\   ; _/ _/ /@@@@@@;~
                     \@\   /  / ,'@@@,-'~
                       \\  (  ) :@@(~
                    ___ )-'~~~~`--/ ___
                   (   `--_    _,--'   )
                  (~`- ___ \  / ___ -'~)
                 __~\_(   \_~~_/   )_/~__
 /\ /\ /\     ,-'~~~~~`-._ 0\/0 _,-'~~~~~`-.
| |:  ::|    ;     ______ `----'  ______    :
| `'  `'|    ;    {      \   ~   /      }   |
 \_   _/     `-._      ,-,' ~~  `.-.      _,'        |\
   \ /_          `----' ,'       `, `----'           : \
   |_( )                `-._/#\_,-'                  :  )
 ,-'  ~)           _,--./  (###)__                   :  :
 (~~~~_)          /       ; `-'   `--,               |  ;
 (~~~' )         ;       /@@@@@@.    `.              | /
 `.HH~;        ,-'  ,-   |@@@ @@@@.   `.             .')
  `HH `.      ,'   /     |@@@@@ @@@@.  `.           / /(~)
   HH   \_   ,'  _/`.    |@@@@@ @@@@@;  `.          ; (~~)
   ~~`.   \_,'  /   ;   .@@@@@ @@@@@@;\_  \___      ; H~\)
       \_     _/    `.  |@@@@@@ @@@@@;  \     `----'_HH[~)
         \___/       `. :@@@@@ @@@@@@'   \__,------' HH ~
        ______        ; |@@@@@@ @@@'                 HH
      _)      \_,     ; :@@@@@@@@@;                  ~~
    _;          \\   ,' |@@@@@@@@@:
  ,'     ; :      \_,   :@@@@@@@@@@.
  `.__,-'~~`._,-.  ,    :@@@@@@@@@@`.
                 \/    /@@@@@@@@@@@@:
                 /    ,@@@@@@@@@@@@@@.
                |    ,@@@@@@@@@@@@@@@:
                |    :@@@@@@@@@@@@@@@'
                `.   \@@@@/  `@@@@@/(
                  )   ~~~/    \~~~~  \
                  :     /       \_    \
                  (    /          \_   `.
                  /   ;             \_  `.
                 /   /                \  `.
                /   /                  `.  \
              ,'  ,'/~~)                ;  /
              {   `'   (               /  /
              `.___,-'  \             /  /
                 __/     |           /  /
                /        |           : :   __
                :        |           ; : _;  )__
                (  |  |  /          /  `,'  ~   )_
                 `-:__;-'          :  ,'      ~~  ;
                                  /          (_,--'
                                 (       ,-'~~
                                  \__,-'~");

            Monster monster3 = new Monster();
            monster3.monsterName = "Cute Monster";
            monster3.attackPoints = 15;
            monster3.asciiartMonster = (@"                           XXXXXXXXXXXXXXXXXXXXXXX
                     XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                  XXXX                                XXXX
              XXXX                                        XXXX
           XXX                                                XXX
         XX                                                      XX
       XX                                                          XX
      XX                                                            XX
     XX                                                              XX
    XX                                                        X       XX
   XX                                                   XX     XX      XX
  XX                                                      XXX    XX     XX
 XX      XX   XX                                             XX         XX
 XX    XX   XX                                                 XX        XX
XX    X    X                                                    XX       XX
XX   X    X                                                               X
X   X    X                                                                X
X       X              8                                 8                X
X                       8                               8                 X
X                  8     8                             8   8              X
X                   8  8  8                           8  8   8            X
X                    8  8  8                         8  8  88             X
X                     8  8  8                       XXXX  8               X
X                      8 XXXX                       XXXXX8                X
XX                      XXXXXX                    XXXXXXXX               XX
XX                     XXXXXXXX                  XXXXXXXXXX              XX
XX                    XXXXXXXXXX                XXXXXXXXXXXX             XX
 XX                  XXXXXXXXXXXX               XXXXXXXXXXXXX           XX
  XX                 XXXXXXXXXXXXX             XXXXXXXXXXXXXX          XX
  XX                XXXXXXXXXXXXXX            XXXXXXXXXXXXXXX          XX
  XX                XXXXXXXXXXXXXX           XXXXXXXXXXXXXXXX          XX
   XX              XXXXXXXXXXXXXXX           XXXXXXXXXXXXXXXX         XX
    XX             XXXXXXXXXXXXXXX           XXXXXXX    XXXXX        XX
     XX            XXXXXXX   XXXXX           XXXXXX      XXXX       XX
     XX            XXXXXX     XXX            XXXXX       XXXX       XX
      XX           XXXXX  88  XXXX           XXXX   88   XXX       XX
      XX           XXXX  8888  XX            XXXX  8888  XXX       XX
       XX          XXXX  8888 XXX            XXXX  8888 XXX       XX
        XX         XXXXX  88 XXX              XXXX  88 XXX       XX
          XX        XXXX    XXX               XXXX    XXX       XX
           XXX       XXXXXXXXX                 XXXXXXXXX       XXX
           XX          XXXXX      XXXXXXXXXXX    XXXXX           XX
          XXX           XX    XXXX           XXX  XX             XXX
          XX                XX XXXXX          XXXXX                XX
          XX               X  XX    XXXX  XXXX  XXXX   XXXX        XX
          XX                    XXX     XX     XX   XXX    X       XX
          XX                       XXX     XXX                    XX
           XX                         XXXXX                     XXX
             XX                                               XXX
              XXXXX                                        XXXX
                   XXXXXXXXXXX                     XXXXXXXX
                              XXXX             XXXX
                                 XX           XX
                                  XX         XX
                                  XX         XX
                                  XX         XX");


  
            // hier random getal
            Random rnd = new Random();
            int theRightMonster = rnd.Next(1, 4); // creates a number between 1 and 3
            switch (theRightMonster)
            {
                case 1:
                    {
                        Console.WriteLine(monster.asciiartMonster);
                        Console.WriteLine("Hello I am {0} and I will Attack you with {1} levelpoints", monster.monsterName, monster.attackPoints);
                        return monster;
                    }
                case 2:
                    {
                        Console.WriteLine(monster2.asciiartMonster);
                        Console.WriteLine("Hello I am {0} and I will Attack you with {1} levelpoints", monster2.monsterName, monster2.attackPoints);
                        return monster2;
                    }
                case 3:
                    {
                        Console.WriteLine(monster3.asciiartMonster);
                        Console.WriteLine("Hello I am {0} and I will Attack you with {1} levelpoints", monster3.monsterName, monster3.attackPoints);
                        return monster3;
                    }
                default:
                    {
                        System.Console.WriteLine("you are lucky no monsters here :)");
                        return null;
                    }
            };

           
        }

        //
        public static int AttackPlayer(int playerPoints, int monsterPoints)
        {
            playerPoints = playerPoints - monsterPoints;
            return playerPoints;
        }


        public static int HealthPlayer(int playerPoints)
        {
            playerPoints = playerPoints + 5;
            return playerPoints;
        }

        // naar room class zetten 
        public static void CreateRoom() {
        }

        public static void CreateGame()
        {
            Console.WriteLine("type a command: ");
            Commands.CommandHandler.CommandInGame();
        }

            public static void End()
        {
           Console.WriteLine(@"     ----o-   
              _____________   %%% , ,%_________
             (___________,,)  %c    >) ,________)
                (_________,,)  )   =  ,______)
                     (_____,,)/ _/__,,____)
                        / \   \__/ /\
                       /\ |        \/\
                      /__\|'   ,   /  \,
                     < -  '====o==,  /_\
                    /    /`       |\ __ \
                   /__,_/    |  _/, \____\
                   //   |     \/  \    \
                 _( \   \      \  \   _/ \
                  //|    \     \  \    |/|
                         < `  _\ -)
                        /    |_/ |
                       |    / |_/
                      /-_,  ' /|
                      \/ \_,--.,
                      '(    )'
                     / |    | \
                     |,/    \,/   ");
            Console.WriteLine(@"
 ______     ________  ______    
/_____/\   /_______/\/_____/\   
\:::_ \ \  \__.::._\/\:::_ \ \  
 \:(_) ) )_   \::\ \  \:(_) \ \ 
  \: __ `\ \  _\::\ \__\: ___\/ 
   \ \ `\ \ \/__\::\__/\\ \ \   
    \_\/ \_\/\________\/ \_\/   
                                
");
            Console.WriteLine("Press a key to end the game");
            Console.ReadLine();

        }
    }
}
