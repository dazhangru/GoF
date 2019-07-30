using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 计算器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal amount;
            decimal rate;
            decimal reduce;
            int staging;
            decimal totalInterest = 0;
            decimal fee;
            try
            {
                if (string.IsNullOrEmpty(Amount.Text))
                {
                    MessageBox.Show("请输入总额度");
                    return;
                }
                amount = Convert.ToDecimal(Amount.Text);
                if (string.IsNullOrEmpty(Rate.Text))
                {
                    MessageBox.Show("请输入利率");
                    return;
                }
                rate = Convert.ToDecimal(Rate.Text);
                if (string.IsNullOrEmpty(Reduce.Text))
                {
                    MessageBox.Show("请输入每月还款额");
                    return;
                }
                reduce = Convert.ToDecimal(Reduce.Text);
                if (string.IsNullOrEmpty(Staging.Text))
                {
                    MessageBox.Show("请输入期数");
                    return;
                }
                staging = Convert.ToInt32(Staging.Text);
                if (string.IsNullOrEmpty(Fee.Text))
                {
                    MessageBox.Show("请输入每月手续费");
                }
                fee = Convert.ToDecimal(Fee.Text);

                for (int i = 0; i < staging; i++)
                {
                    var interest = (amount - reduce * i) * rate;
                    totalInterest += interest;
                }
                MessageBox.Show($"利润为:{(totalInterest - fee * staging).ToString("#0.00")}元");
            }
#if !DEBUG
catch (Exception)
            {
                MessageBox.Show("请输入正确的参数");
            }
#endif
#if DEBUG
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#endif
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
