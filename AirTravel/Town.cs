using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AirTravel
{
    public class Town : Button
    {
        public string name;
        public string info;
        private int xDB;
        private int yDB;
        static public int width = 10;
        private int id;

        public Town(int _id, string _name, string _info, int _xDB, int _yDB)
        {
            id = _id;
            name = _name;
            info = _info;
            xDB = _xDB;
            yDB = _yDB;
        }

        public void PathTown()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, width, width);
            this.Region = new Region(path);
            this.BackColor = Color.White;
            this.ForeColor = Color.White;
        }

        public string TownName
        {
            get { return name; }
        }

        public string TownInfo
        {
            get { return info; }
        }

        public int TownID
        {
            get { return id; }
        }

        public int TownX
        {
            get { return xDB; }
            set { xDB = value; }
        }

        public int TownY
        {
            get { return yDB; }
            set { yDB = value; }
        }
    }
}
