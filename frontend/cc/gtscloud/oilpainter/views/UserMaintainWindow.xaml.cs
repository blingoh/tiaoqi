using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.cc.gtscloud.oilpainter.views.context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace frontend.cc.gtscloud.oilpainter.views
{
    /// <summary>
    /// UserMaintainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserMaintainWindow : MahApps.Metro.Controls.MetroWindow
    {
        private IUserService userService = new UserServiceImpl();

        private SynchronizationContext _uiSyncContext;
        
        public UserMaintainWindow()
        {
            InitializeComponent();
            _uiSyncContext = SynchronizationContext.Current;
            LoadUserList();
        }

        // 加载用户信息列表
        private void LoadUserList()
        {
            Thread loadUserThread = new Thread(new ThreadStart(LoadUserListThread));

            loadUserThread.Start();
        }

        // 子线程方法，用于在线程中加载数据
        private void LoadUserListThread()
        {
            // 获取用户列表
            IList<SecurityUserModel> allEncryptUsers = userService.AllUsersEncrypt();

            // 获取权限列表
            IList<string> allRights = userService.AllUserRights();
            // 发送到主线程进行UI更新
            _uiSyncContext.Post(UserListLoadedCompleted, new object[] { allEncryptUsers, allRights });

        }

        // UI更新方法，用于在用户列表加载完成后，执行数据绑定或渲染操作
        private void UserListLoadedCompleted(object param)
        {
            var index = cmbUserName.SelectedIndex;
            cmbRoleType.ItemsSource = (IList<string>)(param as object[])[1];
            cmbUserName.DataContext = new ObservableCollection<SecurityUserModel>((param as object[])[0] as IList<SecurityUserModel>);
            if (0 > index)
            {
                cmbUserName.SelectedIndex = 0;
            }
            else
            {
                cmbUserName.SelectedIndex = index;
            }
        }

        // 开启可编辑状态
        private void OpenEditableSituation()
        {
            // 启用控件
            cmbRoleType.IsEnabled = true;
            boxPassword.IsReadOnly = false;

            // 启用编辑
            cmbRoleType.IsEditable = true;
            cmbUserName.IsEditable = true;
        }

        private void CloseEditableSituation()
        {
            // 启用控件
            cmbRoleType.IsEnabled = false;
            boxPassword.IsReadOnly = true;

            // 启用编辑
            cmbRoleType.IsEditable = false;
            cmbUserName.IsEditable = false;
            
        }

        // 点击添加按钮
        private void OnButtonAddUserClicked(object sender, RoutedEventArgs e)
        {
            if ("增加".Equals(btnAddUser.Content))
            {

                // 禁用其他控件
                btnModifyUser.IsEnabled = false;

                btnAddUser.Content = "保存";
                btnDeleteUser.Content = "取消";

                OpenEditableSituation(); // 开启控件编辑状态
            }
            else if ("保存".Equals((sender as Button).Content))
            {

                btnModifyUser.IsEnabled = false;
                btnDeleteUser.IsEnabled = false;

                btnAddUser.Content = "增加";

                // 保存新增
                CloseEditableSituation();

                // 构建现有用户
                SecurityUserModel storedUser = new SecurityUserModel();
                
                storedUser.UserName = cmbUserName.Text.ToString();
                storedUser.Right = cmbRoleType.Text.ToString();
                storedUser.Password = boxPassword.Text;

                // 去除空格
                storedUser.UserName = null == storedUser.UserName ? null : storedUser.UserName.Trim();
                storedUser.Right = null == storedUser.Right ? null : storedUser.Right.Trim();

                StartAddUserThread(storedUser); // 启动添加用户线程
            }
        }
        
        // 添加用户的线程入口
        private void AddUserThreadEntry(object user)
        {
            SecurityUserModel storedUser = null;
            if (user is SecurityUserModel)
            {
                storedUser = user as SecurityUserModel;
            }

            // 添加
            string response = userService.RegisterUser(storedUser);
            
            // 发送结果给主线程
            if (null == response)
            {
                _uiSyncContext.Post(UserAddedCallback, storedUser); // 注册成功
            }
            else
            {
                _uiSyncContext.Post(UserAddedCallback, response); // 注册失败
            }
        }

        // 添加用户成功后的回调
        private void UserAddedCallback(object value)
        {
            if (value is string)
            {
                // 注册失败
                cmbUserName.SelectedIndex = 0;
                MessageBox.Show(value as string, "添加错误");
            }
            else if (value is SecurityUserModel)
            {
                // 注册成功
                LoadUserList();
            }

            ResetControls();
        }

        // 开启线程进行用户添加
        private void StartAddUserThread(SecurityUserModel user)
        {
            Thread userAddThread = new Thread(new ParameterizedThreadStart(AddUserThreadEntry));

            userAddThread.IsBackground = true;

            userAddThread.Start(user); // 启动线程
        }

        // 点击修改用户信息事件处理
        private void OnModifyUserClicked(object sender, RoutedEventArgs e)
        {
            SecurityUserModel selectedUser = null;
            if (cmbUserName.SelectedItem is SecurityUserModel)
            {
                selectedUser = cmbUserName.SelectedItem as SecurityUserModel;
            }

            if (null == selectedUser)
            {
                MessageBox.Show("无法解析到必要信息，操作被取消！");
                return;
            }

            if ("修改".Equals((sender as Button).Content))
            {
                // 把相应控件状态进行更新
                btnDeleteUser.Content = "取消";
                btnModifyUser.Content = "保存修改";
                btnAddUser.IsEnabled = false;
                cmbUserName.IsEnabled = false;
                cmbRoleType.IsEditable = true;
                cmbRoleType.IsEnabled = true;   
            }
            else if ("保存修改".Equals((sender as Button).Content))
            {
                // 把相应控件状态进行更新
                cmbRoleType.IsEditable = false;
                cmbRoleType.IsEnabled = false;

                // 开启线程更新信息
                Thread modifyUserThread = new Thread(new ParameterizedThreadStart(ModifyUserThreadEntry));

                selectedUser.Right = cmbRoleType.Text;

                modifyUserThread.Start(selectedUser);
            }
            
        }

        // 点击删除用户
        private void OnButtonDeleteClicked(object sender, RoutedEventArgs e)
        {
            SecurityUserModel selectedUser = null;
            if (cmbUserName.SelectedItem is SecurityUserModel)
            {
                selectedUser = cmbUserName.SelectedItem as SecurityUserModel;
            }

            if (null == selectedUser)
            {
                MessageBox.Show("未能正确解析您的信息！");
                return;
            }

            if ("删除".Equals((sender as Button).Content))
            {
                // 执行删除操作
                if (MessageBox.Show("您确认要删除用户：" + selectedUser.UserName, "删除确认", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    // 开启线程更新
                    Thread delThread = new Thread(new ParameterizedThreadStart(DeleteUserThreadEntry));

                    btnAddUser.IsEnabled = false;
                    btnModifyUser.IsEnabled = false;
                    btnDeleteUser.IsEnabled = false;

                    delThread.Start(cmbUserName.SelectedItem);

                }
            }
            else if ("取消".Equals((sender as Button).Content))
            {
                cmbUserName.SelectedItem = selectedUser; // 重置
                ResetControls();
            }
        }

        // 重置控件
        private void ResetControls()
        {
            cmbUserName.IsEnabled = true;
            cmbUserName.IsEditable = false;
            cmbRoleType.IsEditable = false;
            cmbRoleType.IsEnabled = false;

            btnAddUser.Content = "增加";
            btnDeleteUser.Content = "删除";
            btnModifyUser.Content = "修改";

            btnAddUser.IsEnabled = true;
            btnModifyUser.IsEnabled = true;
            btnDeleteUser.IsEnabled = true;
        }

        // 修改用户信息入口
        private void ModifyUserThreadEntry(object user)
        {
            string response = null;
            if (user is SecurityUserModel)
            {
                response = userService.ChangeUserRight(user as SecurityUserModel);
            }

            if (null == response)
            {
                _uiSyncContext.Post(UserModifiedCallback, user);
            }
            else
            {
                _uiSyncContext.Post(UserModifiedCallback, response);
            }
        }

        // 用户修改后的回调
        private void UserModifiedCallback(object value)
        {
            if (value is string)
            {
                MessageBox.Show(value as string, "修改失败");
            }
            else if (value is SecurityUserModel)
            {
                LoadUserList();
            }

            ResetControls();// 重置控件
        }

        // 删除用户进程入口
        private void DeleteUserThreadEntry(object username)
        {
            SecurityUserModel delUser = username as SecurityUserModel;

            string response = userService.DeleteUser(delUser);

            if (null == response) // 成功
            {
                _uiSyncContext.Post(UserDeletedCallback, delUser);
            }
            else
            {
                _uiSyncContext.Post(UserDeletedCallback, response); // 失败
            }
        }

        // 用户删除后的回调函数
        private void UserDeletedCallback(object value)
        {
            if (value is string)
            {
                MessageBox.Show(value as string, "删除错误");
            }
            else if (value is SecurityUserModel)
            {
                LoadUserList();
            }

            ResetControls();
        }
    }
}
