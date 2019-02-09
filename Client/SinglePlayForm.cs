using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class board_bk : Form
    {
        private const int rectSize = 33;
        private const int edgeCount = 15;

        private enum Horse { none = 0, BLACK, WHITE };
        private Horse[,] board = new Horse[edgeCount, edgeCount];
        private Horse nowPlayer = Horse.BLACK;

        private bool playing = false;

        public board_bk()
        {
            InitializeComponent();
        }

        private bool judge()
        {
            for (int i = 0; i < edgeCount - 4; i++)
                for (int j = 0; j < edgeCount; j++)
                    if (board[i, j] == nowPlayer && board[i + 1, j] == nowPlayer && board[i + 2, j] == nowPlayer &&
                        board[i + 3, j] == nowPlayer && board[i + 4, j] == nowPlayer)
                        return true;
            for (int i = 0; i < edgeCount; i++)
                for (int j = 4; j < edgeCount; j++)
                    if (board[i, j] == nowPlayer && board[i, j - 1] == nowPlayer && board[i, j - 2] == nowPlayer &&
                        board[i, j - 3] == nowPlayer && board[i, j - 4] == nowPlayer)
                        return true;
            for (int i = 0; i < edgeCount - 4; i++)
                for (int j = 0; j < edgeCount - 4; j++)
                    if (board[i, j] == nowPlayer && board[i + 1, j + 1] == nowPlayer && board[i + 2, j + 2] == nowPlayer &&
                        board[i + 3, j + 3] == nowPlayer && board[i + 4, j + 4] == nowPlayer)
                        return true;
            for (int i = 4; i < edgeCount; i++)
                for (int j = 0; j < edgeCount - 4; j++)
                    if (board[i, j] == nowPlayer && board[i - 1, j + 1] == nowPlayer && board[i - 2, j + 2] == nowPlayer &&
                        board[i - 3, j + 3] == nowPlayer && board[i - 4, j + 4] == nowPlayer)
                        return true;
            return false;
        }

        private void refresh()
        {
            this.boardpicture.Refresh();
            for (int i = 0; i < edgeCount; i++)
                for (int j = 0; j < edgeCount; j++)
                    board[i, j] = Horse.none;
        }

        private void boardpicture_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.boardpicture.CreateGraphics();
            int x = e.X / rectSize;
            int y = e.Y / rectSize;
            if( x < 0 || y < 0 || x >= edgeCount || y >= edgeCount)
            {
                MessageBox.Show("테두리를 벗어날 수 없습니다.");
                return;
            }
            if (board[x, y] != Horse.none) return;
            board[x, y] = nowPlayer;

            if(nowPlayer == Horse.BLACK)
            {
                SolidBrush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize, rectSize);
            }
            else
            {
                SolidBrush brush = new SolidBrush(Color.WhiteSmoke);
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize, rectSize);
            }

            if(judge())
            {
                MessageBox.Show(nowPlayer.ToString() + "플레이어가 승리했습니다.");
                label1.Text = nowPlayer.ToString() + "플레이어가 승리했습니다.";
                playing = false;
                button1.Text = "게임시작";
            }
            else
            {
                nowPlayer = ((nowPlayer == Horse.BLACK) ? Horse.WHITE : Horse.BLACK);
                label1.Text = nowPlayer.ToString() + "플레이어의 차례입니다.";
            }


        }

        private void boardpicture_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            Color lineColor = Color.Black;
            Pen p = new Pen(lineColor, 2);
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2);
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize / 2);
           // gp.DrawLine(p, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount);
            gp.DrawLine(p, rectSize * edgeCount - rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount);
            p = new Pen(lineColor, 1);

            for(int i = rectSize + rectSize / 2; i < rectSize * edgeCount - rectSize / 2; i += rectSize)
            {
                gp.DrawLine(p, rectSize / 2, i, rectSize * edgeCount - rectSize / 2, i);
                gp.DrawLine(p, i, rectSize / 2, i, rectSize * edgeCount - rectSize / 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!playing)
            {
                refresh();
                playing = true;
                button1.Text = "재시작";
                label1.Text = nowPlayer.ToString() + "플레이어의 차례입니다."; 
            }
            else
            {
                refresh();
                label1.Text = "게임이 재시작 되었습니다.";
            }
        }

    }
}
