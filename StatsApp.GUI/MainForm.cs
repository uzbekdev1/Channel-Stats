using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL;
using TeleSharp.TL.Auth;
using TeleSharp.TL.Channels;
using TeleSharp.TL.Messages;
using TLSharp.Core;
using TLSharp.Core.Exceptions;

namespace StatsApp.GUI
{
    public partial class MainForm : Form
    {

        private void AppendLog(string s)
        {
            rbxLogs.AppendText(s + Environment.NewLine);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnConnect_Click(object sender, EventArgs e)
        {
            var apiId = int.Parse(tbxId.Text);
            var apiHash = tbxHash.Text;
            var store = new FileSessionStore(new DirectoryInfo(Environment.CurrentDirectory));
            var client = new TelegramClient(apiId, apiHash, store);
            await client.ConnectAsync();

            var phone = "+998" + tbxPhone.Text.Replace("-", "");
            AppendLog("Enter your phone number: " + phone);

            var codeHash = await client.SendCodeRequestAsync(phone);
            var code = Interaction.InputBox("Please enter confirmation code", "Telegram");
            if (string.IsNullOrWhiteSpace(code))
            {
                return;
            }
            AppendLog("Enter your Telegram code: " + code);

            TLUser user;
            try
            {
                user = await client.MakeAuthAsync(phone, codeHash, code);
            }
            catch (CloudPasswordNeededException)
            {
                var passwordSetting = await client.GetPasswordSetting();
                AppendLog("This account needs cloud password.");

            TryAgain:

                var password = tbxPassword.Text;
                AppendLog("Enter your password: " + password);

                try
                {
                    user = await client.MakeAuthWithPasswordAsync(passwordSetting, password);
                }
                catch
                {
                    AppendLog("Hint: " + passwordSetting.Hint);

                    if (passwordSetting.HasRecovery)
                    {
                        AppendLog("Do you want to reset your password? Yes");

                        AppendLog("Recovery email: " + passwordSetting.EmailUnconfirmedPattern);

                        tbxEmail.Text = passwordSetting.EmailUnconfirmedPattern;

                        var recoveryCode = Interaction.InputBox("Enter email recovery code", "Telegram");
                        if (string.IsNullOrWhiteSpace(code))
                        {
                            return;
                        }
                        AppendLog("Enter email recovery code: " + recoveryCode);

                        await client.SendRequestAsync<TLRequestRecoverPassword>(new TLRequestRecoverPassword() { Code = recoveryCode });
                    }
                    else
                    {
                        AppendLog("This account doesn't have recovery!");
                    }

                    goto TryAgain;
                }
            }

            var channelId = int.Parse(tbxChannel.Text);
            TLChannel channel = null;
            var dialogs = (TLDialogs)await client.GetUserDialogsAsync();
            if (dialogs != null)
            {
                foreach (var element in dialogs.Chats)
                {
                    if (element is TLChannel _channel)
                    {
                        if (_channel.Id == channelId)
                        {
                            channel = _channel;
                            break;
                        }
                    }
                }
            }
            if (channel != null)
            {
                var listenTime = TimeSpan.FromMinutes(5);
                while (true)
                {

                    var info = await client.SendRequestAsync<TeleSharp.TL.Messages.TLChatFull>(new TLRequestGetFullChannel()
                    {
                        Channel = new TLInputChannel
                        {
                            ChannelId = channel.Id,
                            AccessHash = (long)channel.AccessHash
                        }
                    });
                    var body = Encoding.UTF8.GetString(info.Serialize());

                    AppendLog(body);

                    Thread.Sleep(listenTime);

                    Application.DoEvents();
                }
            }
        }

    }
}
