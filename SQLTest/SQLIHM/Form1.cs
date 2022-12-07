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

namespace SQLIHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        bool connect = false;

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            if(ConnectBTN.Text == "Se connecter") //Se connecter
            {
                if(txtBoxHost.Text != null) //Vérification txtBoxHost
                {
                    if(txtBoxDB.Text != null) //Vérification txtBoxDB
                    {
                        if (txtBoxUID.Text != null) //Vérification txtBoxUID
                        {
                            conn = new MySqlConnection("SERVER=" + txtBoxHost.Text + ";DATABASE=" + txtBoxDB.Text + ";UID=" + txtBoxUID.Text + ";PASSWORD=" + txtBoxPassword.Text);
                            try
                            {
                                if (conn.State == ConnectionState.Closed) //Si session est déconnectée
                                { 
                                    conn.Open();
                                    connect = true;
                                }
                                ConnectBTN.Text = "Se déconnecter";
                                MessageBox.Show("Base de donnée connectée");
                            }
                            catch(Exception erreur)
                            {
                                MessageBox.Show(erreur.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Complétez votre nom d'utilisateur");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complétez le nom de la base de donnée");
                    }
                }
                else
                {
                    MessageBox.Show("Complétez l'adresse de la base de donnée");
                }
            }
            else //Se déconnecter
            {
                conn.Close();
                ConnectBTN.Text = "Se connecter";
                connect = false;
                listViewMembre.Items.Clear();
                MessageBox.Show("Base de donnée déconnectée");
            }
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            if(txtBoxNom.Text == "")
            {
                MessageBox.Show("Complétez tous les champs");
            }else if(txtBoxPrenom.Text == "")
            {
                MessageBox.Show("Complétez tous les champs");
            }else if (txtBoxAge.Text == "")
            {
                MessageBox.Show("Complétez tous les champs");
            }else if (txtBoxSexe.Text == "")
            {
                MessageBox.Show("Complétez tous les champs");
            }
            else
            {
                if (connect)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO membres(nom, prenom, age, sexe) VALUES(@nom, @prenom, @age, @sexe)", conn);
                    cmd.Parameters.AddWithValue("@nom", txtBoxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtBoxPrenom.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txtBoxAge.Text));
                    cmd.Parameters.AddWithValue("@sexe", txtBoxSexe.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Membre ajouté avec succés");
                    txtBoxNom.Text = "";
                    txtBoxPrenom.Text = "";
                    txtBoxAge.Text = "";
                    txtBoxSexe.Text = "";
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas connecté à la BDD");
                }
            }
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                listViewMembre.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM membres", conn);
                using(MySqlDataReader Lire = cmd.ExecuteReader())
                {
                    while (Lire.Read())
                    {
                        string ID = Lire["id"].ToString();
                        string nom = Lire["nom"].ToString();
                        string prenom = Lire["prenom"].ToString();
                        string age = Lire["age"].ToString();
                        string sexe = Lire["sexe"].ToString();

                        listViewMembre.Items.Add(new ListViewItem(new[] { ID, nom, prenom, age, sexe }));
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas connecté à la BDD");
            }
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                if(listViewMembre.SelectedItems.Count > 0)
                {
                    ListViewItem element = listViewMembre.SelectedItems[0];
                    string ID = element.SubItems[0].Text;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM membres WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    element.Remove();
                    MessageBox.Show("Membre supprimé avec succès");
                }
            }
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listViewMembre.SelectedItems.Count > 0)
            {
                ListViewItem element = listViewMembre.SelectedItems[0];
                string ID = element.SubItems[0].Text;
                string nom = element.SubItems[1].Text;
                string prenom = element.SubItems[2].Text;
                string age = element.SubItems[3].Text;
                string sexe = element.SubItems[4].Text;

                using(Modifier m = new Modifier())
                {
                    m.ID = ID;
                    m.Nom = nom;
                    m.Prenom = prenom;
                    m.Age = age;
                    m.Sexe = sexe;

                    if(m.ShowDialog() == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand("UPDATE membres SET nom=@nom, prenom=@prenom, age=@age, sexe=@sexe WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@nom", m.Nom);
                        cmd.Parameters.AddWithValue("@prenom", m.Prenom);
                        cmd.Parameters.AddWithValue("@age", m.Age);
                        cmd.Parameters.AddWithValue("@sexe", m.Sexe);
                        cmd.ExecuteNonQuery();
                        element.SubItems[1].Text = m.Nom;
                        element.SubItems[2].Text = m.Prenom;
                        element.SubItems[3].Text = m.Age;
                        element.SubItems[4].Text = m.Sexe;
                        MessageBox.Show("Membre modifié");
                    }
                }
            }
        }
    }
}
