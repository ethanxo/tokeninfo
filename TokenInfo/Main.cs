using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TokenInfo
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        int lastindex;
        string filepath;
        private Token[] tokens;

        public Main()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // get current index and subtract one
            int index = combobox_token.SelectedIndex - 1;
            // perform bounds check / loop on index
            if (index < 0)
                index = combobox_token.Items.Count - 1;
            if (index > combobox_token.Items.Count - 1)
                index = 0;
            // reassign index
            combobox_token.SelectedIndex = index;
            // load info
            loadInfo(combobox_token.SelectedIndex);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            // get current index and add one
            int index = combobox_token.SelectedIndex + 1;
            // perform bounds check / loop on index
            if (index < 0)
                index = combobox_token.Items.Count - 1;
            if (index > combobox_token.Items.Count - 1)
                index = 0;
            // reassign index
            combobox_token.SelectedIndex = index;
            // load info
            loadInfo(combobox_token.SelectedIndex);
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            // show filedialog, save the filepath
            openfiledialog.ShowDialog();
            filepath = openfiledialog.FileName;
            // set the filepath label text
            label_filepath.Text = filepath;
            // linecount
            int linecount = CountLinesReader(new FileInfo(filepath));
            // precheck tokens
            Token[] prtokens = new Token[linecount];
            // make raw token list
            string[] rawtokens;
            rawtokens = File.ReadAllLines(filepath);
            // fill precheck token array with tokens from the file
            for (int i = 0; i < linecount; i++)
            {
                prtokens[i] = new Token();
                prtokens[i].token = rawtokens[i];
            }
            // pass in precheck tokens and return with working tokens
            tokens = initializeTokens(prtokens);
            // populate combobox and select first value
            for (int i = 0; i < tokens.Length; i++)
                combobox_token.Items.Add(tokens[i].tag + " | " + tokens[i].token);
            combobox_token.SelectedIndex = 0;
            // load start info
            loadInfo(combobox_token.SelectedIndex);
            // enable back and forth buttons + combobox
            if (tokens.Length > 0)
            {
                combobox_token.Enabled = true;
                button_back.Enabled = true;
                button_next.Enabled = true;
            }
            else
            {
                combobox_token.Enabled = false;
                button_back.Enabled = false;
                button_next.Enabled = false;
            }
            // set loaded tokens label
            label_tokensloaded.Text = "Active Verified Tokens: " + tokens.Length;
        }

        private void combobox_token_DropDownClosed(object sender, EventArgs e)
        {
            // if the dropdown is closed and the option hasnt changed then dont execute code
            if (lastindex == combobox_token.SelectedIndex) return;
            // get token info
            loadInfo(combobox_token.SelectedIndex);
        }

        private void combobox_token_DropDown(object sender, EventArgs e)
        {
            // store current index as "lastindex" upon opening
            lastindex = combobox_token.SelectedIndex;
        }

        private Token[] initializeTokens(Token[] prtokens)
        {
            // create temporary token arraylist
            ArrayList tokens = new ArrayList();
            // check tokens and get info
            for (int i = 0; i < prtokens.Length; i++)
            {
                // get info
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(prtokens[i].token);
                var content = client.GetAsync("https://discordapp.com/api/v6/users/@me").Result.Content.ReadAsStreamAsync();
                var result = new StreamReader(content.Result).ReadToEnd();
                dynamic json = JsonConvert.DeserializeObject(result);
                // check validity
                string validity = (string)json["message"];
                if (validity != null)
                    continue;
                // add info to new token
                Token tokentoadd = new Token();
                tokentoadd.token = prtokens[i].token;
                tokentoadd.id = (string)json["id"];
                bool verified = (bool)json["verified"];
                if (!verified)
                    tokentoadd.status = "Unverified";
                else
                    tokentoadd.status = "Verified";
                tokentoadd.tag = (string)json["username"] + "#" + (string)json["discriminator"];
                string email = (string)json["email"];
                if (email != null)
                    tokentoadd.email = email;
                else
                    tokentoadd.email = "null (Unverified)";
                tokentoadd.avatarurl = (string)json["avatar"];
                // add completed object to arraylist
                tokens.Add(tokentoadd);
            }
            // convert arraylist to array
            Token[] returntokens = (Token[])tokens.ToArray(typeof(Token));
            // return unverified and normal tokens
            return returntokens;
        }

        private void loadInfo(int index)
        {
            // set info to retrieved info
            label_status.Text = "Status: " + tokens[index].status;
            label_tag.Text = "Tag: " + tokens[index].tag;
            label_email.Text = "Email: " + tokens[index].email;
            label_id.Text = "ID: " + tokens[index].id;
            label_token.Text = "Token: " + tokens[index].token;
            picturebox_avatar.Load("https://cdn.discordapp.com/avatars/" + tokens[index].id + "/" + tokens[index].avatarurl + ".png");
        }

        private int CountLinesReader(FileInfo file)
        {
            var lineCounter = 0;
            using (var reader = new StreamReader(file.FullName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
                return lineCounter;
            }
        }

        private void label_status_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_status.Text);
        }

        private void label_tag_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_tag.Text);
        }

        private void label_email_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_email.Text);
        }

        private void label_id_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_id.Text);
        }

        private void label_token_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_token.Text);
        }

        private void picturebox_avatar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://cdn.discordapp.com/avatars/" + tokens[combobox_token.SelectedIndex].id + "/" + tokens[combobox_token.SelectedIndex].avatarurl + ".png");
        }
    }
}
