using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.cc.gtscloud.oilpainter.util;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace frontend.cc.gtscloud.oilpainter.views
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        private IUserService userService = new UserServiceImpl();

        private SynchronizationContext _uiSyncContext;

        private bool logining; // 正在登录

        private readonly static string REG_SECURITY_KEY = "Security\\AccountOption\\Pass";

        public LoginWindow()
        {
            InitializeComponent();

            // UI主线程记录
            _uiSyncContext = SynchronizationContext.Current;

            SecurityUserModel user = CheckStoredUser();
            if (null != user)
            {
                chkRememberPasasword.IsChecked = true;

                txtUserName.Text = user.UserName;
                txtPassword.Password = user.Password;
            }
        }

        private void OnLoginButtonClicked(object sender, RoutedEventArgs e)
        {
            // 用户名为空
            if (null == txtUserName.Text || 0 >= txtUserName.Text.Trim().Length)
            {
                txtUserName.Focus();
                lblLoginError.Text = "登录错误：用户名不可为空！";
                AnimateErrorTip();

                return;
            }

            // 密码为空
            if (null == txtPassword.Password || 0 >= txtPassword.Password.Length)
            {
                txtPassword.Focus();
                lblLoginError.Text = "登录错误：密码不能为空！";
                AnimateErrorTip();

                return;
            }

            btnLogin.IsEnabled = false;
            gifLoading.Visibility = Visibility.Visible;

            // 开启线程进行登录
            Thread loginThread = new Thread(new ParameterizedThreadStart(LoginWithInput));

            SecurityUserModel user = new SecurityUserModel();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Password;
            logining = true;

            loginThread.Start(user);
        }

        // 读取输入并登陆
        private void LoginWithInput(object param)
        {
            string result = userService.Login(param as SecurityUserModel);

            if (null != result)
            {
                // 登陆失败应该删除注册表信息
                DeleteRegKey();
            }

            _uiSyncContext.Post(AfterLoginCallback, result);
        }

        /// <summary>
        /// 动画显示错误提示
        /// </summary>
        private void AnimateErrorTip()
        {
            Storyboard storyboard = new Storyboard();
            ThicknessAnimation marginAnimation = new ThicknessAnimation(new Thickness(0, -40, 0, 0), new Duration(new TimeSpan(0, 0, 0, 0, 300)));
            DoubleAnimation opacityAnimation = new DoubleAnimation(1, new Duration(new TimeSpan(0, 0, 0, 0, 300)));
            Storyboard.SetTargetProperty(marginAnimation, new PropertyPath(TextBlock.MarginProperty));
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(TextBlock.OpacityProperty));

            storyboard.Children.Add(marginAnimation);
            storyboard.Children.Add(opacityAnimation);

            storyboard.Begin(lblLoginError);
        }

        /// <summary>
        /// 将提示文本隐藏
        /// </summary>
        private void AnimateHideTip()
        {
            Storyboard storyboard = new Storyboard();
            ThicknessAnimation marginAnimation = new ThicknessAnimation();
            marginAnimation.To = new Thickness(0, 0, 0, 0);
            marginAnimation.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 300));
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 300));
            opacityAnimation.To = 0;
            Storyboard.SetTargetProperty(marginAnimation, new PropertyPath(TextBlock.MarginProperty));
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(TextBlock.OpacityProperty));

            storyboard.Children.Add(marginAnimation);
            storyboard.Children.Add(opacityAnimation);

            storyboard.Begin(lblLoginError);

        }

        // 输入框获取到焦点后的事件

        private void OnInputFocused(object sender, RoutedEventArgs e)
        {
            if (logining)
            {
                return;
            }

            if (sender is TextBox)
            {
                if ((sender as TextBox).IsFocused)
                {
                    AnimateHideTip();
                }
            }
            else if (sender is PasswordBox)
            {
                if ((sender as PasswordBox).IsFocused)
                {
                    AnimateHideTip();
                }
            }
        }

        // 登录回调函数
        private void AfterLoginCallback(object result)
        {
            logining = false;
            if (null == result)
            {
                SecurityUserModel user = new SecurityUserModel();
                user.UserName = txtUserName.Text.Trim();
                user.Password = txtPassword.Password;

                if (true == chkRememberPasasword.IsChecked)
                {
                    Thread writeRegThread = new Thread(new ParameterizedThreadStart(WriteInformationToReg));
                    
                    writeRegThread.Start(user);
                }

                // 登录成功
                MainWindow mainWin = new MainWindow();
                mainWin.LoginedUser = user;
                mainWin.Show();
                
                this.Close(); // 关闭当前窗口
            }
            else
            {
                // 登录失败
                lblLoginError.Text = (string)result;
                AnimateErrorTip();

                // 停止动画
                btnLogin.IsEnabled = true;
                gifLoading.Visibility = Visibility.Hidden;

            }

        }

        // 窗口关闭之前执行的事件
        private void OnLoginWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (logining)
            {
                // 正在登录执行关闭操作
                Application.Current.Shutdown();
            }
        }

        // 将信息存储到REG注册表
        private void WriteInformationToReg(object user)
        {
            SecurityUserModel storedUser = user as SecurityUserModel;

            // 存储账号
            string accountStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(storedUser.UserName));
            // 是否存储密码
            string pwdStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(storedUser.Password));
            
            RegReaderWriter regRW = new RegReaderWriter();
            regRW.WriteValueForKey("Security\\AccountOption\\Pass", "account", accountStr);
            regRW.WriteValueForKey("Security\\AccountOption\\Pass", "pwd", pwdStr);
        }

        /// <summary>
        /// 删除用户信息注册表
        /// </summary>
        private void DeleteRegKey()
        {
            var reg = new RegReaderWriter();
            reg.DeleteValue(REG_SECURITY_KEY, "account");
            reg.DeleteValue(REG_SECURITY_KEY, "pwd");
        }

        // 检查是否已经存储登陆账号
        private SecurityUserModel CheckStoredUser()
        {
            RegReaderWriter regRw = new RegReaderWriter();
            bool hasAccount = regRw.HasKey(REG_SECURITY_KEY);

            if (hasAccount)
            {
                string account = (string)regRw.GetValue(REG_SECURITY_KEY, "account");
                string pwd = (string)regRw.GetValue(REG_SECURITY_KEY, "pwd");

                if (null != account)
                {
                    account = Encoding.UTF8.GetString(Convert.FromBase64String(account));
                }

                if (null != pwd)
                {
                    pwd = Encoding.UTF8.GetString(Convert.FromBase64String(pwd));
                }

                SecurityUserModel storedUser = new SecurityUserModel();
                storedUser.UserName = account;
                storedUser.Password = pwd;

                return storedUser;
            }
            return null;
        }
        
    }
}
