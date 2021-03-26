using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alô Mundo!");



            MessageBox.Show("Alô Mundo!",
            "Estudos Iniciais");



            MessageBox.Show("Alô Mundo!",
            "Estudos Iniciais",
            MessageBoxButtons.OKCancel);



            MessageBox.Show("Alô Mundo!",
            "Estudos Iniciais",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList o_arlGeral = new ArrayList();



            // Adiciona elementos
            o_arlGeral.Add(3);
            o_arlGeral.Add("João");
            o_arlGeral.Add(1.65f);
            o_arlGeral.Add(DateTime.Now);
            o_arlGeral.Add("João");
            o_arlGeral.Add("João");



            //Exibe todos os elementos
            foreach (Object item in o_arlGeral)
            {
                Console.WriteLine("Item: " + item.ToString());
            }





            // Verifica se contem o elemento
            if (o_arlGeral.Contains("João"))
            {
                MessageBox.Show("O Array List contem o nome: João",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Array List NÃO contem o nome: João",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }



            // Remove o primeiro João que encontrar na lista
            o_arlGeral.Remove("João");



            MessageBox.Show("O primeiro João encontrado na lista foi removido",
            "Remoção", MessageBoxButtons.OK,
            MessageBoxIcon.Information);



            //Exibe todos os elementos
            foreach (Object Item in o_arlGeral)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }



            // Remove todos os elementos
            o_arlGeral.Clear();



            MessageBox.Show("Todos os itens da lista foram removidos.",
            "Remoção", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> lstStarWars = new List<string>();



            // Adiciona um elemento
            lstStarWars.Add("Luke Skywalker");
            lstStarWars.Add("Darth Vader");
            lstStarWars.Add("Han Solo");
            lstStarWars.Add("Chewbacca");



            // Exibe todos os elementos da lista
            foreach (string item in lstStarWars)
            {
                Console.WriteLine("Nomes: " + item.ToString());
            }




            // Remove o item
            lstStarWars.Remove("Chewbacca");



            // Adiciona itens na lista
            lstStarWars.Add("Leia Organa");
            lstStarWars.Add("R2D2");
            lstStarWars.Add("C3PO");
            lstStarWars.Add("BB8");



            // Verifica se um elemento se encontra na lista
            if (lstStarWars.Contains("Han Solo"))
            {
                MessageBox.Show("Han Solo – Positivo Operante",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Han Solo – Inativo",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }



            Console.WriteLine("\n\n\n");



            // Exibe todos os elementos da lista
            foreach (Object Item in lstStarWars)
            {
                Console.WriteLine("Novos Itens: " + Item.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Código com tratamento com ERRO



try
            {
                int x, total;



                x = 0;



                total = 100 / x;



                Console.WriteLine("Resultado: " + total);
            }
            catch
            {
                MessageBox.Show("Não é possível divisão por zero.",
                "Tratamento de Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;



                x = 0;



                total = 100 / x;



                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                "Tratamento de Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hashtable o_hstEmailAluno = new Hashtable();



            // Adiciona elementos
            o_hstEmailAluno.Add("jose@google.com", "José Maria");
            o_hstEmailAluno.Add("carlos@hotmail", "Carlos Teixeira");
            o_hstEmailAluno.Add("jose@msn.com", "José Maria");



            //Exibe todos os elementos com BASE NA CHAVE
            Console.WriteLine("=========== CHAVE ===========");
            foreach (Object item in o_hstEmailAluno.Keys)
            {
                Console.WriteLine("Item.Chave: " + item.ToString());
            }




            //Exibe todos os elementos com BASE NO VALOR
            Console.WriteLine("=========== VALOR ===========");
            foreach (Object item in o_hstEmailAluno.Values)
            {
                Console.WriteLine("Item.Valor: " + item.ToString());
            }





            //Exibe todos os elementos INDEPENDENTE DA CHAVE OU VALOR
            Console.WriteLine("=========== CHAVE / VALOR ===========");
            // Cada item é um Hashtable é marmazenado em um par de chave/valor
            // armazenado em um objeto DictionaryEntry.
            foreach (DictionaryEntry item in o_hstEmailAluno)
            {
                Console.WriteLine(item.Key.ToString() + " ==> " + item.Value.ToString());
            }




            // Verifica se contem o elemento
            if (o_hstEmailAluno.Contains("pedropaulo@msn.com"))
            {
                MessageBox.Show("O Hashtable contem o email: pedropaulo@msn.com",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Hashtable NÃO contem o email: pedropaulo@msn.com",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }



            // Remove o elemento com base na sua CHAVE
            o_hstEmailAluno.Remove("pedropaulo@msn.com");



            //Exibe todos os elementos INDEPENDENTE DA CHAVE OU VALOR
            Console.WriteLine("=========== CHAVE / VALOR ===========");
            // Cada item é um Hashtable é marmazenado em um par de chave/valor
            // armazenado em um objeto DictionaryEntry.
            foreach (DictionaryEntry item in o_hstEmailAluno)
            {
                Console.WriteLine(item.Key.ToString() + " ==> " + item.Value.ToString());
            }




            // Remove todos os elementos
            o_hstEmailAluno.Clear();



            MessageBox.Show("Todos os itens foram removidos.",
            "Remoção", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;



                x = 0;



                if (x == 0)
                {
                    throw new Exception("O valor de X deve ser maior que zero.");
                }



                total = 100 / x;



                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
