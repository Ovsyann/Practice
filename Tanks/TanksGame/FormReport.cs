using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    public partial class FormReport : Form
    {
        public FormReport(GameForm game)
        {
            InitializeComponent();
            gameform = game;
            gameform.OnTransferInfo += TransferHandler;
        }

        private void TransferHandler(object sender, ReportEventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add("Player",e.Player.Left, e.Player.Top);

            for (int i = 0; i < e.Enemies.Count; i++)
            {
                dataGridView.Rows.Add($"Enemy-{i}", e.Enemies[i].Left, e.Enemies[i].Top);
            }

            for (int i = 0; i < e.Bonuses.Count; i++)
            {
                dataGridView.Rows.Add($"Bonus-{i}", e.Bonuses[i].Left, e.Bonuses[i].Top);
            }
        }

        GameForm gameform;

        private void FormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameform.OnTransferInfo -= TransferHandler;
        }
    }
}
