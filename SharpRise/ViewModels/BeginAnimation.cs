using SharpRise;

namespace SharpRise.ViewModels
{
    public partial class BeginAnimation : Form
    {
        public BeginAnimation()
        {
            InitializeComponent();

            this.BackColor = Color.White; 
            this.TransparencyKey = Color.White; 
            this.FormBorderStyle = FormBorderStyle.None; 

            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.logo_text;
            logo.Dock = DockStyle.Fill;
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(logo);
        }

        /// Настройка типов анимаций
        /// 1 - fade in
        /// 2 - stay (waiting)
        /// 3 - fade out
        private int animation_type = 1;
        private int staySeconds = 3;

        private void BeginAnimation_Load(object sender, EventArgs e)
        {
            timer_animation.Start();
        }

        /// Таймер, тики которого реализуют анимацию в зависимости от типа
        private void timer_animation_Tick(object sender, EventArgs e)
        {
            switch (animation_type)
            {
                //start
                case 1:
                    if (Opacity != 1)
                    {
                        Opacity += 0.05;
                    }
                    else
                    {
                        animation_type = 2;
                        timer_animation.Interval = 1000;
                    }
                    break;
                //waiting
                case 2:
                    if (staySeconds != 0)
                        --staySeconds;
                    else
                    {
                        animation_type = 3;
                        timer_animation.Interval = 5;
                    }
                    break;
                //end
                case 3:
                    if (Opacity != 0)
                    {
                        Opacity -= 0.05;
                    }
                    else
                    {
                        timer_animation.Stop();
                        SignInWindow adEntryForm = new SignInWindow();
                        Hide();
                        adEntryForm.Show();
                    }
                    break;
            }
        }

        /// <summary>
        /// Корректное закрытие формы при ручном закрытии приложения
        /// Предотвращает зависание процесса в системе после закрытия приложения
        /// </summary>
        private void BeginAnimation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
