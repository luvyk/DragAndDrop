using DragAndDrop.Odpadky;
using System.Numerics;
using System.Web;

namespace DragAndDrop
{
    public class Box
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public int MinWidth => 160;
        public int MinHeight { get; set; }
        public int MaxWidth => 320;
        public int MaxHeight => 500;

        private Brush _color;
        public Objekt _text;
        public List<Cara> Cary {  get; set; }
        private Canvas _canvas { get; set; }

        public Box(int x, int y, Canvas canvas)
        {
            PositionX = x;
            PositionY = y;

            Width = 160;
            Height = 80;
            _color = Brushes.Red;
            _text = new Objekt();
            _text.Nazev = "TestClass";
            //_text = "Box";
            MinHeight = 40;
            _canvas = canvas;
        }

        public Cara VytvorCaru(Box b)
        {
            Cara c = new Cara();
            c.StartX = NajdiXStredBoxu(this);
            c.StartY = NajdiYStredBoxu(this);
            c.EndX = NajdiXStredBoxu(b);
            c.EndY = NajdiYStredBoxu(b);
            if (this.PositionX < b.PositionX)
            {
                c.BodXProCisloStart = Convert.ToInt32(c.StartX + 10 + (this.Width * 0.7));
            }
            else
            {
                c.BodXProCisloStart = Convert.ToInt32(c.StartX - 10 - (this.Width * 0.7));
            }

            if (this.PositionY < b.PositionY)
            {
                c.BodYProCisloStart = Convert.ToInt32(c.StartY + 10 + (b.Height * 0.7));
            }
            else
            {
                c.BodYProCisloStart = Convert.ToInt32(c.StartY - 10 - (b.Height * 0.7));
            }
                
            return c;
        }
        public int NajdiXStredBoxu(Box b)
        {
            if(b != null)
            {
                return b.PositionX; //+ (Convert.ToInt32(b.Width * 0.5));
            }
            else
            {
                return 0;
            }
        }
        public int NajdiYStredBoxu(Box b)
        {
            if (b != null)
            {
                return b.PositionY; //+ (Convert.ToInt32(b.Height * 0.5));
            }
            else
            {
                return 0;
            }
        }
        public void AdjustHeight()
        {
            int countOfRows = 1;

            foreach (Vlastnost V in _text.Vlastnosti)
            {
                countOfRows++;
            }
            foreach (Metoda M in _text.Metody)
            {
                countOfRows++;
            }

            int newHeight = 20 + (countOfRows * 15) + 10;
            if (Height < newHeight)
            {
                Height = newHeight;
            }
            MinHeight = newHeight;
        }

        public void Select()
        {
            _color = Brushes.Blue;
            //_text = "Selected";
        }

        public void Unselect()
        {
            _color = Brushes.Red;
            //_text = "Box";
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Resize(int w, int h)
        {
            if (w < MinWidth)
                w = MinWidth;

            if (h < MinHeight)
                h = MinHeight;

            if (w > MaxWidth)
                w = MaxWidth;

            if (h > MaxHeight)
                h = MaxHeight;

            Width = w;
            Height = h;
        }

        public void Draw(Graphics g)
        {
            this.AdjustHeight();
            g.TranslateTransform(PositionX, PositionY);
            g.FillRectangle(_color, 0, 0, Width, Height);
            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);
            g.DrawString(_text.Nazev, new Font("Comic Sans MS", 10), Brushes.Black, 10, 10);
            g.DrawLine(Pens.Black, 0,25,Width, 25);
            int vlastnostY = 25;

            foreach(Vlastnost s in _text.Vlastnosti)
            {
                string modifikator = PrevedModPrNaZnak(s.Modifikator);
                g.DrawString($"{modifikator}{s.Nazev}: {s.DatovyTyp}", new Font("Comic Sans MS", 10), Brushes.Black, 10, vlastnostY);
                vlastnostY += 11;
            }
            vlastnostY += 15;
            foreach (Metoda m in _text.Metody)
            {
                string modifikator = PrevedModPrNaZnak(m.Pristup);
                g.DrawString($"{modifikator}{m.Nazev}()", new Font("Comic Sans MS", 10), Brushes.Black, 10, vlastnostY);
                vlastnostY += 11;
            }
            foreach(Objekt o in this._text.Realizace)
            {
                Box x = _canvas._boxes.FirstOrDefault(s => s._text == o);

                //if (x.PositionX != null)
                //{
                 //   Cara c = VytvorCaru(x);
                //    g.DrawLine(Pens.Black, PositionX / 2, PositionY / 2, x.PositionX, x.PositionY);
                //}
            }
            //g.DrawString(_text, new Font("Arial", 10), Brushes.Black, 10, 10);
            //mám v tom nepořádek

            g.ResetTransform();
        }
        public string PrevedModPrNaZnak(ModifikatorPrEnum enumerator)
        {
            string znak = "";
            switch (enumerator)
            {
                case ModifikatorPrEnum.IsInternal:
                    znak = "~";
                    break;
                case ModifikatorPrEnum.IsPrivate:
                    znak = "-";
                    break;
                case ModifikatorPrEnum.IsPublic:
                    znak = "+";
                    break;
                case ModifikatorPrEnum.IsProtected:
                    znak = "#";
                    break;
            }
            return znak;
        }
        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;
        }

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > (PositionX + Width - 10) && x <= PositionX + Width
                && y > (PositionY + Height - 10) && y <= PositionY + Height;
        }
    }
}
