using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace logAnalizer
{
    public partial class logAnalizer : Form
    {
       
        public logAnalizer()
        {
            InitializeComponent();
        }

        private void generateMetricsBtn_Click(object sender, EventArgs e)
        {
            if(File.Exists(logSelectionLbl.Text) && numNodes.Text != null && !numNodes.Text.Equals("") && numPackets.Text != null && !numPackets.Text.Equals(""))
                analizeLogFile(logSelectionLbl.Text);
            else
                MessageBox.Show("Selezionare il file di log del sink e/o riempire i valori dei nodi e dei pacchetti!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void analizeLogFile(string sinkPath)
        {
            logResultText.AppendText("Analisi del file di log del sink in corso...");
            logResultText.AppendText(Environment.NewLine);
            int[] packetRetransmissions = new int[Convert.ToInt32(numPackets.Text)];
            int[] nodeRetransmissions = new int[Convert.ToInt32(numNodes.Text) + 1];
            using (StreamReader sr = File.OpenText(sinkPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subStrings = line.Split('-');
                    
                    /*
                     subStrings structure: 
                        [0] = action made
                        [1] = NODE_ID
                        [2] = value associated with the action made
                     */
                    switch (subStrings[0])
                    {
                        case "RTXPKTTX":
                            packetRetransmissions[Convert.ToInt32(subStrings[2])]++;
                            break;
                        case "RTXTOT":
                            nodeRetransmissions[Convert.ToInt32(subStrings[1])] = Convert.ToInt32(subStrings[2]);
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            try
            {
                for (int node = 0; node < Convert.ToInt32(numNodes.Text); node++)
                {
                    DialogResult dialogResult = MessageBox.Show("Premi Okay per aggiungere il file di log del prossimo nodo", "Avviso", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        string path = openedFilePath();

                        logResultText.AppendText("Analisi del file di log del nodo " + (node + 1) + " in corso...");
                        logResultText.AppendText(Environment.NewLine);

                        using (StreamReader sr = File.OpenText(path))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] subStrings = line.Split('-');

                                /*
                                 subStrings structure: 
                                    [0] = action made
                                    [1] = NODE_ID
                                    [2] = value associated with the action made
                                 */
                                switch (subStrings[0])
                                {
                                    case "RTXPKTTX":
                                        packetRetransmissions[Convert.ToInt32(subStrings[2])]++;
                                        break;
                                    case "RTXTOT":
                                        nodeRetransmissions[Convert.ToInt32(subStrings[1])] = Convert.ToInt32(subStrings[2]);
                                        break;
                                    default:
                                        break;
                                }

                            }
                        }
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("Nessun file selezionato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            logResultText.AppendText("Creazione del file di output in: " + Path.GetDirectoryName(sinkPath) + @"\output.txt");
            logResultText.AppendText(Environment.NewLine);

            int i= 0,j = 0;
            using (StreamWriter sw = File.CreateText(Path.GetDirectoryName(sinkPath)+@"\output.txt"))
            {
                while (i < packetRetransmissions.Length)
                {
                    sw.WriteLine("Packet " + i + " Total retransmissions: " + packetRetransmissions[i]);
                    i++;
                }
                while (j < nodeRetransmissions.Length)
                {
                    sw.WriteLine("Node " + j + " Total retransmissions: " + nodeRetransmissions[j]);
                    j++;
                }
            }
            logResultText.AppendText("Analisi terminata.");
            logResultText.AppendText(Environment.NewLine);
        }

        private string openedFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    return filePath;
                }
            }
            return null;
        }

        private void logSelectionBtn_Click(object sender, EventArgs e)
        {
            string path = openedFilePath();
            if (path != null)
                logSelectionLbl.Text = path;
        }
    }
}
