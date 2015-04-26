using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SingleLevelGame
{
    class GameGraphicsEngine
    {
       /*-------Class variables---------*/

        private Graphics gameGraphics;
        private Bitmap bg;
        private Bitmap gameCollectable;
        private Bitmap gameEnemy;

        /*-------Class functions------*/

        public GameGraphicsEngine(Graphics g) //constructor
        {
            gameGraphics = g;
        }

        public void initialise()    //load graphics assets and start rendering engine
        {
            loadAssets();
        }

        private void loadAssets()   //load assets for game - images and sounds - here
        {

        }
        
       public void render()    //draws graphics frame by frame, background, enemies, main character
       {
            Bitmap frame = new Bitmap(Game.CANVAS_WIDTH, Game.CANVAS_HEIGHT);  //clear the buffer frame
            Graphics frameGraphics = Graphics.FromImage(frame);      

            //draw background into new frame 
            frameGraphics.DrawImage(bg, 0, 0, Game.CANVAS_WIDTH, Game.CANVAS_HEIGHT);

           //draw grid objects into new frame
            Game.gridObjects[,] levelObjects = Level.levelMap;   //get a copy of the grid

            for (int x = 0; x < Game.LEVEL_WIDTH; x++)
            {
                for (int y = 0; y < Game.LEVEL_HEIGHT; y++)
                {
                    switch (levelObjects[x, y])
                    {
                        case Game.gridObjects.empty:
                            break;
                        case Game.gridObjects.collectable:
                            frameGraphics.DrawImage(gameCollectable, x * Game.TILE_SIZE, y * Game.TILE_SIZE);
                            break;
                        case Game.gridObjects.enemy:
                            frameGraphics.DrawImage(gameEnemy, x * Game.TILE_SIZE, y * Game.TILE_SIZE);
                            break;
                    }
                }
            }
           

            //draw level
            gameGraphics.DrawImage(frame, 0, 0);
        }
    }
}
