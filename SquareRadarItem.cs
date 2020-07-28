using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interface_RADAR
{
    public class SquareRadarItem : RadarItem
    {
        int _id;
        int _azimuth;
        int _range;
        int _width;
        int _height;
        DateTime _created = DateTime.Now;

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public int Azimuth
        {
            get
            {
                return _azimuth;
            }
            set
            {
                _azimuth = value;
                while (_azimuth < 0)
                {
                    _azimuth += 360;
                }
                if (_azimuth >= 360)
                    _azimuth = _azimuth % 360;
            }
        }
        public int Range
        {
            get
            {
                return _range;
            }
            set
            {
                _range = value;
                if (_range > 90)
                    _range = 90;
                else if (_range < 0)
                    _range = 0;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
            }
        }
        public DateTime Created
        {
            get
            {
                return _created;
            }
        }

        public SquareRadarItem(int id, int size, int az, int rg)
        {
            _id = id;
            _width = size;
            _height = size;
            _azimuth = az;
            _range = rg;
        }

        public void DrawItem(Radar radar, Graphics g)
        {
            PointF cp = radar.AzRg2XY(_azimuth, _range);
            PointF topLeft = new PointF(cp.X - ((float)_width / 2), cp.Y - ((float)_height / 2));

            g.FillRectangle(new SolidBrush(radar.CustomLineColor), new RectangleF(topLeft, new SizeF((float)_width, (float)_height)));
        }

        public int CompareTo(RadarItem item)
        {
            return 0;
        }
    }
}
