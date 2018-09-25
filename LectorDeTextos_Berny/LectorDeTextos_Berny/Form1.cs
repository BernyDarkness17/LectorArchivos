using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorDeTextos_Berny {
    public partial class FormArchivos : Form {
        int contPalabras = 0;
        int contCaracteres = 0;
        int contEspacios = 0;
        int contTabulador = 0;
        int contLineas = 0;
        int contVocales = 0;
        int contConsonantes = 0;

        public FormArchivos() {
            InitializeComponent();
            cmbQuitar.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            //QUITAR ESPACIOS EN BLANCO
            if (cmbQuitar.SelectedIndex == 0) { 
                String tx = txtTEXTO.Text;
                String nuevoText = tx.Replace(" ", "");
                txtTEXTO.Text = nuevoText;

            //QUITAR VOCALES
            }if (cmbQuitar.SelectedIndex == 1) {
                String texto = txtTEXTO.Text.ToLower();
                string cadena = "";
                char[] vocales = { 'e', 'a', 'i', 'o' , 'u' };
                string[] Corte = texto.Split(vocales);

                foreach (string p in Corte) {
                    if (!p.Equals("")) {
                        cadena = cadena + p;
                    }
                    txtTEXTO.Text = cadena.Trim();
                }

            //QUITAR CONSONANTES
            }if (cmbQuitar.SelectedIndex == 2) {
                String texto = txtTEXTO.Text.ToLower();
                string cadena = "";
                char[] consonantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
                string[] Corte = texto.Split(consonantes);

                foreach (string p in Corte) {
                    if (!p.Equals("")) {
                        cadena = cadena + p;
                    }
                    txtTEXTO.Text = cadena.Trim();
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e) {
            //GUARDAR ARCHIVO

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de texto (*.txt)|*.txt";

            if (guardar.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                StreamWriter crear = new StreamWriter(File.Create(guardar.FileName));

                crear.Write(txtTEXTO.Text);
                crear.Dispose();

            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            //EXAMINAR ARCHIVOS

            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "Archivos de texto (*.txt)|*.txt";
            contPalabras = 0;
            contCaracteres = 0;
            contEspacios = 0;
            contTabulador = 0;
            contLineas = 0;
            contVocales = 0;
            contConsonantes = 0;

            if (examinar.ShowDialog() == DialogResult.OK) {
                StreamReader leer = new StreamReader(File.OpenRead(examinar.FileName));
                String ruta = examinar.FileName;

                txtRutaArchivo.Text = ruta;
                txtTEXTO.Text = leer.ReadToEnd();

                leer.Dispose();

                //Contar Tabulaciones
                contTabulador = txtTEXTO.Text.Split('\t').Length;
                contTabulador--;
                ContTabuladores.Text = ": " + contTabulador;

                //Espacios en blanco
                contEspacios = txtTEXTO.Text.Split(' ').Length;
                contEspacios--; //trucho, creo..
                ContEspaciosBlancos.Text = ": "+contEspacios;

                //Contador lineas
                contLineas = txtTEXTO.Lines.Count();
                ContLineas.Text = ": " + contLineas;

                //Contador Consonantes
                string txtCon = txtTEXTO.Text.ToLower();//a minuscula todo, nomas
                for (int i = 0; i < txtCon.Length; i++) {
                    switch (txtCon[i]) {
                        case 'b':
                            contConsonantes++;
                            break;
                        case 'c':
                            contConsonantes++;
                            break;
                        case 'd':
                            contConsonantes++;
                            break;
                        case 'f':
                            contConsonantes++;
                            break;
                        case 'g':
                            contConsonantes++;
                            break;
                        case 'h':
                            contConsonantes++;
                            break;
                        case 'j':
                            contConsonantes++;
                            break;
                        case 'k':
                            contConsonantes++;
                            break;
                        case 'l':
                            contConsonantes++;
                            break;
                        case 'm':
                            contConsonantes++;
                            break;
                        case 'n':
                            contConsonantes++;
                            break;
                        case 'p':
                            contConsonantes++;
                            break;
                        case 'q':
                            contConsonantes++;
                            break;
                        case 'r':
                            contCaracteres++;
                            break;
                        case 's':
                            contConsonantes++;
                            break;
                        case 't':
                            contConsonantes++;
                            break;
                        case 'v':
                            contConsonantes++;
                            break;
                        case 'w':
                            contConsonantes++;
                            break;
                        case 'x':
                            contConsonantes++;
                            break;
                        case 'y':
                            contConsonantes++;
                            break;
                        case 'z':
                            contConsonantes++;
                            break;
                    }
                }
                ContConsonantes.Text = ": " + contConsonantes;

                //Contar Vocales
                String txt = txtTEXTO.Text.ToLower();
                for (int i = 0; i < txt.Length; i++) {
                    switch (txt[i]) {
                        case 'a':
                            contVocales++;
                            break;
                        case 'e':
                            contVocales++;
                            break;
                        case 'i':
                            contVocales++;
                            break;
                        case 'o':
                            contVocales++;
                            break;
                        case 'u':
                            contVocales++;
                            break;
                    }
                }
                ContVocales.Text = ": " + contVocales;

                //Contar cantidad caracteres
                contCaracteres = contVocales + contConsonantes + contEspacios + contTabulador;//los espacios son caracteres???
                ContCaracteres.Text = ": " + contCaracteres;

                //Contar Palabras   
                String texto = txtTEXTO.Text;

                char[] sentencia = { ' ', '\n', '\t' };
                string[] Corte = texto.Split(sentencia);

                foreach (string p in Corte){
                    if (!p.Equals("")){
                        contPalabras++;
                    }
                    ContPalabras.Text = ": " + contPalabras;
                }
            }
        }

        private void cmbQuitar_SelectedIndexChanged(object sender, EventArgs e) {
        }
    }
}
