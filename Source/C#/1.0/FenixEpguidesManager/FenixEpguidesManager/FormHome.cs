// Fenix Epguides Manager 1.0
// © Ismael Heredia , Argentina , 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Security;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace FenixEpguidesManager
{
    public partial class FormHome : Form
    {
        Helpers helper = new Helpers();

        string application_title = "Fenix Epguides Manager 1.0";

        public FormHome()
        {
            InitializeComponent();
        }

        public string http_get(string url)
        {
            string html = "";
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Proxy = null;
                request.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36";

                ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateServerCertificate);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                html = reader.ReadToEnd();
            }
            catch
            {
                MessageBox.Show("Error loading page", application_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return html;
        }

        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            string show_name = txtShow.Text;

            if (show_name == "")
            {
                MessageBox.Show("Enter show name", application_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lvEpisodes.Items.Clear();

                int counter = 0;

                show_name = show_name.Replace(" ","");

                string html = http_get("http://epguides.com/" + show_name);

                Match search1 = Regex.Match(html, "<pre[^<>]*>(.*?)</pre>", RegexOptions.Singleline);

                if (search1.Success)
                {
                    string pre = search1.Groups[1].Value;
                    string[] stringSeparators = new string[] { "\n" };
                    string[] lineas = pre.Split(stringSeparators, StringSplitOptions.None);

                    foreach (string linea in lineas)
                    {
                        string pre_cleaned = Regex.Replace(linea, @"\s+", " ");

                        string number = "";
                        string episode_number = "";
                        string air_date = "";
                        string title = "";

                        Match search2 = Regex.Match(pre_cleaned, "(.*?). (.*?)-(.*?) (.*?) <a target=\"_blank\" href=\"(.*?)\">(.*?)</a>", RegexOptions.IgnoreCase);
                        while (search2.Success)
                        {
                            number = search2.Groups[1].Value;
                            episode_number = search2.Groups[2].Value + "-" + search2.Groups[3].Value;
                            air_date = search2.Groups[4].Value;
                            title = search2.Groups[6].Value;
                            counter++;
                            search2 = search2.NextMatch();
                        }

                        if (air_date == "")
                        {
                            Match search3 = Regex.Match(pre_cleaned, "(.*?). (.*?) <a target=\"_blank\" href=\"(.*?)\">(.*?)</a>", RegexOptions.IgnoreCase);
                            while (search3.Success)
                            {
                                number = search3.Groups[1].Value;
                                episode_number = search3.Groups[2].Value;
                                air_date = "No date";
                                title = search3.Groups[4].Value;
                                counter++;
                                search3 = search3.NextMatch();
                            }
                        }
                        
                        ListViewItem item = new ListViewItem();
                        item.Text = number;
                        item.SubItems.Add(episode_number);
                        item.SubItems.Add(air_date);
                        item.SubItems.Add(title);

                        if (title != "")
                        {
                            lvEpisodes.Items.Add(item);
                        }

                    }

                    gbEpisodes.Text = "Episodes : " + counter;
                }
                else
                {
                    MessageBox.Show("Show not found, try another name", application_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                helper.play_sound("done");
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            helper.play_sound("loaded");
        }

        private void FormHome_MouseClick(object sender, MouseEventArgs e)
        {
            helper.play_sound("click");
        }

        private void lblPowered_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://epguides.com/");
        }
    }
}
