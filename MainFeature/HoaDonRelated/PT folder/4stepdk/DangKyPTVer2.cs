using GymManagerment_MVP.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT
{
    public partial class DangKyPTVer2 : UserControl
    {
        private UserControl[] steps;
        private int currentStep = 0;
        public event Action<GoiPT> SetForBuy;
        public DangKyPTVer2()
        {
            steps = new UserControl[] {
                new _4stepdk.Step1(),
                 new _4stepdk.Step2(),
                  new _4stepdk.Step3(),
                   new _4stepdk.Step4(),
            };
            InitializeComponent();
            _4stepdk.Step1 step1 = (_4stepdk.Step1)steps[0];
            step1.SetToBill += Step1_SetToBill;
            _4stepdk.Step2 step2 = (_4stepdk.Step2)steps[1];
            step2.ChooseSpec += Step2_ChooseSpec;
            ShowStep(currentStep);
            SetActiveStep(currentStep);
        }

        private void Step2_ChooseSpec(Specialties obj)
        {
            //btnNext.PerformClick();
            pnlDKcontent.Controls.Clear();

            
                currentStep++;
            _4stepdk.Step3 step3 = new _4stepdk.Step3(obj);
            pnlDKcontent.Controls.Add(step3);
            step3.Dock = DockStyle.Fill;
            SetActiveStep(currentStep);
            //pnlDKcontent.Controls.Add();
        }

        private void Step1_SetToBill(Business.GoiPT obj)
        {
            SetForBuy.Invoke(obj);

           
        }

        private void ShowStep(int index)
        {
            // Xóa control cũ
            pnlDKcontent.Controls.Clear();

            // Thêm step hiện tại vào panel
            pnlDKcontent.Controls.Add(steps[index]);
            steps[index].Dock = DockStyle.Fill;

            // Cập nhật trạng thái nút
            btnBack.Enabled = (index > 0);
            btnNext.Enabled = (index < steps.Length - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep < steps.Length - 1)
            {
                currentStep++;
                ShowStep(currentStep);
                SetActiveStep(currentStep);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                ShowStep(currentStep);
                SetActiveStep(currentStep);
            }
        }
        private void SetActiveStep(int step)
        {
            Label[] steps = { lblStep1, lblStep2, lblStep3, lblStep4 };

            for (int i = 0; i < steps.Length; i++)
            {
                if (i < step) // step đã hoàn thành
                {
                    steps[i].ForeColor = Color.Black;
                    steps[i].BackColor = Color.LightGreen;
                    steps[i].Font = new Font(steps[i].Font, FontStyle.Regular);
                }
                else if (i == step) // step hiện tại
                {
                    steps[i].ForeColor = Color.White;
                    steps[i].BackColor = Color.Green;
                    steps[i].Font = new Font(steps[i].Font, FontStyle.Bold);
                }
                else // step chưa tới
                {
                    steps[i].BackColor = Color.LightGray;
                    steps[i].Font = new Font(steps[i].Font, FontStyle.Regular);
                }
            }
        }
    }
}
