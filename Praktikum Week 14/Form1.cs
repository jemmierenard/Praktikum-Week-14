using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_14
{
    public partial class FormW14 : Form
    {
        public FormW14()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtData = new DataTable();
        DataTable dtGoal = new DataTable();
        DataTable dtGridMatch = new DataTable();
        DataTable dtWorst = new DataTable();
        int posisiSekarang = 0;
        
        public void IsiDataPemain(int Posisi)
        {
            
            lbl_IsiTeamName.Text = dtData.Rows[Posisi][0].ToString();
            lbl_IsiManager.Text = dtData.Rows[Posisi][1].ToString();
            lbl_IsiStadium.Text = dtData.Rows[Posisi][2].ToString();
            string simpan = dtData.Rows[Posisi][3].ToString();
            dtGridMatch = new DataTable();
            sqlQuery = "select concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), '(', sum(dm.type = 'GP'),')') from dmatch dm, player p where p.team_id = '" + dtData.Rows[Posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id group by dm.player_id order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGoal);
            lbl_IsiTopScorer.Text = dtGoal.Rows[Posisi][0].ToString();
            //lbl_IsiWorstDiscipline.Text = dtData.Rows[Posisi][8].ToString();
            sqlQuery = "SELECT date_format(m.match_date, '%d/%c/%Y') as'match_date' , if(m.team_home = '" + simpan + "','HOME',if(team_away = '" + simpan + "','AWAY',0)) as 'Home/Away',if(m.team_home = '" + simpan + "',m.team_away,if(m.team_away = '" + simpan + "',m.team_home,0)) as 'lawan' ,concat(m.goal_home,'-',m.goal_away) as 'score' FROM `match` m where m.team_home = '" + simpan + "' or m.team_away = '" + simpan + "' order by m.match_date desc LIMIT 5 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGridMatch);
            dgv_IsiMatch.DataSource = dtGridMatch;
            posisiSekarang = Posisi;

            dtWorst = new DataTable();
            sqlQuery = "SELECT p.player_name, SUM(if(d.`type`='CR',1,0)) , SUM(if(d.`type` = 'CY', 1, 0)) ,  sum(if(d.type = 'CY',1,0)) + sum(if(d.type = 'CR',3,0)) as 'poin'  from player p, dmatch d, team t where p.player_id = d.player_id and t.team_id = p.team_id and t.team_id='" + simpan + "' group by p.player_id order by poin desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorst);

            lbl_IsiWorstDiscipline.Text = dtWorst.Rows[0][0].ToString() + " ," + dtWorst.Rows[0][2].ToString() + " Yellow Card and " + dtWorst.Rows[0][1].ToString() + " Red Card";
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormW14_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (', n.nation, ')'), concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')'), team_id from team t, manager m, nationality n where t.manager_id = m.manager_id and n.nationality_id = m.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtData);
            IsiDataPemain(0);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (posisiSekarang > 0)
            {
                posisiSekarang--;
                IsiDataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posisiSekarang < dtData     .Rows.Count - 1)
            {
                posisiSekarang++;
                IsiDataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtData.Rows.Count - 1);
        }
    }
}
