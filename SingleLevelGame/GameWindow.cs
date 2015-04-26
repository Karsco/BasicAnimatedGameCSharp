using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleLevelGame
{
    public partial class GameWindow : Form
    {

        /*----------Class variables----------*/

        private Game gameLevel = new Game(); //Main game object for managing game functions, etc
        private Graphics g;

        /*---------Class functions-----------*/

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            g = canvas.CreateGraphics();
            gameLevel.startGraphics(g);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            gameLevel.renderGraphics(g);
        }
    }
}
