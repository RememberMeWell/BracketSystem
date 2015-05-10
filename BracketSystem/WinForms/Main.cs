using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BracketSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            string[] playerDatabase = new string[4] { "Hermen","Jiri", "Yolo", "Dingen" };           
            // id naam ip adress gamesplayed
            // 0 = Hermen
            
            

            string players = "0;1;2;3";

            List<string> players2 = new List<string>();
            players2 = players.Split(';').ToList(); //string split => string[] => list<string<>

            for (int i = 0; i < players2.Count; i++)
            {
                MessageBox.Show(playerDatabase[i]);
            }

            

            



        }

        
    }
}
