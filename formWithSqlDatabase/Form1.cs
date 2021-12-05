using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formWithSqlDatabase
{

    public partial class Form1 : Form
    {

        int where;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void initial()
        {
            ddl_ids.Enabled = false;
            txtName.Enabled = false;
            txtCin.Enabled = false;
            txtAge.Enabled = false;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = false;
            btAnnuler.Enabled = false;
            btAjouter.Enabled = true;
            ddl_ids.SelectedItem = null;
            txtName.Clear();
            txtCin.Clear();
            txtAge.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initial();
     
                Connectdb.ids(ddl_ids);

        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            where = 1;
            ddl_ids.Text = null;
            ddl_ids.Enabled = false;
            txtName.Enabled = true;
            txtCin.Enabled = true;
            txtAge.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;
            txtName.Clear();
            txtCin.Clear();
            txtAge.Clear();

            
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            where = 2;
            ddl_ids.Enabled = false;
            txtName.Enabled = true;
            txtCin.Enabled = true;
            txtAge.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;

        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            where = 3;
            ddl_ids.Enabled = false;
            txtName.Enabled = false;
            txtCin.Enabled = false;
            txtAge.Enabled = false;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;

        }

        private void btConfirmer_Click(object sender, EventArgs e)
        {
            if (where == 1)
            {
                if (txtName.Text.Trim().Length > 0 && txtCin.Text.Trim().Length > 0 && txtAge.Text.Trim().Length > 0)
                {
                    Connectdb.add(ddl_ids ,txtName.Text, txtCin.Text, int.Parse(txtAge.Text));
                    ddl_ids.Enabled = true;
                    txtName.Enabled = false;
                    txtCin.Enabled = false;
                    txtAge.Enabled = false;
                    btAjouter.Enabled = true;
                    btModifier.Enabled = true;
                    btSupprimer.Enabled = true;
                    btConfirmer.Enabled = false;
                    btAnnuler.Enabled = false;
                }
            } else if (where == 2)
            {
                
                Connectdb.modify(ddl_ids, txtName, txtCin, txtAge);
                btAjouter.Enabled = true;
                btModifier.Enabled = true;
                btSupprimer.Enabled = true;
                btAnnuler.Enabled = false;
                btConfirmer.Enabled = false;
                ddl_ids.Enabled = true;
                txtAge.Enabled = false;
                txtCin.Enabled = false;
                txtName.Enabled = false;
                
            }
            else
            {
                Connectdb.supprimer(ddl_ids);
                ddl_ids.Enabled = true;
                txtName.Enabled = false;
                txtCin.Enabled = false;
                txtAge.Enabled = false;
                btAjouter.Enabled = true;
                btModifier.Enabled = true;
                btSupprimer.Enabled = true;
                btConfirmer.Enabled = false;
                btAnnuler.Enabled = false;
                txtAge.Text = string.Empty;
                txtCin.Text = string.Empty;
                txtName.Text = string.Empty;
                ddl_ids.Text = string.Empty;
                Connectdb.lastId(ddl_ids);

            }


        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            if(where==1)
            initial();
            else
            {
                ddl_ids.Enabled = true;
                txtName.Enabled = false;
                txtCin.Enabled = false;
                txtAge.Enabled = false;
                btAjouter.Enabled = true;
                btModifier.Enabled = true;
                btSupprimer.Enabled = true;
                btConfirmer.Enabled = false;
                btAnnuler.Enabled = false;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenom_Click(object sender, EventArgs e)
        {

        }

        private void ddl_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_ids.Enabled = true;
            txtAge.Enabled = false;
            txtCin.Enabled = false;
            txtName.Enabled = false;
            btAjouter.Enabled = true;
            btModifier.Enabled = true;
            btSupprimer.Enabled = true;
            btConfirmer.Enabled = false;
            btAnnuler.Enabled = false;            
            Connectdb.charger(ddl_ids,txtName,txtCin,txtAge);

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        
    }
}
