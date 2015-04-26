using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SingleLevelGame
{
    class Game
    {
        /*----------Constant values----------*/
        public const int CANVAS_HEIGHT = 600;
        public const int CANVAS_WIDTH = 1000;
        public const int LEVEL_WIDTH = 20;
        public const int LEVEL_HEIGHT = 12;
        public const int TILE_SIZE = 50;


        /*----------Class types------------*/

        public enum gridObjects      //components in a level
        {
            empty,
            collectable,
            enemy,
            mainCharacter
        }

        
        /*----------Class variables----------*/

        private GameGraphicsEngine gEngine;


        /*----------Class functions---------*/

        public void loadLevel() //set up level grid and main character
        {
            Level.initialiseLevel();  //add an empty grid
            Level.placeActors(gridObjects.collectable, 1);   //add 1 collectables (or food) to the game
            Level.placeActors(gridObjects.enemy, 1);   //add 1 enemies to the game
        }
        

        public void startGraphics(Graphics g)   //start graphics engine
        {
            loadLevel();
            gEngine = new GameGraphicsEngine(g);
            gEngine.initialise();
        }

        public void renderGraphics(Graphics g)   //start graphics engine
        {
            gEngine.render();
        }
    }
}
