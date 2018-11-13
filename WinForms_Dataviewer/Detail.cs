using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Dataviewer
{
    public partial class Detail : Form
    {
        MonsterDetailed _monster = new MonsterDetailed();

        public Detail(MonsterDetailed monster)
        {
            InitializeComponent();
            _monster = monster;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            //DisplayCurrentMonstersAsync();
        }

        private void Detail_Load_1(object sender, EventArgs e)
        {
            lblName.Text = char.ToUpper(_monster.name[0]) + _monster.name.Substring(1);

            WebClient wc = new WebClient();
            if(_monster.sprites.front_default != null)
            {
                byte[] bytes = wc.DownloadData(_monster.sprites.front_default);
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox1.Image = Image.FromStream(ms);
            }
            lblAtk.Text += ": "+ _monster.stats[4].base_stat.ToString();
            lblSpd.Text += ": " + _monster.stats[0].base_stat.ToString();
            lblDef.Text += ": " + _monster.stats[3].base_stat.ToString();
            lblSpcDef.Text += ": " + _monster.stats[1].base_stat.ToString();
            lblSpcAtk.Text += ": " + _monster.stats[2].base_stat.ToString();
            lblHP.Text += ": " + _monster.stats[5].base_stat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
