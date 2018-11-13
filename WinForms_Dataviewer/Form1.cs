using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Dataviewer
{
    public partial class Form1 : Form
    {
        RootObject currentMonsterData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCurrentMonstersAsync();
        }

        static async Task<RootObject> GetListAsync()
        {
            string url;

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("https://pokeapi.co/api/v2/pokemon/");

            url = sb.ToString();

            RootObject currentMonsterList = new RootObject();

            Task<RootObject> getCurrentMonsterList = HttpGetCurrentMonstersAsync(url);

            currentMonsterList = await getCurrentMonsterList;

            return currentMonsterList;
        }

        static async Task<MonsterDetailed> GetMonsterAsync(string monster)
        {
            string url;

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("https://pokeapi.co/api/v2/pokemon/"+monster+"/");

            url = sb.ToString();

            MonsterDetailed currentMonster = new MonsterDetailed();

            Task<MonsterDetailed> getCurrentMonsterList = HttpGetMonstersAsync(url);

            currentMonster = await getCurrentMonsterList;

            Detail detailForm = new Detail(currentMonster);

            detailForm.ShowDialog();

            return currentMonster;
        }

        static async Task<RootObject> HttpGetCurrentMonstersAsync(string url)
        {
            string result = null;

            using (HttpClient syncClient = new HttpClient())
            {
                var response = await syncClient.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
            }

            RootObject currentMonsterList = JsonConvert.DeserializeObject<RootObject>(result);

            return currentMonsterList;
        }

        static async Task<MonsterDetailed> HttpGetMonstersAsync(string url)
        {
            string result = null;

            using (HttpClient syncClient = new HttpClient())
            {
                var response = await syncClient.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
            }

            MonsterDetailed currentMonsterList = JsonConvert.DeserializeObject<MonsterDetailed>(result);

            return currentMonsterList;
        }

        async Task DisplayCurrentMonstersAsync()
        {
            currentMonsterData = await GetListAsync();
            dataGridView1.AutoSize = false;
            for (int i = 0; i < currentMonsterData.results.Count(); i++)
            {
                currentMonsterData.results[i].number = i+1;
            }
            dataGridView1.DataSource = currentMonsterData.results;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Monster selectedMonster = new Monster();
            selectedMonster = dataGridView1.CurrentRow.DataBoundItem as Monster;

            GetMonsterAsync(selectedMonster.name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                dataGridView1.DataSource = currentMonsterData.results.Where(mon => mon.name.Contains(textBox1.Text)).ToList();
            }
            else
            {
                dataGridView1.DataSource = currentMonsterData.results;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monster selectedMonster = dataGridView1.CurrentRow.DataBoundItem as Monster;
            currentMonsterData.results.Remove(selectedMonster);
            dataGridView1.Refresh();
            //dataGridView1.DataSource = currentMonsterData.results;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currentMonsterData.results.OrderByDescending(x => x.name).ToList();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currentMonsterData.results.OrderBy(x => x.name).ToList();
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currentMonsterData.results.OrderBy(x => x.number).ToList();
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currentMonsterData.results.OrderByDescending(x => x.number).ToList();
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();

            helpForm.ShowDialog();
        }
    }
}
