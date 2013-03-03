using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Data.Linq;

namespace VoiceRecognition
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recognitionEngine;

        Choices application_choices;
        Choices close_choices;
        Choices search_choices;
        Choices open_choices;
        Choices choices_choices;

        GrammarBuilder MainGrammar;
        GrammarBuilder close_grammar;
        GrammarBuilder application_grammar;
        GrammarBuilder search_grammar;
        GrammarBuilder open_grammar;
        static GrammarBuilder options;

        //static Grammar MainGrammar;

        public string newpath;
        public string computername_s;
        static List<string> n_list = new List<string>();
        static List<string> p_list = new List<string>();

        public string[] open_list = new string[3] { "open", "run", "start" };
        public string[] close_list = new string[3] { "close", "kill", "exit" };
        public string[] search_list = new string[3] { "search", "google", "look up" };
        public string[] home_list = new string[2] { "set", "adjust"};
        public string[] ac_list = new string[5] { "temp", "temperature", "heat", "ac", "air" };

        public static string[] recognized_list = new string[12];

        //Grammar applicationsGrammar;
        public Form1()
        {
            InitializeComponent();
            computername_s = computername.Text;
            recognitionEngine = new SpeechRecognitionEngine();
            recognitionEngine.SetInputToDefaultAudioDevice();

            stop_button.Enabled = false;
            delete_button.Enabled = false;
            add_button.Enabled = false;
            save_button.Enabled = false;

            

            recognitionEngine.SpeechRecognized += (s, args) =>
            {
                int i = 0;
                string line =   "";

                foreach (RecognizedWordUnit word in args.Result.Words)
                {
                    //float word_cf = (float)Convert.ToDecimal (text_word_confidence.Text);
                    float word_cf = 0.5F;

                    if (word.Confidence > word_cf)
                        line += word.Text + " ";
                        recognized_list[i] += word.Text;
                        i++;
                        if (i > 12)
                        {
                            i = 0;
                        }
                }

                string command = Regex.Replace(line, computername_s, "").Trim();

                label4.Visible = true;
                label7.Visible = false;
                
                //string command = find_command(line,computername_s);

                if (command.Contains(open_list[0]) || command.Contains(open_list[1]) || command.Contains(open_list[2]))
                {
                    //open
                    string application = split_commands(command);
                    StartProgram(application);

                };
                if (command.Contains(close_list[0]) || command.Contains(close_list[1]) || command.Contains(close_list[2]))
                {
                    //close
                    string application = split_commands(command);
                    ExitProgram(application);

                };
                if (command.Contains(search_list[0]) || command.Contains(search_list[1]) || command.Contains(search_list[2]))
                {
                    //search
                    string search = split_commands(command);
                    if (search.Contains(search_list[0]) || search.Contains(search_list[1]) || search.Contains(search_list[2]))
                    {
                        //MessageBox.Show("Unrecognized Search Query", "Error",
                        //MessageBoxButtons.OKCancel,
                        //MessageBoxIcon.Asterisk);
                        label4.Visible = false;
                        label7.Visible = true;
                        

                        
                    }
                    else
                    {
                        SearchGoogle(search);
                    }
                };
                if (command.Contains(home_list[0]) || command.Contains(home_list[1]))
                {
                    //search
                    string home = split_commands(command);
                    if (home.Contains(ac_list[0]) || home.Contains(ac_list[1]) || home.Contains(ac_list[2]))
                    {
                    }
                    //SearchGoogle(search);
                };
            };
   
        }

        static string split_commands(string command)
        {
            string[] split_commands = command.Split(' ');
            int size = split_commands.Length;
            string last = split_commands[size-1];
            return last;
        }


        static int  find_position(string name)
        {
            int pos = n_list.IndexOf(name);
            return pos;
        }

        static void SearchGoogle(string t)
        {

            Process.Start("http://google.com/search?q=" + t);

        }

        static void StartProgram(string name)
        {
            int num = find_position(name);
            string path = p_list[num];
            Process.Start(path);

        }
        static void ExitProgram(string t)
        {
            //
            Process[] prs = Process.GetProcesses();

            foreach (Process pr in prs)
            {
                if (pr.ProcessName == t)
                {

                    pr.Kill();

                }

            }
        }

        
        private Grammar MainGrammarBuilder()
        {
            computername_s = computername.Text;

            recognitionEngine.UnloadAllGrammars();
            //string stuff = names_list.Items;
            //Choices update = new Choices(name_text.Text);
            string[] x = new string[names_list.Items.Count];
            int i = 0;
            foreach (object item in names_list.Items)
            {
                x[i] = item.ToString();
                i++;
            }
            //rebuilding
            ///////////%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            GrammarBuilder application_grammar = new GrammarBuilder();
            if (x.Length > 0)
            {
                Choices application_choices = new Choices(x);
                application_grammar.Append(application_choices);
                application_grammar.Append(new SemanticResultValue("Application"));
            }
            //open
            
            GrammarBuilder open_grammar = new GrammarBuilder();
            //Choices open_choices = new Choices("open", "run", "start", "launch");
            Choices open_choices = new Choices(open_list);
            //string open_strings = open_choices.
            open_grammar.Append(open_choices);
            open_grammar.Append(new SemanticResultValue("Open"));


            GrammarBuilder close_grammar = new GrammarBuilder();
            //Choices close_choices = new Choices("close", "kill", "exit");
            Choices close_choices = new Choices(close_list);
            close_grammar.Append(close_choices);
            close_grammar.Append(new SemanticResultValue("Close"));

            GrammarBuilder search_grammar = new GrammarBuilder();
            //Choices search_choices = new Choices("search", "google", "look up");
            Choices search_choices = new Choices(search_list);
            search_grammar.Append(search_choices);
            search_grammar.Append(new SemanticResultValue("Search"));
            search_grammar.AppendDictation();

            GrammarBuilder home_grammar = new GrammarBuilder();
            Choices home_choices = new Choices(home_list);
            home_grammar.Append(home_choices);
            home_grammar.Append(new SemanticResultValue("Home"));

            //GrammarBuilder dictation = new GrammarBuilder();
            //dictation.AppendDictation();

            options = new GrammarBuilder(new Choices(open_grammar, close_grammar, search_grammar));

            //Final Grammar
            GrammarBuilder MainGrammar = new GrammarBuilder();
            //MainGrammar.Culture = culture;

            MainGrammar.Append(new Choices(computername_s));
            MainGrammar.Append(new Choices("Please"," "));
            MainGrammar.Append(new SemanticResultKey("Options", options));
            if (x.Length > 0)
            {
                MainGrammar.Append(new SemanticResultKey("Application", application_grammar));
            }
            //MainGrammar.Append(new SemanticResultKey("Dictation Input", dictation));

            //MainGrammar.Append("to");
            //MainGrammar.Append(new SemanticResultKey("to", airports));

            return new Grammar(MainGrammar);

            ///////////%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        }





        private void button1_Click(object sender, EventArgs e)
        {
            computername_s = computername.Text;
            //update
            //updategrammars();
            //LoadGrammars(MainGrammar);

            Grammar main = MainGrammarBuilder();
            //CreateGrammarBuilders();
            //LoadGrammars();
            recognitionEngine.LoadGrammar(main);

            label4.Visible = true;
            stop_button.Enabled = true;
            start_button.Enabled = false;
            try
            {
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                label4.Text = "Error";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            stop_button.Enabled = false;
            start_button.Enabled = true;
            recognitionEngine.RecognizeAsyncStop();
        }


        private void open_button_Click(object sender, EventArgs e)
        {

            add_button.Enabled = true;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            OpenFileDialog result = new OpenFileDialog();
            result.InitialDirectory = path ;
            result.RestoreDirectory = true;
            result.Filter = "Application Files (*.exe)|*.exe";
            if (result.ShowDialog() == DialogResult.OK) // Test result.
            {
                //MessageBox.Show(result.FileName, computername.Text,
                //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            newpath = result.FileName;
            string name = result.SafeFileName;
            commandname.Text = Regex.Replace(name, ".exe", "");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            delete_button.Enabled = true;
            stop_button.Enabled = false;
            start_button.Enabled = true;

            recognitionEngine.RecognizeAsyncStop();
            label4.Visible = false;

            string newcommand = commandname.Text;

            if (newpath != null && newcommand != null)
            {

                names_list.BeginUpdate();
                paths_list.BeginUpdate();

                names_list.Items.Add(newcommand);
                paths_list.Items.Add(newpath);

                names_list.EndUpdate();
                paths_list.EndUpdate();

                n_list.Add(newcommand);
                p_list.Add(newpath);

            }
            Grammar main = MainGrammarBuilder();
            recognitionEngine.LoadGrammar(main);        
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int delete_index = names_list.SelectedIndex;

            recognitionEngine.RecognizeAsyncStop();


            label4.Visible = false;

            names_list.BeginUpdate();
            paths_list.BeginUpdate();

            names_list.Items.RemoveAt(delete_index);
            paths_list.Items.RemoveAt(delete_index);

            names_list.EndUpdate();
            paths_list.EndUpdate();

            n_list.RemoveAt(delete_index);
            p_list.RemoveAt(delete_index);

            Grammar main = MainGrammarBuilder();
            recognitionEngine.LoadGrammar(main);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_file();
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            open_file();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void add_to_list(string newcommand, string newpath)
        {
            recognitionEngine.RecognizeAsyncStop();
            label4.Visible = false;

            //newcommand = commandname.Text;

            if (newpath != null && newcommand != null)
            {

                names_list.BeginUpdate();
                paths_list.BeginUpdate();

                names_list.Items.Add(newcommand);
                paths_list.Items.Add(newpath);

                names_list.EndUpdate();
                paths_list.EndUpdate();

                n_list.Add(newcommand);
                p_list.Add(newpath);

            }
            Grammar main = MainGrammarBuilder();
            recognitionEngine.LoadGrammar(main);        
        }



        private void save_file()
        {
            StreamWriter Write;
            string path = Directory.GetCurrentDirectory();
            SaveFileDialog Save = new SaveFileDialog();
            Save.InitialDirectory = path;
            Save.RestoreDirectory = true;
            
            try
            {
                Save.Filter = ("Text Document|*.txt|All Files|*.*");
                Save.ShowDialog();
                Write = new StreamWriter(Save.FileName);
                Write.WriteLine(computername);
                for (int i = 0; i < names_list.Items.Count; i++)
                {
                    string line = Convert.ToString(names_list.Items[i]) + "," + Convert.ToString(paths_list.Items[i]);
                    Write.WriteLine(line);
                }
                Write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
                return;
            }
        }
        private void open_file()
        {
            try
            {
                OpenFileDialog result = new OpenFileDialog();
                string path = Directory.GetCurrentDirectory();
                result.InitialDirectory = path;
                result.Filter = "text Files (*.txt)|*.txt";

                if (result.ShowDialog() == DialogResult.OK) // Test result.
                {
                    //MessageBox.Show(result.FileName, computername.Text,
                    //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }

                using (StreamReader readFile = new StreamReader(result.FileName))
                {
                    string line;
                    string[] row;

                    paths_list.Items.Clear();
                    names_list.Items.Clear();

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        add_to_list(row[0], row[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
                return;
            }

            //newpath = result.FileName;
            //string name = result.SafeFileName;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }





  







        




    }
}
