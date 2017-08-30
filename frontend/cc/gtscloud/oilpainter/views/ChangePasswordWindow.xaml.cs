using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// ChangePasswordWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChangePasswordWindow : MetroWindow
    {
        private IUserService userService = new UserServiceImpl();

        private SynchronizationContext _uiSyncContext = null;
        public ChangePasswordWindow()
        {
            InitializeComponent();
            _uiSyncContext = SynchronizationContext.Current;

            LoadUserList();
        }

        // 点击确认更改
        private void OnEnsureButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!pwdNewBox.Password.Equals(pwdEnsureBox.Password))
            {
                MessageBox.Show("前后密码不一致，请确认你的密码！", "密码确认失败");
                return;
            }

            (sender as Button).IsEnabled = false;
            gifLoading.Visibility = Visibility.Visible;
            
            // 后台线程执行更新操作
            SecurityUserModel newUser = new SecurityUserModel(), oldUser = new SecurityUserModel();
            newUser.UserName = (cmbUsers.SelectedItem as SecurityUserModel).UserName;
            newUser.Password = pwdNewBox.Password;
            oldUser.Password = pwdOldBox.Password;
            oldUser.UserName = newUser.UserName;

            Thread changePwdThread = new Thread(new ParameterizedThreadStart(ChangePasswordThreadEntry));

            changePwdThread.Start(new object[] { oldUser, newUser });
        }

        // 后台加载用户列表
        private void LoadUserList()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadUserListThreadEntry));

            loadThread.Start();
        }

        // 加载用户信息的线程
        private void LoadUserListThreadEntry()
        {
            IList<SecurityUserModel> users = userService.AllUsersEncrypt();

            _uiSyncContext.Post(UserListLoadedCallback, users);
        }

        // 用户信息修改成功的回调
        private void UserListLoadedCallback(object value)
        {
            if (value is IList<SecurityUserModel>)
            {
                var users = value as IList<SecurityUserModel>;
                cmbUsers.DataContext = users;
            }
        }

        // 修改密码的线程入口
        private void ChangePasswordThreadEntry(object users)
        {
            // 第一个用户为旧用户，第二个用户为新用户
            var oldUser = (users as object[])[0] as SecurityUserModel;
            var newUser = (users as object[])[1] as SecurityUserModel;
            
            // 更改密码
            string validateStr = userService.ChangePassword(newUser, oldUser.Password);

            _uiSyncContext.Post(PasswordChangedCallback, validateStr); // 进行回调

        }

        // 密码修改成功的回调
        private void PasswordChangedCallback(object value)
        {
            if (null == value)
            {
                // 成功
                //MessageBox.Show("密码重置成功！", "重置结果");
                ShowTipText("密码重置成功", true);
                HideTipText();
                // 可以使用POPUP进行优化
            }
            else
            {
                ShowTipText(value as string, false);
                HideTipText();
            }

            btnChangePassword.IsEnabled = true;
            gifLoading.Visibility = Visibility.Hidden;
        }

        // 显示提示文本
        private void ShowTipText(string text, bool success)
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation(0, 1, new Duration(new TimeSpan(0, 0, 0, 0, 1500)));
            
            if (success)
            {
                lblChangeStatus.Foreground = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#66BB6A"));
            }
            else
            {
                lblChangeStatus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F44336"));

            }

            lblChangeStatus.Text = text;

            Storyboard storyboard = new Storyboard();
            storyboard.RepeatBehavior = new RepeatBehavior(1);
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(TextBlock.OpacityProperty));
            storyboard.Children.Add(opacityAnimation);
            storyboard.Begin(lblChangeStatus);
        }

        // 隐藏提示文本
        private void HideTipText()
        {
            DoubleAnimation opacityAnimation = new DoubleAnimation(1, 0, new Duration(new TimeSpan(0, 0, 0, 0, 1500)));
            // opacityAnimation.BeginTime = new TimeSpan(0, 0, 0, 0, 2000);
            
            Storyboard storyboard = new Storyboard();
            storyboard.RepeatBehavior = new RepeatBehavior(1);
            Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath(TextBlock.OpacityProperty));
            storyboard.Children.Add(opacityAnimation);
            storyboard.Children.Add(opacityAnimation);
            storyboard.Begin(lblChangeStatus, HandoffBehavior.Compose);
        }
    }
}
