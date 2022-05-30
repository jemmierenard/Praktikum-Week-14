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
        int posisiSekarang = 0;
        public void IsiDataPemain(int Posisi)
        {
            //MessageBox.Show(Posisi.ToString());
            lbl_IsiTeamName.Text = dtData.Rows[Posisi][0].ToString();
            lbl_IsiManager.Text = dtData.Rows[Posisi][1].ToString();
            lbl_IsiStadium.Text = dtData.Rows[Posisi][2].ToString();
            sqlQuery = "select concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), '(', sum(dm.type = 'GP'),')') from dmatch dm, player p where p.team_id = '" + dtData.Rows[Posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id group by dm.player_id order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGoal);
            lbl_IsiTopScorer.Text = dtGoal.Rows[Posisi][0].ToString();
            //lbl_IsiWorstDiscipline.Text = dtData.Rows[Posisi][8].ToString();
   
           
            posisiSekarang = Posisi;
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormW14_Load(object sender, EventArgs e)
        {
            //sqlQuery = "";
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (', n.nation, ')'), concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')'), team_id from team t, manager m, nationality n where t.manager_id = m.manager_id and n.nationality_id = m.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtData);
            IsiDataPemain(0);

            DataTable dtMatch = new DataTable();
            sqlQuery = "select match_date from `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgv_IsiMatch.DataSource = dtMatch;


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
