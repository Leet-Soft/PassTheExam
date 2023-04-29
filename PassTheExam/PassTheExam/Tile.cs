using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace PassTheExam
{
    public enum TileStatus
    {
        Closed,
        Flagged,
        Opened
    }

    public class Tile : Frame
    {
        private TileStatus tileStatus = TileStatus.Closed;
        private Label infoLabel;
        private Image bombImage;
        private Image flagImage;

        public int Row { get; set; }
        public int Col { get; set; }
        public bool IsTheBomb { get; set; }
        public int SurroundingBombsCount { get; set; }

        public event EventHandler<TileStatus> TileStatusChanged;

        public Tile(int row, int col)
        {
            Row = row;
            Col = col;

            BackgroundColor = Color.Gray;
            BorderColor = Color.Black;
            Padding = 2;

            infoLabel = new Label
            {
                TextColor = Color.White,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Assembly assembly = Assembly.GetExecutingAssembly();
            
            flagImage = new Image
            {
                Source = ImageSource.
                    FromResource("PassTheExam.images.flag.png", assembly)
                
            };

            bombImage = new Image
            {
                Source = ImageSource.
             FromResource("PassTheExam.images.bomb.png", assembly)

            };

        }



    }
}
